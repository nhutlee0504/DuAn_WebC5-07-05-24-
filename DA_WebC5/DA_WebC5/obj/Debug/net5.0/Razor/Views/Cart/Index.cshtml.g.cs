#pragma checksum "D:\C#5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59276a8ad048acbfbdae055818792bcffffa7f9bf84b89bf4b760aea899ca9d5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"59276a8ad048acbfbdae055818792bcffffa7f9bf84b89bf4b760aea899ca9d5", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/css/bootstrap.min.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"">
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
		width: 100px;
		display: flex;
		justify-content: center; /* Căn giữa theo chiều ngang */
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
		transition: box-shadow 0.3s, tra");
            WriteLiteral(@"nsform 0.3s;
	}

	.col-sm-3:hover .border {
		box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.5); 
		transform: translateY(-5px); 
	}

	.col-sm-3:hover .container-fluid {
		transform: translateY(-5px);
	}
</style>
<div class=""container"">
	<div class=""border p-2 mb-3"" style=""background-color: lightgray;"">
		<i class=""bi bi-receipt""></i> Nhập mã giảm giá để có thêm nhận thêm nhiều ưu đãi hơn
	</div>
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
				<tr>
					<td>
						<input type=""checkbox"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 1903, "\"", 1911, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
					</td>
					<td>
						<div class=""d-flex align-items-center"">
							<div class=""col-12 p-0"">
								<img src=""/Image_Nhut/Detail1.jpg"" style=""width:150px; "" alt=""Alternate Text"" class=""img-fluid"" />
							</div>							
						</div>
					</td>
					<td>
						<div class=""col-12 p-0"">
							<div>Tên sản phẩm</div>
							<div>Loại sản phẩm</div>
						</div>
					</td>
					<td>30000</td>
					<td class=""text-center"">
						<div class=""input-group"">
							<button class=""btn btn-outline-secondary btn-sm"" type=""button"" id=""subtractBtn"">-</button>
							<input type=""text"" class=""form-control text-center"" value=""3"" id=""quantityInput"" readonly>
							<button class=""btn btn-outline-secondary btn-sm"" type=""button"" id=""addBtn"">+</button>
						</div>
					</td>
					<td>90.000 đồng</td>
					<td><a href=""#"" class=""text-center""><i class=""fas fa-trash-alt""></i></a></td>
				</tr>
				<tr>
					<td>
						<input type=""checkbox"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 2896, "\"", 2904, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
					</td>
					<td>
						<div class=""d-flex align-items-center"">
							<div class=""col-12 p-0"">
								<img src=""/Image_Nhut/Detail1.jpg"" style=""width:150px; "" alt=""Alternate Text"" class=""img-fluid"" />
							</div>
						</div>
					</td>
					<td>
						<div class=""col-12 p-0"">
							<div>Tên sản phẩm</div>
							<div>Loại sản phẩm</div>
						</div>
					</td>
					<td>30000</td>
					<td class=""text-center"">
						<div class=""input-group"">
							<button class=""btn btn-outline-secondary btn-sm"" type=""button"" id=""subtractBtn"">-</button>
							<input type=""text"" class=""form-control text-center"" value=""3"" id=""quantityInput"" readonly>
							<button class=""btn btn-outline-secondary btn-sm"" type=""button"" id=""addBtn"">+</button>
						</div>
					</td>
					<td>90.000 đồng</td>
					<td><a href=""#"" class=""text-center""><i class=""fas fa-trash-alt""></i></a></td>
				</tr>

			</tbody>
		</table>
	</div>

	<div class=""border p-2 mt-3 d-flex align-items-center flex-wrap"">
		");
            WriteLiteral(@"<button class=""btn btn-danger mr-2 mb-2 mb-md-0"">Xóa tất cả sản phẩm</button>
		<button class=""btn btn-dark mr-2 mb-2 mb-md-0"">Tiếp tục mua hàng</button>

		<div class=""ml-md-auto mr-md-0 mb-2 mb-md-0"">Tổng thanh toán(0 sản phẩm)</div>
		<div class=""px-2 mb-2 mb-md-0""><strong class=""text-danger"">0đ</strong></div>
		<button class=""btn btn-success"">Mua hàng</button>
	</div>

	<hr>
	<h4>Có thể bạn sẽ thích</h4>
	
	<div class=""row overflow-auto"">
		<div class=""col-sm-3 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid justify-content-center text-center"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
				<p style=""font-size");
            WriteLiteral(@": small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p class=""text-center container-fluid"">
				<i class=""bi bi-star-fill text-warning""></i> 4.9 (100)
			</p>
		</div>
		<div class=""col-sm-3 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid justify-content-center text-center"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1 text-danger"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p class=""text-center container-fluid"">
				<i class=""bi bi-star-fill text-warning"">");
            WriteLiteral(@"</i> 4.9 (100)
			</p>
		</div>
		<div class=""col-sm-3 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
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
				<div class=""d-flex justify-content-end m-2""><i c");
            WriteLiteral(@"lass=""btn btn-outline-dark bi bi-bag-fill""></i></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
