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
                Update.IdProduct = ProductList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Update.ShowDialog();
            }
        }
    }
}
