#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef27fb7d464ca4c67587cac3dc92da3fed80b48"
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
#line 1 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class TopSideNav : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "menu-area");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "top-menu-area");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, @"<div class=""col-lg-3 col-md-3 col-6 v_middle""><div class=""logo d-block d-md-none"" style=""padding:19px 0""><a href=""/"" title=""  Logo""><img src=""Assets/Imgs/Logo/"" alt=""  Logo"" title=""  Logo"" class=""img-fluid"" width=""399"" height=""50""></a></div></div>
                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-8 offset-lg-1 col-md-9 col-6 v_middle");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "author-area");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "author__notification_area");
                __builder2.OpenElement(17, "ul");
                __builder2.OpenElement(18, "li");
                __builder2.AddAttribute(19, "class", "has_dropdown");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "icon_wrap");
                __builder2.AddMarkupContent(22, "<span class=\"fal fa-shopping-cart\"></span>\r\n                                                ");
                __builder2.OpenElement(23, "span");
                __builder2.AddAttribute(24, "class", "notification_count msg");
                __builder2.AddContent(25, 
#nullable restore
#line 59 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                      GetCountCart()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                                            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "dropdowns messaging--dropdown");
                __builder2.AddMarkupContent(29, "<div class=\"dropdown_module_header\"><h4>Giỏ hàng</h4>\r\n                                                    <a href=\"/cart\">Xem tất cả</a></div>");
#nullable restore
#line 66 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                 if (GioHangNotEmpty())
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                     foreach (var item in giohang.cartItems)
                                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "messages");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "href", "/food-detail/" + (
#nullable restore
#line 71 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                   item.product.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "class", "message recent");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "message__actions_avatar");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "avatar");
#nullable restore
#line 74 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                          
                                                                            if (item.product.Photos.Any())
                                                                            {
                                                                                temp = imgUrl + item.product.Photos.FirstOrDefault().FileName;
                                                                            }
                                                                            else
                                                                            {
                                                                                temp = imgUrl + "/nophoto.png";
                                                                            }
                                                                        

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(39, "img");
                __builder2.AddAttribute(40, "src", 
#nullable restore
#line 84 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                   temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "alt", "avatar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                                                                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "message_data");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "name_time");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "name");
                __builder2.OpenElement(49, "p");
                __builder2.AddContent(50, 
#nullable restore
#line 90 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                item.product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                                                                        ");
                __builder2.OpenElement(52, "span");
                __builder2.AddAttribute(53, "class", "time");
#nullable restore
#line 96 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                             if (item.product.CategoryID != null)
                                                                            {
                                                                                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, 
#nullable restore
#line 98 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                 item.product.Category.Title

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 98 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                                            
                                                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                                                        ");
                __builder2.OpenElement(56, "p");
                __builder2.AddMarkupContent(57, "Số lượng: ");
                __builder2.AddContent(58, 
#nullable restore
#line 101 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                      item.quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 107 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                      ()=>OrderCart()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "style", "\r\n    height: 46px ;");
                __builder2.AddAttribute(62, "class", "btn btn-primary btn-block mb-4");
                __builder2.AddMarkupContent(63, "\r\n                                                        Đặt hàng\r\n                                                    ");
                __builder2.CloseElement();
#nullable restore
#line 112 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "author-author__info inline has_dropdown");
                __builder2.AddMarkupContent(67, "<div class=\"author__avatar\"><img src=\"/css/Assets/Imgs/Avatar/avatar.jpg\" alt=\"hovanthanh avatar\" style=\"width: 35px; height: 35px; border-radius:50%\"></div>\r\n                                    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "autor__info");
                __builder2.OpenElement(70, "p");
                __builder2.AddAttribute(71, "class", "name");
                __builder2.AddContent(72, 
#nullable restore
#line 122 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                         context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                        ");
                __builder2.AddMarkupContent(74, "<p class=\"ammount\">100,000,000 VND</p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                    ");
                __builder2.AddMarkupContent(76, @"<div class=""dropdowns dropdown--author""><ul><li><a href=""/user/profile""><span class=""fas fa-user""></span>Hồ sơ
                                                </a></li>
                                            <li><a href=""/history""><span class=""fas fa-history""></span>Lịch sử mua hàng
                                                </a></li>
                                            <li><a href=""/logout""><span class=""fas fa-sign-out-alt""></span>Logout
                                                </a></li></ul></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "mobile_content ");
                __builder2.AddMarkupContent(80, "<span class=\"fas fa-user menu_icon\"></span>\r\n                                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "offcanvas-menu closed");
                __builder2.AddMarkupContent(83, "<span class=\"fal fa-times close_menu\"></span>\r\n                                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "author-author__info");
                __builder2.AddMarkupContent(86, "<div class=\"author__avatar v_middle\"><img src=\"/css/Assets/Imgs/Avatar/avatar.jpg\" alt=\"hovanthanh avatar\" style=\"width: 50px; height: 50px; border-radius:50%\"></div>\r\n                                        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "autor__info v_middle");
                __builder2.OpenElement(89, "p");
                __builder2.AddAttribute(90, "class", "name");
                __builder2.AddContent(91, 
#nullable restore
#line 156 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                            ");
                __builder2.AddMarkupContent(93, "<p class=\"ammount\">100,000,000 LND</p>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                    ");
                __builder2.AddMarkupContent(95, "<div class=\"author__notification_area\"><ul></ul></div>\r\n                                    ");
                __builder2.AddMarkupContent(96, @"<div class=""dropdowns dropdown--author""><ul><li><a href=""/user/profile""><span class=""fas fa-user""></span>Hồ sơ
                                                </a></li>
                                            <li><a href=""/history""><span class=""fal fa-book-open""></span>Lịch sử mua hàng
                                                </a></li>
                                            <li><a href=""/logout""><span class=""fas fa-sign-out-alt""></span>Logout
                                                </a></li></ul></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(97, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "author-area not_logged_in");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "pull-right join");
                __builder2.OpenElement(102, "a");
                __builder2.AddAttribute(103, "href", "/login");
                __builder2.AddAttribute(104, "class", "btn btn--round btn--xs btn-warning");
                __builder2.AddAttribute(105, "title", "Giỏ hàng");
                __builder2.AddMarkupContent(106, "Giỏ hàng (");
                __builder2.AddContent(107, 
#nullable restore
#line 209 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
                                                                                                                            GetCountCart()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(108, ")");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                    ");
                __builder2.AddMarkupContent(110, "<a href=\"/register\" class=\"btn btn--round btn-secondary  btn--xs\" title=\"Đăng ký thành viên\">Đăng ký</a>\r\n                                    ");
                __builder2.AddMarkupContent(111, "<a href=\"/login\" class=\"btn btn--round btn--xs\" title=\"Đăng nhập\">Đăng nhập</a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                            ");
                __builder2.AddMarkupContent(113, "<div class=\"mobile_content \"><span class=\"menu_icon\"><a href=\"/login\" title=\"Đăng nhập\" style=\"color:white\">Đăng nhập</a></span></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 228 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopClient\Shared\TopSideNav.razor"
       
    string emailAddress;
    string Name;
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    public PostCartModel giohang;
    protected string imgUrl = "";
    string cart;
    int cartItemCount = 0;
    protected string temp = "";
    public string khachid;

    protected async override void OnInitialized()
    {
        //cart = sessionStorage.GetItem<string>("cart");
        _OCSvc.OnChange += StateHasChanged;
        await GetKhachId();
        getGioHang();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }
    public async Task<string> GetKhachId()
    {
        khachid = (await AuthStat).User.Claims.FirstOrDefault(x => x.Type == "khachid").Value.ToString();
        return khachid;
    }
    public void Dispose()
    {
        _OCSvc.OnChange -= StateHasChanged;
    }
    public void getGioHang()
    {
        var cart = sessionStorage.GetItem<string>("cart");//get key cart

        if (cart == null)
        {
            giohang = new PostCartModel();
        }
        else
        {
            giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
        }
    }
    private async Task OrderCart()
    {
        NavigationManager.NavigateTo("/checkout");
    }
    private bool GioHangNotEmpty()
    {
        getGioHang();
        if (giohang.cartItems != null)
            return true;
        return false;
    }
    private void DeleteCart(CartItem item)
    {
        giohang.cartItems.Remove(item);
        giohang.TongTien = Tinhtien(giohang.cartItems);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
        _OCSvc.Invoke();
    }

    private double Tinhtien(List<CartItem> listCart)
    {
        double tongtien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongtien += listCart[i].Sotien;
            }
        }
        return tongtien;
    }
    public int GetCountCart()
    {
        cart = sessionStorage.GetItem<string>("cart");
        if (cart != null)
        {
            PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
            var temp = cartItemCount = giohang.cartItems.Count;
            if (temp < 1)
            {
                temp = 0;
            }
            return temp;
        }
        return 0;
    }
    protected void o()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        cart = sessionStorage.GetItem<string>("cart");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOnChangeService _OCSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
