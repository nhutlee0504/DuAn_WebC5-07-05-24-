using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SizeController : Controller
    {
        private string urlSize = "http://localhost:57700/api/Size/";
        [Route("Admin/Size/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Sizes> sizes = new List<Sizes>();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlSize))
                {
                    string aipRessponse = await Response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<List<Sizes>>(aipRessponse);
                }
            }
                return View(sizes);
        }
        [Route("Admin/Size/CreateSize")]
        public IActionResult CreateSize()
        {
            return View();
        }

        [Route("Admin/Size/CreateSize")]
        [HttpPost]
        public async Task<IActionResult> CreateSize(Sizes sizes)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseMessage = await httpClient.PostAsJsonAsync(urlSize, sizes);
            }

            return Redirect("Index");
        }

        [Route("Admin/Size/UpdateSize")]
        public async Task<IActionResult> UpdateSize(int id)
        {
            Sizes sizes = new Sizes();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlSize + id))
                {
                    string aipRessponse = await Response.Content.ReadAsStringAsync();
                    sizes = JsonConvert.DeserializeObject<Sizes>(aipRessponse);
                }
            }
            return View(sizes);
        }

        [Route("Admin/Size/UpdateSize")]
        [HttpPost]
        public async Task<IActionResult> UpdateSize(Sizes update)
        {
            Sizes sizes = new Sizes();
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(update), Encoding.UTF8, "application/json");
                using (var request = new HttpRequestMessage(HttpMethod.Put, urlSize + update.IDSize))
                {
                    request.Content = content;
                    using (var response = await httpClient.SendAsync(request))
                    {
                        string apiRes = await response.Content.ReadAsStringAsync();
                        sizes = JsonConvert.DeserializeObject<Sizes>(apiRes);
                    }
                }
            }
            return Redirect("Index");
        }
    }
}
