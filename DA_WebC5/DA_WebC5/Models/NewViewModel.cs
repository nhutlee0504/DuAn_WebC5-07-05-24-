using System.Collections.Generic;

namespace DA_WebC5.Models
{
    public class NewViewModel
    {
        public class ProductViewModel
        {
            public int IDProduct { get; set; }
            public string Name { get; set; }
            public string CategoryName { get; set; }
            public string Image { get; set; }
            public double  Price { get; set; }
            public string Description { get; set; }
            public string NameSuplier { get; set; }
            public string Status { get; set; }
            public IEnumerable<Category> Categories { get; set; }
        }

        public class ProductDetailViewModel
        {
            public Product Product { get; set; }
            public List<ImageDetails> Images { get; set; }
            public List<ProductDetails> ProductDetails { get; set; }
            public List<Colors> Colors { get; set; }
            public List<Sizes> Sizes { get; set; }
            public List<Supplier> Suppliers { get; set; }
        }
    }
}
