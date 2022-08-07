using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PostCartModel
{
    public string khachHangId { get; set; }
    public double TongTien { get; set; }    
    public int quantity { set; get; }
    public MonAn product { set; get; }
    [Required]
    public string ghiChu { get; set; }
    [Required]
    public string tenNguoiNhan { get;set; }
    [Required]
    public string address { get; set; }
    [Required]
    public string phoneNumber { set; get; }
    public List<CartItem> cartItems { get; set; }
}
