using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetEmailOrUserName : ControllerBase
    {
        private readonly DataContext _context;

        public GetEmailOrUserName(DataContext context)
        {
            this._context = context;
        }

        [HttpGet("{content}")]
        public async Task<IActionResult> GetUserName(string content)
        {
            AppUser appUser = null;
            if (IsValidEmail(content))
            {
                appUser = await _context.Users.FirstOrDefaultAsync(x=>x.Email == content);
            }
            else
            {
                appUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == content);
            }
            
            if(appUser != null)
            {
                return Ok();
            }
            return BadRequest();
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
