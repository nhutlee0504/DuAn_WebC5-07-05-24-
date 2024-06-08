using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private string urlP = "http://localhost:57700/api/Product/";
        private string urlCate = "http://localhost:57700/api/Category/";
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlP))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
                using (var response1 = await httpClient.GetAsync(urlCate))
                {
                    string apiResponse1 = await response1.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse1);
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
                            Image = product.Image
                        };
                        productsViewModel.Add(prod);
                    }
                }
                return View(productsViewModel);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult TTKH()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
