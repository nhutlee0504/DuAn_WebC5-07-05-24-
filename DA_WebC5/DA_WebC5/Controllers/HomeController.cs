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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Google;

namespace DA_WebC5.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private string urlP = "http://localhost:57700/api/Product/";
        private string urlCate = "http://localhost:57700/api/Category/";
        private string urlPdetail = "http://localhost:57700/api/ProductDetail";
        private string _urlSale = "http://localhost:57700/api/Sale/";
        private string urlBills = "http://localhost:57700/api/Bill/";
        private string urlBillDetailBill = "http://localhost:57700/api/BillDetail/";
        private string urlPddt = "http://localhost:57700/api/ProductDetail/";
        private string urlColor = "http://localhost:57700/api/Color/";
        private string urlSize = "http://localhost:57700/api/Size/";
        private string urlCategory = "http://localhost:57700/api/Category";
        private string urlSupplier = "http://localhost:57700/api/Supplier";
        private string urlAccount = "http://localhost:57700/api/Account";

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Bills()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("LoggedInUser")))
            {
                var loggedInUsername = HttpContext.Session.GetString("LoggedInUser");
                var userBills = _context.Bills.Where(b => b.UserName == loggedInUsername).ToList();

                // Check if the user has any bills
                if (userBills != null && userBills.Count > 0)
                {
                    return View(userBills);
                }
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> BillDetail(int id)
        {
            var view = new BillInfor()
            {
                BillDetails = new List<BillDetails>(),
                Colors = new List<Colors>(),
                Sizes = new List<Sizes>()
            };

            using (var httpClient = new HttpClient())
            {


                var response = await httpClient.GetAsync(urlBillDetailBill + id);
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var billDetails = JsonConvert.DeserializeObject<List<BillDetailViewModel>>(apiResponse);

                    foreach (var bd in billDetails)
                    {
                        var billDetail = new BillDetails
                        {
                            IDBDetail = bd.IDBDetail,
                            IDBill = bd.IDBill,
                            IDPDetail = bd.IDPDetail,
                            Quantity = bd.Quantity,
                            Price = bd.Price,
                            ProductDetails = new ProductDetails
                            {
                                IDProduct = bd.Product.IDProduct,
                                Product = new Product
                                {
                                    Name = bd.Product.Name,
                                    Image = bd.Product.Image
                                },
                                IDColor = bd.IDColor,
                                Size = bd.IDSize, 
                            }
                        };

                        view.BillDetails.Add(billDetail);
                    }
                }
                var responseColor = await httpClient.GetAsync(urlColor);
                if (responseColor.IsSuccessStatusCode)
                {
                    string apiResponseColor = await responseColor.Content.ReadAsStringAsync();
                    view.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponseColor);
                }

                // Gọi API để lấy thông tin kích thước
                var responseSize = await httpClient.GetAsync(urlSize);
                if (responseSize.IsSuccessStatusCode)
                {
                    string apiResponseSize = await responseSize.Content.ReadAsStringAsync();
                    view.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponseSize);
                }

                return View(view);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
            List<ProductDetails> productsDetails = new List<ProductDetails>();
            List<Sale> sale = new List<Sale>();
            using (var httpClient = new HttpClient())
            {
                using (var response2 = await httpClient.GetAsync(urlPdetail))
                {
                    string apiResponse2 = await response2.Content.ReadAsStringAsync();
                    productsDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse2);
                }
                using (var response3 = await httpClient.GetAsync(_urlSale))
                {
                    string apiResponse2 = await response3.Content.ReadAsStringAsync();
                    sale = JsonConvert.DeserializeObject<List<Sale>>(apiResponse2);
                }
                using (var response = await httpClient.GetAsync(urlP))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                    products = products.Where(p => productsDetails.Any(pd => pd.IDProduct == p.IDProduct)).Where(p => p.Status == "Bán").ToList();
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

		[HttpPost]
		public async Task<IActionResult> UpdateBillStatus(int id, string status)
		{
			Bill bill = new Bill();
			using (HttpClient httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync(urlBills + id))
				{
					if (!response.IsSuccessStatusCode)
					{
						return NotFound();
					}

					var apiRes = await response.Content.ReadAsStringAsync();
					bill = JsonConvert.DeserializeObject<Bill>(apiRes);
				}

				bill.Status = status;

				var jsonContent = new StringContent(JsonConvert.SerializeObject(bill), Encoding.UTF8, "application/json");

				using (var request = new HttpRequestMessage(HttpMethod.Put, urlBills + id))
				{
					request.Content = jsonContent;
					using (var responseUpdate = await httpClient.SendAsync(request))
					{
						//string apiRestUpdateBill = await responseUpdate.Content.ReadAsStringAsync();
						//bill = JsonConvert.DeserializeObject<Bill>(apiRestUpdateBill);
						_context.Bills.Update(bill);
						await _context.SaveChangesAsync();
					}
				}
			}
			return RedirectToAction(nameof(Bills));
		}

        public async Task SigninGoogle()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleResponse")
            });
        }
        public async Task<IActionResult> GoogleResponse()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (!authenticateResult.Succeeded)
            {
                return RedirectToAction(nameof(Login));
            }

            // Lấy thông tin người dùng từ principal
            var email = authenticateResult.Principal.FindFirst(ClaimTypes.Email)?.Value;

            // Gọi API hoặc truy xuất dữ liệu từ cơ sở dữ liệu để lấy thông tin tài khoản người dùng
            var user = _context.Accounts.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                // Xử lý trường hợp không tìm thấy người dùng
                return RedirectToAction(nameof(Login));
            }

            // Lưu thông tin người dùng vào Session (tùy chọn)
            HttpContext.Session.SetString("LoggedInUser", user.UserName);

            return RedirectToAction(nameof(Index));
        }
    }
}
