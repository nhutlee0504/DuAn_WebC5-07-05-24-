#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17916555681cf7c474e0940397164bb0e93cd76ef6b87fb0b4e9fb5dff040d12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TTKH), @"mvc.1.0.view", @"/Views/Home/TTKH.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"17916555681cf7c474e0940397164bb0e93cd76ef6b87fb0b4e9fb5dff040d12", @"/Views/Home/TTKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_TTKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_WebC5.Models.Account>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container mt-5"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto"">
                <div class=""card"">
                    <div class=""card-header"">
                        Hồ sơ của tôi<br />
                        Quản lý thông tin hồ sơ để bảo mật tài khoản
                    </div>
                    <div class=""card-body"">
                        <div class=""form-group row"">
                            <label for=""username"" class=""col-sm-4 text-right"">Tên đăng nhập:</label>
                            <div class=""col-sm-8"">
                                <span id=""username"">");
#nullable restore
#line 17 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                               Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""name"" class=""col-sm-4 text-right"">Tên:</label>
                            <div class=""col-sm-8"">
                                <span id=""name"">");
#nullable restore
#line 23 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""phone"" class=""col-sm-4 text-right"">Số Điện Thoại:</label>
                            <div class=""col-sm-8"">
                                <span id=""phone"">");
#nullable restore
#line 29 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                            Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""email"" class=""col-sm-4 text-right"">Email:</label>
                            <div class=""col-sm-8"">
                                <span id=""email"">");
#nullable restore
#line 35 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                            Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""gender"" class=""col-sm-4 text-right"">Giới tính:</label>
                            <div class=""col-sm-8"">
                                <span id=""gender"">");
#nullable restore
#line 41 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                             Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""address"" class=""col-sm-4 text-right"">Địa chỉ:</label>
                            <div class=""col-sm-8"">
                                <span id=""address"">");
#nullable restore
#line 47 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                                              Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Không tìm thấy thông tin người dùng.</p>\r\n");
#nullable restore
#line 59 "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DA_WebC5.Models.Account> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
