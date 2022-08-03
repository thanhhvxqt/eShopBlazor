using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IDonHangSvc
    {
        List<DonHang> GetDonHangAll();
        Task<AppUser> GetDonHangByKhachHang(string khachHangID);
        DonHang GetDonHang(int id);
        int AddDonHang(DonHang donHang);
        int EditDonHang(int id, DonHang donHang);
    }
    public class DonHangSvc : IDonHangSvc
    {
        protected DataContext _context;

        public DonHangSvc(DataContext context)
        {
            _context = context;
        }

        public int AddDonHang(DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Add(donHang);
                _context.SaveChanges();
                ret = donHang.DonHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditDonHang(int id, DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Update(donHang);
                _context.SaveChanges();
                ret = donHang.DonHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public DonHang GetDonHang(int id)
        {
            DonHang donHang = null;
            donHang = _context.DonHangs.Where(x => x.DonHangID == id)
                .Include(x => x.donHangChiTiets)
                .ThenInclude(y => y.MonAn)
                .ThenInclude(x=>x.Photos)
                .Include(x => x.KhachHang)
                .FirstOrDefault();
            return donHang;
        }

        public List<DonHang> GetDonHangAll()
        {
            List<DonHang> donHangs = new List<DonHang>();
            donHangs = _context.DonHangs.OrderByDescending(x => x.NgayDat)
                .Include(x => x.KhachHang)
                .Include(x => x.donHangChiTiets)
                .ToList();
            return donHangs;
        }

        public async Task<AppUser> GetDonHangByKhachHang(string khachHangID)
        {
            AppUser donHangs = new AppUser();
            donHangs = await _context.Users.Where(x=>x.Id.Equals(khachHangID)).Include(x => x.DonHang).ThenInclude(x=>x.donHangChiTiets).FirstOrDefaultAsync();
            return donHangs;
        }
    }

