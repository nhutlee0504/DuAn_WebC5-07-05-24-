#pragma checksum "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06b0853146833e1cd59df03ed4673eb3b2f2faa84d6adea29e59ff3ba0d18253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_History), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/History.cshtml")]
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
#line 1 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06b0853146833e1cd59df03ed4673eb3b2f2faa84d6adea29e59ff3ba0d18253", @"/Areas/Admin/Views/Accounts/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Accounts_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.History>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1>Lịch sử</h1>
    <table class=""table table-bordered table-striped"">
        <thead>
            <tr class=""table-dark"">
                <th>
                    STT
                </th>
                <th>
                    Mô tả
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IDHistory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Describe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "D:\FPOLY\z. Finished\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\History.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.History>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591