#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eea1e4859c743a46c48702e3830daf32ca0aaa8"
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
#line 1 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using eShopClient.Services;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"off_canvars_overlay\" b-54ym07er1g></div>\r\n    ");
            __builder.AddMarkupContent(1, "<div class=\"Offcanvas_menu\" b-54ym07er1g><div class=\"container\" b-54ym07er1g><div class=\"row\" b-54ym07er1g><div class=\"col-12\" b-54ym07er1g><div class=\"canvas_open\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><i class=\"ion-navicon\" b-54ym07er1g></i></a></div>\r\n                    <div class=\"Offcanvas_menu_wrapper\" b-54ym07er1g><div class=\"canvas_close\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div>\r\n                        <div class=\"support_info\" b-54ym07er1g><p b-54ym07er1g>Any Enquiry: <a href=\"tel:\" b-54ym07er1g>+56985475235</a></p></div>\r\n                        <div class=\"top_right text-right\" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=\"my-account.html\" b-54ym07er1g> My Account </a></li> \r\n                               <li b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g> Checkout </a></li></ul></div> \r\n                        <div class=\"search_container\" b-54ym07er1g><form action=\"#\" b-54ym07er1g><div class=\"search_box\" b-54ym07er1g><input placeholder=\"Search product...\" type=\"text\" b-54ym07er1g>\r\n                                    <button type=\"submit\" b-54ym07er1g>Search</button></div></form></div> \r\n                        \r\n                        <div class=\"middel_right_info\" b-54ym07er1g><div class=\"header_wishlist\" b-54ym07er1g><a href=\"wishlist.html\" b-54ym07er1g><img src=\"assets/img/user.png\" alt b-54ym07er1g></a></div>\r\n                            <div class=\"mini_cart_wrapper\" b-54ym07er1g><a href=\"javascript:void(0)\" b-54ym07er1g><img src=\"assets/img/shopping-bag.png\" alt b-54ym07er1g></a>\r\n                                <span class=\"cart_quantity\" b-54ym07er1g>2</span>\r\n                                \r\n                                 <div class=\"mini_cart\" b-54ym07er1g><div class=\"cart_item\" b-54ym07er1g><div class=\"cart_img\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/s-product/product.jpg\" alt b-54ym07er1g></a></div>\r\n                                        <div class=\"cart_info\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Sit voluptatem rhoncus sem lectus</a>\r\n                                            <p b-54ym07er1g>Qty: 1 X <span b-54ym07er1g> $60.00 </span></p></div>\r\n                                        <div class=\"cart_remove\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div></div>\r\n                                    <div class=\"cart_item\" b-54ym07er1g><div class=\"cart_img\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><img src=\"assets/img/s-product/product2.jpg\" alt b-54ym07er1g></a></div>\r\n                                        <div class=\"cart_info\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Natus erro at congue massa commodo</a>\r\n                                            <p b-54ym07er1g>Qty: 1 X <span b-54ym07er1g> $60.00 </span></p></div>\r\n                                        <div class=\"cart_remove\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"ion-android-close\" b-54ym07er1g></i></a></div></div>\r\n                                    <div class=\"mini_cart_table\" b-54ym07er1g><div class=\"cart_total\" b-54ym07er1g><span b-54ym07er1g>Sub total:</span>\r\n                                            <span class=\"price\" b-54ym07er1g>$138.00</span></div>\r\n                                        <div class=\"cart_total mt-10\" b-54ym07er1g><span b-54ym07er1g>total:</span>\r\n                                            <span class=\"price\" b-54ym07er1g>$138.00</span></div></div>\r\n\r\n                                    <div class=\"mini_cart_footer\" b-54ym07er1g><div class=\"cart_button\" b-54ym07er1g><a href=\"cart.html\" b-54ym07er1g>View cart</a></div>\r\n                                        <div class=\"cart_button\" b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g>Checkout</a></div></div></div></div></div>\r\n                        <div id=\"menu\" class=\"text-left \" b-54ym07er1g><ul class=\"offcanvas_main_menu\" b-54ym07er1g><li class=\"menu-item-has-children active\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>Home</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"product-details.html\" b-54ym07er1g>product</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>pages </a>\r\n                                    <ul class=\"sub-menu\" b-54ym07er1g><li b-54ym07er1g><a href=\"about.html\" b-54ym07er1g>About Us</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g>contact</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"privacy-policy.html\" b-54ym07er1g>privacy policy</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"faq.html\" b-54ym07er1g>Frequently Questions</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"login.html\" b-54ym07er1g>login</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"register.html\" b-54ym07er1g>register</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"forget-password.html\" b-54ym07er1g>Forget Password</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"404.html\" b-54ym07er1g>Error 404</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"cart.html\" b-54ym07er1g>cart</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"tracking.html\" b-54ym07er1g>tracking</a></li>\r\n\t\t\t\t\t\t\t\t\t\t<li b-54ym07er1g><a href=\"checkout.html\" b-54ym07er1g>checkout</a></li></ul></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"#\" b-54ym07er1g>blog</a>\r\n                                    <ul class=\"sub-menu\" b-54ym07er1g><li b-54ym07er1g><a href=\"blog.html\" b-54ym07er1g>blog</a></li>\r\n                                        <li b-54ym07er1g><a href=\"blog-details.html\" b-54ym07er1g>blog details</a></li></ul></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"login.html\" b-54ym07er1g>my account</a></li>\r\n                                <li class=\"menu-item-has-children\" b-54ym07er1g><a href=\"contact.html\" b-54ym07er1g> Contact Us</a></li></ul></div>\r\n\r\n                        <div class=\"Offcanvas_footer\" b-54ym07er1g><span b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-envelope-o\" b-54ym07er1g></i> info@drophunt.com</a></span>\r\n                            <ul b-54ym07er1g><li class=\"facebook\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-facebook\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"twitter\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-twitter\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"pinterest\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-pinterest-p\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"google-plus\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-google-plus\" b-54ym07er1g></i></a></li>\r\n                                <li class=\"linkedin\" b-54ym07er1g><a href=\"#\" b-54ym07er1g><i class=\"fa fa-linkedin\" b-54ym07er1g></i></a></li></ul></div></div></div></div></div></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(2, "header");
            __builder.AddAttribute(3, "b-54ym07er1g");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main_header");
            __builder.AddAttribute(6, "b-54ym07er1g");
            __builder.AddMarkupContent(7, @"<div class=""header_top"" b-54ym07er1g><div class=""container"" b-54ym07er1g><div class=""row align-items-center"" b-54ym07er1g><div class=""col-lg-6 col-md-6"" b-54ym07er1g><div class=""support_info"" b-54ym07er1g><p b-54ym07er1g>Email: <a href=""mailto:"" b-54ym07er1g>support@drophunt.com</a></p></div></div>
                        <div class=""col-lg-6 col-md-6"" b-54ym07er1g><div class=""top_right text-right"" b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=""my-account.html"" b-54ym07er1g>Account</a></li> 
                                   <li b-54ym07er1g><a href=""checkout.html"" b-54ym07er1g>Checkout</a></li></ul></div></div></div></div></div>
            
            
            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "header_middle");
            __builder.AddAttribute(10, "b-54ym07er1g");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container");
            __builder.AddAttribute(13, "b-54ym07er1g");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row align-items-center");
            __builder.AddAttribute(16, "b-54ym07er1g");
            __builder.AddMarkupContent(17, "<div class=\"col-lg-3 col-md-6\" b-54ym07er1g><div class=\"logo\" b-54ym07er1g><a href=\"index-2.html\" b-54ym07er1g><img src=\"assets/img/logo/logo.png\" alt b-54ym07er1g></a></div></div>\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-lg-9 col-md-6");
            __builder.AddAttribute(20, "b-54ym07er1g");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "middel_right");
            __builder.AddAttribute(23, "b-54ym07er1g");
            __builder.AddMarkupContent(24, @"<div class=""search_container"" b-54ym07er1g><form action=""#"" b-54ym07er1g><div class=""search_box"" b-54ym07er1g><input placeholder=""Search product..."" type=""text"" b-54ym07er1g>
                                            <button type=""submit"" b-54ym07er1g>Search</button></div></form></div>
                                
                                ");
            __builder.OpenComponent<eShopClient.Shared.RighSideNav>(25);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            \r\n            \r\n            ");
            __builder.AddMarkupContent(27, @"<div class=""main_menu_area"" b-54ym07er1g><div class=""container"" b-54ym07er1g><div class=""row justify-content-center"" b-54ym07er1g><div class=""col-lg-12 col-md-12"" b-54ym07er1g><div class=""main_menu menu_position"" b-54ym07er1g><nav b-54ym07er1g><ul b-54ym07er1g><li b-54ym07er1g><a href=""/"" b-54ym07er1g>home</a></li></ul></nav></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    \r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "container");
            __builder.AddAttribute(31, "b-54ym07er1g");
            __builder.OpenElement(32, "main");
            __builder.AddAttribute(33, "role", "main");
            __builder.AddAttribute(34, "class", "pb-3");
            __builder.AddAttribute(35, "b-54ym07er1g");
#nullable restore
#line 244 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Shared\WebLayout.razor"
__builder.AddContent(36, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.AddMarkupContent(38, "<footer class=\"border-top footer text-muted\" b-54ym07er1g><div class=\"container\" b-54ym07er1g>\r\n        &copy; 2021 - ASM - <a asp-area asp-controller=\"Home\" asp-action=\"Privacy\" b-54ym07er1g>Privacy</a></div></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
