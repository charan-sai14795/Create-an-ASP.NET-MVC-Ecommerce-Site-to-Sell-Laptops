#pragma checksum "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a7ff5475dc9b2a4d7e5e9d2967695909d3dd24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductManagement), @"mvc.1.0.view", @"/Views/Home/ProductManagement.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\_ViewImports.cshtml"
using WebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\_ViewImports.cshtml"
using WebProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a7ff5475dc9b2a4d7e5e9d2967695909d3dd24", @"/Views/Home/ProductManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8530eb335d7f469aa330a5cd7c5d5d30c16b6bf1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
  
    ViewData["Title"] = "ProductManagement";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ProductManagement</h1>\r\n\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <h5>Hello Admin User .. You can manage product by the following function:</h5>\r\n\r\n    </div>\r\n</div>\r\n\r\n<p>");
#nullable restore
#line 19 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
Write(Html.ActionLink("Add Product", "AddProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<table class=""table"">
    <tr>
        <th>
            ID
        </th>
        <th>
            Name
        </th>
        <th>
            Price
        </th>
        <th>
            Quantity
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 38 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
     foreach (var item in Model.Iproduct)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 55 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\chara\source\repos\simplileran-projects-for-wipro\Views\Home\ProductManagement.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
