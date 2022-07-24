using eShopShare.Models;
using eShopShare.Models.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
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

        public async Task<IActionResult> Post(ViewWebLogin login)
        {
            var user = await _UserManager.FindByNameAsync(login.Email);
            if (user == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var result = await _SignInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

            if (!result.Succeeded) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.Email),
                new Claim("UserId", user.Id.ToString())
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

            return Ok(new LoginResponse { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}
