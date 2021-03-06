using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Convert.ToString(tbUsername.Text);
            string password = Convert.ToString(tbPassword.Text);

            if(password != "pbo123")
            {
                MessageBox.Show("Password Salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                MainForm f = new MainForm();
                f.Show();
            }
        }
    }
}
