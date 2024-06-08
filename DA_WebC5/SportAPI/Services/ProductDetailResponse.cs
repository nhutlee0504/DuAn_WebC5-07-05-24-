using Microsoft.EntityFrameworkCore;
using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class ProductDetailResponse : IProductDetail
    {
        private readonly ApplicationDbContext context;
        public ProductDetailResponse(ApplicationDbContext ct) => context = ct;
        public ProductDetails Add(ProductDetails productDetails)
        {
            context.ProductDetails.Add(productDetails);
            context.SaveChanges();
            return productDetails;
        }

        public void Delete(int id)
        {
            var prod = context.ProductDetails.FirstOrDefault(x => x.IDPDetail == id);
            if (prod != null)
            {
                context.ProductDetails.Remove(prod);
                context.SaveChanges();
            }
        }

        public IEnumerable<ProductDetails> GetPddtByProdId(int productId)
        {
            return context.ProductDetails.Where(x => x.IDProduct == productId);
        }

        public IEnumerable<ProductDetails> GetProductDetails()
        {
            return context.ProductDetails;
        }

        public ProductDetails GetProductDetails(int id)
        {
            return context.ProductDetails.FirstOrDefault(x => x.IDPDetail == id);
        }

        public ProductDetails Update(ProductDetails productDetails, int id)
        {
            try
            {
                var prod = context.ProductDetails.FirstOrDefault(x => x.IDPDetail == id);
                if (prod != null)
                {
                    prod.IDColor = productDetails.IDColor;
                    prod.IDProduct = productDetails.IDProduct;
                    prod.Size = productDetails.Size;
                    prod.Quantity = productDetails.Quantity;
                    context.SaveChanges();
                    return productDetails;
                }
                return null;
            }
            catch (System.Exception)
            {

                return null;
            }
        }
    }
}
