#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b8dc2d01af2d5499c3a6525fb1c082119953e95"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopClient.Pages
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
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
using eShopShare.Models.Paging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
 if (monAns == null || monAns.Count <= 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<eShopClient.Shared.LoadingIndicator>(0);
            __builder.CloseComponent();
#nullable restore
#line 18 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "featured-products bgcolor  section--padding");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "shortcode_wrapper");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-12");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "shortcode_modules");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "tab tab3");
            __builder.AddMarkupContent(15, @"<div class=""item-navigation"" style=""text-align:left !important""><ul class=""nav nav-tabs nav--tabs2""><li><a href=""#new-phim-index-tab"" class=""active"" role=""tab"" data-toggle=""tab""><span class=""fa fa-burger-soda""></span> Thức ăn nổi bật
                                            </a></li></ul></div>
                                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "tab-content");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "tab-pane product-tab fade show active");
            __builder.AddAttribute(20, "id", "new-phim-index-tab");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
#nullable restore
#line 40 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                             foreach (var item in monAns)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-6 col-md-6 col-lg-3 col-rt15-3");
            __builder.AddAttribute(25, "style", "padding-right:5px; padding-left:5px");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "news");
            __builder.AddAttribute(28, "style", "margin-bottom:30px");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "news__thumbnail");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/food-detail/" + (
#nullable restore
#line 45 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                   item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "title", 
#nullable restore
#line 45 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                    item.Name

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 47 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                  
                                                                    if (item.Photos.Any())
                                                                    {
                                                                        temp = imgUrl + item.Photos.FirstOrDefault().FileName;
                                                                    }
                                                                    else
                                                                    {
                                                                        temp = imgUrl + "/nophoto.png";
                                                                    }

                                                                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "img");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                           temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "alt", 
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                       item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "title", 
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "style", "width:270px;height:290px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "news__content");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", "food-detail/" + (
#nullable restore
#line 62 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                  item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "news-title");
            __builder.AddAttribute(45, "title", 
#nullable restore
#line 62 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "style", "margin-bottom:5px");
            __builder.OpenElement(47, "h2");
            __builder.AddAttribute(48, "style", "font-size:14px; line-height:20px");
            __builder.AddContent(49, 
#nullable restore
#line 63 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                              item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                                            ");
            __builder.OpenElement(51, "h3");
            __builder.AddAttribute(52, "style", "font-size:12px; color: var(--p); line-height:20px");
            __builder.AddAttribute(53, "title", 
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                                                  item.MoTa

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, 
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                                                                                                                              item.MoTa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\Myproject\CSharp\NET106\ASM\eShopBlazor\eShopClient\Pages\Index.razor"
       
    private string name;
    //public List<MonAn> monAns = null;
    protected string imgUrl = "";
    protected string temp = "";
    public string CARTKEY = "cart";
    public List<MonAn> monAns { get; set; } = new List<MonAn>();
    public MetaData MetaData { get; set; } = new MetaData();
    private ProductParameters _productParameters = new ProductParameters();
    //protected void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        temp = imgUrl + "/nophoto.png";
        await GetProducts();
    }
    private async Task GetProducts()
    {
        var res = await _productSvc.GetAll();
        monAns = res.OrderByDescending(x => x.Views).Take(4).ToList();
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("setTitle", "Web bán thức ăn"); ;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService _cartSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICallProductSvc _productSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
