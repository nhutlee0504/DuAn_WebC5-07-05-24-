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
        private string urlImg = "http://localhost:57700/api/ImageDetail/";
        private string urlPddt = "http://localhost:57700/api/ProductDetail/prodId?prodId=";
        private string urlColor = "http://localhost:57700/api/Color/";
        private string urlSize = "http://localhost:57700/api/Size/";
        private string urlEvaluate = "http://localhost:57700/api/Evaluate/";
        private string urlCategory = "http://localhost:57700/api/Category";
        private string urlSupplier = "http://localhost:57700/api/Supplier";
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
                var cateResponse = await httpClient.GetAsync(urlCategory + viewModel.Product.Category);
                if (cateResponse.IsSuccessStatusCode)
                {
                    string apiResponse7 = await cateResponse.Content.ReadAsStringAsync();
                    var cate = JsonConvert.DeserializeObject<List<Category>>(apiResponse7);
                    viewModel.Product.Category = cate.FirstOrDefault(x => x.IDCategory == viewModel.Product.IDCategory);
                }
                var supResponse = await httpClient.GetAsync(urlSupplier + viewModel.Product.Supplier);
                if (supResponse.IsSuccessStatusCode)
                {
                    string apiResponse8 = await supResponse.Content.ReadAsStringAsync();
                    var supl = JsonConvert.DeserializeObject<List<Supplier>>(apiResponse8);
                    viewModel.Product.Supplier = supl.FirstOrDefault(x => x.IDSupplier == viewModel.Product.IDSupplier);
                }

            }
            string username = HttpContext.Session.GetString("LoggedInUser");
            var userBills = _context.Bills.Where(x => x.UserName == username&& x.Status == "Hoàn thành").Select(x => x.IDBill).ToList();
            bool Reviewed = _context.BillDetails
                .Any(bd => userBills.Contains(bd.IDBill) && bd.ProductDetails.IDProduct == id);
            bool hasEvaluated = _context.Evaluates.Any(e => e.IDProduct == id && e.UserName == username);
            ViewBag.Condition = Reviewed && !hasEvaluated;
            return View(viewModel);
        }
        public IActionResult AddEvaluate(string dsc, int id, int point)
        {
            string username = HttpContext.Session.GetString("LoggedInUser");
            var add = new Evaluate
            {
                UserName = username,
                IDProduct = id,
                Point = point,
                Describe = dsc,
            };
            _context.Evaluates.Add(add);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = id });
        }
    }
}
