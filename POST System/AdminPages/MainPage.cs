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
    public partial class MainPage : Form
    {
        public string username { get; set; }
        public string isActive;

        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            Username.Text = this.username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = "dataProduct";
            if (isActive == "dataProduct")
            {
                ProductPage product = new ProductPage();
                product.TopLevel = false;
                product.Dock = DockStyle.Fill;
                product.FormBorderStyle = FormBorderStyle.None;
                productBox.Controls.Clear();
                productBox.Controls.Add(product);
                productBox.Text = "Product";
                product.Show();
                ProductNav.BackColor = Color.Transparent;
                TransactionNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Gray;
            }
        }

        private void TransactionNav_Click(object sender, EventArgs e)
        {
            isActive = "dataTransaction";
            if (isActive == "dataTransaction")
            {
                productBox.Controls.Clear();
                productBox.Text = "Transaction";
                TransactionNav.BackColor = Color.Transparent;
                ProductNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Gray;
            }
        }
    }


}