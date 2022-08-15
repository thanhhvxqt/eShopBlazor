using eShopApi.Models;
using eShopApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopApi.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;

        public CartController(IDonHangSvc donHangSvc, IDonHangChiTietSVC donHangChiTietSVC, DataContext dataContext, IEmailService emailService, UserManager<AppUser> userManager, IConfiguration configuration)
        {
            _DonHangSvc = donHangSvc;
            _DonHangChiTietSVC = donHangChiTietSVC;
            _context = dataContext;
            this._emailService = emailService;
            this._userManager = userManager;
            this._configuration = configuration;
        }

        public IDonHangSvc _DonHangSvc { get; }
        public IDonHangChiTietSVC _DonHangChiTietSVC { get; }
        public DataContext _context { get; }
        [HttpPost]

        public async Task<ActionResult<int>> PostCart(PostCartModel giohang)
        {
            try
            {
                var cart = giohang.cartItems;
                decimal total = 0;
                foreach (var item in cart)
                {
                    var thanhtien = item.quantity * item.product.Gia;
                    total += thanhtien;
                }

                DonHang donHang = new DonHang()
                {
                    KhachHangID = giohang.khachHangId,
                    Ghichu = giohang.ghiChu,
                    TenNguoiNhan = giohang.tenNguoiNhan,
                    Address = giohang.address,
                    SDT = giohang.phoneNumber,
                    NgayDat = DateTime.Now.Date,
                    Tongtien = (double)total,
                    TrangthaiDonhang = DonHang.TrangThaiDonHang.MoiDat,
                    KhachHang = _context.Users.Where(u => u.Id == giohang.khachHangId).FirstOrDefault()
                };
                await _context.DonHangs.AddAsync(donHang);
                await _context.SaveChangesAsync();
                for (int i = 0; i < cart.Count; i++)
                {
                    DonHangChiTiet detail = new DonHangChiTiet()
                    {
                        DonHangID = _context.DonHangs.Max(x => x.DonHangID),
                        MonAnID = cart[i].product.Id,
                        SoLuong = cart[i].quantity,
                        ThanhTien = cart[i].quantity * (double)cart[i].product.Gia
                    };
                    var product = _context.MonAns
                                .Where(p => p.Id == cart[i].product.Id && p.TrangThai == true)
                                .FirstOrDefault();
                    if (product.Quantity > 0)
                    {
                        product.Quantity -= cart[i].quantity;
                    }
                    _context.MonAns.Update(product);
                    await _context.DonHangChiTiets.AddAsync(detail);
                    await _context.SaveChangesAsync();
                }
                var getUserFromId = await _userManager.FindByIdAsync(giohang.khachHangId);
                if (getUserFromId == null)
                {
                    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }
                string url = $"{_configuration["ClientUrl"]}/history";
                EmailDto emailDto = new EmailDto
                {
                    Subject = "Đặt hàng thành công",
                    Body = $"<h1>Xin chào, {getUserFromId.Name}</h1><br/>"
                    + $"<p>Bạn vừa đặt hàng thành công</p>"
                    + $"<p>Tổng tiền: {giohang.TongTien}</p>"
                    + $"<p><a href='{url}'>Bấm vào đây</a> để xem lịch sử mua hàng</p>",
                    To = getUserFromId.Email
                };
                _emailService.SendEmail(emailDto);
            }
            catch
            {
                return BadRequest(-1);
            }

            return Ok(1);

        }
    }
}
