#pragma checksum "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c407214389cff06fb2605ebadebf316ea0027d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Showcase_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Showcase/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c407214389cff06fb2605ebadebf316ea0027d", @"/Views/Showcase/Components/CategoryGetList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Showcase_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodProject.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\CategoryGetList\Default.cshtml"
         foreach (var item in Model)
        {           

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 221, "\"", 270, 2);
            WriteAttributeValue("", 228, "/Showcase/CategoryDetails/", 228, 26, true);
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 254, item.CategoryID, 254, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\CategoryGetList\Default.cshtml"
                                                            Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\CategoryGetList\Default.cshtml"
       
    
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </ul>\r\n        \r\n      \r\n</div><!-- /.navbar-collapse -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodProject.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
