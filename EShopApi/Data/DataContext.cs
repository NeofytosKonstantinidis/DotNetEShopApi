using EShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS2023;Database= productdb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set;}
    }
}
