#pragma checksum "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b868d70399bf95eb6ac4c3caf445afbbb834941f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\_ViewImports.cshtml"
using FoodProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\_ViewImports.cshtml"
using FoodProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b868d70399bf95eb6ac4c3caf445afbbb834941f", @"/Views/Category/CategoryGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodProject.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.HiddenFor(x=> x.CategoryID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.Label("Kategori Ad??"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x=> x.CategoryName,"",new {@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /> \r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.Label("Durumu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.DropDownListFor(x=> x.Status,(List<SelectListItem>)ViewBag.dgr, new {@class="form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br /> \r\n");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.Label("Kategori A????klamas??"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"
Write(Html.TextAreaFor(x=> x.CategoryDescription,new{@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("   <button class=\"btn btn-success\"> G??ncelle </button>\r\n");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Category\CategoryGet.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodProject.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
