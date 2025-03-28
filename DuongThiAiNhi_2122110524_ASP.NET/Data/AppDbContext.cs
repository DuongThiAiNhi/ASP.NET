using DuongThiAiNhi_2122110524_ASP.NET.Model;
using Microsoft.EntityFrameworkCore;

namespace DuongThiAiNhi_2122110524_ASP.NET.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
