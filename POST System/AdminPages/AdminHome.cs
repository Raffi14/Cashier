using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POST_System.AdminPages;
using POST_System.DB_Create;

namespace POST_System
{
    public partial class AdminHome : Form
    {
        public string username { get; set; }
        public string isActive;

        public AdminHome()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            Username.Text = this.username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = "dataProduct";
            if (isActive == "dataProduct")
            {
                productBox.Visible = true;
                ProductNav.BackColor = Color.Transparent;
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }
    }


}
