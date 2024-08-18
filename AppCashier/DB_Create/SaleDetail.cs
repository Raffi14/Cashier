using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_System.DB_Create
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public Product Produk { get; set; }
        public Sale Penjualan { get; set; }
        public int Kuantitas { get; set; }
        public int SubTotal { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<SaleDetail>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Kuantitas).HasColumnType("int").IsRequired();
                e.Property(e => e.SubTotal).HasColumnType("int").IsRequired();
                e.HasOne(e => e.Produk);
                e.HasOne(e => e.Penjualan);
            });
        }
    }
}
