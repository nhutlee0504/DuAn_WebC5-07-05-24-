#pragma checksum "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c949a4d97cf4ceeccd0991c2104e643ba16f357e7c6bba1864db8ee0aa9f4244"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c949a4d97cf4ceeccd0991c2104e643ba16f357e7c6bba1864db8ee0aa9f4244", @"/Views/Home/TTKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_TTKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profile-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/IMG/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<style>
    .header-container {
        padding: 20px;
        border-radius: 10px;
        background-color: #f8f9fa;
    }

        .header-container h5 {
            margin-bottom: 0;
        }

        .header-container p {
            margin-bottom: 0;
        }

    #profile-img-container {
        display: flex;
        justify-content: center;
        margin-top: 20px;
    }

    #profile-img {
        width: 100px;
        height: 100px;
        cursor: pointer;
    }

    #user-info {
        transition: max-height 0.5s ease-out, opacity 0.5s ease-out;
    ");
            WriteLiteral(@"    overflow: hidden;
        max-height: 0;
        opacity: 0;
        border-color: radial-gradient(circle, rgba(238,174,202,1) 0%, rgba(148,187,233,1) 100%);
        margin-top: 20px;
    }

        #user-info.show {
            max-height: 1000px; /* Adjust this value based on content height */
            opacity: 1;
        }

    #button-container {
        display: flex;
        justify-content: center;
        margin-top: 20px;
    }

    .btn-custom {
        margin: 0 10px;
        background: linear-gradient(90deg, rgba(2, 0, 36, 1) 0%, rgba(139, 222, 34, 1) 0%, rgba(0, 212, 255, 1) 100%);
        color: white;
        font-weight: bolder;
        border:none;
        background-size: 200% 200%;
        transition: background-position 0.5s ease, transform 0.3s ease;
    }

        .btn-custom:hover {
            background-position: 100% 0;
            color: white;
            transform: scale(1.05);
        }
    a {
        text-decoration:none;
    }
</styl");
            WriteLiteral(@"e>
<div class=""container"">

    <ol class=""breadcrumb bg-transparent"">
        <li class=""breadcrumb-item""><a href=""Home/Index"">Trang chủ</a></li>

        <li class=""breadcrumb-item active"" aria-current=""page"">Thông tin cá nhân</li>
    </ol>
</div>

");
#nullable restore
#line 78 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
  
    string hiddenPhoneNumber = Model.Phone.Substring(0, Model.Phone.Length / 2) + new string('*', Model.Phone.Length / 2);
    string hiddenEmail = Model.Email.Substring(0, Model.Email.IndexOf('@') / 2) + new string('*', Model.Email.Length - Model.Email.IndexOf('@'));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"margin-bottom:300px\">\r\n    <div id=\"profile-img-container\" class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c949a4d97cf4ceeccd0991c2104e643ba16f357e7c6bba1864db8ee0aa9f42447268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral(@"
        <span class=""hover-text"">Thông tin cá nhân</span>
    </div>

    <div id=""user-info"" class=""row mt-3"">
        <ul class=""list-group w-100"">
            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                <span class=""fw-bolder"">Tên:</span>
                <span>");
#nullable restore
#line 92 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                <span class=\"fw-bolder\">Số Điện Thoại:</span>\r\n                <span>");
#nullable restore
#line 96 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                 Write(hiddenPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                <span class=\"fw-bolder\">Email:</span>\r\n                <span>");
#nullable restore
#line 100 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                 Write(hiddenEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                <span class=\"fw-bolder\">Giới tính:</span>\r\n                <span>");
#nullable restore
#line 104 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                 Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                <span class=\"fw-bolder\">Địa chỉ:</span>\r\n                <span>");
#nullable restore
#line 108 "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\TTKH.cshtml"
                 Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </li>
            <div id=""button-container"" class=""col-md-12"">
                <button class=""btn btn-primary btn-custom"">
                    Cập nhật thông tin
                </button>
                <button class=""btn btn-secondary btn-custom"">
                    Đăng xuất
                </button>
            </div>
        </ul>
        
    </div>
</div>");
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
