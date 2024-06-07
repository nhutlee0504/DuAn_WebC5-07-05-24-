using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DA_WebC5.Controllers
{
    public class ProductDetailController : Controller
    {
        private ApplicationDbContext _context;
        private string urlPD = "http://localhost:57700/api/Product/";
        public ProductDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            Product products = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlPD + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(products);
        }
    }
}
