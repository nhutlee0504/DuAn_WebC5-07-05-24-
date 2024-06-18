using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillsController : Controller
    {
        private string urlBill = "http://localhost:57700/api/Bill/";
        private string urlBillDetailBill = "http://localhost:57700/api/BillDetail/";
        private string urlPD = "http://localhost:57700/api/Product/";
        private string urlPddt = "http://localhost:57700/api/ProductDetail";
        private string urlColor = "http://localhost:57700/api/Color/";
        private string urlSize = "http://localhost:57700/api/Size/";
        private string urlCategory = "http://localhost:57700/api/Category";
        private string urlSupplier = "http://localhost:57700/api/Supplier";
        private string urlAccount = "http://localhost:57700/api/Account";
        private readonly ApplicationDbContext _context;
        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("Admin/Bills/Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Bill> bills = new List<Bill>();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlBill))
                {
                    string apiResponse = await Response.Content.ReadAsStringAsync();
                    bills = JsonConvert.DeserializeObject<List<Bill>>(apiResponse);
                }
            }
            return View(bills);
        }
        [Route("Admin/Bills/BillDetail/{id}")]
        [HttpGet]
        public async Task<IActionResult> BillDetail(int id)
        {
            var viewModel = new BillDetailViewModel();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Lấy chi tiết hóa đơn từ API
                    var response = await httpClient.GetAsync(urlBillDetailBill + id);
                    response.EnsureSuccessStatusCode();
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    viewModel.BillDetails = JsonConvert.DeserializeObject<List<BillDetails>>(apiResponse);

                    // Lấy danh sách màu sắc từ API
                    var responseColors = await httpClient.GetAsync(urlColor);
                    responseColors.EnsureSuccessStatusCode();
                    string apiResponseColors = await responseColors.Content.ReadAsStringAsync();
                    viewModel.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponseColors);

                    // Lấy danh sách kích thước từ API
                    var responseSizes = await httpClient.GetAsync(urlSize);
                    responseSizes.EnsureSuccessStatusCode();
                    string apiResponseSizes = await responseSizes.Content.ReadAsStringAsync();
                    viewModel.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponseSizes);

                    // Lấy chi tiết sản phẩm từ API
                    var responseProductDetails = await httpClient.GetAsync(urlPddt);
                    responseProductDetails.EnsureSuccessStatusCode();
                    string apiResponseProductDetails = await responseProductDetails.Content.ReadAsStringAsync();
                    viewModel.ProductDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponseProductDetails);

                    // Lấy danh sách sản phẩm từ API
                    var responseProducts = await httpClient.GetAsync(urlPD);
                    responseProducts.EnsureSuccessStatusCode();
                    string apiResponseProducts = await responseProducts.Content.ReadAsStringAsync();
                    viewModel.Products = JsonConvert.DeserializeObject<List<Product>>(apiResponseProducts);

                    // Đảm bảo rằng mỗi BillDetails có thông tin ProductDetails và Product tương ứng
                    foreach (var billDetail in viewModel.BillDetails)
                    {
                        // Tìm ProductDetail từ danh sách ProductDetails
                        billDetail.ProductDetails = viewModel.ProductDetails.FirstOrDefault(pd => pd.IDPDetail == billDetail.IDPDetail);

                        // Nếu tìm thấy ProductDetail, tiếp tục tìm Product từ danh sách Products
                        if (billDetail.ProductDetails != null)
                        {
                            billDetail.ProductDetails.Product = viewModel.Products.FirstOrDefault(p => p.IDProduct == billDetail.ProductDetails.IDProduct);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Đã xảy ra lỗi khi lấy dữ liệu: {ex.Message}";
            }

            return View(viewModel); // Trả về view với đối tượng viewModel của lớp BillDetailViewModel
        }




        [Route("Admin/Bills/ConformBill")]
        public IActionResult ConformBill()
        {
            return View();
        }

        [Route("Admin/Bills/BillAll")]
        [HttpGet]
        public async Task<IActionResult> BillAll()
        {
            List<Bill> bills = new List<Bill>();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlBill))
                {
                    string apiResponse = await Response.Content.ReadAsStringAsync();
                    bills = JsonConvert.DeserializeObject<List<Bill>>(apiResponse);
                }
            }
            return View(bills);
            //    var list = _context.Bills.ToList();
            //return View(list);
        }


		//     [Route("Admin/Bills/UpdateBillStatus")]
		//     [HttpGet]
		//     public async Task<IActionResult> UpdateBillStatusv(int id, string status)
		//     {
		//var bill = _context.Bills.FirstOrDefault(x => x.IDBill == id);
		//if (bill == null)
		//{
		//	return NotFound();
		//}

		//bill.Status = status;
		//_context.SaveChanges();
		//return RedirectToAction("BillAll");
		//     }

		[Route("Admin/Bills/UpdateBillStatus")]
		[HttpPost]
		public async Task<IActionResult> UpdateBillStatus(int id, string status)
		{
			Bill bill = new Bill();
			using (HttpClient httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync(urlBill + id))
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

				using (var request = new HttpRequestMessage(HttpMethod.Put, urlBill + id))
				{
					request.Content = jsonContent;
                    using(var responseUpdate = await httpClient.SendAsync(request))
                    {
                        //string apiRestUpdateBill = await responseUpdate.Content.ReadAsStringAsync();
                        //bill = JsonConvert.DeserializeObject<Bill>(apiRestUpdateBill);
                        _context.Bills.Update(bill);
                        await _context.SaveChangesAsync();
                    }
				}
			}
			return RedirectToAction(nameof(BillAll));
		}


		[Route("Admin/Bills/UpdateBillStatus2")]
		[HttpPost]
		public async Task<IActionResult> UpdateBillStatus2(int id, string status)
		{
			Bill bill = new Bill();
			using (HttpClient httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync(urlBill + id))
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

				using (var request = new HttpRequestMessage(HttpMethod.Put, urlBill + id))
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
			return RedirectToAction("Index", "Bills" , new {Areas = "Admin"});
		}


	}
}
