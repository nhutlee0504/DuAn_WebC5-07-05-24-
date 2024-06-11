using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluateController : ControllerBase
    {
        private IEvaluate _evaluate;
        public EvaluateController(IEvaluate eva)
        {
            _evaluate = eva;
        }

        [HttpGet]
        public IEnumerable<Evaluate> Get()
        {
            return _evaluate.GetEvaluate();
        }
    }
}
