#pragma checksum "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4cc662f4812f1761f6f3afe65285399b7ddb12587accb309715a8f0589a913a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Index), @"mvc.1.0.view", @"/Views/Bills/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4cc662f4812f1761f6f3afe65285399b7ddb12587accb309715a8f0589a913a2", @"/Views/Bills/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bills_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.BillViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>
");
#nullable restore
#line 4 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
  
    ViewData["Title"] = "Thanh toán";
    decimal totalPrice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .rounded-input {
        border-radius: 8px;
        border: 1px solid #ccc;
        padding: 10px;
        width: 100%;
        box-sizing: border-box;
        margin-bottom: 10px;
    }

    .product-item {
        display: flex;
        align-items: center;
        margin-bottom: 15px;
        border-bottom: 1px solid #ddd;
        padding-bottom: 10px;
    }

        .product-item img {
            max-width: 100px;
            max-height: 100px;
            margin-right: 15px;
            border-radius: 8px;
        }

    .product-details {
        flex-grow: 1;
    }

    .product-summary {
        flex-shrink: 0;
        text-align: right;
    }
    .card{
        border:none
    }


    .card-header {
        background-color:white;
        font-weight: bold;
    }

    .form-section {
        margin-bottom: 20px;
    }

    .form-section-header {
        font-weight: bold;
        margin-bottom: 10px;
    }
</style>
<ol class=""breadcr");
            WriteLiteral(@"umb bg-transparent"">
    <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
    <li class=""breadcrumb-item active"">Giỏ hàng</li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Thanh toán</li>
</ol>

<div class=""container mt-5"">
    <h3 class=""mb-4"">Thanh toán</h3>
    <div class=""row"">
        <div class=""col-md-5 mb-3"">
            <div class=""card"">
                <div class=""card-header fw-bold"">
                    THÔNG TIN CỦA BẠN
                </div>
                <div class=""card-body"">
                    <div class=""form-section"">
                        <div class=""form-section-header fw-bold"">THÔNG TIN LIÊN HỆ</div>
                        <div class=""row"">
                            <div class=""col-md-6 mb-3"">
                                <label>Số điện thoại của bạn</label>
                                <input class=""rounded-input"" type=""text"" placeholder=""Số điện thoại của bạn""");
            BeginWriteAttribute("value", " value=\"", 2515, "\"", 2540, 1);
#nullable restore
#line 81 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 2523, Model.User.Phone, 2523, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                            </div>
                            <div class=""col-md-6 mb-3"">
                                <label>Địa chỉ email</label>
                                <input class=""rounded-input"" type=""text"" placeholder=""Địa chỉ email""");
            BeginWriteAttribute("value", " value=\"", 2810, "\"", 2835, 1);
#nullable restore
#line 85 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 2818, Model.User.Email, 2818, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-6 mb-3"">
                                <label>Họ</label>
                                <input class=""rounded-input"" type=""text"" placeholder=""Họ""");
            BeginWriteAttribute("value", " value=\"", 3160, "\"", 3203, 1);
#nullable restore
#line 92 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 3168, Model.User.Name.Split(' ').First(), 3168, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label>Tên</label>\r\n                                <input class=\"rounded-input\" type=\"text\" placeholder=\"Tên\"");
            BeginWriteAttribute("value", " value=\"", 3453, "\"", 3495, 1);
#nullable restore
#line 96 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 3461, Model.User.Name.Split(' ').Last(), 3461, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                            </div>
                        </div>
                    </div>
                    <div class=""form-section"">
                        <div class=""form-section-header"">ĐỊA CHỈ GIAO HÀNG</div>
                        <div class=""row"">
                           
                            <div class=""col-md-8 mb-3"">
                                <label>Dòng địa chỉ 1</label>
                                <input class=""rounded-input"" type=""text"" placeholder=""Dòng địa chỉ 1""");
            BeginWriteAttribute("value", " value=\"", 4029, "\"", 4056, 1);
