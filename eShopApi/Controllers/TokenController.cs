using eShopShare.Models;
using eShopShare.Models.ApiModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public TokenController(IConfiguration configuration, IKhachHangSvc khachHangSvc, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _Configuration = configuration;
            _KhachHangSvc = khachHangSvc;
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        public IConfiguration _Configuration { get; }
        public IKhachHangSvc _KhachHangSvc { get; }
        public UserManager<AppUser> _UserManager { get; }
        public SignInManager<AppUser> _SignInManager { get; }
        [HttpPost]
        public async Task<IActionResult> Post(ViewWebClientLogin login)
        {
            List<string> loi = new List<string>();
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            var user = await _UserManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                loi.Add("Username or password are invalid.");
                return BadRequest(new ApiProblemModel { StatusCode = 400, Message = loi });
            }

            var result = await _SignInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);

            if (!result.Succeeded)
            {
                loi.Add("Invalid login attempt.");
                return BadRequest(new ApiProblemModel { StatusCode = 400, Message = loi });
            }


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _Configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim(ClaimTypes.Email, user.Email.ToString()),
                new Claim("UserName", login.UserName),
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddMinutes(Convert.ToInt32(_Configuration["Jwt:DurationInMinutes"]));

            var token = new JwtSecurityToken(
                _Configuration["Jwt:Issuer"],
                _Configuration["Jwt:Audience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new ViewToken { KhachhangId = user.Id.ToString(), Token = new JwtSecurityTokenHandler().WriteToken(token), Email = user.Email, Name = user.Name, UserName = user.UserName, NgayThamGia = user.ParticipationDate.ToString("dddd, dd MMMM yyyy") });
        }

    }
}
