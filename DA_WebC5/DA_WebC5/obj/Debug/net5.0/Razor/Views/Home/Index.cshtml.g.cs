#pragma checksum "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\_ViewImports.cshtml"
using DA_WebC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DA_WebC5.Models.NewViewModel.ProductViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn btn-dark border-2 border-secondary position-absolute rounded-pill text-white h-auto w-45"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("left: 37%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "NEXTON SHOP";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"" crossorigin=""anonymous""></script>
<!-- MDB -->
<link href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/7.2.0/mdb.min.css"" rel=""stylesheet"" />
<!-- Font Awesome -->
<link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"" />
<!-- Icon -->
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css"">
<style>
    .features-item {
        height: 100%;
    }

    .card {
        height: 100%;
    }

    .card-body {
        display: flex;
        flex-direction: column;
        justify-content: center;
    }

<");
            WriteLiteral(@"/style>
<!-- Carousel -->
<div id=""carouselExampleAutoplaying"" class=""carousel slide"" data-bs-ride=""carousel"" data-bs-interval=""3000"">
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <!-- Image with no mask -->
            <div class=""bg-image"">
                <img src=""https://theme.hstatic.net/1000341630/1001071096/14/slideshow_3.jpg?v=848"" class=""img-fluid w-100"" alt=""hinh1"">
                <!-- Mask -->
                <div class=""mask"">
                    <div class=""bottom-0 d-flex align-items-center h-100 text-center justify-content-start"">
                        <div class=""col-md-12 col-lg-5"">
                            <h3 class=""text-secondary"">Chỉ từ $49.99</h3>
                            <h1 class=""display-3 text-dark"">NEXTON</h1>
                            <div class=""position-relative mx-auto"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f7266", async() => {
                WriteLiteral("\r\n                                    Mua ngay\r\n                                    <i class=\"bi bi-search\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        </div>
        <div class=""carousel-item"">
            <!-- Image with no mask -->
            <div class=""bg-image"">
                <img src=""https://theme.hstatic.net/1000341630/1001071096/14/slideshow_2.jpg?v=848"" class=""d-block w-100"" alt=""hinh2"">
                <!-- Mask -->
                <div class=""mask"">
                    <div class=""bottom-0 d-flex align-items-center h-100 text-center justify-content-start"">
                        <div class=""col-md-12 col-lg-5"">
                            <h3 class=""text-secondary"">Chỉ từ $49.99</h3>
                            <h1 class=""display-3 text-light"">NEXTON</h1>
                            <div class=""position-relative mx-auto"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f9877", async() => {
                WriteLiteral("\r\n                                    Mua ngay\r\n                                    <i class=\"bi bi-search\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        </div>
        <div class=""carousel-item"">
            <!-- Image with no mask -->
            <div class=""bg-image"">
                <img src=""https://theme.hstatic.net/1000341630/1001071096/14/slideshow_4.jpg?v=848"" class=""d-block w-100"" alt=""hinh3"">
                <!-- Mask -->
                <div class=""mask"">
                    <div class=""bottom-0 d-flex align-items-center h-100 text-center justify-content-start"">
                        <div class=""col-md-12 col-lg-5"">
                            <h3 class=""text-secondary"">Chỉ từ $49.99</h3>
                            <h1 class=""display-3 text-dark"">NEXTON</h1>
                            <div class=""position-relative mx-auto"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f12487", async() => {
                WriteLiteral("\r\n                                    Mua ngay\r\n                                    <i class=\"bi bi-search\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        </div>
    </div>
    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleAutoplaying"" data-bs-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Previous</span>
    </button>
    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleAutoplaying"" data-bs-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""visually-hidden"">Next</span>
    </button>
</div>
<!-- Cards -->
<div class=""container-fluid py-3"">
    <div class=""container py-5"">
        <div class=""row g-4"">

            <div class=""container-fluid py-3"">
                <div class=""container py-5"">
                    <div class=""row g-4"">
                        <div class=""col-md-6 col-lg-");
            WriteLiteral(@"3"">
                            <div class=""features-item text-center rounded bg-light p-4"">
                                <div class=""card"">
                                    <img src=""https://img.freepik.com/free-vector/smiley-delivery-man-with-lovely-style_23-2147677399.jpg?t=st=1716138183~exp=1716141783~hmac=ed6ecff25a7515818503f0460d36bf10831648c1c3ab8bf71179468b89ed68fe&w=740"" class=""card-img-top""
                                         alt=""Free shipping"" />
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">Miễn phí giao hàng</h5>
                                        <p class=""card-text"">Khi tổng hóa đơn trên 500.000d</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-3"">
                            <div class=""features-item text-center rounded bg-light p-4"">");
            WriteLiteral(@"
                                <div class=""card"">
                                    <img src=""https://img.freepik.com/free-vector/contactless-payment-with-two-smartphones_23-2147677483.jpg?t=st=1716137582~exp=1716141182~hmac=647e1b722ce247e54aa968cd96b3d78eb61b5608fef9177abf6f57ba24820e84&w=740"" class=""card-img-top""
                                         alt=""Secure payment"" />
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">An toàn khi giao dịch</h5>
                                        <p class=""card-text"">100% bảo mật</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-3"">
                            <div class=""features-item text-center rounded bg-light p-4"">
                                <div class=""card"">
                                    <img src=""https:");
            WriteLiteral(@"//img.freepik.com/free-vector/indian-rupee-currency-exchange_23-2148009228.jpg?t=st=1716137670~exp=1716141270~hmac=c3cbe808d1f10448a078b03cc36caac97cfd041698e123c6d8f4bb9f1bb749ef&w=740"" class=""card-img-top""
                                         alt=""Refund within 30 days"" />
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">Hoàn trả trong 30 ngày</h5>
                                        <p class=""card-text"">Hoàn trả sản phẩm nếu như không mong muốn</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-3"">
                            <div class=""features-item text-center rounded bg-light p-4"">
                                <div class=""card"">
                                    <img src=""https://img.freepik.com/free-vector/call-center-agent-concept-flat-style_23-21479476");
            WriteLiteral(@"54.jpg?t=st=1716138278~exp=1716141878~hmac=25f365cdc8d95ca01b0a0fd7891e9782365c4c94741f877c4fc982a490e4c03f&w=740"" class=""card-img-top""
                                         alt=""24/7 support"" />
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">Hỗ trợ 24/7</h5>
                                        <p class=""card-text"">Hỗ trợ bạn bất cứ lúc nào</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>

<!-- Cards -->
<div class=""container"">
    <h1>
        Bắt đầu khám phá.
        <span class=""text-secondary"">Những điều tốt đẹp đang chờ đợi bạn</span>
    </h1>
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""card"">
                <div class=""p-3 mb-2 bg-info-subtle text-dark"">
   ");
            WriteLiteral(@"                 <div class=""card-body"">
                        <h5 class=""card-title"">Dành cho nam</h5>
                        <p class=""card-text"">Chỉ từ $24</p>
                        <a href=""#"" class=""btn btn-primary float-end"" data-mdb-ripple-init>
                            Mua ngay
                            <i class=""bi bi-arrow-right""></i>
                        </a>
                    </div>
                </div>

            </div>
        </div>

        <div class=""col-sm-4"">
            <div class=""card"">
                <div class=""p-3 mb-2 bg-info-subtle text-dark"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Dành cho nữ</h5>
                        <p class=""card-text"">Chỉ từ $19</p>
                        <a href=""#"" class=""btn btn-primary float-end"" data-mdb-ripple-init>
                            Mua ngay
                            <i class=""bi bi-arrow-right""></i>
                        </a>
               ");
            WriteLiteral(@"     </div>
                </div>

            </div>
        </div>

        <div class=""col-sm-4"">
            <div class=""card"">
                <div class=""p-3 mb-2 bg-info-subtle text-dark"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Phụ kiện</h5>
                        <p class=""card-text"">Khám phá phụ kiện</p>
                        <a href=""#"" class=""btn btn-primary float-end"" data-mdb-ripple-init>
                            Mua ngay
                            <i class=""bi bi-arrow-right""></i>
                        </a>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<!-- Product -->
<div class=""container py-5"">
    <h1 class=""tab-content"">
        Khuyến nghị.
        <span class=""text-secondary"">Sản phẩm phù hợp nhất dành cho bạn</span>
    </h1>
    <section style=""background-color: #eee;"">
        <div class=""container py-3"">
            <div class=""row"">
");
#nullable restore
#line 238 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-3 d-flex justify-content-center flex-column\">\r\n                        <div class=\"border border-secondary-subtle rounded\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d2ec45ee5443bdefde8356bcfb3ea791630e5c23c48c46ba7978c5910a9d0f22196", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 12422, "\"", 12454, 2);
                WriteAttributeValue("", 12428, "/Image_Product/", 12428, 15, true);
#nullable restore
#line 242 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
WriteAttributeValue("", 12443, item.Image, 12443, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" class=\"mw-100\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 242 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                                                                                   WriteLiteral(item.IDProduct);

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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row container-fluid\">\r\n                            <p class=\"font-weight-bold col-sm-8 mb-1\">");
#nullable restore
#line 245 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-bold col-sm-4 mb-1\">");
#nullable restore
#line 246 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                                                                 Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"font-size: small;\" class=\"col-sm-8\">");
#nullable restore
#line 247 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                                                                     Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <strike style=\"font-size: small;\" class=\"col-sm-4\">");
#nullable restore
#line 248 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                                                                          Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strike>\r\n                        </div>\r\n                        <p><i class=\"bi bi-star-fill text-warning\"></i> 4.9 (100)</p>\r\n                    </div>\r\n");
#nullable restore
#line 252 "D:\FPOLY\1.CSharp5_SD18031\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
</div>

<!-- Product -->
<div class=""container py-5"">
    <h1 class=""tab-content"">
        Bán chạy nhất.
        <span class=""text-secondary"">Bán chạy nhất trong tháng</span>
    </h1>
    <section style=""background-color: #eee;"">
        <div class=""container py-3"">
            <div class=""row"">
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                        <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                      ");
            WriteLiteral(@"  <p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                        <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                        <p cl");
            WriteLiteral(@"ass=""font-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                        <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                        <p class=""fo");
            WriteLiteral(@"nt-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
            </div>
        </div>

        <div class=""container py-3"">
            <div class=""row"">
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                     ");
            WriteLiteral(@"   <p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                        <p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                        <p c");
            WriteLiteral(@"lass=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                        <p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
                <div class=""col-sm-4 d-flex justify-content-center flex-column"">
                    <div class=""border border-secondary-subtle rounded"">
                        <div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
                        <div><img src=""https://product.hstatic.net/1000341630/product/prematch-07_58796c34b2054d5cbed1f4f8061770ee_master.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
                    </div>
                    <div class=""row container-fluid"">
                        <p class=""f");
            WriteLiteral(@"ont-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
                        <p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
                        <p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
                        <strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
                    </div>
                    <p><i class=""bi bi-star-fill""></i> 4.9 (100)</p>
                </div>
            </div>
        </div>
    </section>
</div>

<!-- Banner -->
<div class=""container py-3"">
    <div class=""bg-image"">
        <img src=""https://theme.hstatic.net/1000341630/1001071096/14/slideshow_1.jpg?v=848"" class=""img-fluid"" alt=""banner"">
        <!-- Mask -->
        <div class=""mask"">
            <div class=""bottom-0 d-flex align-items-center h-100 text-center justify-content-start"">
                <div class=""col-md-12 col-lg-5"">
                    <h5 class=""text-secondary text-sm"">Sản phẩm chính hãng 100%</h5>
                    <div class=""display-6 text");
            WriteLiteral(@"-light"">
                        Thời trang hoàn toàn mới <br />
                        Vật phẩm sưu tập
                    </div>
                    <h5 class=""text-secondary text-sm"">Chỉ từ $59,99</h5>
                    <div class=""position-relative mx-auto"">
                        <button type=""submit""
                                class=""btn btn btn-dark border-2 border-secondary position-absolute rounded-pill text-white h-auto w-45""
                                style=""left: 40%;"">
                            Mua ngay
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>










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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DA_WebC5.Models.NewViewModel.ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
