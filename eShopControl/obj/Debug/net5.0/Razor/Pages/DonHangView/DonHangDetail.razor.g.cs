#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0740ceff09449bd56b1024554fd7b300c25d49"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.DonHangView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using eShopControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using eShopControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/donhangdetail/{id}")]
    public partial class DonHangDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chi tiết đơn hàng</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-2\">Khách hàng</dt>\r\n        ");
            __builder.OpenElement(6, "dd");
            __builder.AddAttribute(7, "class", "col-sm-10");
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(8, donHang.KhachHang.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<dt class=\"col-sm-2\">Ngày đặt</dt>\r\n        ");
            __builder.OpenElement(11, "dd");
            __builder.AddAttribute(12, "class", "col-sm-10");
#nullable restore
#line 19 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(13, donHang.NgayDat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<dt class=\"col-sm-2\">Tổng tiền</dt>\r\n        ");
            __builder.OpenElement(16, "dd");
            __builder.AddAttribute(17, "class", "col-sm-10");
#nullable restore
#line 23 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(18, donHang.Tongtien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<dt class=\"col-sm-2\">Trạng thái</dt>\r\n        ");
            __builder.OpenElement(21, "dd");
            __builder.AddAttribute(22, "class", "col-sm-10");
#nullable restore
#line 27 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(23, donHang.TrangthaiDonhang);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.AddMarkupContent(25, "<dt class=\"col-sm-2\">Ghi chú</dt>\r\n        ");
            __builder.OpenElement(26, "dd");
            __builder.AddAttribute(27, "class", "col-sm-10");
#nullable restore
#line 31 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(28, donHang.Ghichu);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table");
            __builder.AddMarkupContent(32, "<thead><tr><th scope=\"col\">Món ăn</th>\r\n      <th scope=\"col\">Hình</th>\r\n      <th scope=\"col\">Số lượng</th>\r\n      <th scope=\"col\">Thành tiền</th>\r\n      <th scope=\"col\">Ghi chú</th></tr></thead>\r\n  ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 45 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
             foreach(var item in donHang.donHangChiTiets)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "th");
#nullable restore
#line 48 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(36, item.MonAn.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n      ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "src", "images/food/" + (
#nullable restore
#line 49 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
                                  item.MonAn.Photos.FirstOrDefault().FileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "alt");
            __builder.AddAttribute(42, "style", "width:150px;border-radius:0px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n      ");
            __builder.OpenElement(44, "td");
#nullable restore
#line 50 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(45, item.SoLuong);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n      ");
            __builder.OpenElement(47, "td");
#nullable restore
#line 51 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
__builder.AddContent(48, item.DonHang.Ghichu);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenElement(50, "div");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "class", "btn btn-info");
            __builder.AddAttribute(53, "href", "/donhangdialog/" + (
#nullable restore
#line 60 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
                                                   donHang.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "Sửa");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n     ");
            __builder.AddMarkupContent(56, "<a class=\"btn btn-info\" href=\"/donhanglist\">Danh sách</a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangDetail.razor"
      
    [Parameter]
    public string id { get; set; }
    public string TieuDe { get; set; }
    public DonHang donHang;
    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(id) || id == "0")
        {
            navigation.NavigateTo("donhanglist", true);
        }
        else{
            donHang = _donhangSvc.GetDonHang(int.Parse(id));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangSvc { get; set; }
    }
}
#pragma warning restore 1591
