using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailController : ControllerBase
    {
        private IBillDetail bid;
        public BillDetailController(IBillDetail s) => bid = s;
        [HttpGet]
        public IEnumerable<BillDetails> GetBDID(int id)
        {
            return bid.GetBillDetails(id);
        }
    }
}
