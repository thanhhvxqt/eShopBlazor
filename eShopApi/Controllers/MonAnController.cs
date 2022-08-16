using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopShare.Models.Paging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        public async Task<IActionResult> GetMonAns([FromQuery] ProductParameters productParameters)
        {
            var products = await _monAnSvc.GetMonAnAllClient(productParameters);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(products.MetaData));

            return Ok(products);
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
