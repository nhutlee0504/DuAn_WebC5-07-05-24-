#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Shared\_partial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7df641dd4a3705a6aae15d14a663ad70c498fac8b1a150ff2c2d421c4e9a69b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__partial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_partial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7df641dd4a3705a6aae15d14a663ad70c498fac8b1a150ff2c2d421c4e9a69b8", @"/Areas/Admin/Views/Shared/_partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMG/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"      <!-- partial -->
<div class=""container-fluid page-body-wrapper"">
    <!-- partial:partials/_sidebar.html -->
    <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <ul class=""nav"">
            <li class=""nav-item nav-profile"">
                <a href=""#"" class=""nav-link"">
                    <div class=""nav-profile-image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7df641dd4a3705a6aae15d14a663ad70c498fac8b1a150ff2c2d421c4e9a69b84504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <span class=""login-status online""></span>
                        <!--change to offline or busy as needed-->
                    </div>
                    <div class=""nav-profile-text d-flex flex-column"">
                        <span class=""font-weight-bold mb-2"">Phạm Quốc Huy</span>
                        <span class=""text-secondary text-small"">Quản trị viên</span>
                    </div>
                    <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""index.html"">
                    <span class=""menu-title"">Trang chính</span>
                    <i class=""mdi mdi-home menu-icon""></i>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                    <span class=""menu-ti");
            WriteLiteral(@"tle"">Quản lý</span>
                    <i class=""menu-arrow""></i>
                    <i class=""mdi mdi-crosshairs-gps menu-icon""></i>
                </a>
                <div class=""collapse"" id=""ui-basic"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Quản lý sản phẩm</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/dropdowns.html"">Quản lý tài khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/typography.html"">Quản lý hóa đơn</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/typography.html"">Quản lý loại sản phẩm</a>
                        ");
            WriteLiteral(@"</li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/typography.html"">Quản lý kích cỡ </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/ui-features/typography.html"">Quản lý màu</a>
                        </li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#icons"" aria-expanded=""false"" aria-controls=""icons"">
                    <span class=""menu-title"">Tài khoản</span>
                    <i class=""mdi mdi-contacts menu-icon""></i>
                </a>
                <div class=""collapse"" id=""icons"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/icons/font-awesome.html"">Font Awesome</a>
        ");
            WriteLiteral(@"                </li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#forms"" aria-expanded=""false"" aria-controls=""forms"">
                    <span class=""menu-title"">Mãu nhập</span>
                    <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
                </a>
                <div class=""collapse"" id=""forms"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/forms/basic_elements.html"">Form Elements</a>
                        </li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#charts"" aria-expanded=""false"" aria-controls=""charts"">
                    <span class=""menu-title"">Biểu đồ</span>
                    <i class=""");
            WriteLiteral(@"mdi mdi-chart-bar menu-icon""></i>
                </a>
                <div class=""collapse"" id=""charts"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/charts/chartjs.html"">ChartJs</a>
                        </li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#tables"" aria-expanded=""false"" aria-controls=""tables"">
                    <span class=""menu-title"">Bảng</span>
                    <i class=""mdi mdi-table-large menu-icon""></i>
                </a>
                <div class=""collapse"" id=""tables"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/tables/basic-table.html"">Basic table</a>
                        </li>
                 ");
            WriteLiteral(@"   </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                    <span class=""menu-title"">Trang cài đặt</span>
                    <i class=""menu-arrow""></i>
                    <i class=""mdi mdi-lock menu-icon""></i>
                </a>
                <div class=""collapse"" id=""auth"">
                    <ul class=""nav flex-column sub-menu"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/samples/blank-page.html""> Blank Page </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/samples/login.html""> Login </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/samples/register.html""> Register </a>
            ");
            WriteLiteral(@"            </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/samples/error-404.html""> 404 </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pages/samples/error-500.html""> 500 </a>
                        </li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""docs/documentation.html"" target=""_blank"">
                    <span class=""menu-title"">Documentation</span>
                    <i class=""mdi mdi-file-document-box menu-icon""></i>
                </a>
            </li>
        </ul>
    </nav>
    <!-- partial -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591