#pragma checksum "D:\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Checkout\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "259cd397270d8e749560dd8f8fcaf8adc081a032c63edc077233820641c0f430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
#line 1 "D:\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"259cd397270d8e749560dd8f8fcaf8adc081a032c63edc077233820641c0f430", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Thanh toán";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thanh toán</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6 d-flex flex-column\">\r\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 161, "\"", 169, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Họ tên\" class=\"mt-3\"/>\r\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 234, "\"", 242, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Số điện thoại\" class=\"mt-3\" />\r\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 315, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Email\" class=\"mt-3\" />\r\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 388, "\"", 396, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Địa chỉ"" class=""mt-3"" />
        <div class=""d-flex justify-content-end mt-3"">
            <a class=""btn btn-secondary text-white px-3"">Đặt hàng &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class=""bi bi-arrow-right""></i></a>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""border border-dark container m-3"">
            <div class=""d-flex justify-content-end""><b class=""text-primary"">(2)</b></div>
            <h2>Sản phẩm</h2>
            <div class=""row"">
                <div class=""col-sm-4"">
                    <img src=""Image_QMinh/aocaulong.png"" alt=""Alternate Text"" class=""mw-100""/>
                </div>
                <div class=""col-sm-8 flex-column"">
                    <p class=""font-weight-bold"">Áo cầu lông 1</p>
                    <p>Xanh/M</p>
                    <div class=""row"">
                        <div class=""col-sm-6 text-primary font-weight-bold"">(1)</div>
                        <div class=""col-sm-6"">200.000</div>
                    </");
            WriteLiteral("div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-sm-4"">
                    <img src=""Image_QMinh/aocaulong.png"" alt=""Alternate Text"" class=""mw-100"" />
                </div>
                <div class=""col-sm-8 flex-column"">
                    <p class=""font-weight-bold"">Áo cầu lông 1</p>
                    <p>Xanh/M</p>
                    <div class=""row"">
                        <div class=""col-sm-6 text-primary font-weight-bold"">(1)</div>
                        <div class=""col-sm-6"">200.000</div>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"
            <hr class=""mt-3""/>
            <div class=""row"">
                <div class=""col-sm-4 font-weight-bold"">Tổng cộng</div>
                <div class=""col-sm-8 font-weight-bold d-flex justify-content-end"">400.000</div>
            </div>
            <div class=""row"">
                <div class=""col-sm-4 font-weight-bold"">Phí vận chuyển</div>
                <div class=""col-sm-8 font-weight-bold d-flex justify-content-end"">30.000</div>
            </div>
            <hr class=""mt-3"" />
            <div class=""row mb-3"">
                <h5 class=""col-sm-4 font-weight-bold"">Tổng tiền</h5>
                <h5 class=""col-sm-8 font-weight-bold d-flex justify-content-end"">430.000</h5>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
