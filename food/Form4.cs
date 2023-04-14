using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dash : Form
    {

        public string username;
        public Dash()
        {
            InitializeComponent();
            label2.Text = username;
            username = " ";
            panel1.BackColor = Color.FromArgb(230, Color.Black);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();

            this.Hide();

            log.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();

            this.Hide();

            sign.Show();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            
            if(username!=" ")
            {
                label2.Text = username;
                label2.Show();
                label3.Show();
                linkLabel3.Show()
;               linkLabel1.Hide();
                linkLabel2.Hide();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dash new_dash = new Dash();
            this.Hide();
            new_dash.Show();
        }
    }
}
