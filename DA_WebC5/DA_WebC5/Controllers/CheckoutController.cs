using Microsoft.AspNetCore.Mvc;

namespace DA_WebC5.Controllers
{
    public class CheckoutController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
