using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using POST_System.DB_Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_System
{
    internal class Database : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<User_account> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=Cashier;Username=postgres;Password=Raffi141599;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Product.CreateModel(modelBuilder);
            Sale.CreateModel(modelBuilder);
            SaleDetail.CreateModel(modelBuilder);
            User_account.CreateModel(modelBuilder);
        }
    }
}
