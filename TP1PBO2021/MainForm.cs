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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            Komputer x = new Komputer();
            Pizza a = new Pizza();
            flowLayoutPanel1.Controls.Add(x);
            flowLayoutPanel1.Controls.Add(a);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm a = new loginForm();
            a.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shopee.co.id");
        }
    }
}
