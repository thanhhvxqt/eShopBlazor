#pragma checksum "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa647f7396e9a875cfb06399b992edfcad46b07"
// <auto-generated/>
#pragma warning disable 1591
namespace eShopControl.Pages.CategoryView
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
#line 2 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
using eShopShare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh-muc-dialog/{id}")]
    public partial class CategoryDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 10 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
     TieuDe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
 if (danhmuc == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
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
#line 20 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                              danhmuc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                                       SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "hidden");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                            danhmuc.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => danhmuc.Id = __value, danhmuc.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"exampleInputEmail1\" class=\"form-label\">Tên danh mục</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                                                 danhmuc.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => danhmuc.Title = __value, danhmuc.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => danhmuc.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __Blazor.eShopControl.Pages.CategoryView.CategoryDialog.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 27 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                              ()=>danhmuc.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label for=\"exampleInputEmail1\" class=\"form-label\">Mô tả danh mục</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                                                 danhmuc.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => danhmuc.Description = __value, danhmuc.Description))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => danhmuc.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __Blazor.eShopControl.Pages.CategoryView.CategoryDialog.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 32 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                              ()=>danhmuc.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "<label for=\"exampleInputEmail1\" class=\"form-label\">Url hiển thị</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                                                 danhmuc.Slug

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => danhmuc.Slug = __value, danhmuc.Slug))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => danhmuc.Slug));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __Blazor.eShopControl.Pages.CategoryView.CategoryDialog.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 37 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                              ()=>danhmuc.Slug

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                    ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "class", "btn btn-primary");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Myproject\CSharp\NET106\ASM\temp\eShopBlazor\eShopControl\Pages\CategoryView\CategoryDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private Category danhmuc { get; set; }

    private string TieuDe = "";

    IReadOnlyList<IBrowserFile> selectedFile;

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(id) || id == "0")
        {
            TieuDe = "Thêm danh mục";
            //nguoidung = _nguoiDungSvc.GetNguoiDung(int.Parse(id));
            danhmuc = new Category()
            {
                Id = int.Parse(id)
            };
        }
        else
        {
            TieuDe = "Sửa danh mục";
            danhmuc = _context.Categories.Find(int.Parse(id));
        }
    }

    private async void SubmitForm()
    {

        if (danhmuc.Id == 0)
        {
            var temp = AddDanhMuc(danhmuc);
            if (temp > 0)
                toastService.ShowSuccess($"Thêm thành {danhmuc.Title}");
            else
                toastService.ShowSuccess($"Thêm thất bại {danhmuc.Title}");
        }
        else
        {
            var temp = SuaDanhMuc(danhmuc.Id, danhmuc);
            if (temp > 0)
                toastService.ShowSuccess($"Đã sửa {danhmuc.Title}");
            else
                toastService.ShowSuccess($"Sửa thất bại {danhmuc.Title}");
        }
        navigation.NavigateTo("/danh-muc-list");



    }

    private void Cancel()
    {
        navigation.NavigateTo("/danh-muc-list", true);
    }

    public int AddDanhMuc(Category category)
    {
        try
        {
            _context.Add(category);
            _context.SaveChanges();
            return 1;
        }
        catch
        {
            return 0;
        }

    }
    public int SuaDanhMuc(int id, Category category)
    {
        try
        {
            _context.Update(category);
            _context.SaveChanges();
            return id;
        }
        catch
        {
            return 0;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonAnSvc _monAnSvc { get; set; }
    }
}
namespace __Blazor.eShopControl.Pages.CategoryView.CategoryDialog
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
    }
}
#pragma warning restore 1591
