#pragma checksum "D:\Mon_Dang_Hoc\C_Schapes_5\DuAn_WebC5-07-05-24-\DA_WebC5\DA_WebC5\Views\ProductDetail\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35f88dced5500a094c9f9d4210858e06038624600c497af7bc30b1bee93bd0f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"35f88dced5500a094c9f9d4210858e06038624600c497af7bc30b1bee93bd0f5", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"725912a7fa5205fee5f8804b4f0f7b0f688a4ee2087292be2d4e7d38ac17ed9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
	.radio-btn-image {
		display: none;
	}

	.radio-btn-image + label {
	display: inline-block;
	cursor: pointer;
	}

	.radio-btn-image + label img {
		border-radius: 25px;
	}



	.radio-btn-image:checked + label img {
		font-weight: bold;
	}

	.radio-btn-image:not(:checked) + label img {
		opacity: 0.5; 
	}


	.radio-btn-size {
		display: none;
	}

	.radio-btn-size + label {
		display: inline-block;
	/* 	padding: 10px 20px; */
		text-align:center;
		align-items:center;
		align-content:center;
		width:50px;
		height:50px;
		margin-right: 10px;
		border: 1px solid #000;
		border-radius: 0; /* Loại bỏ border radius */
		cursor: pointer;
	}




	.radio-btn-size:checked + label {
		background-color: #0EA5E9; /* Màu nền khi chọn */
		color: white; /* Màu chữ khi chọn */
	}

	.quantity-selector {
		display: flex;
		float: left;
		justify-content: center;
		text-align: center;
		background-color: gray;
		border-radius: 25px;
		padding: 5px;
	}

	.quan");
            WriteLiteral(@"tity-selector button {
		border: 1px solid #000;
		background: white;
		width: 30px;
		height: 30px;
		border-radius: 50%;
		font-weight: bold;
		font-size: 20px;
	}

	.quantity-input {
		border: none;
		background: transparent;
		text-align: center;
		padding: 5px 10px;
		font-size: 15px;
		font-weight: bold;
		width: 30px;
	}

	.add-cart {
		display: flex;
		float: right;
		background-color: black;
		color: white;
		text-align: center;
		align-items: center;
		justify-content: center;
		font-size: 15px;
		border-radius: 25px;
		padding: 10px 15px;
	}

	.radio-color {
		display: none;
	}

	.color-box {
		width: 50px;
		height: 50px;
		display: inline-block;
		margin-right: 10px;
		border: 2px solid transparent;
		cursor: pointer;
	}

	input[type=""radio""]:checked + label.color-box {
		border-color: black;
	}

	input[type=""radio""]:not(:checked) + label.color-box {
		opacity: 0.5;
	}

