#pragma checksum "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc988cbd972d727f2ecf77025ee46e4be9c7c7236116ef179657ec88eb05576f"
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
#line 1 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fc988cbd972d727f2ecf77025ee46e4be9c7c7236116ef179657ec88eb05576f", @"/Views/Bills/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bills_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.BillViewModel>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>
");
#nullable restore
#line 4 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
  
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
#line 81 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
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
#line 85 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
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
#line 92 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue("", 3168, Model.User.Name.Split(' ').First(), 3168, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label>Tên</label>\r\n                                <input class=\"rounded-input\" type=\"text\" placeholder=\"Tên\"");
            BeginWriteAttribute("value", " value=\"", 3453, "\"", 3495, 1);
#nullable restore
#line 96 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
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
#line 106 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
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
                <div class=""card-header"">SẢN PHẨM THANH TOÁN</div>
                <div class=""card-body"">
");
#nullable restore
#line 118 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {
                        var itemTotalPrice = item.Quantity * item.ProductDetails.Product.Price;
                        totalPrice += itemTotalPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc988cbd972d727f2ecf77025ee46e4be9c7c7236116ef179657ec88eb05576f10770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4833, "~/", 4833, 2, true);
#nullable restore
#line 123 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
AddHtmlAttributeValue("", 4835, item.ProductDetails.Product.Image, 4835, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 123 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
AddHtmlAttributeValue("", 4876, item.ProductDetails.Product.Name, 4876, 33, false);

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
#line 125 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                         Write(item.ProductDetails.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <span class=\"badge text-bg-dark\"");
            BeginWriteAttribute("title", " title=\"", 5141, "\"", 5208, 3);
            WriteAttributeValue("", 5149, "Giá:", 5149, 4, true);
#nullable restore
#line 126 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5153, item.ProductDetails.Product.Price.ToString("N0"), 5154, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5203, "đồng", 5204, 5, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 126 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                                 Write(item.ProductDetails.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</span>\r\n                                <span class=\"badge text-bg-dark\"");
            BeginWriteAttribute("title", " title=\"", 5338, "\"", 5394, 2);
            WriteAttributeValue("", 5346, "Loại:", 5346, 5, true);
#nullable restore
#line 127 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5351, item.ProductDetails.Product.Category.Name, 5352, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 127 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                      Write(item.ProductDetails.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
            BeginWriteAttribute("title", " title=\"", 5512, "\"", 5544, 3);
            WriteAttributeValue("", 5520, "Số", 5520, 2, true);
            WriteAttributeValue(" ", 5522, "lượng:", 5523, 7, true);
#nullable restore
#line 128 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5529, item.Quantity, 5530, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 128 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
            BeginWriteAttribute("title", " title=\"", 5634, "\"", 5689, 3);
            WriteAttributeValue("", 5642, "Kích", 5642, 4, true);
            WriteAttributeValue(" ", 5646, "thước:", 5647, 7, true);
#nullable restore
#line 129 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5653, item.ProductDetails.Sizes.SizeName, 5654, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 129 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                     Write(item.ProductDetails.Sizes.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge text-bg-dark\"");
            BeginWriteAttribute("title", " title=\"", 5800, "\"", 5850, 3);
            WriteAttributeValue("", 5808, "Màu", 5808, 3, true);
            WriteAttributeValue(" ", 5811, "sắc:", 5812, 5, true);
#nullable restore
#line 130 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
WriteAttributeValue(" ", 5816, item.ProductDetails.Colors.Color, 5817, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 130 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                                Write(item.ProductDetails.Colors.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div>\r\n\r\n                            <div class=\"product-summary\">\r\n                                <div><strong>Tổng cộng:</strong> <span class=\"badge rounded-pill text-bg-danger\">");
#nullable restore
#line 135 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                                                                            Write(itemTotalPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</span></div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 138 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"total-price\">\r\n                        <div><strong>Tổng giá:</strong> ");
#nullable restore
#line 140 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Bills\Index.cshtml"
                                                   Write(totalPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đồng</div>
                    </div>
               
                  
                </div>
                <button type=""submit"" class=""btn btn-dark btn-rounded btn-block"">Thanh toán</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DA_WebC5.Models.BillViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
