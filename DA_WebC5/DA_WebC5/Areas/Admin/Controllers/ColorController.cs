using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Json;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        private readonly string _urlP = "http://localhost:57700/api/Product/";
        private readonly string _urlCate = "http://localhost:57700/api/Category/";
        private readonly string _urlSuplier = "http://localhost:57700/api/Supplier/";
        private readonly string _urlSizes = "http://localhost:57700/api/Size";
        private readonly string _urlColors = "http://localhost:57700/api/Color/";
        private readonly string _urlProductDetails = "http://localhost:57700/api/ProductDetail/";
        private readonly string _urlImageDetail = "http://localhost:57700/api/ImageDetail/";

        [Route("Admin/Color/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Colors> colors;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlColors))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse);
                }
            }
            ViewBag.Colors = new SelectList(colors, "IDColor", "Color");
            return View(colors);
        }

        [Route("Admin/Color/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Admin/Color/Create")]
        [HttpPost]
        public async Task<IActionResult> Create(Colors colors)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(_urlColors, colors);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(colors);
            }
        }

        [Route("Admin/Color/Update")]
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Colors color;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_urlColors + id))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    color = JsonConvert.DeserializeObject<Colors>(apiResponse);
                }
            }

            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        [Route("Admin/Color/Update")]
        [HttpPost]
        public async Task<IActionResult> Update(Colors col, int idcolor)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.PutAsJsonAsync(_urlColors + idcolor, col);


                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index"); // Chuyển hướng về trang danh sách hoặc trang chi tiết
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "An error occurred while updating the color.");
                    }
                }
            }

            return View(col); // Nếu có lỗi, hiển thị lại form với thông báo lỗi
        }
    }
}
