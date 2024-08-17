using POST_System.AdminPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POST_System.Pages.Components
{
    public partial class AddPetugas : Form
    {
        public Petugas Petugas;
        public AddPetugas(Petugas petugas)
        {
            InitializeComponent();
            Petugas = petugas;
        }

        private void AddPetugas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InpName.Text) || string.IsNullOrEmpty(InpNo.Text) || string.IsNullOrEmpty(InpAlamat.Text) || string.IsNullOrEmpty(InpUsername.Text) || string.IsNullOrEmpty(InpPass.Text))
            {
                MessageBox.Show("Please fill all the coloumn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DB_Create.User_account user = new DB_Create.User_account
                {
                    Tipe_User = "petugas",
                    Nama = InpName.Text,
                    Alamat = InpAlamat.Text,
                    NoTelp = InpNo.Text,
                    Username = InpUsername.Text,
                    Password = InpPass.Text,
                };

                Program.db.Users.Add(user);
                Program.db.SaveChanges();
                Petugas.RefreshUser();
                this.Close();
            }
        }
    }
}
