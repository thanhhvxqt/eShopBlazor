using eShopApi.Models;
using eShopShare.Models.ApiModels;
using eShopShare.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eShopApi.Services
{
    public interface IUserService
    {
        Task<ApiProblemModel> RegisterUserAsync(RegisterClientRequest model);

        Task<ApiProblemModel> LoginUserAsync(ViewWebClientLogin model);

        Task<ApiProblemModel> ConfirmEmailAsync(string userId, string token);

        Task<ApiProblemModel> ForgetPasswordAsync(string email);

        Task<ApiProblemModel> ResetPasswordAsync(ResetPasswordViewModel model);

        Task<ApiProblemModel> ChangePasswordAsync(ChangePasswordViewModel model);
    }

    public class UserService : IUserService
    {
        private UserManager<AppUser> _userManger;
        private IConfiguration _configuration;
        private IEmailService _mailService;
        private readonly SignInManager<AppUser> _signInManager;

        public UserService(UserManager<AppUser> userManager, IConfiguration configuration, IEmailService mailService, SignInManager<AppUser> signInManager)
        {
            _userManger = userManager;
            _configuration = configuration;
            _mailService = mailService;
            this._signInManager = signInManager;
        }
        public async Task<ApiProblemModel> ConfirmEmailAsync(string userId, string token)
        {
            var user = await _userManger.FindByIdAsync(userId);

            if (user == null)
            {
                return new ApiProblemModel { IsSuccess = false, Message = new List<string> { $"Unable to load user with ID '{userId}'." }, StatusCode = 404 };
            }

            var decodedToken = WebEncoders.Base64UrlDecode(token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManger.ConfirmEmailAsync(user, normalToken);

            if (result.Succeeded)
                return new ApiProblemModel
                {
                    IsSuccess = true,
                    Message = new List<string> { "Email is confirm !" }
                };

            return new ApiProblemModel
            {
                IsSuccess = false,
                Message = new List<string> { "Email did not confirm" }
            };
        }

        public async Task<ApiProblemModel> ForgetPasswordAsync(string email)
        {
            var user = await _userManger.FindByEmailAsync(email);
            if (user == null)
                return new ApiProblemModel
                {
                    IsSuccess = false,
                    Message = new List<string> { "No user associated with email" },
                    StatusCode = 404
                };

            var token = await _userManger.GeneratePasswordResetTokenAsync(user);
            var encodedToken = Encoding.UTF8.GetBytes(token);
            var validToken = WebEncoders.Base64UrlEncode(encodedToken);

            string url = $"{_configuration["ApiUrl"]}/ResetPassword?email={email}&token={validToken}";
            //string url = $"{_configuration["ClientUrl"]}/recovery/email/{email}?token={token}";

            EmailDto emailDto = new EmailDto
            {
                Subject = "Đặt lại mật khẩu",
                Body = $"<h1>Làm theo hướng dẫn để đặt lại mật khẩu của bạn</h1>" +
                $"<p>Tên đăng nhập của bạn là: </p><h3>{user.UserName}</h3>"+
                $"<p>Để đặt lại mật khẩu <a href='{url}'>Bấm vào đây</a></p>",
                To = user.Email
            };

            _mailService.SendEmail(emailDto);

            return new ApiProblemModel
            {
                IsSuccess = true,
                Message = new List<string> { "Reset password URL has been sent to the email successfully!" },
                StatusCode = 200
            };
        }

        public async Task<ApiProblemModel> LoginUserAsync(ViewWebClientLogin model)
        {
            var user = await _userManger.FindByNameAsync(model.UserName);

            if (user == null)
            {
                return new ApiProblemModel { StatusCode = 400, Message = new List<string> { "Username or password are invalid." } };
            }

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (!result.Succeeded)
            {
                return new ApiProblemModel { StatusCode = 400, Message = new List<string> { "Invalid login attempt." } };
            }


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim(ClaimTypes.Email, user.Email.ToString()),
                new Claim("UserName", model.UserName),
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["Jwt:DurationInMinutes"]));

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return new ApiProblemModel { user = user, IsSuccess = true, Message = new List<string> { new JwtSecurityTokenHandler().WriteToken(token) }, StatusCode = 200 };

        }

        public async Task<ApiProblemModel> RegisterUserAsync(RegisterClientRequest model)
        {
            if (model == null)
                throw new NullReferenceException("Reigster Model is null");

            if (model.Password != model.ConfirmPassword)
                return new ApiProblemModel
                {
                    Message = new List<string> { "Confirm password doesn't match the password" },
                    IsSuccess = false,
                };

            var user = new AppUser { UserName = model.UserName, Email = model.Email, Name = model.Name, ParticipationDate = Convert.ToDateTime(DateTime.Now) };

            var result = await _userManger.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var loi = new List<string>();
                foreach (var error in result.Errors)
                {
                    loi.Add(error.Description);
                }
                return new ApiProblemModel { StatusCode = 400, Message = loi, IsSuccess = false };
            }

            var confirmEmailToken = await _userManger.GenerateEmailConfirmationTokenAsync(user);
            var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
            var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

            string url = $"{ _configuration["ApiUrl"]}/api/user/confirmemail?userid={user.Id}&token={validEmailToken}";

            EmailDto emailDto = new EmailDto
            {
                Subject = "Xác thực email người dùng",
                Body = $"<h1>Xin chào, {user.Name}</h1><br/>"
                + $"<p>Hãy xác nhận email Web Bán Thức Ăn của bạn <a href='{url}'>Bấm vào đây</a></p>",
                To = user.Email
            };

            _mailService.SendEmail(emailDto);

            return new ApiProblemModel
            {
                Message = new List<string> { "User created succesfully" },
                IsSuccess = true,
                StatusCode = 200
            };
        }

        public async Task<ApiProblemModel> ResetPasswordAsync(ResetPasswordViewModel model)
        {
            var user = await _userManger.FindByEmailAsync(model.Email);
            if (user == null)
                return new ApiProblemModel
                {
                    IsSuccess = false,
                    Message = new List<string> { "No user associated with email" },
                };

            if (model.NewPassword != model.ConfirmPassword)
                return new ApiProblemModel
                {
                    IsSuccess = false,
                    Message = new List<string> { "Password doesn't match its confirmation" },
                };

            var decodedToken = WebEncoders.Base64UrlDecode(model.Token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await _userManger.ResetPasswordAsync(user, normalToken, model.NewPassword);

            if (result.Succeeded)
                return new ApiProblemModel
                {
                    Message = new List<string> { "Password has been reset successfully!" },
                    IsSuccess = true,
                };

            return new ApiProblemModel
            {
                Message = new List<string> { "Something went wrong", result.Errors.Select(e => e.Description).ToString() },
                IsSuccess = false,
            };
        }
        public async Task<string> EncodeToken(AppUser appUser)
        {
            var confirmEmailToken = await _userManger.GenerateEmailConfirmationTokenAsync(appUser);

            var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);

            var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

            return validEmailToken;
        }
        public string DecodeToken(string token)
        {
            var decodedToken = WebEncoders.Base64UrlDecode(token);

            string normalToken = Encoding.UTF8.GetString(decodedToken);

            return normalToken;
        }
        public async Task<ApiProblemModel> ChangePasswordAsync(ChangePasswordViewModel model)
        {
            var userId = model.UserId;
            var user = await _userManger.FindByIdAsync(userId);
            if (user == null)
            {
                return new ApiProblemModel { IsSuccess = false, Message = new List<string> { $"Unable to load user with ID '{userId}'." }, StatusCode = 404 };
            }

            var changePasswordResult = await _userManger.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                List<string> loi = new List<string>();
                foreach (var error in changePasswordResult.Errors)
                {
                    loi.Add(error.Description);
                }
                return new ApiProblemModel { StatusCode = 400, Message = loi, IsSuccess = false };
            }
            else
            {
                await _signInManager.RefreshSignInAsync(user);
                List<string> mes = new List<string>();
                mes.Add("Your Password has been reset");
                return new ApiProblemModel { StatusCode = 200, Message = mes, IsSuccess = true };
            }
        }
    }
}
