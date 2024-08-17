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
        public Transaction()
        {
            InitializeComponent();
            LoadComboBoxProduct();
            label1.Text = "SILAHKAN PILIH PRODUK TERLEBIH DAHULU";
        }

        private void LoadComboBoxProduct()
        {
            var products = Program.db.Products.Select(p => new { p.Id, p.Nama }).ToList();
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Nama";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Pilih produk";
            comboBox1.SelectedItem = null;
            isInitialized = true;
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
                    subTotal += totalHarga;
                }
            }

            total = subTotal;
            label1.Text = $"Total Harga: {total}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitialized && comboBox1.SelectedIndex != -1 && comboBox1.SelectedItem != null)
            {
                var selectedItem = comboBox1.SelectedItem;
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
                            dataGridView1.Rows.Add(selectedProduct.Nama, 1, selectedProduct.Harga);
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
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                UpdateTotalHarga();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
