using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace eShopControl.Pages
{
    public class CheckLoginModel : PageModel
    {
        public CheckLoginModel(INguoidungSvc nguoidungSvc)
        {
            _NguoidungSvc = nguoidungSvc;
        }

        public string ReturnUrl { get; set; }
        public INguoidungSvc _NguoidungSvc { get; set; }

        public async Task<IActionResult> OnGetAsync(string paramUserName, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch { }

            bool flagLogin = false;
            var viewLogin = new ViewLogin()
            {
                UserName = paramUserName,
                Password = paramPassword
            };
            var nguoidung = _NguoidungSvc.Login(viewLogin);
            if(nguoidung != null)
            {
                flagLogin = true;
            }
            if(!flagLogin)
            {

            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, paramUserName),
                    new Claim(ClaimTypes.Role,"Admin")
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };

                try
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimIdentity),
                        authProperties);
                }
                catch(Exception ex)
                {
                    string error = ex.Message;
                }
            }
            return LocalRedirect(returnUrl);
        }
    }
}
