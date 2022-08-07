using eShopShare.Models.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(UserManager<AppUser> userManager, DataContext dataContext)
        {

            _UserManager = userManager;
            this._dataContext = dataContext;
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
                return BadRequest(new ApiProblemModel{ StatusCode = 400, Errors = loi });
            }

            var user = new AppUser { UserName = model.UserName, Email = model.Email, Name = model.Name };

            try
            {

                var checkExist = await _dataContext.Users.FirstOrDefaultAsync(x=>x.Email ==  model.Email.Trim().ToString());

                if (checkExist != null)
                {
                    loi.Add("This email is exist");
                    return BadRequest(new ApiProblemModel { StatusCode = 406, Errors = loi });
                }
                var result = await _UserManager.CreateAsync(user, model.Password);
                
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        loi.Add(error.Description);
                    }
                    return BadRequest(new ApiProblemModel{ StatusCode = 400, Errors = loi });
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
            AppUser checkExist = null;

            if (IsValidEmail(content))
            {
                checkExist = await _dataContext.Users.FirstOrDefaultAsync(x => x.Email == content.Trim().ToString());
            }
            else
            {
                checkExist = await _dataContext.Users.FirstOrDefaultAsync(x => x.UserName == content.Trim().ToString());
            }

            if (checkExist != null)
            {
                return BadRequest(-1);
            }

            return Ok(1);
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
