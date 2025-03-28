using DuongThiAiNhi_2122110524_ASP.NET.Model;
using Microsoft.EntityFrameworkCore;
namespace DuongThiAiNhi_2122110524_ASP.NET.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Double Price { get; set; }
    }
}
