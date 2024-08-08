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
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Create.Product product = new DB_Create.Product{
                Name = InpName.Text,
                Price = Convert.ToDecimal(InpPrice.Text),
                Stock = Convert.ToInt32(InpStock.Text)
            };
            AdminHome Home = new AdminHome();
            Program.db.Products.Add(product);
            Program.db.SaveChanges();
            Home.RefreshData();
            this.Close();
        }
    }
}
