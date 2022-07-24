using eShopShare.Models;
using eShopShare.Models.ApiModels;
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
    public class LoginClientController : ControllerBase
    {
        public LoginClientController(IConfiguration configuration,
            SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _Configuration = configuration;
            _SignInManager = signInManager;
            _UserManager = userManager;
        }

        public IConfiguration _Configuration { get; }
        public SignInManager<AppUser> _SignInManager { get; }
        public UserManager<AppUser> _UserManager { get; }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginClientRequest login)
        {
            var user = await _UserManager.FindByNameAsync(login.UserName);
            if (user == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var result = await _SignInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);

            if (!result.Succeeded) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.UserName),
                new Claim("UserId", user.Id.ToString())
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
        }
    }
}
