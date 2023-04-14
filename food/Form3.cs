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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(230, Color.Black);

            this.ActiveControl = label1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();

            bool flag = true;

            StreamReader open = new StreamReader("User.txt");

            string lin = "";
            int cnt = 0;

            while ((lin = open.ReadLine()) != null)
            {
                cnt++;

                if (cnt == 7 && lin == textBox2.Text)
                {
                    label4.Show();
                    flag = false;
                }

                if (cnt == 7)
                {
                    cnt = 0;
                }
            }

            open.Close();

            string s = textBox1.Text;
            int l = s.Length;

            if (!(l >= 5 && (s.Contains('@')) && (s.Substring(s.Length - 4) == ".com") && !s.Contains(' ')))
            {
                label3.Show();
                flag = false;
            }

            s = textBox2.Text;
            l = s.Length;

            if (!(l >= 2 && l<16 && (s[0] >= 'A' && s[0] <= 'Z')))
            {
                label4.Show();
                flag = false;
            }

            if (textBox2.Text != textBox3.Text)
            {
                label5.Show();
                flag = false;
            }

            if(flag==true)
            {
                StreamReader text = new StreamReader("User.txt");

                int count = 0;
                string line = "";
                string str = "";

                while (line != null)
                {
                    line = text.ReadLine();
                    count++;

                    //MessageBox.Show(count.ToString() + " " + line);

                    if (count == 5)
                    {
                        if (line == textBox1.Text)
                        {
                            text.ReadLine();
                            str=text.ReadLine();
                            text.ReadLine();

                            break;
                        }
                    }

                    if (count == 7)
                    {
                        text.ReadLine();
                        count = 1;
                    }
                }

                text.Close();

                string tex = File.ReadAllText("User.txt");

                tex = tex.Replace(str, textBox2.Text);

                File.WriteAllText("User.txt", tex);

                Login log = new Login();

                this.Hide();

                log.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            this.Hide();

            log.Show();
        }
    }
}
