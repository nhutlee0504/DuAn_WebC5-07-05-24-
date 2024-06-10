using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IProductDetail
    {
        public IEnumerable<ProductDetails> GetProductDetails();

        public IEnumerable<ProductDetails> GetPddtByProdId(int productId);

        public ProductDetails GetProductDetails(int id);

        public ProductDetails Add(ProductDetails productDetails);

        public ProductDetails Update(ProductDetails productDetails, int id);

        public void Delete(int id);
    }
}
