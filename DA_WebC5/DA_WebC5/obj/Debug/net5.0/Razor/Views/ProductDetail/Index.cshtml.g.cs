#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49ad2a30ea1c637bfd129cfc3b08aff7ab9a2cfbf1034d9457573e7f64b33492"
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
#line 1 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"49ad2a30ea1c637bfd129cfc3b08aff7ab9a2cfbf1034d9457573e7f64b33492", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.NewViewModel.ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 133 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
  
    ViewData["Title"] = "Chi tiết sản phẩm";

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
  
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
                            <img id=""main-image""");
            BeginWriteAttribute("src", " src=\"", 3681, "\"", 3722, 2);
            WriteAttributeValue("", 3687, "/Image_Product/", 3687, 15, true);
#nullable restore
#line 148 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 3702, Model.Product.Image, 3702, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" class=\"w-100\" style=\"border-radius: 25px;\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n");
#nullable restore
#line 152 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                         if (Model.Images != null)
                        {
                            foreach (var img in Model.Images)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 4161, "\"", 4178, 1);
#nullable restore
#line 157 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4166, img.IDImage, 4166, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"options\"");
            BeginWriteAttribute("value", " value=\"", 4194, "\"", 4212, 1);
#nullable restore
#line 157 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4202, img.Image, 4202, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"radio-btn-image\">\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 4282, "\"", 4300, 1);
#nullable restore
#line 158 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4288, img.IDImage, 4288, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4306, "\"", 4337, 2);
            WriteAttributeValue("", 4312, "/Image_Product/", 4312, 15, true);
#nullable restore
#line 158 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4327, img.Image, 4327, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4338, "\"", 4363, 2);
            WriteAttributeValue("", 4344, "Option", 4344, 6, true);
#nullable restore
#line 158 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue(" ", 4350, img.IDImage, 4351, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-75\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 160 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <hr>\r\n            <h3>THÔNG TIN SẢN PHẨM</h3>\r\n            <p>");
#nullable restore
#line 167 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 4966, "\"", 4974, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div style=""font-size:large"">
                                    <i class=""bi bi-star-fill text-warning""></i> <strong>4.9</strong><i class=""bi bi-dot""></i><u>149 Views</u>
                                </div>
                            </div>
                            <div class=""text-center"">
                                <div");
            BeginWriteAttribute("class", " class=\"", 5352, "\"", 5360, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"font-weight-bold\" style=\"font-size:x-large\">");
#nullable restore
#line 181 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ad2a30ea1c637bfd129cfc3b08aff7ab9a2cfbf1034d9457573e7f64b3349214731", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 194 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                 foreach (var detail in Model.ProductDetails)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-sm-2\">\r\n                                        <input class=\"radio-btn-size\" type=\"radio\" name=\"IdPDetail\"");
                BeginWriteAttribute("id", " id=\"", 6334, "\"", 6360, 3);
#nullable restore
#line 197 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6339, detail.IDPDetail, 6339, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 6356, "+", 6357, 2, true);
                WriteAttributeValue(" ", 6358, "1", 6359, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6361, "\"", 6386, 1);
#nullable restore
#line 197 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6369, detail.IDPDetail, 6369, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\'", 6387, "\'", 6454, 1);
#nullable restore
#line 197 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6397, detail.IDPDetail == selectedIdPDetail ? "checked" : "", 6397, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label class=\"font-weight-bold radio-btn-size\"");
                BeginWriteAttribute("for", " for=\"", 6544, "\"", 6571, 3);
#nullable restore
#line 198 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6550, detail.IDPDetail, 6550, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 6567, "+", 6568, 2, true);
                WriteAttributeValue(" ", 6569, "1", 6570, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 6572, "\"", 6667, 2);
                WriteAttributeValue("", 6580, "background-color:", 6580, 17, true);
#nullable restore
#line 198 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue(" ", 6597, Model.Colors.FirstOrDefault(x => x.IDColor == detail.IDColor)?.Color, 6598, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\'", 6668, "\'", 6735, 1);
#nullable restore
#line 198 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 6678, detail.IDPDetail == selectedIdPDetail ? "checked" : "", 6678, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            ");
#nullable restore
#line 199 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                       Write(Model.Sizes.FirstOrDefault(s => s.IDSize == detail.Size)?.SizeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n");
#nullable restore
#line 202 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div class=""row"">
                                <div class=""col-sm-12 d-flex justify-content-between"">
                                    <div class=""quantity-selector"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ad2a30ea1c637bfd129cfc3b08aff7ab9a2cfbf1034d9457573e7f64b3349219446", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      \r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 8277, "\"", 8285, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <hr></hr>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ad2a30ea1c637bfd129cfc3b08aff7ab9a2cfbf1034d9457573e7f64b3349223553", async() => {
                WriteLiteral("\r\n                    <textarea rows=\"5\" class=\"w-100\">\r\n\r\n                    </textarea>\r\n                    <button class=\"btn btn-secondary\">Gửi đánh giá</button>\r\n                ");
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
            WriteLiteral("\r\n\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n");
#nullable restore
#line 237 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                         foreach (var evaluate in Model.Evaluates.Where(x=> x.IDProduct == Model.Product.IDProduct))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"evaluate-item\">\r\n                                <div class=\"user\">");
#nullable restore
#line 240 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                             Write(evaluate.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"point\">Điểm: ");
#nullable restore
#line 241 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                                    Write(evaluate.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"describe\">Mô tả: ");
#nullable restore
#line 242 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                                                        Write(evaluate.Describe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n");
#nullable restore
#line 244 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
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
                    <i class=""bi bi-star-fill text-warning""></i> 4.9 (100");
            WriteLiteral(@")
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
            <div class=""border border-secondary-subtle rounded");
            WriteLiteral(@""">
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
            <div class=""row container-fluid justify-con");
            WriteLiteral(@"tent-center text-center"">
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
                quantityIn");
            WriteLiteral(@"put.value = currentValue - 1;
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
