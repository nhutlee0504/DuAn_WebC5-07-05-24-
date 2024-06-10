using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategory category;
        public CategoryController(ICategory cgr) => category = cgr;

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return category.GetCategories();
        }
    }
}
