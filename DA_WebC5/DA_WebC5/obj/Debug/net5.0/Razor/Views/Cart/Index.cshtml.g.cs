#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#nullable restore
#line 63 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef23", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.Cart>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubtractOne", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOne", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mr-2 mb-2 mb-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mr-2 mb-2 mb-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/css/bootstrap.min.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"">
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>

<style>

    .table td, .table th {
        vertical-align: middle;
        text-align: center;
        white-space: nowrap;
    }

    td.d-flex {
        justify-content: center; /* Canh giữa theo chiều ngang */
    }


    .input-group {
        padding: 0.25rem 0.5rem;
        width: 150px;
        display: flex;
        justify-content: center; /* Căn giữa th");
            WriteLiteral(@"eo chiều ngang */
        align-items: center; /* Căn giữa theo chiều dọc */
    }

    .table .d-flex .p-2 {
        padding-left: 0;
        padding-right: 0;
    }

    .product-info {
        display: flex;
        flex-direction: column;
    }

        .product-info span {
            display: block;
            white-space: nowrap;
        }

        .product-info div {
            padding: 5px;
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
");
#nullable restore
#line 65 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
  
    string username = "";
    var loggedInUser = HttpContextAccessor.HttpContext.Session.GetString("LoggedInUser");
    if (HttpContextAccessor.HttpContext.Session.GetString("LoggedInUser") != null)
    {
        username = HttpContextAccessor.HttpContext.Session.GetString("LoggedInUser");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb bg-transparent\">\r\n    <li class=\"breadcrumb-item\"><a href=\"#\">Trang chủ</a></li>\r\n\r\n    <li class=\"breadcrumb-item active\" aria-current=\"page\">Giỏ hàng</li>\r\n</ol>\r\n\r\n");
#nullable restore
#line 80 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
 if (TempData["error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 83 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
   Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 85 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div  style=""position: relative; overflow: hidden; height:25px;"">
        <i class=""bi bi-receipt"" style=""position: absolute; top: 50%; transform: translateY(-50%);""></i>
        <span style=""color: red; position: absolute; transform: translateY(-50%); animation: slide 2s infinite alternate;"">Nhập mã <strong>giảm giá</strong> để nhận thêm nhiều <strong>ưu đãi</strong> hơn</span>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2312375", async() => {
                WriteLiteral(@"
    <div class=""table-responsive"">
        <table class=""table text-center"">
            <thead>
                <tr>
                    <th></th>
                    <th>Sản phẩm</th>
                    <td></td>
                    <th>Đơn giá</th>
                    <th>Số lượng</th>
                    <th>Số tiền</th>
                    <th>Thao tác</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 106 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                                <input type=\"checkbox\" name=\"selectedProducts\"");
                BeginWriteAttribute("value", " value=\"", 3760, "\"", 3783, 1);
#nullable restore
#line 110 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3768, item.IDPDetail, 3768, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"d-flex align-items-center\">\r\n                                <div class=\"col-12 p-0\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2314156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4025, "~/", 4025, 2, true);
#nullable restore
#line 115 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 4027, item.ProductDetails.Product.Image, 4027, 34, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"col-12 p-0\">\r\n                                <div>");
#nullable restore
#line 121 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                Write(item.ProductDetails.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div class=\"text-secondary\">");
#nullable restore
#line 122 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                       Write(item.ProductDetails.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div class=\"text-secondary\">");
#nullable restore
#line 123 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                       Write(item.ProductDetails.Sizes.SizeName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 123 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                                                             Write(item.ProductDetails.Colors.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            </div>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 126 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                       Write(item.ProductDetails.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            <div class=\"input-group\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2318198", async() => {
                    WriteLiteral("\r\n                                    <button class=\"btn btn-outline-secondary btn-sm\" type=\"submit\" id=\"subtractBtn\">-</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                                                       WriteLiteral(item.IDCart);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"text\" class=\"form-control text-center\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 5285, "\"", 5307, 1);
#nullable restore
#line 132 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5293, item.Quantity, 5293, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"quantityInput\" readonly>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2321751", async() => {
                    WriteLiteral("\r\n                                    <button class=\"btn btn-outline-secondary btn-sm\" type=\"submit\" id=\"addBtn\">+</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                                                  WriteLiteral(item.IDCart);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 138 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                        Write((item.Quantity * item.ProductDetails.Product.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đồng</td>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2325180", async() => {
                    WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                                               WriteLiteral(item.IDCart);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 141 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"border p-2 mt-3 d-flex align-items-center flex-wrap\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2328241", async() => {
                    WriteLiteral("Xóa tất cả sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3cd7e986438db01cb8538ce46a621dad54357a65345697f5f2c2d78c20eef2329807", async() => {
                    WriteLiteral("Tiếp tục mua hàng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <div class=\"ml-md-auto mr-md-0 mb-2 mb-md-0\">Tổng thanh toán(");
#nullable restore
#line 150 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml"
                                                                Write(Model.Where(x => x.UserName == ViewBag.Username).Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(" sản phẩm)</div>\r\n        <div class=\"px-2 mb-2 mb-md-0\"><strong class=\"text-danger\"></strong></div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-success\">Mua hàng</button>\r\n    </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <hr>
    <h4>Có thể bạn sẽ thích</h4>

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
                <i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
            </p>
        </div>
        <div class=""col-sm-3 d-flex justify-content-center flex-column"">
            <div cla");
            WriteLiteral(@"ss=""border border-secondary-subtle rounded"">
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
            <");
            WriteLiteral(@"div class=""row container-fluid justify-content-center text-center"">
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
            <div class=""row container-fluid justify-content-center text-center"">
                <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                <p class=""font-weig");
            WriteLiteral(@"ht-bold col-sm-4 mb-1 text-danger"">200.000</p>
                <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
            </div>
            <p class=""text-center container-fluid"">
                <i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
            </p>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.Cart>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
