using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportAPI.Data;
using SportAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class ProductResponse : IProduct
    {
        private readonly ApplicationDbContext context;
        public ProductResponse(ApplicationDbContext ct) => context = ct;
        public Product Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            var prod = context.Products.FirstOrDefault(x => x.IDProduct == id);
            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
            }
        }

        public Product GetProductId(int id)
        {
            return context.Products.FirstOrDefault(x => x.IDProduct == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product Update(Product product, int id)
        {
            try
            {
                var prod = context.Products.FirstOrDefault(x => x.IDProduct == id);
                if (prod != null)
                {
                    prod.IDSupplier = product.IDSupplier;
                    prod.IDCategory = product.IDCategory;
                    prod.Name = product.Name;
                    prod.Price = product.Price;
                    prod.Image = product.Image;
                    prod.Describe = product.Describe;
                    prod.Status = product.Status;
                    context.SaveChanges();
                    return prod;
                }
                return null;
            }
            catch (Exception)
            {

               return null;
            }
        }
    }
}
