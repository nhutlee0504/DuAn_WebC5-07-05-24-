#pragma checksum "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ff1ee0913b9241fb63e92ba0a074c8db979afc3f80fe38d4030e8e9f0361515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_IndexPost), @"mvc.1.0.view", @"/Views/Bills/IndexPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ff1ee0913b9241fb63e92ba0a074c8db979afc3f80fe38d4030e8e9f0361515", @"/Views/Bills/IndexPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bills_IndexPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.BillViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>

");
#nullable restore
#line 5 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
  
    ViewData["Title"] = "Thanh toán";

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

    .card-header {
        background-color: #f8f9fa; /* Đổi màu nền header của card */
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

<ol class=""breadcrumb");
            WriteLiteral(@" bg-transparent"">
    <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
    <li class=""breadcrumb-item active"">Giỏ hàng</li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Thanh toán</li>
</ol>

<div class=""container mt-5"">
    <h3 class=""mb-4"">Thanh toán</h3>
    <div class=""row"">
        <div class=""col-md-5 mb-3"">
            <div class=""card"">
                <div class=""card-header"">
                    THÔNG TIN CỦA BẠN
                </div>
                <div class=""card-body"">
                    <div class=""form-section"">
                        <div class=""form-section-header"">THÔNG TIN LIÊN HỆ</div>
                        <div class=""row"">
                            <div class=""col-md-6 mb-3"">
                                <label>Số điện thoại của bạn</label>
                                <input class=""rounded-input"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 2433, "\"", 2459, 1);
#nullable restore
#line 78 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue("", 2441, Model.User?.Phone, 2441, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label>Địa chỉ email</label>\r\n                                <input class=\"rounded-input\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2701, "\"", 2727, 1);
#nullable restore
#line 82 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue("", 2709, Model.User?.Email, 2709, 18, false);

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
                                <input class=""rounded-input"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 3033, "\"", 3072, 1);
#nullable restore
#line 88 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue("", 3041, Model.User?.Name.Split(' ')[0], 3041, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label>Tên</label>\r\n                                <input class=\"rounded-input\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3304, "\"", 3343, 1);
#nullable restore
#line 92 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue("", 3312, Model.User?.Name.Split(' ')[1], 3312, 31, false);

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
                            <div class=""col-md-12 mb-3"">
                                <input class=""rounded-input"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 3757, "\"", 3784, 1);
#nullable restore
#line 100 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue("", 3765, Model.User.Address, 3765, 19, false);

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
            <button type=""submit"" class=""btn btn-danger btn-block mt-3"">Cập nhật thông tin</button>
        </div>
        <div class=""col-md-7"">
            <div class=""card"">
                <div class=""card-header"">
                    SẢN PHẨM THANH TOÁN
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 114 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                     foreach (var item in Model.CartItems)
                    {
                        var itemTotalPrice = item.Quantity * item.ProductDetails.Product.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ff1ee0913b9241fb63e92ba0a074c8db979afc3f80fe38d4030e8e9f036151511968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4539, "~/", 4539, 2, true);
#nullable restore
#line 118 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
AddHtmlAttributeValue("", 4541, item.ProductDetails.Product.Image, 4541, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 118 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
AddHtmlAttributeValue("", 4582, item.ProductDetails.Product.Name, 4582, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"product-details\">\r\n                                <div class=\"font-weight-bold\">");
#nullable restore
#line 120 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                         Write(item.ProductDetails.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <span class=\"badge bg-dark text-white\"");
            BeginWriteAttribute("title", " title=\"", 4853, "\"", 4920, 3);
            WriteAttributeValue("", 4861, "Giá:", 4861, 4, true);
#nullable restore
#line 121 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue(" ", 4865, item.ProductDetails.Product.Price.ToString("N0"), 4866, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4915, "đồng", 4916, 5, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 121 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                                                       Write(item.ProductDetails.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</span>\r\n                                <span class=\"badge bg-dark text-white\"");
            BeginWriteAttribute("title", " title=\"", 5056, "\"", 5112, 2);
            WriteAttributeValue("", 5064, "Loại:", 5064, 5, true);
#nullable restore
#line 122 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue(" ", 5069, item.ProductDetails.Product.Category.Name, 5070, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 122 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                                            Write(item.ProductDetails.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge bg-dark text-white\"");
            BeginWriteAttribute("title", " title=\"", 5236, "\"", 5268, 3);
            WriteAttributeValue("", 5244, "Số", 5244, 2, true);
            WriteAttributeValue(" ", 5246, "lượng:", 5247, 7, true);
#nullable restore
#line 123 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue(" ", 5253, item.Quantity, 5254, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 123 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                    Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge bg-dark text-white\"");
            BeginWriteAttribute("title", " title=\"", 5364, "\"", 5419, 3);
            WriteAttributeValue("", 5372, "Kích", 5372, 4, true);
            WriteAttributeValue(" ", 5376, "thước:", 5377, 7, true);
#nullable restore
#line 124 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue(" ", 5383, item.ProductDetails.Sizes.SizeName, 5384, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 124 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                                           Write(item.ProductDetails.Sizes.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge bg-dark text-white\"");
            BeginWriteAttribute("title", " title=\"", 5536, "\"", 5586, 3);
            WriteAttributeValue("", 5544, "Màu", 5544, 3, true);
            WriteAttributeValue(" ", 5547, "sắc:", 5548, 5, true);
#nullable restore
#line 125 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
WriteAttributeValue(" ", 5552, item.ProductDetails.Colors.Color, 5553, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 125 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                                      Write(item.ProductDetails.Colors.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"product-summary\">\r\n                                <div><strong>Tổng cộng:</strong> <span class=\"badge rounded-pill bg-danger text-white\">");
#nullable restore
#line 128 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                                                                                                  Write(itemTotalPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</span></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 131 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff1ee0913b9241fb63e92ba0a074c8db979afc3f80fe38d4030e8e9f036151520318", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-dark btn-block mt-3\">Thanh toán</button>\r\n                ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card mt-4\">\r\n                <div class=\"card-header\">\r\n                    NHẬP MÃ KHUYẾN MÃI\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff1ee0913b9241fb63e92ba0a074c8db979afc3f80fe38d4030e8e9f036151522542", async() => {
                WriteLiteral(@"
                        <div class=""form-group mb-3"">
                            <input type=""text"" class=""form-control"" name=""saleName"" placeholder=""Nhập mã khuyến mãi (nếu có)"">
                        </div>
                        <button type=""submit"" class=""btn btn-primary"">Áp dụng mã</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 149 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                     if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger mt-3\">\r\n                            ");
#nullable restore
#line 152 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 154 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                     if (ViewBag.SaleData != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success mt-3\">\r\n                            <h4 class=\"alert-heading\">Thông tin khuyến mãi</h4>\r\n                            <p>Mã khuyến mãi: ");
#nullable restore
#line 159 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                         Write(ViewBag.SaleData.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Số lượng: ");
#nullable restore
#line 160 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                    Write(ViewBag.SaleData.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Giá trị tối thiểu: ");
#nullable restore
#line 161 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                             Write(ViewBag.SaleData.MinAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Giá trị tối đa: ");
#nullable restore
#line 162 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                                          Write(ViewBag.SaleData.MaxAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 164 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\IndexPost.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
