#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc6caee24e110d43f43bc9eb52b0db4be5dded70"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Shared.PaginationView
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
#line 14 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center");
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
         foreach (var link in _links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
                            ()=> OnSelectedPage(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "cursor:pointer");
            __builder.AddAttribute(7, "class", "page-item" + "\r\n                " + (
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
                  link.Active?"active":null

#line default
#line hidden
#nullable disable
            ) + "\r\n                " + (
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
                  link.Enabled?null:"disabled"

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "href", "#");
            __builder.AddContent(11, 
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Shared\PaginationView\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
