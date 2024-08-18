using POST_System.DB_Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POST_System.Pages
{
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            saleDetailBindingSource.DataSource = Program.db.SaleDetails.Select(e => new
            {
                Id = e.Id,
                Produk = e.Produk.Nama,
                Total = e.SubTotal,
                Kuantitas = e.Kuantitas,
                User = e.Penjualan.User.Nama,
                Tanggal = e.Penjualan.Tanggal,
            }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Refresh();
            }
            else
            {
                saleDetailBindingSource.DataSource = Program.db.SaleDetails.Select(e => new
                {
                    Id = e.Id,
                    Produk = e.Produk.Nama,
                    Total = e.SubTotal,
                    Kuantitas = e.Kuantitas,
                    User = e.Penjualan.User.Nama,
                    Tanggal = e.Penjualan.Tanggal,
                }).OrderByDescending(e => e.Id).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox1.Text;

            if (Text.Length > 0)
            {
                saleDetailBindingSource.DataSource = Program.db.SaleDetails.Select(e => new
                {
                    Id = e.Id,
                    Produk = e.Produk.Nama,
                    Total = e.SubTotal,
                    Kuantitas = e.Kuantitas,
                    User = e.Penjualan.User.Nama,
                    Tanggal = e.Penjualan.Tanggal,
                }).Where(e => e.Produk.ToLower().Contains(Text)).OrderBy(e => e.Produk).ToList();
            }
            else
            {
                Refresh();
            }
        }

        private void FilterMonth(int v)
        {
            saleDetailBindingSource.DataSource = Program.db.SaleDetails.Select(e => new
            {
                Id = e.Id,
                Produk = e.Produk.Nama,
                Total = e.SubTotal,
                Kuantitas = e.Kuantitas,
                User = e.Penjualan.User.Nama,
                Tanggal = e.Penjualan.Tanggal,
            }).Where(e => e.Tanggal.Month == v).OrderBy(e => e.Tanggal).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0){ FilterMonth(1); }
            else if (comboBox2.SelectedIndex == 1){ FilterMonth(2); }
            else if (comboBox2.SelectedIndex == 2){ FilterMonth(3); }
            else if (comboBox2.SelectedIndex == 3){ FilterMonth(4); }
            else if (comboBox2.SelectedIndex == 4){ FilterMonth(5); } 
            else if (comboBox2.SelectedIndex == 5){ FilterMonth(6); }
            else if (comboBox2.SelectedIndex == 6){ FilterMonth(7); }
            else if (comboBox2.SelectedIndex == 7){ FilterMonth(8); }
            else if (comboBox2.SelectedIndex == 8){ FilterMonth(9); }
            else if (comboBox2.SelectedIndex == 9){ FilterMonth(10); }
            else if (comboBox2.SelectedIndex == 10){ FilterMonth(11); }
            else if (comboBox2.SelectedIndex == 11){ FilterMonth(12); }
            else { Refresh(); }
        }
    }
}
