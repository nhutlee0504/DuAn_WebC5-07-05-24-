#pragma checksum "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76135e9efd229acacd27cc7880aff9a23093c4b76fcb3ea12e94ef998a744a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/Index.cshtml")]
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
#line 1 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"76135e9efd229acacd27cc7880aff9a23093c4b76fcb3ea12e94ef998a744a04", @"/Areas/Admin/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.Account>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-6 grid-margin stretch-card text-center"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Danh sách tài khoản</h4>
            <p class=""card-description"">
            </p>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Tên tài khoản</th>
                        <th>Mật khẩu</th>
                        <th>Email</th>
                        <th>Vai trò</th>
                        <th>Tên</th>
                        <th>Giới tính</th>
                        <th>Số điện thoại</th>
                        <th>Địa chỉ</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 31 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 34 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 40 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                  
                                    if(item.Role.Equals("Người dùng"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <label>Người dùng <i class=\"fa fa-user-o\"></i></label>\r\n");
#nullable restore
#line 44 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <label>Quản trị <i class=\"fa fa-bookmark\"></i></label>\r\n");
#nullable restore
#line 48 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 62 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76135e9efd229acacd27cc7880aff9a23093c4b76fcb3ea12e94ef998a744a0410408", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                                       WriteLiteral(item.UserName);

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
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76135e9efd229acacd27cc7880aff9a23093c4b76fcb3ea12e94ef998a744a0412694", async() => {
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
#line 66 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                                          WriteLiteral(item.UserName);

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
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76135e9efd229acacd27cc7880aff9a23093c4b76fcb3ea12e94ef998a744a0414988", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                                                         WriteLiteral(item.UserName);

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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Hung\Documents\FPT Polytechnic\LAP_TRINH_C Sharp 5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Areas\Admin\Views\Accounts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.Account>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
