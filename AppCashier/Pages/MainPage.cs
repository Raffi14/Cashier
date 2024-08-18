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
using POST_System.Pages;

namespace POST_System
{
    public partial class MainPage : Form
    {
        public User_account User;
        public string isActive;

        public MainPage(User_account user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            Username.Text = User.Username;

            switch (User.Tipe_User)
            {
                case "admin":
                    TransactionNav.Visible = false;
                    Riwayat.Location = new System.Drawing.Point(11, 215);
                    break;
                case "petugas":
                    ProductNav.Visible = false;
                    Staff.Visible = false;
                    TransactionNav.Location = new System.Drawing.Point(11, 87);
                    Riwayat.Location = new System.Drawing.Point(11, 151);
                    break;
            }
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
                productBox.Text = "Data Produk";
                product.Show();
                ProductNav.BackColor = Color.Transparent;
                TransactionNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Gray;
                Riwayat.BackColor = Color.Gray;
            }
        }

        private void TransactionNav_Click(object sender, EventArgs e)
        {
            isActive = "dataTransaction";
            if (isActive == "dataTransaction")
            {
                Transaction transaction = new Transaction(User);
                transaction.TopLevel = false;
                transaction.Dock = DockStyle.Fill;
                transaction.FormBorderStyle = FormBorderStyle.None;
                productBox.Controls.Clear();
                productBox.Controls.Add(transaction);
                productBox.Text = "Transaksi";
                transaction.Show();
                TransactionNav.BackColor = Color.Transparent;
                ProductNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Gray;
                Riwayat.BackColor = Color.Gray;
            }
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            isActive = "dataPetugas";
            if (isActive == "dataPetugas")
            {
                Petugas petugas = new Petugas();
                petugas.TopLevel = false;
                petugas.Dock = DockStyle.Fill;
                petugas.FormBorderStyle = FormBorderStyle.None;
                productBox.Controls.Clear();
                productBox.Controls.Add(petugas);
                productBox.Text = "Data Petugas";
                petugas.Show();
                ProductNav.BackColor = Color.Gray;
                TransactionNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Transparent;
                Riwayat.BackColor = Color.Gray;
            }
        }

        private void Riwayat_Click(object sender, EventArgs e)
        {
            isActive = "Riwayat";
            if (isActive == "Riwayat")
            {
                productBox.Controls.Clear();
                productBox.Text = "Riwayat Transaksi";
                TransactionNav.BackColor = Color.Gray;
                ProductNav.BackColor = Color.Gray;
                Staff.BackColor = Color.Gray;
                Riwayat.BackColor = Color.Transparent;
            }
        }
    }


}