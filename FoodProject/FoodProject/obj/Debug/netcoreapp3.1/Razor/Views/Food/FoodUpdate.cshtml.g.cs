#pragma checksum "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08efa081830371604e38c0b48a38e3a49855ba69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodUpdate), @"mvc.1.0.view", @"/Views/Food/FoodUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08efa081830371604e38c0b48a38e3a49855ba69", @"/Views/Food/FoodUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_FoodUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodProject.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
  
    ViewData["Title"] = "FoodUpdate";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
 using (Html.BeginForm("FoodUpdate", "Food", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.HiddenFor(x => x.FoodID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Yiyecek Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.TextBoxFor(x => x.FoodName, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Fiyat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.TextBoxFor(x => x.Price, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Stok"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.TextBoxFor(x => x.Stock, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Resim URL"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.dgr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"
Write(Html.TextAreaFor(x=> x.Description,new {@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-success btn-sm\">Kaydet </button>\r\n");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Food\FoodUpdate.cshtml"



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodProject.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591