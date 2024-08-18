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

namespace POST_System.AdminPages.Components
{
    public partial class UpProduct : Form
    {
        public string IdProduct { get; set; }
        public Product product;
        private ProductPage ProductPage;
        public UpProduct(ProductPage page)
        {
            InitializeComponent();
            ProductPage = page;
        }

        private void UpProduct_Load(object sender, EventArgs e)
        {
            product = Program.db.Products.FirstOrDefault(v => v.Id.ToString() == IdProduct);
            EdName.Text = product.Nama;
            EdPrice.Text = product.Harga.ToString();
            EdStock.Text = product.Stok.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin memperbarui data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                product.Nama = EdName.Text;
                product.Harga = Convert.ToInt32(EdPrice.Text);
                product.Stok = Convert.ToInt32(EdStock.Text);

                Program.db.SaveChanges();
                ProductPage.RefreshData();
                this.Close();
            }
        }
    }
}
