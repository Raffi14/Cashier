using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using POST_System.DB_Create;
using Npgsql;


namespace POST_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_account user = Program.db.Users.FirstOrDefault(value => value.Username == username.Text && value.Password == password.Text);

            if (user == null)
            {
                MessageBox.Show("username atau password salah!");
            }

            switch (user.User_Type)
            {
                case "Admin":
                    new Home().Show();
                    Hide();
                    break;
                case "Petugas":
                    new Login().Show();
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
