using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SuplierController : Controller
    {
        private readonly string _urlP = "http://localhost:57700/api/Product/";
        private readonly string _urlCate = "http://localhost:57700/api/Category/";
        private readonly string _urlSuplier = "http://localhost:57700/api/Supplier/";
        private readonly string _urlSizes = "http://localhost:57700/api/Size";
        private readonly string _urlColors = "http://localhost:57700/api/Color/";
        private readonly string _urlProductDetails = "http://localhost:57700/api/ProductDetail/";
        private readonly string _urlImageDetail = "http://localhost:57700/api/ImageDetail/";
        [Route("Admin/Suplier/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            List<Supplier> suppliers;

            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync(_urlSuplier))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    suppliers = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse);
                }
            }
            return View(suppliers);

        }
        [Route("Admin/Suplier/Create")]
        public IActionResult Create()
        {

            return View();

        }
        [Route("Admin/Suplier/Create")]
        [HttpPost]
        public async Task<IActionResult> Create( Supplier supplier)
        {

            if (ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlSuplier, supplier);

                }
                return Redirect("Index");

            }
            else
            {
                return RedirectToAction("Create");
            }

        }
        [HttpGet("Admin/Suplier/UpdateSuplier")]
        public async Task<IActionResult> UpdateSuplier(int id)
        {
            Supplier supplier;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_urlSuplier + id);
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    supplier = JsonConvert.DeserializeObject<Supplier>(apiResponse);
                    return View(supplier);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpPost("Admin/Suplier/UpdateSuplier")]
        public async Task<IActionResult> UpdateSuplier(int ipsuplier, Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.PutAsJsonAsync(_urlSuplier + ipsuplier, supplier);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Có lỗi khi cập nhật.");
                    }
                }
            }
            return View(supplier);
        }

    }
}
