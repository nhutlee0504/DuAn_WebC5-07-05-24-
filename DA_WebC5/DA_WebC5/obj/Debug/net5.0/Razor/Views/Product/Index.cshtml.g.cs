#pragma checksum "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27270a3ad5ce427d6b8d789222f83096ac9277f312682da6de5f3664fdf3b51a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"27270a3ad5ce427d6b8d789222f83096ac9277f312682da6de5f3664fdf3b51a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.NewViewModel.ProductViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilterByCategories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filterByCate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/FilterByPrice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sortOrderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .bg-text {
        background-color: white;
    }

    .col-sm-3 .border {
        transition: box-shadow 0.3s, transform 0.3s;
    }

    .col-sm-3 .container-fluid {
        transition: box-shadow 0.3s, transform 0.3s;
    }

    .col-sm-3:hover .border {
        box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.5);
        transform: translateY(-5px);
    }

    .col-sm-3:hover .container-fluid {
        transform: translateY(-5px);
    }
</style>

<div class=""container"">
    <div class=""row mt-3"">
        <div class=""col-sm-3"">
            <h5>Loại</h5>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27270a3ad5ce427d6b8d789222f83096ac9277f312682da6de5f3664fdf3b51a6284", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                 foreach (var category in Model.SelectMany(m => m.Categories).Distinct())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-check\">\r\n                        <input class=\"form-check-input\" type=\"checkbox\" name=\"selectedCategories\"");
                BeginWriteAttribute("value", " value=\"", 1042, "\"", 1070, 1);
#nullable restore
#line 36 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1050, category.IDCategory, 1050, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1071, "\"", 1096, 1);
#nullable restore
#line 36 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1076, category.IDCategory, 1076, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1155, "\"", 1181, 1);
#nullable restore
#line 37 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1161, category.IDCategory, 1161, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 38 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                       Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n");
#nullable restore
#line 41 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"btn btn-dark mt-2\">Lọc</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <hr class=\"mt-3 mb-3\" />\r\n            <h5>Phạm vi giá</h5>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27270a3ad5ce427d6b8d789222f83096ac9277f312682da6de5f3664fdf3b51a10481", async() => {
                WriteLiteral("\r\n                <div class=\"row container\">\r\n                    <div class=\"col-sm-6\"><input type=\"number\" placeholder=\"Thấp\" class=\"w-100\" name=\"priceLow\" id=\"priceLow\"");
                BeginWriteAttribute("value", " value=\"", 1719, "\"", 1744, 1);
#nullable restore
#line 49 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1727, ViewBag.PriceLow, 1727, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                    <div class=\"col-sm-6\"><input type=\"number\" placeholder=\"Cao\" class=\"w-100\" name=\"priceHigh\" id=\"priceHigh\"");
                BeginWriteAttribute("value", " value=\"", 1882, "\"", 1908, 1);
#nullable restore
#line 50 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1890, ViewBag.PriceHigh, 1890, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                </div>\r\n                <div class=\"row container mt-2\">\r\n                    <button type=\"submit\" class=\"btn btn-dark\">Lọc</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <hr class=\"mt-3 mb-3\" />\r\n\r\n            <h5>Thứ tự sắp xếp</h5>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27270a3ad5ce427d6b8d789222f83096ac9277f312682da6de5f3664fdf3b51a13459", async() => {
                WriteLiteral(@"
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""sortOrder"" id=""priceLowToHigh"" value=""priceLowToHigh"">
                    <label class=""form-check-label"" for=""priceLowToHigh"">
                        Giá từ thấp - cao
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""sortOrder"" id=""priceHighToLow"" value=""priceHighToLow"">
                    <label class=""form-check-label"" for=""priceHighToLow"">
                        Giá từ cao - thấp
                    </label>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-9\">\r\n");
#nullable restore
#line 76 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
             if (ViewBag.NotProducts != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"font-weight-bold\">");
#nullable restore
#line 78 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                        Write(ViewBag.NotProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 79 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n");
#nullable restore
#line 81 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-3 d-flex justify-content-center flex-column\">\r\n                        <div class=\"border border-secondary-subtle rounded\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3461, "\"", 3504, 2);
            WriteAttributeValue("", 3468, "/ProductDetail/Index/", 3468, 21, true);
#nullable restore
#line 85 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 3489, item.IDProduct, 3489, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <div><img");
            BeginWriteAttribute("src", " src=\"", 3516, "\"", 3548, 2);
            WriteAttributeValue("", 3522, "/Image_Product/", 3522, 15, true);
#nullable restore
#line 85 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 3537, item.Image, 3537, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" class=\"mw-100\" /></div></a>\r\n                        </div>\r\n                        <div class=\"row container-fluid\">\r\n                            <p class=\"font-weight-bold col-sm-8 mb-1\">");
#nullable restore
#line 88 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-bold col-sm-4 mb-1\">");
#nullable restore
#line 89 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                 Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"font-size: small;\" class=\"col-sm-8\">");
#nullable restore
#line 90 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                     Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <strike style=\"font-size: small;\" class=\"col-sm-4\">400.000</strike>\r\n                        </div>\r\n                        <p><i class=\"bi bi-star-fill text-warning\"></i> 4.9 (100)</p>\r\n                    </div>\r\n");
#nullable restore
#line 95 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    document.querySelectorAll('input[name=""sortOrder""]').forEach(radio => {
        radio.addEventListener('change', function () {
            document.getElementById('sortOrderForm').submit();
        });
    });
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.NewViewModel.ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
