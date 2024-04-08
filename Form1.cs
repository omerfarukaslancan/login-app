using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = check1.Text;
            string check2 = this.check2.Text;

            if (string.IsNullOrEmpty(username))
            {
                checking.Text = "Please Enter Your Username or Email";
                return;
            }

            if (string.IsNullOrEmpty(check2))
            {
                checking.Text = "Please Enter Your Password";
                return;
            }

            if (username == "omerfarukaslancan0@gmail.com" && check2 == "c#project")
            {
                checking.Text = "Successfully logged in";
            }
            else
            {
                checking.Text = "Incorrect information";
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

