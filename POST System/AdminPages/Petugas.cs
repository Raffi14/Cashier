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
        public Petugas()
        {
            InitializeComponent();
            RefreshUser();
        }

        public void RefreshUser()
        {
            useraccountBindingSource.DataSource = Program.db.Users.OrderBy(v => v.Id).Where(v => v.Tipe_User == "petugas").ToList();
        }
    }
}