#nullable restore
#line 106 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 4037, Model.User.Address, 4037, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-danger btn-rounded btn-block"">Cập nhật thông tin</button>
        </div>
        <div class=""col-md-7"">
            <div class=""card"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc662f4812f1761f6f3afe65285399b7ddb12587accb309715a8f0589a913a210546", async() => {
                WriteLiteral("\r\n                <div class=\"card-header\">SẢN PHẨM THANH TOÁN</div>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 119 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\" name=\"selectedProducts\"");
                BeginWriteAttribute("value", " value=\"", 4723, "\"", 4746, 1);
#nullable restore
#line 121 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 4731, item.IDPDetail, 4731, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 122 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                        var itemTotalPrice = item.Quantity * item.ProductDetails.Product.Price;
                        totalPrice += itemTotalPrice;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"product-item\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 4990, "\"", 5045, 2);
                WriteAttributeValue("", 4996, "/Image_Product/", 4996, 15, true);
#nullable restore
#line 125 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 5011, item.ProductDetails.Product.Image, 5011, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5046, "\"", 5085, 1);
#nullable restore
#line 125 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 5052, item.ProductDetails.Product.Name, 5052, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <div class=\"product-details\">\r\n                                <div class=\"font-weight-bold\">");
#nullable restore
#line 127 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                         Write(item.ProductDetails.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <span class=\"badge text-bg-dark\"");
                BeginWriteAttribute("title", " title=\"", 5317, "\"", 5384, 3);
                WriteAttributeValue("", 5325, "Giá:", 5325, 4, true);
#nullable restore
#line 128 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5329, item.ProductDetails.Product.Price.ToString("N0"), 5330, 49, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 5379, "đồng", 5380, 5, true);
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 128 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                                 Write(item.ProductDetails.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đồng</span>\r\n                                <span class=\"badge text-bg-dark\"");
                BeginWriteAttribute("title", " title=\"", 5514, "\"", 5570, 2);
                WriteAttributeValue("", 5522, "Loại:", 5522, 5, true);
#nullable restore
#line 129 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5527, item.ProductDetails.Product.Category.Name, 5528, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 129 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                      Write(item.ProductDetails.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
                BeginWriteAttribute("title", " title=\"", 5688, "\"", 5720, 3);
                WriteAttributeValue("", 5696, "Số", 5696, 2, true);
                WriteAttributeValue(" ", 5698, "lượng:", 5699, 7, true);
#nullable restore
#line 130 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5705, item.Quantity, 5706, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 130 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
                BeginWriteAttribute("title", " title=\"", 5810, "\"", 5865, 3);
                WriteAttributeValue("", 5818, "Kích", 5818, 4, true);
                WriteAttributeValue(" ", 5822, "thước:", 5823, 7, true);
#nullable restore
#line 131 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5829, item.ProductDetails.Sizes.SizeName, 5830, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 131 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                     Write(item.ProductDetails.Sizes.SizeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
                BeginWriteAttribute("title", " title=\"", 5976, "\"", 6026, 3);
                WriteAttributeValue("", 5984, "Màu", 5984, 3, true);
                WriteAttributeValue(" ", 5987, "sắc:", 5988, 5, true);
#nullable restore
#line 132 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5992, item.ProductDetails.Colors.Color, 5993, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 132 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                Write(item.ProductDetails.Colors.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n\r\n                            <div class=\"product-summary\">\r\n                                <div><strong>Tổng cộng:</strong> <span class=\"badge rounded-pill text-bg-danger\">");
#nullable restore
#line 136 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                            Write(itemTotalPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đồng</span></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 139 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"total-price\">\r\n                        <div><strong>Tổng giá:</strong> ");
#nullable restore
#line 141 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                   Write(totalPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đồng</div>\r\n                        <input type=\"hidden\" name=\"totalPrice\"");
                BeginWriteAttribute("value", " value=\"", 6626, "\"", 6645, 1);
#nullable restore
#line 142 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 6634, totalPrice, 6634, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n               \r\n                  \r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-dark btn-rounded btn-block\">Thanh toán</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DA_WebC5.Models.BillViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
