using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MonAnController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMonAnSvc _monAnSvc;

        public MonAnController(DataContext context, IMonAnSvc monAnSvc)
        {
            _context = context;
            this._monAnSvc = monAnSvc;
        }

        // GET: api/MonAn
        [HttpGet]
        public ActionResult<IEnumerable<MonAn>> GetMonAns()
        {
            return  _monAnSvc.GetMonAnAll();
        }

        // GET: api/MonAn/5
        [HttpGet("{id}")]
        public  ActionResult<MonAn> GetMonAn(int id)
        {
            
            return  _monAnSvc.GetMonAn(id);
        }
        [HttpGet("Search/{text}")]
        public async Task<ActionResult<List<MonAn>>> SearchMonAns(string text)
        {
            return Ok(await _monAnSvc.Search(text));
        }
        private bool MonAnExists(int id)
        {
            return _context.MonAns.Any(e => e.Id == id);
        }
    }
}
