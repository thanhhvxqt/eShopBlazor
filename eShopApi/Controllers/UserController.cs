using eShopShare.Models.ApiModels;
using eShopShare.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHttpContextAccessor _httpContext;
        public UserController(UserManager<AppUser> userManager, DataContext dataContext, SignInManager<AppUser> signInManager,
            IHttpContextAccessor httpContext)
        {

            _UserManager = userManager;
            this._dataContext = dataContext;
            this._signInManager = signInManager;
            _httpContext = httpContext;
        }

        public UserManager<AppUser> _UserManager { get; }
        [HttpPost("dangky")]
        public async Task<IActionResult> PostUser(RegisterClientRequest model)
        {
            List<string> loi = new List<string>();
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                foreach(var item in errors)
                {
                    loi.Add(item.ErrorMessage.ToString());
                }
                return BadRequest(new ApiProblemModel{ StatusCode = 400, Message = loi });
            }

            var user = new AppUser { UserName = model.UserName, Email = model.Email, Name = model.Name ,ParticipationDate = Convert.ToDateTime(DateTime.Now) };

            try
            {

                var checkExist = await _dataContext.Users.AnyAsync(x=>x.Email ==  model.Email.Trim().ToString());

                if (checkExist)
                {
                    loi.Add("Email này đã tồn tại !");
                    return BadRequest(new ApiProblemModel { StatusCode = 406, Message = loi });
                }
                var result = await _UserManager.CreateAsync(user, model.Password);
                
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        loi.Add(error.Description);
                    }
                    return BadRequest(new ApiProblemModel{ StatusCode = 400, Message = loi });
                }
                return Accepted();
            }
            catch (Exception ex)
            {
                return Problem("Some thing when wrong", statusCode: 500);
            }

        }
        [HttpGet("{content}")]
        public async Task<IActionResult> GetUserNameOrEmail(string content)
        {
            bool checkExist = true;

            if (IsValidEmail(content))
            {
                checkExist = await _dataContext.Users.AnyAsync(x => x.Email == content.Trim().ToString());
            }
            else
            {
                checkExist = await _dataContext.Users.AnyAsync(x => x.UserName == content.Trim().ToString());
            }

            if (checkExist)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePasword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var userId = model.UserId;
            var user = await _UserManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_UserManager.GetUserId(User)}'.");
            }

            var changePasswordResult = await _UserManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                List<string> loi = new List<string>();
                foreach (var error in changePasswordResult.Errors)
                {
                    loi.Add(error.Description);
                }
                return BadRequest(new ApiProblemModel { StatusCode = 400, Message = loi });
            }
            else
            {
                await _signInManager.RefreshSignInAsync(user);
                List<string> mes = new List<string>();
                mes.Add("Your Password has been reset");
                return Ok(new ApiProblemModel { StatusCode = 200, Message = mes });
            }
            
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
