using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangChiTietController : ControllerBase
    {
        private readonly DataContext _context;

        public DonHangChiTietController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DonHangChiTiet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonHangChiTiet>>> GetDonHangChiTiets()
        {
            return await _context.DonHangChiTiets.ToListAsync();
        }

        // GET: api/DonHangChiTiet/5
        [HttpGet("{id}")]
        public async Task<List<DonHang>> GetDonHangChiTiet(int id)
        {
            var donHangChiTiet = await _context.DonHangs.Where(x=>x.DonHangID == id)
                .Include(x=>x.donHangChiTiets)
                .ThenInclude(x=>x.MonAn)
                .ThenInclude(x=>x.Photos)
                .ToListAsync();

            if (donHangChiTiet == null)
            {
                return null;
            }

            return donHangChiTiet;
        }

        // PUT: api/DonHangChiTiet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonHangChiTiet(int id, DonHangChiTiet donHangChiTiet)
        {
            if (id != donHangChiTiet.ChiTietID)
            {
                return BadRequest();
            }

            _context.Entry(donHangChiTiet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonHangChiTietExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DonHangChiTiet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DonHangChiTiet>> PostDonHangChiTiet(DonHangChiTiet donHangChiTiet)
        {
            _context.DonHangChiTiets.Add(donHangChiTiet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonHangChiTiet", new { id = donHangChiTiet.ChiTietID }, donHangChiTiet);
        }

        // DELETE: api/DonHangChiTiet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonHangChiTiet(int id)
        {
            var donHangChiTiet = await _context.DonHangChiTiets.FindAsync(id);
            if (donHangChiTiet == null)
            {
                return NotFound();
            }

            _context.DonHangChiTiets.Remove(donHangChiTiet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonHangChiTietExists(int id)
        {
            return _context.DonHangChiTiets.Any(e => e.ChiTietID == id);
        }
    }
}
