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

namespace POST_System.AdminPages
{
    public partial class ProductPage : Form
    {
        public string IdProduct = string.Empty;
        public ProductPage()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            productBindingSource.DataSource = Program.db.Products.OrderBy(v => v.Id).ToList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm(this).ShowDialog();
        }

        private void ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductList.CurrentRow.Selected = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UpProduct Update = new UpProduct(this);
                Update.IdProduct = IdProduct;
                Update.ShowDialog();
                IdProduct = string.Empty;
            }
        }

        private void ProductList_Click(object sender, DataGridViewCellEventArgs e)
        {
            ProductList.CurrentRow.Selected = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdProduct = ProductList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IdProduct == string.Empty)
                MessageBox.Show("Harap pilih produk terlebih dahulu");

            if(IdProduct != string.Empty)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus produk ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    var ProductId = Program.db.Products.Find(Convert.ToInt32(IdProduct));
                    Program.db.Products.Remove(ProductId);
                    Program.db.SaveChanges();
                    RefreshData();
                    IdProduct = string.Empty;
                }
                else if (result == DialogResult.No)
                {
                    IdProduct = string.Empty;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = Search.Text.ToLower();

            if(searchText.Length > 0)
            {
                productBindingSource.DataSource = Program.db.Products.Where(v => v.Nama.ToLower().Contains(searchText)).OrderBy(v => v.Nama).ToList();
            }
            else
            {
                RefreshData();
            }
        }
    }
}
