using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username= tb_username.Text.Trim().ToString();
            String password = tb_password.Text.Trim().ToString();

            if (username == "admin" && password == "1")
            {
                new MainForm().ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("sai ten hoac pass");
            }

        }
    }
}
