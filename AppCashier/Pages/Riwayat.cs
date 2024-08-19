using Microsoft.VisualBasic.ApplicationServices;
using POST_System.AdminPages.Components;
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
        public string IdSale = string.Empty;
        public Riwayat()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            saleBindingSource.DataSource = Program.db.Sales.Select(e => new
            {
                e.Id,
                e.Tanggal,
                e.TotalHarga,
                User = e.User.Nama,
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
                saleBindingSource.DataSource = Program.db.Sales.Select(e => new
                {
                    e.Id,
                    e.Tanggal,
                    e.TotalHarga,
                    User = e.User.Nama,
                }).OrderBy(v => v.Id).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox1.Text;

            if (Text.Length > 0)
            {
                saleBindingSource.DataSource = Program.db.Sales.Select(e => new
                {
                    e.Id,
                    e.Tanggal,
                    e.TotalHarga,
                    User = e.User.Nama,
                }).Where(e => e.User.ToLower().Contains(Text)).OrderBy(e => e.User).ToList();
            }
            else
            {
                Refresh();
            }
        }

        private void FilterMonth(int v)
        {
            saleBindingSource.DataSource = Program.db.Sales.Select(e => new
            {
                Id = e.Id,
                Tanggal = e.Tanggal,
                TotalHarga = e.TotalHarga,
                User = e.User.Nama,
            }).Where(e => e.Tanggal.Month == v).OrderBy(e => e.Tanggal).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) { FilterMonth(1); }
            else if (comboBox2.SelectedIndex == 1) { FilterMonth(2); }
            else if (comboBox2.SelectedIndex == 2) { FilterMonth(3); }
            else if (comboBox2.SelectedIndex == 3) { FilterMonth(4); }
            else if (comboBox2.SelectedIndex == 4) { FilterMonth(5); }
            else if (comboBox2.SelectedIndex == 5) { FilterMonth(6); }
            else if (comboBox2.SelectedIndex == 6) { FilterMonth(7); }
            else if (comboBox2.SelectedIndex == 7) { FilterMonth(8); }
            else if (comboBox2.SelectedIndex == 8) { FilterMonth(9); }
            else if (comboBox2.SelectedIndex == 9) { FilterMonth(10); }
            else if (comboBox2.SelectedIndex == 10) { FilterMonth(11); }
            else if (comboBox2.SelectedIndex == 11) { FilterMonth(12); }
            else { Refresh(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdSale = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            }

            var sales = Program.db.Sales.Select(e => new
            {
                e.Id,
                e.Tanggal,
                e.TotalHarga,
                User = e.User.Nama,
            }).FirstOrDefault(e => e.Id.ToString() == IdSale);

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("===== Detail Pembelian =====");
            receipt.AppendLine($"Tanggal: {sales.Tanggal}");
            receipt.AppendLine($"User: {sales.User}");
            receipt.AppendLine("Detail Pembelian:");

            var saleDetail = Program.db.SaleDetails.Select(e => new
            {
                e.Id,
                e.Kuantitas,
                e.SubTotal,
                Produk = e.Produk.Nama,
                Total = e.Produk.Harga,
                Penjualan = e.Penjualan.Id,
            }).Where(e => e.Penjualan.ToString() == IdSale);

            foreach (var detail in saleDetail)
            {
                receipt.AppendLine($"{detail.Produk}\t{detail.Kuantitas}\t{detail.Total}");
            }

            receipt.AppendLine("----------------------------");
            receipt.AppendLine($"Total Harga: {sales.TotalHarga}");
            receipt.AppendLine("======================");
            MessageBox.Show(receipt.ToString(), "Detail Pembelian");
        }
    }
}
