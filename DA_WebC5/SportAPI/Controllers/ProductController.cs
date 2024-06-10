using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct product;
        private IImage image;
        public ProductController(IProduct prod, IImage img)
        {
            product = prod;
            image = img;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return product.GetProducts();
        }

        [HttpPost]
        public Product Add(Product prod)
        {
            return product.Add(new Product
            {
                IDSupplier = prod.IDSupplier,
                IDCategory = prod.IDCategory,
                Name = prod.Name,
                Price = prod.Price,
                Image = prod.Image,
                Describe = prod.Describe,
                Status = prod.Status
            });
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
          return product.GetProductId(id);
        }

        [HttpPut("{id}")]
        public Product Update(Product prod, int id)
        {
            return product.Update(prod, id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            product.Delete(id);
        }
    }
}
