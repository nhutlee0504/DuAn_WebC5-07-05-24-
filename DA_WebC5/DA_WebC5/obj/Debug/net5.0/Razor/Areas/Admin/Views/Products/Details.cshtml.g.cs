#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf0331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Details.cshtml")]
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
#line 1 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf0331", @"/Areas/Admin/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.NewViewModel.ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-gradient-primary btn-rounded btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Chi tiết sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết sản phẩm</h1>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4>Thông tin sản phẩm</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 16 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 19 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 22 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 25 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Giá\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 31 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Nhà cung cấp\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 37 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Supplier.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Loại sản phẩm\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 43 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                Mô tả\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 49 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Product.Describe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf03319889", async() => {
                WriteLiteral("Cập nhật sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                                                                               WriteLiteral(Model.Product.IDProduct);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""card mt-3"">
    <div class=""card-header"">
        <h4>Chi tiết sản phẩm</h4>
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Kích cỡ</th>
                    <th>Màu sắc</th>
                    <th>Số lượng còn lại</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 72 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                 foreach (var detail in Model.ProductDetails)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                       Write(detail.IDPDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                       Write(Model.Sizes.FirstOrDefault(s => s.IDSize == detail.Size)?.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 82 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                       Write(Model.Colors.FirstOrDefault(x => x.IDColor == detail.IDColor)?.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                       Write(Model.ProductDetails.FirstOrDefault(x => x.IDPDetail == detail.IDPDetail)?.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf033115137", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 89 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Products\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf033117216", async() => {
                WriteLiteral("Thêm chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe432a93ab817f178e17fc95a6f67a8301ca5232c9b1b5ca7c3f63823cf033119035", async() => {
                WriteLiteral("Quay lại danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
