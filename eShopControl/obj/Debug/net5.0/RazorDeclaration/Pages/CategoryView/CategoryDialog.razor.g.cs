// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
