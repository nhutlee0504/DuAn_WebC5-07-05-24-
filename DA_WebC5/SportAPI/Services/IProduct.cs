using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IProduct
    {
        public IEnumerable<Product> GetProducts();

        public Product GetProductId(int id);

        public Product Add(Product product);

        public Product Update(Product product, int id);

        public void Delete(int id);
    }
}
