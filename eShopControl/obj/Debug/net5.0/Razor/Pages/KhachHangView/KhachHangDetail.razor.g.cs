#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32818ba51b3c1e388723aceb8f45a8e6cf82a1df"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.KhachHangView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using eShopControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using eShopControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/khach-hang-detail/{id}")]
    public partial class KhachHangDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chi tiết khách hàng</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-2\">User Name</dt>\r\n        ");
            __builder.OpenElement(6, "dd");
            __builder.AddAttribute(7, "class", "col-sm-10");
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(8, user.UserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<dt class=\"col-sm-2\">Tên khách hàng</dt>\r\n        ");
            __builder.OpenElement(11, "dd");
            __builder.AddAttribute(12, "class", "col-sm-10");
#nullable restore
#line 19 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(13, user.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<dt class=\"col-sm-2\">Địa chỉ</dt>\r\n        ");
            __builder.OpenElement(16, "dd");
            __builder.AddAttribute(17, "class", "col-sm-10");
#nullable restore
#line 23 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(18, user.HomeAddress);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<dt class=\"col-sm-2\">Ngày sinh</dt>\r\n        ");
            __builder.OpenElement(21, "dd");
            __builder.AddAttribute(22, "class", "col-sm-10");
#nullable restore
#line 27 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(23, user.DayOfBirth);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.AddMarkupContent(25, "<dt class=\"col-sm-2\">Email</dt>\r\n        ");
            __builder.OpenElement(26, "dd");
            __builder.AddAttribute(27, "class", "col-sm-10");
#nullable restore
#line 31 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(28, user.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<dt class=\"col-sm-2\">SDT</dt>\r\n        ");
            __builder.OpenElement(31, "dd");
            __builder.AddAttribute(32, "class", "col-sm-10");
#nullable restore
#line 35 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
__builder.AddContent(33, user.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.AddMarkupContent(35, "<div><a class=\"btn btn-info\" href=\"/khach-hang-list\">Danh sách</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\KhachHangView\KhachHangDetail.razor"
      
    [Parameter]
    public string id { get; set; }
    public string TieuDe { get; set; }
    public AppUser user;
    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(id) || id == "0")
        {
            navigation.NavigateTo("/khach-hang-list", true);
        }
        else{
            user = _context.Users.FirstOrDefault(x=>x.Id == id);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext _context { get; set; }
    }
}
#pragma warning restore 1591
