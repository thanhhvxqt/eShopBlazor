using eShopShare.Models;
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
    public class LoginAdminController : ControllerBase
    {
        public LoginAdminController(IConfiguration configuration,INguoidungSvc nguoidungSvc)
        {
            _Configuration = configuration;
            _NguoidungSvc = nguoidungSvc;
        }

        public IConfiguration _Configuration { get; }
        public INguoidungSvc _NguoidungSvc { get; }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] ViewLogin login)
        {
            //var user = await _UserManager.FindByNameAsync(login.UserName);
            //if (user == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            //var result = await _SignInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);

            //if (!result.Succeeded) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var result = await _NguoidungSvc.Login(login);

            if (result != null) {
                var claims = new[]
                {
                new Claim(ClaimTypes.Name, login.UserName),
                new Claim("UserId", result.NguoiDungId.ToString())
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["JwtSecurityKey"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(Convert.ToInt32(_Configuration["JwtExpiryInDays"]));

                var token = new JwtSecurityToken(
                    _Configuration["JwtIssuer"],
                    _Configuration["JwtAudience"],
                    claims,
                    expires: expiry,
                    signingCredentials: creds
                );

                return Ok(new LoginResponse { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
            } return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });
            
        }
    }
}
