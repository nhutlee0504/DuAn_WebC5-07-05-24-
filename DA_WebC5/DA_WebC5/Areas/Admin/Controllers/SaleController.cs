using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SaleController : Controller
    {
        private readonly string _urlP = "http://localhost:57700/api/Product/";
        private readonly string _urlCate = "http://localhost:57700/api/Category/";
        private readonly string _urlSuplier = "http://localhost:57700/api/Supplier/";
        private readonly string _urlSizes = "http://localhost:57700/api/Size";
        private readonly string _urlColors = "http://localhost:57700/api/Color/";
        private readonly string _urlProductDetails = "http://localhost:57700/api/ProductDetail/prodId?prodId=";
        private readonly string _urlProductDetails1 = "http://localhost:57700/api/ProductDetail/";
        private readonly string _urlImageDetail = "http://localhost:57700/api/ImageDetail/";
        private readonly string _urlSale = "http://localhost:57700/api/Sale/";
        [HttpGet("Admin/Sale/Index")]

        public async Task<IActionResult> IndexAsync()
        {
            List<Sale> sale = new List<Sale>();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(_urlSale))
                {
                    string apiResponse = await Response.Content.ReadAsStringAsync();
                    sale = JsonConvert.DeserializeObject<List<Sale>>(apiResponse);
                }
            }
            return View(sale);
        }
        [Route("Admin/Sale/Create")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Admin/Sale/Create")]
        [HttpPost]
        public async Task<IActionResult> Create(Sale sales)
        {

            if (ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlSale, sales);

                }
                return Redirect("Index");

            }
            else
            {
                return RedirectToAction("Create");
            }

        }
    }
}
