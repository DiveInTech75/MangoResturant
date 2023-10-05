using Mango.Services.ProductApi.Models;
using Mango.Services.ProductApi.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ProductApi.DbContexts
{
    public class ApplicationDbContexts:DbContext
    {
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId=1,
                Name="Samosa",
                Price=15,
                Description="Praesent scelerisque, mi sed ultrices condimentum",
                imageurl= "https://dotnetmistry75.blob.core.windows.net/mango/download%20(4).jpg",
                Categoryname="Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum",
                imageurl = "https://dotnetmistry75.blob.core.windows.net/mango/download (5).jpg",
                Categoryname = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 11,
                Description = "Praesent scelerisque, mi sed ultrices condimentum",
                imageurl = "https://dotnetmistry75.blob.core.windows.net/mango/download (6).jpg",
                Categoryname = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum",
                imageurl = "https://dotnetmistry75.blob.core.windows.net/mango/images (1).jpg",
                Categoryname = "Appetizer"
            });
        }
    }
}
