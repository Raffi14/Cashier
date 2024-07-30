using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_System.DB_Create
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Customer>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Nama).HasColumnType("varchar(50)").IsRequired();
                e.Property(e => e.Alamat).HasColumnType("varchar(150)").IsRequired();
                e.Property(e => e.NoTelp).HasColumnType("varchar(50)").IsRequired();
            });
        }
    }
}
