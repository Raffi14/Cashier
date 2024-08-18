using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_System.DB_Create
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal TotalHarga { get; set; }
        public User_account User { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Sale>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Tanggal).HasColumnType("date").IsRequired();
                e.Property(e => e.TotalHarga).HasColumnType("int").IsRequired();
                e.HasOne(e => e.User);
            });
        }
    }
}
