using POST_System.AdminPages;
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
using System.Xml.Linq;

namespace POST_System.Pages.Components
{
    public partial class UpPetugas : Form
    {
        public string IdPetugas { get; set; }
        User_account userSelected;
        Petugas petugasPage;
        public UpPetugas(Petugas petugas)
        {
            InitializeComponent();
            petugasPage = petugas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin memperbarui data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                userSelected.Nama = EdName.Text;
                userSelected.Alamat = EdAlamat.Text;
                userSelected.NoTelp = EdNo.Text;
                userSelected.Username = EdUsername.Text;
                userSelected.Password = EdPass.Text;

                Program.db.SaveChanges();
                petugasPage.RefreshUser();
                this.Close();
            }

        }

        private void UpPetugas_Load(object sender, EventArgs e)
        {
            userSelected = Program.db.Users.FirstOrDefault(v => v.Id.ToString() == IdPetugas);
            EdName.Text = userSelected.Nama;
            EdAlamat.Text = userSelected.NoTelp;
            EdNo.Text = userSelected.Alamat;
            EdUsername.Text = userSelected.Username;
            EdPass.Text = userSelected.Password;
        }
    }
}
