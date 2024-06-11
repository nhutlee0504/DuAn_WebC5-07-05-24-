using DA_WebC5.Controllers;
using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using static DA_WebC5.Models.NewViewModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace DA_WebC5.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductsController : Controller
	{

        public ProductsController() { }
        private string urlP = "http://localhost:57700/api/Product/";
        private string urlCate = "http://localhost:57700/api/Category/";
        private string urlSuplier = "http://localhost:57700/api/Supplier/";
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
                using (var response = await httpClient.GetAsync(urlP))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
                using (var response2 = await httpClient.GetAsync(urlSuplier))
                {
                    string apiResponse = await response2.Content.ReadAsStringAsync();
                    suppliers = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse);
                }
                using (var response1 = await httpClient.GetAsync(urlCate))
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
        public IActionResult Create()
		{
            //var productTypes = _context.Categories.ToList();
            //ViewBag.ProductTypes = new SelectList(productTypes);
            return View();
		}
	}
}
