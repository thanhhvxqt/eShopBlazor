#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d04fbbba56598c9b8254d5ec88c925bbf1ece14"
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
#line 11 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
using eShopShare;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/don-hang-list")]
    public partial class DonHangList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Danh sách đơn hàng</h1>");
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
 if (donhangs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">Khách hàng</th>\r\n                <th scope=\"col\">Ngày đặt</th>\r\n                <th scope=\"col\">Tổng tiền</th>\r\n                <th scope=\"col\">Trạng thái</th>\r\n                <th scope=\"col\">Ghi chú</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
             foreach (var item in donhangs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 25 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
__builder.AddContent(8, item.KhachHang.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 26 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
__builder.AddContent(11, item.NgayDat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 27 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
__builder.AddContent(14, item.Tongtien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.OpenComponent<eShopControl.Shared.Label.OrderStatusLabel>(17);
            __builder.AddAttribute(18, "trangThaiDonHang", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DonHang.TrangThaiDonHang>(
#nullable restore
#line 28 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                                                                                       item.TrangthaiDonhang

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 29 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
__builder.AddContent(21, item.Ghichu);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "btn btn-info");
            __builder.AddAttribute(26, "href", "/don-hang-dialog/" + (
#nullable restore
#line 30 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                                                                        item.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "btn btn-info");
            __builder.AddAttribute(32, "href", "/don-hang-detail/" + (
#nullable restore
#line 31 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
                                                                        item.DonHangID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopControl\Pages\DonHangView\DonHangList.razor"
       
    public List<DonHang> donhangs;
    protected override void OnInitialized()
    {
        donhangs = _donhangSvc.GetDonHangAll();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangSvc { get; set; }
    }
}
#pragma warning restore 1591
