using DuongThiAiNhi_2122110524.Model;
using Microsoft.EntityFrameworkCore;

namespace DuongThiAiNhi_2122110524.Data  // Đặt namespace chính xác theo cấu trúc thư mục
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } // Thêm các bảng cần thiết
        public DbSet<Category> Categories { get; set; } // Thêm các bảng cần thiết

    }
}
