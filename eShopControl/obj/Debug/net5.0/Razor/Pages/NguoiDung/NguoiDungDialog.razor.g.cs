#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe78099c0e80436a470be21478e3817c34a8bcf1"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.NguoiDung
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
#nullable restore
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nguoi-dung-dialog/{id}")]
    public partial class NguoiDungDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 7 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
     TieuDe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
 if (nguoidung == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                  nguoidung

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                             SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "hidden");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                nguoidung.NguoiDungId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nguoidung.NguoiDungId = __value, nguoidung.NguoiDungId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"exampleInputEmail1\" class=\"form-label\">Tên Đăng Nhập</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                 nguoidung.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.UserName = __value, nguoidung.UserName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 24 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                              ()=>nguoidung.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label for=\"exampleInputEmail1\" class=\"form-label\">Họ Tên</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                 nguoidung.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.FullName = __value, nguoidung.FullName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.FullName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 29 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                              ()=>nguoidung.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label for=\"exampleInputEmail1\" class=\"form-label\">Email</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "type", "email");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                 nguoidung.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.Email = __value, nguoidung.Email))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#nullable restore
#line 34 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                              ()=>nguoidung.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label for=\"exampleInputEmail1\" class=\"form-label\">Chức danh</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                 nguoidung.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.Title = __value, nguoidung.Title))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "<label for=\"exampleInputEmail1\" class=\"form-label\">Ngày sinh</label>\r\n                    ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateInputDate_3(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 43 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                 nguoidung.DOB

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.DOB = __value, nguoidung.DOB)), 73, () => nguoidung.DOB);
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_4(__builder2, 75, 76, 
#nullable restore
#line 44 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                              ()=>nguoidung.DOB

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group form-check row");
                __builder2.OpenElement(80, "label");
                __builder2.AddAttribute(81, "for", "exampleInputEmail1");
                __builder2.AddAttribute(82, "class", "form-check-label");
                __builder2.AddMarkupContent(83, "\r\n                        \r\n                        Quản trị\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(84);
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "type", "checkbox");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                         nguoidung.IsAdmin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.IsAdmin = __value, nguoidung.IsAdmin))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => nguoidung.IsAdmin));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.OpenElement(91, "label");
                __builder2.AddAttribute(92, "for", "exampleInputEmail1");
                __builder2.AddAttribute(93, "class", "form-check-label");
                __builder2.AddMarkupContent(94, "\r\n                        \r\n                        Hoạt động\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(95);
                __builder2.AddAttribute(96, "class", "form-control");
                __builder2.AddAttribute(97, "type", "checkbox");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                         nguoidung.Locked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.Locked = __value, nguoidung.Locked))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => nguoidung.Locked));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                <div class=\"form-group form-check\"></div>\r\n                \r\n                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "<label for=\"exampleInputEmail1\" class=\"form-label\">Mật khẩu</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "type", "password");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                         nguoidung.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.Password = __value, nguoidung.Password))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                            ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_5(__builder2, 112, 113, 
#nullable restore
#line 65 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                      ()=>nguoidung.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "<label for=\"exampleInputEmail1\" class=\"form-label\">Xác nhận mật khẩu</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "class", "form-control");
                __builder2.AddAttribute(120, "type", "password");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                                         nguoidung.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nguoidung.ConfirmPassword = __value, nguoidung.ConfirmPassword))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nguoidung.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n                            ");
                __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog.TypeInference.CreateValidationMessage_6(__builder2, 125, 126, 
#nullable restore
#line 70 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                      ()=>nguoidung.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                \r\n\r\n                ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-group");
                __builder2.AddMarkupContent(130, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                    ");
                __builder2.OpenElement(131, "input");
                __builder2.AddAttribute(132, "class", "btn btn-primary");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\NguoiDung\NguoiDungDialog.razor"
        
    [Parameter]
    public string id  { get; set; }

    private Nguoidung nguoidung  { get; set; }

    private string TieuDe = "";

    protected override void OnInitialized()
    {
        if  (string.IsNullOrEmpty(id) || id == "0")
        {
            TieuDe = "Thêm người dùng";
            //nguoidung = _nguoiDungSvc.GetNguoiDung(int.Parse(id));
            nguoidung = new Nguoidung()
                    {
                         NguoiDungId = int.Parse(id)
                    };
        }
        else
        {
            TieuDe = "Sửa người dùng";
            nguoidung = _nguoiDungSvc.GetNguoiDung(int.Parse(id));
        }
    }

    private void SubmitForm()
    {
        if  (nguoidung.NguoiDungId == 0)
        {
            if  (NguoiDungExists(nguoidung.UserName))
            
            {
                toastService.ShowError($"Đã tồn tại {nguoidung.UserName}");
                return;
            
            }
            
            var idtemp = _nguoiDungSvc.AddNguoiDung(nguoidung);
            if  (idtemp <= 0)
            {
                toastService.ShowError($"Lỗi");
                return;
            }

            toastService.ShowSuccess($"Thêm thành công người dùng {nguoidung.UserName}");
        }
        else
        {
            _nguoiDungSvc.EditNguoiDung(nguoidung.NguoiDungId, nguoidung);
            toastService.ShowInfo($"Sửa thành công người dùng {nguoidung.UserName}");
        }
        navigation.NavigateTo("/nguoi-dung-list");
    }

    private void Cancel()
    {
        navigation.NavigateTo("/nguoi-dung-list", true);
    }
    private bool NguoiDungExists(string username)
    {
        return _context.NguoiDungs.Any(e => e.UserName == username);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INguoidungSvc _nguoiDungSvc { get; set; }
    }
}
namespace __Blazor.eShopControl.Pages.NguoiDung.NguoiDungDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
