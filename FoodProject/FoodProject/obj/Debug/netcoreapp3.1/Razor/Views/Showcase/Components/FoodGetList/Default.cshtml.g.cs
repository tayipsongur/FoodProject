#pragma checksum "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bdc415011e659c741c319718e1ad66eedbf2492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Showcase_Components_FoodGetList_Default), @"mvc.1.0.view", @"/Views/Showcase/Components/FoodGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bdc415011e659c741c319718e1ad66eedbf2492", @"/Views/Showcase/Components/FoodGetList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2971d03854856c1b996622a1f584a550e827fd8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Showcase_Components_FoodGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodProject.Models.Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("checkout.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"agile_top_brands_grids\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3 top_brand_left"" style=""margin-bottom:50px;"">
            <div class=""hover14 column"">
                <div class=""agile_top_brand_left_grid"">
                    
                    <div class=""agile_top_brand_left_grid1"">
                        <figure>
                            <div class=""snipcart-item block"">
                                <div class=""snipcart-thumb"">
                                    <a href=""single.html""><img");
            BeginWriteAttribute("title", " title=\"", 602, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:250px; height:200px;\" alt=\" \"");
            BeginWriteAttribute("src", " src=\"", 654, "\"", 674, 1);
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
WriteAttributeValue("", 660, item.ImageURL, 660, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                    <p style=\"color:#e02d2d\"><b>  ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
                                                             Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                    <h4>");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </h4> <h6>Stok: ");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
                                                                 Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                </div>\r\n                                <div class=\"snipcart-details top_brand_home_details\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bdc415011e659c741c319718e1ad66eedbf24926606", async() => {
                WriteLiteral(@"
                                        <fieldset>
                                            <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                            <input type=""hidden"" name=""add"" value=""1"" />
                                            <input type=""hidden"" name=""business"" value="" "" />
                                            <input type=""hidden"" name=""item_name""");
                BeginWriteAttribute("value", " value=\"", 1482, "\"", 1504, 1);
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
WriteAttributeValue("", 1490, item.FoodName, 1490, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            <input type=\"hidden\" name=\"amount\"");
                BeginWriteAttribute("value", " value=\"", 1588, "\"", 1607, 1);
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"
WriteAttributeValue("", 1596, item.Price, 1596, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                           
                                            <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                            <input type=""hidden"" name=""return"" value="" "" />
                                            <input type=""hidden"" name=""cancel_return"" value="" "" />
                                            <input type=""submit"" name=""#"" value=""Satın Al"" class=""button"" />
                                        </fieldset>

                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </figure>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\FoodProject\FoodProject\Views\Showcase\Components\FoodGetList\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"clearfix\"> </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodProject.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
