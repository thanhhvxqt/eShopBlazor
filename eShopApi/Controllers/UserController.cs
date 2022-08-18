using eShopApi.Models;
using eShopApi.Services;
using eShopShare.Models.ApiModels;
using eShopShare.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public UserController(IUserService userService, IConfiguration configuration, IEmailService emailService)
        {
            this._userService = userService;
            this._configuration = configuration;
            this._emailService = emailService;
        }

        public UserManager<AppUser> _UserManager { get; }
        [HttpPost("dangky")]
        public async Task<IActionResult> PostUser(RegisterClientRequest model)
        {
            if (!ModelState.IsValid)
            {
                var loi = new List<string>();
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                foreach (var item in errors)
                {
                    loi.Add(item.ErrorMessage.ToString());
                }
                return BadRequest(new ApiProblemModel { StatusCode = 400, Message = loi });
            }

            try
            {

                var result = await _userService.RegisterUserAsync(model);

                if (!result.IsSuccess)
                {
                    return BadRequest(result);
                }
                
                return Accepted(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, statusCode: 500);
            }

        }
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
                return NotFound();

            var result = await _userService.ConfirmEmailAsync(userId, token);

            if (result.IsSuccess)
            {
                return Redirect($"{_configuration["ApiUrl"]}/ConfirmEmail.html");
                //return Accepted(new ApiProblemModel { StatusCode = 202, Message = new List<string> { "Email confirm succesfully" } });
            }

            return BadRequest(result);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePasword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _userService.ChangePasswordAsync(model);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
                return NotFound(new ApiProblemModel { IsSuccess = false, Message = new List<string> { "This email is empty"} });

            var result = await _userService.ForgetPasswordAsync(email);

            if (result.IsSuccess)
                return Ok(result); // 200

            return BadRequest(result); // 400
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ResetPasswordAsync(model);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
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
