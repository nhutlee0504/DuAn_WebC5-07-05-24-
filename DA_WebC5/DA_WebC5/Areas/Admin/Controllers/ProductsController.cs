using DA_WebC5.Controllers;
using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Threading.Tasks;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly string _urlP = "http://localhost:57700/api/Product/";
        private readonly string _urlCate = "http://localhost:57700/api/Category/";
        private readonly string _urlSuplier = "http://localhost:57700/api/Supplier/";
        private readonly string _urlSizes = "http://localhost:57700/api/Size";
        private readonly string _urlColors = "http://localhost:57700/api/Color/";
        private readonly string _urlProductDetails = "http://localhost:57700/api/ProductDetail/";
        private readonly string _urlImageDetail = "http://localhost:57700/api/ImageDetail/";

        [Route("Admin/Products/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<Supplier> suppliers = new List<Supplier>();
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlP))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
                using (var response2 = await httpClient.GetAsync(_urlSuplier))
                {
                    string apiResponse = await response2.Content.ReadAsStringAsync();
                    suppliers = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse);
                }
                using (var response1 = await httpClient.GetAsync(_urlCate))
                {
                    string apiResponse1 = await response1.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse1);
                }

                foreach (var product in products)
                {
                    var category = categories.FirstOrDefault(x => x.IDCategory == product.IDCategory);
                    var suplier = suppliers.FirstOrDefault(x => x.IDSupplier == product.IDSupplier);
                    if (category != null)
                    {
                        var prod = new ProductViewModel
                        {
                            IDProduct = product.IDProduct,
                            Name = product.Name,
                            Price = product.Price,
                            Description = product.Describe,
                            NameSuplier = suplier.Name,
                            Status = product.Status,
                            CategoryName = category.Name,
                            Image = product.Image,
                            Categories = categories
                        };
                        productsViewModel.Add(prod);
                    }
                }
                return View(productsViewModel);
            }
        }

        [Route("Admin/Products/Create")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<Category> categories;
            List<Supplier> suppliers;
            List<Sizes> sizes;
            List<Colors> colors;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlCate))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse);
                }
                using (var response = await httpClient.GetAsync(_urlSuplier))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    suppliers = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse);
                }
                using (var response = await httpClient.GetAsync(_urlSizes))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse);
                }
                using (var response = await httpClient.GetAsync(_urlColors))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse);
                }
            }
            ViewBag.Categories = new SelectList(categories, "IDCategory", "Name");
            ViewBag.Suppliers = new SelectList(suppliers, "IDSupplier", "Name");
            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Products/Create")]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlP, product);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string apiResponse = await responseMessage.Content.ReadAsStringAsync();
                        Product createdProduct = JsonConvert.DeserializeObject<Product>(apiResponse);

                  
                        return RedirectToAction("CreateDetails", new { productId = createdProduct.IDProduct });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Thêm sản phẩm không thành công. Vui lòng thử lại sau.");
                    }
                }
            }

            // Nếu có lỗi xảy ra hoặc dữ liệu không hợp lệ, hiển thị lại form tạo sản phẩm
            List<Sizes> sizes;
            List<Colors> colors;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlSizes))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse);
                }

                using (var response = await httpClient.GetAsync(_urlColors))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse);
                }
            }

            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");

            return View(product);
        }
        private async Task<Product> GetProductById(int productId)
        {
            Product product = null;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"{_urlP}/{productId}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }

            return product;
        }
        [Route("Admin/Products/CreateDetails")]
        public async Task<IActionResult> CreateDetails(int productId, int Quantity)
        {
            List<Sizes> sizes;
            List<Colors> colors;
            List<Product> products;
           
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlSizes))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse);
                }
                using (var response = await httpClient.GetAsync(_urlP))
                {
                    string apiResponse1 = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse1);
                }              
                    using (var response = await httpClient.GetAsync(_urlColors))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse);
                }
            }
            ViewBag.Products = new SelectList(products, "IDProduct", "Name");
            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");
            return View();
        }
        //[HttpGet]
        //[Route("Admin/Products/CreateDetails")]
        //public async Task<IActionResult> CreateDetails(int productId, List<int> SelectedSizes, List<int> SelectedColors, int Quantity)
        //{
        //    // Lấy thông tin sản phẩm để hiển thị trên form tạo chi tiết sản phẩm
        //    var product = await GetProductById(productId);

        //    if (product == null)
        //    {
        //        // Trả về lỗi nếu không tìm thấy sản phẩm với productId đã cho
        //        return NotFound();
        //    }

        //    using (var httpClient = new HttpClient())
        //    {
        //        foreach (var size in SelectedSizes)
        //        {
        //            foreach (var color in SelectedColors)
        //            {
        //                ProductDetails productDetail = new ProductDetails
        //                {
        //                    IDProduct = product.IDProduct,
        //                    Size = size,
        //                    IDColor = color,
        //                    Quantity = Quantity
        //                };

        //                HttpResponseMessage detailResponseMessage = await httpClient.PostAsJsonAsync(_urlProductDetails, productDetail);

        //                if (!detailResponseMessage.IsSuccessStatusCode)
        //                {
        //                    ModelState.AddModelError(string.Empty, "Thêm chi tiết sản phẩm không thành công. Vui lòng thử lại sau.");
        //                    break;
        //                }
        //            }
        //        }
        //    }



        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Products/CreateDetails")]
        public async Task<IActionResult> CreateDetails(ProductDetails productDetails, int IDColor, int IDSize, int Quantity)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                            ProductDetails productDetail = new ProductDetails
                            {
                                IDProduct = productDetails.IDProduct,
                                Size = IDSize,
                                IDColor = IDColor,
                                Quantity = Quantity
                            };
                            HttpResponseMessage detailResponseMessage = await httpClient.PostAsJsonAsync(_urlProductDetails, productDetail);
                    }

                    if (ModelState.ErrorCount == 0)
                    {
                        return RedirectToAction("Index");
                    }
            }
            else
            {
                return View();
            }
            return View();
        }
         

            [Route("Admin/Products/Details")]
        public async Task<IActionResult> Details(int id)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();

            using (var httpClient = new HttpClient())
            {
                var productResponse = await httpClient.GetAsync(_urlP + id);
                if (productResponse.IsSuccessStatusCode)
                {
                    string apiResponse1 = await productResponse.Content.ReadAsStringAsync();
                    viewModel.Product = JsonConvert.DeserializeObject<Product>(apiResponse1);
                }
                var imageResponse = await httpClient.GetAsync(_urlImageDetail + id);
                if (imageResponse.IsSuccessStatusCode)
                {
                    string apiResponse2 = await imageResponse.Content.ReadAsStringAsync();
                    viewModel.Images = JsonConvert.DeserializeObject<List<ImageDetails>>(apiResponse2);
                }
                var productDetailResponse = await httpClient.GetAsync(_urlProductDetails + "prodId?prodId=" + id);

                if (productDetailResponse.IsSuccessStatusCode)
                {
                    string apiResponse3 = await productDetailResponse.Content.ReadAsStringAsync();
                    var productDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse3);
                    ViewBag.ProductDetails = productDetails;
                }
                var colorResponse = await httpClient.GetAsync(_urlColors);
                if (colorResponse.IsSuccessStatusCode)
                {
                    string apiResponse4 = await colorResponse.Content.ReadAsStringAsync();
                    viewModel.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse4);
                }
                var sizeResponse = await httpClient.GetAsync(_urlSizes);
                if (sizeResponse.IsSuccessStatusCode)
                {
                    string apiResponse5 = await sizeResponse.Content.ReadAsStringAsync();
                    viewModel.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse5);
                }
            }

            return View(viewModel);
        }



    }
}
