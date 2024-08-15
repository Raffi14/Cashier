using POST_System.Pages.Components;
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
    public partial class Petugas : Form
    {
        public string Id_petugas = string.Empty;
        public Petugas()
        {
            InitializeComponent();
            RefreshUser();
        }

        public void RefreshUser()
        {
            useraccountBindingSource.DataSource = Program.db.Users.OrderBy(v => v.Id).Where(v => v.Tipe_User == "petugas").ToList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            new AddPetugas(this).ShowDialog();
        }

        private void PetugasList_Click(object sender, DataGridViewCellEventArgs e)
        {
            PetugasList.CurrentRow.Selected = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Id_petugas = PetugasList.Rows[e.RowIndex].Cells["IdPetugas"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Id_petugas == string.Empty)
                MessageBox.Show("Please select a product");

            if (Id_petugas != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure you to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    var PetugasId = Program.db.Users.Find(Convert.ToInt32(Id_petugas));
                    Program.db.Users.Remove(PetugasId);
                    Program.db.SaveChanges();
                    RefreshUser();
                    Id_petugas = string.Empty;
                }
                else if (result == DialogResult.No)
                {
                    Id_petugas = string.Empty;
                }
            }
        }
    }
}
