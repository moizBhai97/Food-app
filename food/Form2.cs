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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(230, Color.Black);

            this.ActiveControl = label1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();


            bool flag = true;
            StreamReader open = new StreamReader("User.txt");

            string line = "";
            int count= 0;

            while ((line = open.ReadLine()) != null)
            {
                count++;

                if (count == 4 && line == textBox3.Text)
                {
                    label5.Show();
                    flag = false;
                }

                else if (count == 5 && line == textBox4.Text)
                {
                    label6.Show();
                    flag = false;
                }

                else if (count == 6 && line == textBox5.Text)
                {
                    label7.Show();
                    flag = false;
                }

                else if (count == 7 && line == textBox6.Text)
                {
                    label8.Show();
                    flag = false;
                }

                if (count == 7)
                {
                    count = 0;
                }
            }

            open.Close();

            string s = textBox1.Text;
            int l = s.Length;

            if (!(l>=3 && l<=15))
            {
                label3.Show();
                flag = false;
            }

            s = textBox2.Text;
            l = s.Length;

            if (!(l >= 3 && l <= 20))
            {
                label4.Show();
                flag = false;
            }

            s = textBox3.Text;
            l = s.Length;

            if (!(l == 11 && !int.TryParse(s, out int result)))
            {
                label5.Show();
                flag = false;
            }

            s = textBox4.Text;
            l = s.Length;

            if (!(l >= 5 && (s.Contains('@')) && (s.Substring(s.Length - 4) == ".com") && !s.Contains(' ')))
            {
                label6.Show();
                flag = false;
            }

            s = textBox5.Text;
            l = s.Length;

            if (!(l >= 3 && l <= 16 && !s.Contains(' ')))
            {
                label7.Show();
                flag = false;
            }

            s = textBox6.Text;
            l = s.Length;

            if (!(l >= 8 && l<16 && (s[0]>='A' && s[0]<='Z')))
            {
                label8.Show();
                flag = false;
            }

            if (textBox6.Text != textBox7.Text)
            {
                label9.Show();
                flag = false;
            }

            if (flag == true)
            {
                StreamWriter text = File.AppendText("User.txt");
                text.WriteLine();
                text.WriteLine(textBox1.Text);
                text.WriteLine(textBox2.Text);
                text.WriteLine(textBox3.Text);
                text.WriteLine(textBox4.Text);
                text.WriteLine(textBox5.Text);
                text.WriteLine(textBox6.Text);
                text.Close();

                Login log = new Login();

                this.Hide();

                log.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dash dash = new Dash();

            this.Hide();

            dash.Show();
        }
    }
}
