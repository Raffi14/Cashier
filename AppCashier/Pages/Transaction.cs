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
    public partial class Transaction : Form
    {
        private bool isInitialized = false;
        public int total = 0;
        public string data;
        public User_account User;
        public Transaction(User_account user)
        {
            InitializeComponent();
            User = user;
            listBox1.Visible = false;
        }

        private void UpdateTotalHarga()
        {
            int subTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int quantity = Convert.ToInt32(row.Cells["Kuantitas"].Value);
                    int harga = Convert.ToInt32(row.Cells["HargaSatuan"].Value);
                    int totalHarga = quantity * harga;
                    row.Cells["totalHarga"].Value = totalHarga;
                    subTotal += totalHarga;
                }
            }

            total = subTotal;
            textBox1.Text = total.ToString();
        }
        private void ProductList(dynamic products)
        {
            listBox1.Items.Clear();
            foreach (var product in products)
            {
                listBox1.Visible = true;
                listBox1.Items.Add(product);
            }

            if (products.Count == 0)
            {
                listBox1.Visible = false;
            }

            listBox1.DisplayMember = "Nama";
            isInitialized = true;
            listBox1.Height = 24 * products.Count;
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitialized && listBox1.SelectedIndex != -1 && listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem;
                if (selectedItem != null)
                {
                    var product = (dynamic)selectedItem;
                    int selectedProductId = product.Id;
                    var selectedProduct = Program.db.Products.FirstOrDefault(p => p.Id == selectedProductId);
                    if (selectedProduct != null)
                    {

                        if (selectedProduct.Stok <= 0)
                        {
                            MessageBox.Show("Produk tidak tersedia (stok kosong).");
                            return;
                        }

                        bool productExists = false;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["NamaBarang"].Value == selectedProduct.Nama)
                            {
                                productExists = true;
                                break;
                            }
                        }


                        if (!productExists)
                        {
                            dataGridView1.Rows.Add(selectedProduct.Nama, 1, selectedProduct.Harga, selectedProduct.Harga);
                            UpdateTotalHarga();
                        }
                        else
                        {
                            MessageBox.Show("Produk sudah ditambahkan");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Kuantitas"].Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var productName = row.Cells["NamaBarang"].Value.ToString();
                var quantityCell = row.Cells["Kuantitas"];
                int quantity;

                if (quantityCell.Value == null || quantityCell.Value.ToString() == "0")
                {
                    quantityCell.Value = 1;
                }

                if (int.TryParse(quantityCell.Value.ToString(), out quantity))
                {
                    var selectedProduct = Program.db.Products.FirstOrDefault(p => p.Nama == productName);
                    if (selectedProduct != null)
                    {
                        if (quantity > selectedProduct.Stok)
                        {
                            MessageBox.Show("Kuantitas pembelian melebihi stok yang tersedia.");
                            quantityCell.Value = selectedProduct.Stok;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kuantitas harus berupa angka.");
                    quantityCell.Value = 1;
                }
            }
            UpdateTotalHarga();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Apakah anda ingin menghapus pilihan ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    UpdateTotalHarga();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada barang yang dibeli");
                return;
            }

            if (Bayar.Text.Length == 0)
            {
                MessageBox.Show("masukkan nominal bayar");
                return;
            }

            if (int.Parse(Bayar.Text) < int.Parse(textBox1.Text))
            {
                MessageBox.Show("Nominal pembayaran tidak mencukupi");
                return;
            }

            Sale sale = new Sale
            {
                Tanggal = DateTime.Now,
                TotalHarga = int.Parse(textBox1.Text),
                User = User,
            };

            Program.db.Sales.Add(sale);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var product = Program.db.Products.FirstOrDefault(p => p.Nama.ToLower() == row.Cells["NamaBarang"].Value.ToString().ToLower());
                SaleDetail saleDetail = new SaleDetail
                {
                    Produk = product,
                    Kuantitas = int.Parse(row.Cells["Kuantitas"].Value.ToString()),
                    SubTotal = int.Parse(row.Cells["totalHarga"].Value.ToString()),
                    Penjualan = sale,
                };

                Program.db.SaleDetails.Add(saleDetail);

                product.Stok -= Convert.ToInt32(row.Cells["Kuantitas"].Value);

                Program.db.Products.Update(product);
                Program.db.SaveChanges();
            }

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("===== Struk Pembayaran =====");
            receipt.AppendLine($"Tanggal: {DateTime.Now}");
            receipt.AppendLine($"User: {User.Nama}");
            receipt.AppendLine("Detail Pembelian:");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                receipt.AppendLine($"{row.Cells["NamaBarang"].Value}\t{row.Cells["Kuantitas"].Value}\t{row.Cells["HargaSatuan"].Value}");
            }

            receipt.AppendLine("----------------------------");
            receipt.AppendLine($"Total Harga: {textBox1.Text}");
            receipt.AppendLine($"Kembalian: {int.Parse(Bayar.Text) - int.Parse(textBox1.Text)}");
            receipt.AppendLine("======================");
            MessageBox.Show(receipt.ToString(), "Struk Pembayaran");
            dataGridView1.Rows.Clear();
            textBox1.Text = "0";
            Bayar.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.ToLower();

            var products = Program.db.Products
                .Where(e => e.Stok > 0 && e.Nama.ToLower().Contains(search))
                .Select(p => new { p.Id, p.Nama })
                .ToList();

            ProductList(products);

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!listBox1.Focused)
            {
                listBox1.Visible = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            var products = Program.db.Products
                .Where(e => e.Stok > 0)
                .Select(p => new { p.Id, p.Nama })
                .ToList();

            ProductList(products);
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
    }
}
