#pragma checksum "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
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
#line 1 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.NewViewModel.ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    .radio-btn-image {
        display: none;
    }

        .radio-btn-image + label {
            display: inline-block;
            cursor: pointer;
        }

            .radio-btn-image + label img {
                border-radius: 25px;
            }



        .radio-btn-image:checked + label img {
            font-weight: bold;
        }

        .radio-btn-image:not(:checked) + label img {
            opacity: 0.5;
        }


    .radio-btn-size {
        display: none;
    }
        .radio-btn-size + label {
            display: inline-block;
            /* 	padding: 10px 20px; */
            text-align: center;
            align-items: center;
            align-content: center;
            width: 50px;
            height: 50px;
            margin-right: 10px;
            border-radius: 20px; /* Loại bỏ border radius */
            cursor: pointer;
        }

        .radio-btn-size:checked + label {
            /*   background-color: #0EA5E9; /* Mà");
            WriteLiteral(@"u nền khi chọn */
            color: black; /* Màu chữ khi chọn */
            border: 1px solid #0EA5E9;
        }

        .radio-btn-size:not(:checked) + label {
            opacity: 0.5;
            font-weight: normal;
        }

    .quantity-selector {
        display: flex;
        float: left;
        justify-content: center;
        text-align: center;
        background-color: gray;
        border-radius: 25px;
        padding: 5px;
    }

        .quantity-selector button {
            border: 1px solid #000;
            background: white;
            width: 30px;
            height: 30px;
            border-radius: 50%;
            font-weight: bold;
            font-size: 20px;
        }

    .quantity-input {
        border: none;
        background: transparent;
        text-align: center;
        padding: 5px 10px;
        font-size: 15px;
        font-weight: bold;
        width: 30px;
    }

    .add-cart {
        display: flex;
        float: righ");
            WriteLiteral(@"t;
        background-color: black;
        color: white;
        text-align: center;
        align-items: center;
        justify-content: center;
        font-size: 15px;
        border-radius: 25px;
        padding: 10px 15px;
    }

 /*    .radio-color {
        display: none;
    } */

    /* .color-box {
                width: 30px;
                height: 30px;
                border-radius: 50%;
                display: inline-block;
                margin-right: 5px;
            } */

    /*   input[type=""radio""]:checked + label.color-box {
                border-color: black;
            } */

/*     input[type=""radio""]:not(:checked) + label.color-box {
        opacity: 0.5;
    } */

    .col-sm-3 .border {
        transition: box-shadow 0.3s, transform 0.3s;
    }

    .col-sm-3 .container-fluid {
        transition: box-shadow 0.3s, transform 0.3s;
    }

    .col-sm-3:hover .border {
        box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.5);
        transform: ");
            WriteLiteral("translateY(-5px);\r\n    }\r\n\r\n    .col-sm-3:hover .container-fluid {\r\n        transform: translateY(-5px);\r\n    }\r\n</style>\r\n");
#nullable restore
#line 133 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
  
    ViewData["Title"] = "Chi tiết sản phẩm";

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
  
    int selectedIdPDetail = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">

    <div class=""row"">
        <div class=""col-md-7"">
            <div class=""row "">
                <div class=""d-flex"">
                    <div class=""col-md-9"">
                        <div class=""justify-content-center"" style=""margin-right: 15px;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b10331", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3687, "~/", 3687, 2, true);
#nullable restore
#line 148 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
AddHtmlAttributeValue("", 3689, Model.Images, 3689, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n");
#nullable restore
#line 152 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                         if (Model.Images != null)
                        {
                            foreach (var img in Model.Images)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 4141, "\"", 4158, 1);
#nullable restore
#line 157 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4146, img.IDImage, 4146, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"options\"");
            BeginWriteAttribute("value", " value=\"", 4174, "\"", 4192, 1);
#nullable restore
#line 157 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4182, img.Image, 4182, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"radio-btn-image\">\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 4262, "\"", 4280, 1);
#nullable restore
#line 158 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4268, img.IDImage, 4268, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b13912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4292, "~/", 4292, 2, true);
#nullable restore
#line 158 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
AddHtmlAttributeValue("", 4294, img.Image, 4294, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4311, "Option", 4311, 6, true);
#nullable restore
#line 158 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
AddHtmlAttributeValue(" ", 4317, img.IDImage, 4318, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</label>\r\n                                </div>\r\n");
#nullable restore
#line 160 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <hr>\r\n            <h3>THÔNG TIN SẢN PHẨM</h3>\r\n            <p>");
#nullable restore
#line 167 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
          Write(Model.Product.Describe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
        <div class=""col-md-5"">
            <div class=""card"" style=""background-color:#D9D9D9"">
                <div class=""card-body"">
                    <div class=""container"">
                        <div class=""row d-flex justify-content-between"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 4933, "\"", 4941, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div style=""font-size:large"">
                                    <i class=""bi bi-star-fill text-warning""></i> <strong>4.9</strong><i class=""bi bi-dot""></i><u>149 Views</u>
                                </div>
                            </div>
                            <div class=""text-center"">
                                <div");
            BeginWriteAttribute("class", " class=\"", 5319, "\"", 5327, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"font-weight-bold\" style=\"font-size:x-large\">");
#nullable restore
#line 181 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                                                                       Write(Model.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</div>\r\n");
            WriteLiteral(@"                                </div>
                            </div>
                        </div>

                        <div>
                            <div class=""font-weight-bold"" style=""font-size:large"">Màu và kích cỡ:</div>
                        </div>

");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b18516", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 194 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                 foreach (var detail in Model.ProductDetails)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-sm-2\">\r\n                                        <input class=\"radio-btn-size\" type=\"radio\" name=\"IdPDetail\"");
                BeginWriteAttribute("id", " id=\"", 6301, "\"", 6327, 3);
#nullable restore
#line 197 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6306, detail.IDPDetail, 6306, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 6323, "+", 6324, 2, true);
                WriteAttributeValue(" ", 6325, "1", 6326, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6328, "\"", 6353, 1);
#nullable restore
#line 197 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6336, detail.IDPDetail, 6336, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\'", 6354, "\'", 6421, 1);
#nullable restore
#line 197 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6364, detail.IDPDetail == selectedIdPDetail ? "checked" : "", 6364, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label class=\"font-weight-bold radio-btn-size\"");
                BeginWriteAttribute("for", " for=\"", 6511, "\"", 6538, 3);
#nullable restore
#line 198 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6517, detail.IDPDetail, 6517, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 6534, "+", 6535, 2, true);
                WriteAttributeValue(" ", 6536, "1", 6537, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 6539, "\"", 6634, 2);
                WriteAttributeValue("", 6547, "background-color:", 6547, 17, true);
#nullable restore
#line 198 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue(" ", 6564, Model.Colors.FirstOrDefault(x => x.IDColor == detail.IDColor)?.Color, 6565, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\'", 6635, "\'", 6702, 1);
#nullable restore
#line 198 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6645, detail.IDPDetail == selectedIdPDetail ? "checked" : "", 6645, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            ");
#nullable restore
#line 199 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                       Write(Model.Sizes.FirstOrDefault(s => s.IDSize == detail.Size)?.SizeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n");
#nullable restore
#line 202 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12 d-flex justify-content-between"">
                                    <div class=""quantity-selector"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3e07efee993c40f95d11139bd7a4c2a1ebad23c9c4a0898ec9ba451cb1adb6b23042", async() => {
                    WriteLiteral(@"
                                            <button type=""button"" class=""decrease-btn"">-</button>
                                            <input type=""text"" name=""quantity"" value=""1"" class=""quantity-input"" readonly>
                                            <button type=""button"" class=""increase-btn"">+</button>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                    <div>
                                        <button type=""submit"" class=""btn add-cart"">
                                            <i class=""bi bi-bag-plus""></i>
                                            <div>Thêm vào giỏ hàng</div>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                      
                    </div>
                </div>
            </div>
        </div>
    </div>
    <h3>Gợi ý sản phẩm</h3>
        <div class=""row overflow-auto"">
            <div class=""col-sm-3 d-flex justify-content-center flex-column"">
                <div class=""border border-secondary-subtle rounded"">
                    <div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                </div>
                <div class=""row container-fluid justify-content-center text-center"">
                    <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                    <p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
                    <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                    <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                </div>
                <p class=""text-center container-fluid"">
                    <i class=""bi bi-star-fill t");
            WriteLiteral(@"ext-warning""></i> 4.9 (100)
                </p>
            </div>
        <div class=""col-sm-3 d-flex justify-content-center flex-column"">
            <div class=""border border-secondary-subtle rounded"">
                <div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
            </div>
            <div class=""row container-fluid justify-content-center text-center"">
                <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                <p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
                <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
            </div>
            <p class=""text-center container-fluid"">
                <i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
            </p>
        </div>
        <div class=""col-sm-3 d-flex justify-content-center flex-column"">
            <div class=""border borde");
            WriteLiteral(@"r-secondary-subtle rounded"">
                <div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
            </div>
            <div class=""row container-fluid justify-content-center text-center"">
                <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                <p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
                <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
            </div>
            <p class=""text-center container-fluid"">
                <i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
            </p>
        </div>
        <div class=""col-sm-3 d-flex justify-content-center flex-column"">
            <div class=""border border-secondary-subtle rounded"">
                <div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
            </div>
            <div class=""row c");
            WriteLiteral(@"ontainer-fluid justify-content-center text-center"">
                <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                <p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
                <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
            </div>
            <p class=""text-center container-fluid"">
                <i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
            </p>
        </div>
        </div>
</div>

<script>
    document.addEventListener('DOMContentLoaded', function () {
        var quantityInput = document.querySelector("".quantity-input"");
        var decreaseBtn = document.querySelector("".decrease-btn"");
        var increaseBtn = document.querySelector("".increase-btn"");

        decreaseBtn.addEventListener('click', function () {
            var currentValue = parseInt(quantityInput.value);
            if (currentValue > 1) {
");
            WriteLiteral(@"                quantityInput.value = currentValue - 1;
            }
        });

        increaseBtn.addEventListener('click', function () {
            var currentValue = parseInt(quantityInput.value);
            quantityInput.value = currentValue + 1;
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DA_WebC5.Models.NewViewModel.ProductDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
