using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static DA_WebC5.Models.NewViewModel;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillsController : Controller
    {
        private string urlBill = "http://localhost:57700/api/Bill/";
        private string urlBillDetailBill = "http://localhost:57700/api/BillDetail?id=";
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
            //    var list = _context.Bills.ToList();
            //return View(list);
        }

        [Route("Admin/Bills/BillDetail")]
        public async Task<IActionResult> BillDetail(int id)
        {
            var view = new BillInfor();
            using (var httpClient = new HttpClient())
            {
                using (var Response = await httpClient.GetAsync(urlBillDetailBill + id))
                {
                    string apiResponse = await Response.Content.ReadAsStringAsync();
                    view.BillDetails = JsonConvert.DeserializeObject<List<BillDetails>>(apiResponse);
                }
                using(var Response1 = await httpClient.GetAsync(urlColor))
                {
                    string apiResponse1 = await Response1.Content.ReadAsStringAsync();
                   view.Colors = JsonConvert.DeserializeObject<List<Colors>>(apiResponse1);
                }
                using (var Response1 = await httpClient.GetAsync(urlSize))
                {
                    string apiResponse1 = await Response1.Content.ReadAsStringAsync();
                    view.Sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiResponse1);
                }
                using (var Response1 = await httpClient.GetAsync(urlPddt))
                {
                    string apiResponse1 = await Response1.Content.ReadAsStringAsync();
                    view.ProductDetails = JsonConvert.DeserializeObject<List<ProductDetails>>(apiResponse1);
                }
            }
            return View(view);
        }
    }
}
