#pragma checksum "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "891f4527c48068f6260ad6c498b69a12532d510e527a76e1ae7c52345d651fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bills), @"mvc.1.0.view", @"/Views/Home/Bills.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"891f4527c48068f6260ad6c498b69a12532d510e527a76e1ae7c52345d651fcd", @"/Views/Home/Bills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Bills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.Bill>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BillDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
  
    ViewData["Title"] = "Danh sách hóa đơn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/css/bootstrap.min.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"">

<style>
    a {
        text-decoration: none
    }
</style>

<div class=""container"">
    <ol class=""breadcrumb bg-transparent"">
        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891f4527c48068f6260ad6c498b69a12532d510e527a76e1ae7c52345d651fcd4691", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Hóa đơn</li>
    </ol>
</div>

<div class=""container"" style=""margin-bottom: 200px"">
    <table class=""table text-center"">
        <thead class=""bg-dark text-light"">
            <tr>
                <th>Mã đơn hàng</th>
                <th>Số tiền</th>
                <th>Ngày đặt hàng</th>
                <th>Trạng thái</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 35 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 38 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDBill));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                   Write(item.TotalAmount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                   Write(item.OrderDate.ToString("dd/MM/yyyy hh:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 42 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                         if (item.Status.Equals("Đang chờ"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge rounded-pill text-light bg-danger\"> ");
#nullable restore
#line 44 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 45 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891f4527c48068f6260ad6c498b69a12532d510e527a76e1ae7c52345d651fcd8406", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
                                                     WriteLiteral(item.IDBill);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Bills.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.Bill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591