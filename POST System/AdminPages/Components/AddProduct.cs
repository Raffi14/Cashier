using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Xml.Linq;

namespace POST_System.AdminPages
{
    public partial class AddProductForm : Form
    {
        private ProductPage Product;
        public AddProductForm(ProductPage page)
        {
            InitializeComponent();
            Product = page;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InpStock.Text) || string.IsNullOrEmpty(InpPrice.Text) || string.IsNullOrEmpty(InpName.Text))
            {
                MessageBox.Show("Please fill all the coloumn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DB_Create.Product product = new DB_Create.Product
                {
                    Name = InpName.Text,
                    Price = Convert.ToDecimal(InpPrice.Text),
                    Stock = Convert.ToInt32(InpStock.Text)
                };
                Program.db.Products.Add(product);
                Program.db.SaveChanges();
                Product.RefreshData();
                this.Close();
            }
        }
    }
}