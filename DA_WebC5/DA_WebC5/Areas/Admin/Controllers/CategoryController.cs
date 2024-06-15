using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private string urlCate = "http://localhost:57700/api/Category/";
        [Route("Admin/Category/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Category> categories = new List<Category>();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlCate))
                {
                    string apiResponse = await Response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<Category>>(apiResponse);
                }
            }
                return View(categories);
        }

        [Route("Admin/Category/CreateCategory")]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [Route("Admin/Category/CreateCategory")]
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category cate)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(urlCate, cate);
            }

            return Redirect("Index");
        }

        [Route("Admin/Category/UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            Category ctgr = new Category();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlCate + id))
                {
                    string aipRessponse = await Response.Content.ReadAsStringAsync();
                    ctgr = JsonConvert.DeserializeObject<Category>(aipRessponse);
                }
            }
            return View(ctgr);
        }

        [Route("Admin/Category/UpdateCategory")]
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category upCate)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PutAsJsonAsync(urlCate + upCate.IDCategory, upCate);


                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index"); // Chuyển hướng về trang danh sách hoặc trang chi tiết
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the color.");
                }
            }
            return View(upCate);
        }
    }
}
