namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(230, Color.Black);

            this.ActiveControl = label1;

            label4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader text = new StreamReader("User.txt");

            int count = 0;
            string line = "";

            while (line != null)
            {
                line= text.ReadLine();
                count++;

                //MessageBox.Show(count.ToString() + " " + line);

                if (count == 6)
                {
                    if (line == textBox1.Text)
                    {
                        line= text.ReadLine();
                        text.ReadLine();
                        count = 0;

                        if (line == textBox2.Text)
                        {
                            Dash dash = new Dash();

                            this.Hide();
                            dash.username = textBox1.Text;
                            dash.Show();

                            break;
                        }
                    }

                    text.ReadLine();
                    count = 0;
                }
            }

            text.Close();

            label4.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dash dash = new Dash();

            this.Hide();

            dash.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();

            this.Hide();

            sign.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();

            this.Hide();

            form.Show();
        }
    }
}