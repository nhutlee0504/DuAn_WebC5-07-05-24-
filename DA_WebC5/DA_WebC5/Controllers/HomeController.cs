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
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;

namespace DA_WebC5.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private string urlP = "http://localhost:57700/api/Product/";
        private string urlCate = "http://localhost:57700/api/Category/";
        private string urlPdetail = "http://localhost:57700/api/ProductDetail";
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
            List<ProductDetails> productsDetails = new List<ProductDetails>();
            using (var httpClient = new HttpClient())
            {
                using (var response2 = await httpClient.GetAsync(urlPdetail))
                {
                    string apiResponse2 = await response2.Content.ReadAsStringAsync();
                    productsDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse2);
                }
                using (var response = await httpClient.GetAsync(urlP))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                    products = products.Where(p => productsDetails.Any(pd => pd.IDProduct == p.IDProduct)).Where(p => p.Status == "Bán").ToList();
                    //var p = products.Select(p => p.IDProduct).Distinct().ToDictionary(id => id, id => _context.ProductDetails.Count(pd => pd.IDProduct == id && pd.IDProduct > 0));
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
                                Image = product.Image,
                                Status = product.Status
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
        public IActionResult Loginktr(string username, string password)
        {
            // Băm mật khẩu người dùng nhập vào
            MD5 md5 = MD5.Create();
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(passBytes);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            string hashedPassword = builder.ToString();

            // So sánh với mật khẩu đã băm trong cơ sở dữ liệu
            var user = _context.Accounts.FirstOrDefault(u => u.UserName == username && u.Password == hashedPassword);

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    HttpContext.Session.SetString("LoggedInUser", user.UserName);
                    var hs = new History()
                    {
                        UserName = username,
                        Describe = "Chào mừng " + username + " đã đăng nhập vào " + DateTime.Now,
                    };
                    _context.Histories.Add(hs);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else if (user.Role == "Member")
                {
                    HttpContext.Session.SetString("LoggedInUser", user.UserName);
                    var hs = new History()
                    {
                        UserName = username,
                        Describe = "Chào mừng " + username + " đã đăng nhập vào " + DateTime.Now,
                    };
                    _context.Histories.Add(hs);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = "Tài khoản đã bị vô hiệu hóa";
                    return View("Login");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Tài khoản hoặc mật khẩu không đúng";
                return View("Login");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult TTKH()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("LoggedInUser")))
            {
                // Lấy tên người dùng đã đăng nhập từ Session
                var loggedInUsername = HttpContext.Session.GetString("LoggedInUser");
                // Lấy thông tin người dùng từ cơ sở dữ liệu
                var user = _context.Accounts.FirstOrDefault(u => u.UserName == loggedInUsername);
                if (user != null)
                {
                    return View(user);
                }
            }
            // Nếu người dùng chưa đăng nhập, chuyển hướng về trang đăng nhập
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
