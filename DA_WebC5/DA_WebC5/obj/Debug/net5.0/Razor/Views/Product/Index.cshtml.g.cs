#pragma checksum "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "de1d456f772ba9d8f3de53660d82fca3907410dfff2c3b660d92594a58168c1f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"de1d456f772ba9d8f3de53660d82fca3907410dfff2c3b660d92594a58168c1f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.NewViewModel.ProductViewModel>>
    #nullable disable
    {
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
#nullable restore
#line 32 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
             foreach (var category in Model.SelectMany(m => m.Categories).Distinct())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 897, "\"", 925, 1);
#nullable restore
#line 35 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 905, category.IDCategory, 905, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 926, "\"", 951, 1);
#nullable restore
#line 35 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 931, category.IDCategory, 931, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1006, "\"", 1032, 1);
#nullable restore
#line 36 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 1012, category.IDCategory, 1012, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 37 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <hr class=""mt-3 mb-3"" />
            <h5>Phạm vi giá</h5>
            <div class=""row container"">
                <div class=""col-sm-6""><input type=""number"" placeholder=""Thấp"" class=""w-100"" /></div>
                <div class=""col-sm-6""><input type=""number"" placeholder=""Cao"" class=""w-100"" /></div>
            </div>
            <hr class=""mt-3 mb-3"" />
            <h5>Thứ tự sắp xếp</h5>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios1"" value=""option1"">
                <label class=""form-check-label"" for=""exampleRadios1"">
                    Phổ biến nhất
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios2"" value=""option2"">
                <label class=""form-check-label"" for=""exampleRadios2"">
                    Đánh giá cao nhất
                </label>
         ");
            WriteLiteral(@"   </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios3"" value=""option3"">
                <label class=""form-check-label"" for=""exampleRadios3"">
                    Mới nhất
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios4"" value=""option4"">
                <label class=""form-check-label"" for=""exampleRadios4"">
                    Giá từ thấp - cao
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios5"" value=""option5"">
                <label class=""form-check-label"" for=""exampleRadios5"">
                    Giá từ cao - thấp
                </label>
            </div>
        </div>

        <div class=""col-sm-9"">
            <div class=""row"">");
            WriteLiteral("\n");
#nullable restore
#line 83 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-3 d-flex justify-content-center flex-column\">\r\n                        <div class=\"border border-secondary-subtle rounded\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3451, "\"", 3494, 2);
            WriteAttributeValue("", 3458, "/ProductDetail/Index/", 3458, 21, true);
#nullable restore
#line 87 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 3479, item.IDProduct, 3479, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <div><img");
            BeginWriteAttribute("src", " src=\"", 3506, "\"", 3538, 2);
            WriteAttributeValue("", 3512, "/Image_Product/", 3512, 15, true);
#nullable restore
#line 87 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
WriteAttributeValue("", 3527, item.Image, 3527, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" class=\"mw-100\" /></div></a>\r\n                        </div>\r\n                        <div class=\"row container-fluid\">\r\n                            <p class=\"font-weight-bold col-sm-8 mb-1\">");
#nullable restore
#line 90 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-bold col-sm-4 mb-1\">");
#nullable restore
#line 91 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                 Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"font-size: small;\" class=\"col-sm-8\">");
#nullable restore
#line 92 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                                                                     Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <strike style=\"font-size: small;\" class=\"col-sm-4\">400.000</strike>\r\n                        </div>\r\n                        <p><i class=\"bi bi-star-fill text-warning\"></i> 4.9 (100)</p>\r\n                    </div>\r\n");
#nullable restore
#line 97 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
