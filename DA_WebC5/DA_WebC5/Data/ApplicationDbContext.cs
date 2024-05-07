using Microsoft.EntityFrameworkCore;

namespace DA_WebC5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {//Dùng DBset để lấy dữ liệu từ table của database vào model có các thuộc tính tương ứng}}}
        }
    }
}
