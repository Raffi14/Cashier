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
        public ProductPage()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm(this).ShowDialog();
        }
    }
}
