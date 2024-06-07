using Microsoft.EntityFrameworkCore;
using SportAPI.Model;

namespace SportAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {//Dùng DBset để lấy dữ liệu từ table của database vào model có các thuộc tính tương ứng}}}
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Evaluate> Evaluates { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<ImageDetails> ImageDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
