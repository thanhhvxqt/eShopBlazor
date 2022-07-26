#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e2b578e3d9de3aa8f1571eb3b967f3ed906221"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class Breadcrumb : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "breadcrumb-area");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-12");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "breadcrumb");
            __builder.OpenElement(10, "ul");
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                         foreach (var link in Links.OrderBy(x => x.OrderIndex))
                        {
                            if (link.IsActive)
                            {
                                temp = link.Title;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "active");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "style", "text-transform: capitalize;");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                                                                                  link.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, 
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                                                                                                 link.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "li");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", 
#nullable restore
#line 20 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                                              link.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, 
#nullable restore
#line 20 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                                                             link.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                  
                    int n;
                    bool isNumeric = int.TryParse(temp, out n);

                    if (temp.Contains("food-detail") || isNumeric == true)
                        temp = "Chi tiết";

                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "h1");
            __builder.AddAttribute(22, "class", "page-title");
            __builder.AddContent(23, 
#nullable restore
#line 35 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
                                        temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Shared\Breadcrumb.razor"
       
    [Parameter]
    public List<eShopShare.Models.BreadcrumbLink> Links { get; set; }
    public string temp = "";
    public Breadcrumb()
    {

    }
    protected override Task OnParametersSetAsync() => base.OnParametersSetAsync();
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
