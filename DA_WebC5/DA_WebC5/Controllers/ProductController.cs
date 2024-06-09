using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Controllers
{
    public class ProductController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly string urlP = "http://localhost:57700/api/Product/";
        private readonly string urlCate = "http://localhost:57700/api/Category/";

        public ProductController() { }

        [HttpGet]
        public async Task<IActionResult> Index(string find)
        {
            var productsViewModel = await GetProductsViewModel(find);
            return View(productsViewModel);
        }

        private async Task<List<ProductViewModel>> GetProductsViewModel(string find = null, List<int> selectedCategories = null)
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();

            using (var httpClient = new HttpClient())
            {
                var responseProducts = await httpClient.GetAsync(urlP);
                var responseCategories = await httpClient.GetAsync(urlCate);

                if (responseProducts.IsSuccessStatusCode)
                {
                    string apiResponse = await responseProducts.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }

                if (responseCategories.IsSuccessStatusCode)
                {
                    string apiResponse1 = await responseCategories.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse1);
                }
            }

            if (!string.IsNullOrEmpty(find))
            {
                products = products.Where(x => x.Name.ToLower().Contains(find.ToLower())).ToList();
                ViewBag.Seacrh = find;
            }

            if (selectedCategories != null && selectedCategories.Any())
            {
                products = products.Where(x => selectedCategories.Contains(x.IDCategory)).ToList();
            }

            foreach (var product in products)
            {
                var category = categories.FirstOrDefault(x => x.IDCategory == product.IDCategory);
                if (category != null)
                {
                    var prod = new ProductViewModel
                    {
                        IDProduct = product.IDProduct,
                        Name = product.Name,
                        Price = product.Price,
                        CategoryName = category.Name,
                        Image = product.Image,
                        Categories = categories
                    };
                    productsViewModel.Add(prod);
                }
            }
            return productsViewModel;
        }

        [HttpPost]
        public async Task<IActionResult> FilterByPrice(int? priceLow, int? priceHigh)
        {
            var productsViewModel = await GetProductsViewModel();

            if (priceLow.HasValue)
            {
                productsViewModel = productsViewModel.Where(p => p.Price >= priceLow.Value).ToList();
                ViewBag.PriceLow = priceLow.Value;
            }

            if (priceHigh.HasValue)
            {
                productsViewModel = productsViewModel.Where(p => p.Price <= priceHigh.Value).ToList();
                ViewBag.PriceHigh = priceHigh.Value;
            }

            if (!productsViewModel.Any())
            {
                ViewBag.NotProducts = "Không tìm thấy sản phẩm";
            }
            else
            {
                ViewBag.NotProducts = "";
            }

            return View("Index", productsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SortOrder(string sortOrder)
        {
            var productsViewModel = await GetProductsViewModel();

            switch (sortOrder)
            {
                case "priceLowToHigh":
                    productsViewModel = productsViewModel.OrderBy(p => p.Price).ToList();
                    break;
                case "priceHighToLow":
                    productsViewModel = productsViewModel.OrderByDescending(p => p.Price).ToList();
                    break;
            }

            return View("Index", productsViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> FilterByCategories(List<int> selectedCategories)
        {
            if (selectedCategories == null || !selectedCategories.Any())
            {
                return RedirectToAction("Index");
            }

            var productsViewModel = await GetProductsViewModel(null, selectedCategories);
            return View("Index", productsViewModel);
        }
    }
}
