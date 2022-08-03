#pragma checksum "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd56c66e00f9bc06503f9b983b1afc59bcda46d"
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
#nullable restore
#line 15 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/history-detail/{id}")]
    public partial class HistoryDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Chi tiết đơn hàng</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-2\">Ngày đặt</dt>\r\n        ");
            __builder.OpenElement(6, "dd");
            __builder.AddAttribute(7, "class", "col-sm-10");
#nullable restore
#line 22 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(8, model.NgayDat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<dt class=\"col-sm-2\">Tổng tiền</dt>\r\n        ");
            __builder.OpenElement(11, "dd");
            __builder.AddAttribute(12, "class", "col-sm-10");
#nullable restore
#line 26 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(13, model.Tongtien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<dt class=\"col-sm-2\">Trạng thái</dt>\r\n        ");
            __builder.OpenElement(16, "dd");
            __builder.AddAttribute(17, "class", "col-sm-10");
            __builder.OpenComponent<eShopClient.Shared.Label.OrderStatusLabel>(18);
            __builder.AddAttribute(19, "trangThaiDonHang", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DonHang.TrangThaiDonHang>(
#nullable restore
#line 30 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                                                                          model.TrangthaiDonhang

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<dt class=\"col-sm-2\">Ghi chú</dt>\r\n        ");
            __builder.OpenElement(22, "dd");
            __builder.AddAttribute(23, "class", "col-sm-10");
#nullable restore
#line 35 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(24, model.Ghichu);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table");
            __builder.AddMarkupContent(28, @"<thead><tr><th>
                    Món ăn
                </th>
                <th>
                    Hình
                </th>
                <th>
                    Số lượng
                </th>
                <th>
                    Thành tiền
                </th></tr></thead>
        ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 58 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
             foreach (var item in listDonhang)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                 if (item != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(32, item.MonAn.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 68 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                             try
                            {
                                if (item.MonAn.Photos != null)
                                {
                                    temp = imgUrl + item.MonAn.Photos.FirstOrDefault().FileName;
                                }
                                else
                                {
                                    temp = imgUrl + "/nophoto.png";
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "img");
            __builder.AddAttribute(36, "src", 
#nullable restore
#line 78 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                                           temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "style", "width:150px");
            __builder.CloseElement();
#nullable restore
#line 79 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                            }
                            catch
                            {

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 87 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(40, item.SoLuong);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 90 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
__builder.AddContent(43, item.ThanhTien);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.AddMarkupContent(45, "<div><a class=\"btn btn-info\" href=\"/\">Trang chủ</a> |\r\n    <a class=\"btn\" href=\"/History\">Danh sách</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "D:\Myproject\CSharp\NET106\ASM\eShop\eShopClient\Pages\HistoryDetail.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Tieude = "";
    protected string temp = "";
    protected string imgUrl = "";
    public DonHang model;
    public List<DonHangChiTiet> listDonhang = new List<DonHangChiTiet>();
    protected override async Task OnInitializedAsync()
    //protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            NavigationManager.NavigateTo("/History", true); ;
        }
        else
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            model = new DonHang();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("DonHangChiTiet/" + id))
                {
                    //string apiResponse = await response.Content.ReadAsStringAsync();
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DonHang>>(apiResponse)[0];
                    listDonhang = model.donHangChiTiets;
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