</style>
<div class=""container"">

	<div class=""row"">
		<div class=""col");
            WriteLiteral(@"-md-7"">
			<div class=""row "">
				<div class=""d-flex"">
					<div class=""col-md-9"">
						<div class=""justify-content-center"" style=""margin-right: 15px;"">
							<img id=""main-image"" src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""w-100"" style=""border-radius: 25px;"">
						</div>
					</div>
					<div class=""col-md-3"">
							<div class=""justify-content-center"">
								<input type=""radio"" id=""option1radio"" name=""options"" value=""1"" class=""radio-btn-image"">
								<label for=""option1radio""><img src=""/Image_Nhut/Detail1.jpg"" alt=""Option 1"" class=""w-75""></label>
							</div>
							<div>
								<input type=""radio"" id=""option2radio"" name=""options"" value=""1"" class=""radio-btn-image"">
								<label for=""option2radio""><img src=""/Image_Nhut/Detail1.jpg"" alt=""Option 1"" class=""w-75""></label>
							</div>
							<div>
								<input type=""radio"" id=""option3radio"" name=""options"" value=""1"" class=""radio-btn-image"">
								<label for=""option3radio""><img src=""/Image_Nhut/Detail1.jpg"" alt=""Opt");
            WriteLiteral(@"ion 1"" class=""w-75""></label>
							</div>
							<div>
								<input type=""radio"" id=""option4radio"" name=""options"" value=""1"" class=""radio-btn-image"">
								<label for=""option4radio""><img src=""/Image_Nhut/Detail1.jpg"" alt=""Option 1"" class=""w-75""></label>
							</div>
					</div>
				</div>
");
            WriteLiteral(@"			</div>
			<hr>
			<h3>THÔNG TIN SẢN PHẨM</h3>
			<p>
				Thông tin chi tiết sản phẩm nằm ở đây................................................................................
				................................................................................
				................................................................................
				................................................................................
				................................................................................
			</p>
		</div>
		<div class=""col-md-5"">
			<div class=""card"" style=""background-color:#D9D9D9"">
				<div class=""card-body"">
					<div class=""container"">
						<div class=""row d-flex justify-content-between"">
							<div");
            BeginWriteAttribute("class", " class=\"", 5161, "\"", 5169, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<div style=\"font-size:large\">\r\n\t\t\t\t\t\t\t\t\t<i class=\"bi bi-star-fill text-warning\"></i> <strong>4.9</strong><i class=\"bi bi-dot\"></i><u>149 Views</u>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 5406, "\"", 5414, 0);
            EndWriteAttribute();
            WriteLiteral(@">
									<div class=""font-weight-bold"" style=""font-size:x-large"">$166.99</div>
									<del class=""text-muted"" style=""font-size:large"">$199.99</del>
								</div>
							</div>
						</div>
						<div>
							<div class=""font-weight-bold"" style=""font-size:large"">Size:</div>
						</div>
						<div class=""d-flex"">
							<input type=""radio"" id=""sizeOption0"" name=""sizeOptions"" value=""S"" class=""radio-btn-size"">
							<label for=""sizeOption0"" class=""font-weight-bold"">XS</label>
							<input type=""radio"" id=""sizeOption1"" name=""sizeOptions"" value=""S"" class=""radio-btn-size"">
							<label for=""sizeOption1"" class=""font-weight-bold"">S</label>
							<input type=""radio"" id=""sizeOption2"" name=""sizeOptions"" value=""M"" class=""radio-btn-size"">
							<label for=""sizeOption2"" class=""font-weight-bold"">M</label>
							<input type=""radio"" id=""sizeOption3"" name=""sizeOptions"" value=""L"" class=""radio-btn-size"">
							<label for=""sizeOption3"" class=""font-weight-bold"">L</label>
							<input type=""radio"" id=");
            WriteLiteral(@"""sizeOption4"" name=""sizeOptions"" value=""XL"" class=""radio-btn-size"">
							<label for=""sizeOption4"" class=""font-weight-bold"">XL</label>
							<input type=""radio"" id=""sizeOption5"" name=""sizeOptions"" value=""2XL"" class=""radio-btn-size"">
							<label for=""sizeOption5"" class=""font-weight-bold"">2XL</label>
						</div>


						<div>
							<div class=""font-weight-bold"" style=""font-size:large"">Color:</div>
						</div>
						<div class=""d-flex"">
							<input type=""radio"" id=""colorOption1"" name=""colorOptions"" value=""Red"" class=""radio-color"">
							<label for=""colorOption1"" class=""color-box"" style=""background-color: red;""></label>
							<input type=""radio"" id=""colorOption2"" name=""colorOptions"" value=""Blue"" class=""radio-color"">
							<label for=""colorOption2"" class=""color-box"" style=""background-color: blue;""></label>
							<input type=""radio"" id=""colorOption3"" name=""colorOptions"" value=""Green"" class=""radio-color"">
							<label for=""colorOption3"" class=""color-box"" style=""background-color: green;""");
            WriteLiteral(@"></label>
							<input type=""radio"" id=""colorOption4"" name=""colorOptions"" value=""Green"" class=""radio-color"">
							<label for=""colorOption4"" class=""color-box"" style=""background-color: yellow;""></label>
							<input type=""radio"" id=""colorOption5"" name=""colorOptions"" value=""Green"" class=""radio-color"">
							<label for=""colorOption5"" class=""color-box"" style=""background-color: white;""></label>
							<input type=""radio"" id=""colorOption2"" name=""colorOptions"" value=""Blue"" class=""radio-color"">
							<label for=""colorOption2"" class=""color-box"" style=""background-color: blue;""></label>
							<!-- Add more color options as needed -->
						</div>


						<div class=""row"">
							<div class=""col-md-12 d-flex justify-content-between"">
								<div class=""quantity-selector"">
									<button class=""decrease-btn"">-</button>
									<input type=""text"" name=""quantity"" value=""1"" class=""quantity-input"">
									<button class=""increase-btn"">+</button>
								</div>
								<div>
									<button class");
            WriteLiteral(@"=""btn add-cart"">
										<i class=""bi bi-bag-plus""></i>
										<div>Add to cart</div>
									</button>
								</div>
							</div>
						</div>



						<div class=""text-muted mt-3 infor-detail"">
							<div class=""row"">
								<div class=""col-md-12"">
									<div>
										<div class=""float-left"">
											$169.99 x 1
										</div>
										<div class=""float-right"">
											$169.99
										</div>
									</div>
								</div>
								<div class=""col-md-12"">
									<div>
										<div class=""float-left"">
											Discount
										</div>
										<div class=""float-right"">
											$0
										</div>
									</div>
								</div>

								<div class=""col-md-12"">
									<hr>
									<div>
										<div class=""float-left font-weight-bold"">
											Total
										</div>
										<div class=""float-right font-weight-bold"">
											$269.99
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
            WriteLiteral(@"
				</div>
			</div>
		</div>
	</div>
	<h3>Gợi ý sản phẩm</h3>
	<div class=""row"">
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fil");
            WriteLiteral(@"l""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: sma");
            WriteLiteral(@"ll;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subt");
            WriteLiteral(@"le rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
		<div class=""col-sm-2 d-flex justify-content-center flex-column"">
			<div class=""border border-secondary-subtle rounded"">
				<div class=""d-flex justify-content-end m-2""><i class=""btn btn-outline-dark bi bi-bag-fill""></i></div>
				<div><img src=""/Image_Nhut/Detail1.jpg"" alt=""Alternate Text"" class=""mw-100"" /></div>
			</div>
			<div class=""row container-fluid"">
				<p class=""font-weight-bold col-sm-8 mb-1"">");
            WriteLiteral(@"Áo cầu lông 1</p>
				<p class=""font-weight-bold col-sm-4 mb-1"">200.000</p>
				<p style=""font-size: small;"" class=""col-sm-8"">Loại áo</p>
				<strike style=""font-size: small;"" class=""col-sm-4"">400.000</strike>
			</div>
			<p><i class=""bi bi-star-fill text-warning""></i> 4.9 (100)</p>
		</div>
	</div>
</div>
<script>

</script>");
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