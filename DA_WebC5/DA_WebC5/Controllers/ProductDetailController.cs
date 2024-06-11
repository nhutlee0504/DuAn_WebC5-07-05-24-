using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Controllers
{
    public class ProductDetailController : Controller
    {
        private string urlPD = "http://localhost:57700/api/Product/";
        private string urlImg = "http://localhost:57700/api/ImageDetail?productId=";
        private string urlPddt = "http://localhost:57700/api/ProductDetail/prodId?prodId=";
        private string urlColor = "http://localhost:57700/api/Color/";
        private string urlSize = "http://localhost:57700/api/Size/";
        private string urlEvaluate = "http://localhost:57700/api/Evaluate/";
        private readonly ApplicationDbContext _context;
        public ProductDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();

            using (var httpClient = new HttpClient())
            {
                var productResponse = await httpClient.GetAsync(urlPD + id);
                if (productResponse.IsSuccessStatusCode)
                {
                    string apiResponse1 = await productResponse.Content.ReadAsStringAsync();
                    viewModel.Product = JsonConvert.DeserializeObject<Product>(apiResponse1);
                }

                var imageResponse = await httpClient.GetAsync(urlImg + id);
                if (imageResponse.IsSuccessStatusCode)
                {
                    string apiResponse2 = await imageResponse.Content.ReadAsStringAsync();
                    viewModel.Images = JsonConvert.DeserializeObject<List<ImageDetails>>(apiResponse2);
                }

                var pddtResponse = await httpClient.GetAsync(urlPddt + id);
                if (pddtResponse.IsSuccessStatusCode)
                {
                    string apiResponse3 = await pddtResponse.Content.ReadAsStringAsync();
                    viewModel.ProductDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse3);
                }

                var colorResponse = await httpClient.GetAsync(urlColor);
                if (colorResponse.IsSuccessStatusCode)
                {
                    string apiResponse4 = await colorResponse.Content.ReadAsStringAsync();
                    viewModel.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse4);
                }

                var sizeResponse = await httpClient.GetAsync(urlSize);
                if (sizeResponse.IsSuccessStatusCode)
                {
                    string apiResponse5 = await sizeResponse.Content.ReadAsStringAsync();
                    viewModel.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse5);
                }

                var evaResponse = await httpClient.GetAsync(urlEvaluate);
                if (evaResponse.IsSuccessStatusCode)
                {
                    string apiResponse6 = await evaResponse.Content.ReadAsStringAsync();
                    viewModel.Evaluates = JsonConvert.DeserializeObject<List<Evaluate>>(apiResponse6);
                }
            }

            return View(viewModel);
        }
        public IActionResult AddEvaluate(string dsc, int id)
        {
            var db = Index(id);
            string username = HttpContext.Session.GetString("LoggedInUser");
            var add = new Evaluate
            {
                UserName = username,
                IDProduct = id,
                Point = 5,
                Describe = dsc,
            };
            _context.Evaluates.Add(add);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = id });
        }
    }
}
