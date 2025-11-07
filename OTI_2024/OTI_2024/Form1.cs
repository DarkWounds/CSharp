namespace OTI_2024
{
    public partial class Form1 : Form
    {
        string parola = "";
        string email = "";
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RtbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void RtbParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAutentificare_Click(object sender, EventArgs e)
        {
            if (parola == rtbParola.Text && email == rtbEmail.Text)
            {
                Alege_opțiunea form = new Alege_opțiunea();
                form.Show();
                this.Hide();
                rtbParola.Text = "";
                rtbEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Ceva nu a mers bine, mai încercați!");
                rtbParola.Text = "";
                rtbEmail.Text = "";
            }
        }
    }
}
