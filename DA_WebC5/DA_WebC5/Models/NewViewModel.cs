using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            public decimal  Price { get; set; }
            public int Quantity { get; set; }
            public string Description { get; set; }
            public string NameSuplier { get; set; }
            public string Status { get; set; }
            public IEnumerable<Category> Categories { get; set; }
            public List<ProductDetails> pdd { get; set; }
        }

        public class ProductDetailViewModel
        {
            public int IDSize { get; set; }
            public int IDColor { get; set; }
            public string SizeName { get; set; }
            public string Color { get; set; }
            public int Quantity { get; set; }
            public Product Product { get; set; }
            public List<ImageDetails> Images { get; set; }
            public List<ProductDetails> ProductDetails { get; set; }
            public List<Colors> Colors { get; set; }
            public List<Sizes> Sizes { get; set; }
            public List<Supplier> Suppliers { get; set; }
            public List<Evaluate> Evaluates { get; set; }
            public List<BillDetails> BillDetails { get; set; }
            public List<Bill> Bills { get; set; }
            public List<Category> Categories {get; set;}
        }
        public class BillDetailViewModel
        {
            public int IDBDetail { get; set; }
            public int IDBill { get; set; }
            public int IDPDetail { get; set; }
            public int Quantity { get; set; }
            public int IDColor { get; set; }
            public int IDSize { get; set; }
            public string UserName { get; set; }
            public string SizeName { get; set; }
            public string Color { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public List<Product> Products { get; set; }
            public List<ProductDetails> ProductDetails { get; set; }
            public List<BillDetails> BillDetails { get; set; }
            public List<Sizes> Sizes { get; set; }
            public List<Colors> Colors { get; set; }
            public List<Account> Accounts { get; set; }
            public List<Category> Categories { get; set; }
            public List<Supplier> Suppliers { get; set; }
            public ProductViewModel Product { get; set; }
        }
        public class BillInfor
        {
            public Bill Bills { get; set; }
            public List<Product> Products { get; set; }
            public List<ProductDetails> ProductDetails { get; set; }
            public List<BillDetails> BillDetails { get; set; }
            public List<Sizes> Sizes { get; set; }
            public List<Colors> Colors { get; set; }
            public List<Account> Accounts { get; set; }
            public List<Category> Categories { get; set; }
            public List<Supplier> Suppliers { get; set; }

        }
    }
}
