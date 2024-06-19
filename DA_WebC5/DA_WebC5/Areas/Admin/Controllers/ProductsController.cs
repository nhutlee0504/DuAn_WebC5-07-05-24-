using DA_WebC5.Controllers;
using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private readonly string _urlProductDetails = "http://localhost:57700/api/ProductDetail/prodId?prodId=";
        private readonly string _urlProductDetails1 = "http://localhost:57700/api/ProductDetail/";
    
        private readonly string _urlImageDetails = "http://localhost:57700/api/ImageDetail/";
        private readonly ILogger<ProductsController> _logger;
        private readonly ApplicationDbContext _context;
        public ProductsController(ILogger<ProductsController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
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
        public async Task<IActionResult> Create(Product product, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null && Image.Length > 0)
                {
                    var fileName = Path.GetFileName(Image.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image_Product", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await Image.CopyToAsync(stream);
                    }

                    product.Image = "Image_Product/" + fileName;
                }

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlP, product);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string apiResponse = await responseMessage.Content.ReadAsStringAsync();
                        Product createdProduct = JsonConvert.DeserializeObject<Product>(apiResponse);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Thêm sản phẩm không thành công. Vui lòng thử lại sau.");
                    }
                }
            }
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
            ViewBag.Categories = _context.Categories.Select(c => new SelectListItem
            {
                Value = c.IDCategory.ToString(),
                Text = c.Name
            }).ToList();

            ViewBag.Suppliers = _context.Suppliers.Select(s => new SelectListItem
            {
                Value = s.IDSupplier.ToString(),
                Text = s.Name
            }).ToList();

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
            Product product = null;

            using (var httpClient = new HttpClient())
            {
                // Lấy danh sách kích thước
                using (var response = await httpClient.GetAsync(_urlSizes))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse);
                }

                // Lấy thông tin sản phẩm cụ thể theo ID
                using (var response = await httpClient.GetAsync(_urlP +productId))
                {
                    string apiResponse1 = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse1);
                }

                // Lấy danh sách màu sắc
                using (var response = await httpClient.GetAsync(_urlColors))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse);
                }
            }

            // Kiểm tra sản phẩm tồn tại
            if (product == null)
            {
                return NotFound();
            }

            // Chuẩn bị dữ liệu cho view
            ViewBag.Product = product;
            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");
            return View();
        }
        [HttpGet]
        [Route("Admin/Products/EditDetails/{id}")]
        public async Task<IActionResult> EditDetails(int id)
        {
            var productDetail = await _context.ProductDetails
                .Include(pd => pd.Product)
                .FirstOrDefaultAsync(pd => pd.IDPDetail == id);

            if (productDetail == null)
            {
                return NotFound();
            }

            var model = new ProductDetails
            {
                IDPDetail = productDetail.IDPDetail,
                IDProduct = productDetail.IDProduct,
                Size = productDetail.Size,
                IDColor = productDetail.IDColor,
                Quantity = productDetail.Quantity
            };

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

            ViewBag.Product = productDetail.Product;
            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");

            return View(model);
        }
        [HttpPost]
        [Route("Admin/Products/EditDetails/{id}")]
        public async Task<IActionResult> EditDetails(int id, ProductDetails model)
        {
            if (id != model.IDPDetail)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var productDetail = await _context.ProductDetails.FindAsync(id);
                if (productDetail == null)
                {
                    return NotFound();
                }

                productDetail.Size = model.Size;
                productDetail.IDColor = model.IDColor;
                productDetail.Quantity = model.Quantity;

                _context.ProductDetails.Update(productDetail);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

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

            ViewBag.Product = await _context.Products.FindAsync(model.IDProduct);
            ViewBag.Sizes = new SelectList(sizes, "IDSize", "SizeName");
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");

            return View(model);
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

                    HttpResponseMessage detailResponseMessage = await httpClient.PostAsJsonAsync(_urlProductDetails1, productDetail);

                    if (detailResponseMessage.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "An error occurred while creating the product detail.");
                    }
                }
            }

            // If ModelState is not valid or there was an error in the HTTP response, return the view with errors
            return View(productDetails);
        }

        [HttpGet]
        [Route("Admin/Products/UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            Product product = null;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_urlP + id);
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }

                // Populate categories and suppliers for the dropdown lists
                var categoryResponse = await httpClient.GetAsync(_urlCate);
                if (categoryResponse.IsSuccessStatusCode)
                {
                    string categoryResponseBody = await categoryResponse.Content.ReadAsStringAsync();
                    ViewBag.Categories = JsonConvert.DeserializeObject<List<Category>>(categoryResponseBody);
                }

                var supplierResponse = await httpClient.GetAsync(_urlSuplier);
                if (supplierResponse.IsSuccessStatusCode)
                {
                    string supplierResponseBody = await supplierResponse.Content.ReadAsStringAsync();
                    ViewBag.Suppliers = JsonConvert.DeserializeObject<List<Supplier>>(supplierResponseBody);
                }
            }

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

            [HttpPost]
            [ValidateAntiForgeryToken]
            [Route("Admin/Products/UpdateProduct")]
            public async Task<IActionResult> UpdateProduct(Product product, IFormFile Image, int IDProduct)
            {
                if (ModelState.IsValid)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var fileName = Path.GetFileName(Image.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/IMG", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await Image.CopyToAsync(stream);
                        }

                        product.Image = "IMG/" + fileName;
                    }
                    else
                    {
                        // Retrieve the existing product to get the current image path
                        using (var httpClient = new HttpClient())
                        {
                            var existingProductResponse = await httpClient.GetAsync(_urlP + IDProduct);
                            if (existingProductResponse.IsSuccessStatusCode)
                            {
                                string existingProductResponseBody = await existingProductResponse.Content.ReadAsStringAsync();
                                var existingProduct = JsonConvert.DeserializeObject<Product>(existingProductResponseBody);
                                product.Image = existingProduct.Image; // Keep the existing image if no new image is uploaded
                            }
                        }
                    }

                using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PutAsJsonAsync(_urlP + IDProduct, product);

                        if (response.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "An error occurred while updating the product.");
                        }
                    }
                }

                // Repopulate the dropdown lists if validation fails
                using (var httpClient = new HttpClient())
                {
                    var categoryResponse = await httpClient.GetAsync(_urlCate);
                    if (categoryResponse.IsSuccessStatusCode)
                    {
                        string categoryResponseBody = await categoryResponse.Content.ReadAsStringAsync();
                        ViewBag.Categories = JsonConvert.DeserializeObject<List<Category>>(categoryResponseBody);
                    }

                    var supplierResponse = await httpClient.GetAsync(_urlSuplier);
                    if (supplierResponse.IsSuccessStatusCode)
                    {
                        string supplierResponseBody = await supplierResponse.Content.ReadAsStringAsync();
                        ViewBag.Suppliers = JsonConvert.DeserializeObject<List<Supplier>>(supplierResponseBody);
                    }
                }

                return View(product);
            }



        [Route("Admin/Products/Details")]
        public async Task<IActionResult> Details(int id)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();

            using (var httpClient = new HttpClient())
            {
                // Fetch the product
                var productResponse = await httpClient.GetAsync(_urlP + id);
                if (productResponse.IsSuccessStatusCode)
                {
                    string apiResponse1 = await productResponse.Content.ReadAsStringAsync();
                    viewModel.Product = JsonConvert.DeserializeObject<Product>(apiResponse1);
                }
                if (viewModel.Product != null)
                {
                    var categoryResponse = await httpClient.GetAsync(_urlCate + viewModel.Product.Category);
                    if (categoryResponse.IsSuccessStatusCode)
                    {
                        string apiResponse4 = await categoryResponse.Content.ReadAsStringAsync();
                        var categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse4);
                        viewModel.Product.Category = categories.FirstOrDefault(c => c.IDCategory == viewModel.Product.IDCategory);
                    }
                }
                var suplierRespone = await httpClient.GetAsync(_urlSuplier + viewModel.Product.Supplier);
                if (suplierRespone.IsSuccessStatusCode)
                {
                    string apiResponse4 = await suplierRespone.Content.ReadAsStringAsync();
                    var supliers = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse4);
                    viewModel.Product.Supplier = supliers.FirstOrDefault(c => c.IDSupplier == viewModel.Product.IDSupplier);
                }
                var imagteDetailsRespone = await httpClient.GetAsync(_urlImageDetails + id);
                if (imagteDetailsRespone.IsSuccessStatusCode)
                {
                    string apiResponse2 = await imagteDetailsRespone.Content.ReadAsStringAsync();
                    viewModel.Images = JsonConvert.DeserializeObject<List<ImageDetails>>(apiResponse2);
                }
                var productDetailsResponse = await httpClient.GetAsync(_urlProductDetails + id);
                if (productDetailsResponse.IsSuccessStatusCode)
                {
                    string apiResponse2 = await productDetailsResponse.Content.ReadAsStringAsync();
                    viewModel.ProductDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse2);
                }

                // Fetch the colors
                var colorResponse = await httpClient.GetAsync(_urlColors);
                if (colorResponse.IsSuccessStatusCode)
                {
                    string apiResponse3 = await colorResponse.Content.ReadAsStringAsync();
                    viewModel.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse3);
                }

                // Fetch the sizes
                var sizeResponse = await httpClient.GetAsync(_urlSizes);
                if (sizeResponse.IsSuccessStatusCode)
                {
                    string apiResponse4 = await sizeResponse.Content.ReadAsStringAsync();
                    viewModel.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse4);
                }
            }

            return View(viewModel);
        }


        [Route("Admin/Products/CreateImageDetails")]
        [HttpGet]
        public async Task<IActionResult> CreateImageDetails(int productId)
        {
            Product product;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlP + productId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }

            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Admin/Products/CreateImageDetails")]
        public async Task<IActionResult> CreateImageDetails(int productId, IFormFile Images)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {

                        if (Images != null && Images.Length > 0)
                        {
                            var fileName = Path.GetFileName(Images.FileName);
                            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Image_Product");
                            var filePath = Path.Combine(folderPath, fileName);
                            var imagePath = Path.Combine("Image_Product", fileName).Replace("\\", "/");
                          
                            if (!System.IO.File.Exists(filePath))
                            {
                                Directory.CreateDirectory(folderPath); 

                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    await Images.CopyToAsync(stream);
                                }
                            }

                            ImageDetails imageDetail = new ImageDetails
                            {
                                IDProduct = productId,
                                Image = imagePath 
                            };

                            _logger.LogInformation($"Sending image details to API: {imageDetail}");

                            HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlImageDetails, imageDetail);
                            if (!responseMessage.IsSuccessStatusCode)
                            {
                                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                                ImageDetails img = JsonConvert.DeserializeObject<ImageDetails>(responseContent);
                                return RedirectToAction("Index");
                            }
                        }


                    return RedirectToAction("Details", new { id = productId });
                }
            }

            return View();
        }
        [HttpPost("Admin/Products/DeleteImg")]
        public async Task<IActionResult> DeleteImg(int idimg)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(_urlImageDetails + idimg))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                    else
                    {
                       
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        ModelState.AddModelError(string.Empty, "Error deleting image: " + errorResponse);
                    }
                }
            }
            return RedirectToAction("Index", new { error = "Failed to delete image" });
        }





    }
}
