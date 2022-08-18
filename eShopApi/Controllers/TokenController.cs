using eShopApi.Services;
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
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;

        public TokenController(IConfiguration configuration, IKhachHangSvc khachHangSvc, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService)
        {
            _Configuration = configuration;
            _KhachHangSvc = khachHangSvc;
            _UserManager = userManager;
            _SignInManager = signInManager;
            this._userService = userService;
        }

        public IConfiguration _Configuration { get; }
        public IKhachHangSvc _KhachHangSvc { get; }
        public UserManager<AppUser> _UserManager { get; }
        public SignInManager<AppUser> _SignInManager { get; }
        [HttpPost]
        public async Task<IActionResult> Post(ViewWebClientLogin model)
        {
            List<string> loi = new List<string>();
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);

                if (!result.IsSuccess)
                {
                    return BadRequest(result);
                }

                var viewToken = new ViewToken
                {
                    KhachhangId = result.user.Id.ToString(),
                    Token = result.Message.FirstOrDefault().ToString(),
                    Email = result.user.Email,
                    Name = result.user.Name,
                    UserName = result.user.UserName,
                    NgayThamGia = result.user.ParticipationDate.ToString("dddd, dd MMMM yyyy")
                };

                return Ok(viewToken);
            }

            return BadRequest("Something went wrong !");
        }

    }
}
