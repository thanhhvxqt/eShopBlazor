﻿using System;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    
    public class DonHangController : ControllerBase
    {
        private readonly DataContext _context;

        public DonHangController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DonHang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonHang>>> GetDonHangs()
        {
            return await _context.DonHangs.ToListAsync();
        }

        // GET: api/DonHang/5
        [HttpGet("{id}")]
        public async Task<List<DonHang>> GetDonHang(string id)
        {
            var donHang = await _context.DonHangs.Where(x => x.KhachHangID==(id))
                .Include(x => x.donHangChiTiets)
                .ThenInclude(y => y.MonAn)
                .ThenInclude(x => x.Photos)
                .Include(x => x.KhachHang)
                .ToListAsync();
            //var temp = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            //foreach(var item in donHang)
            //{
            //    item.KhachHang = temp;
            //}
            //_context.Update(donHang);
            //_context.SaveChanges();
            if (donHang == null)
            {
                return null;
            }

            return donHang;
        }


        private bool DonHangExists(int id)
        {
            return _context.DonHangs.Any(e => e.DonHangID == id);
        }
    }
}
