using System.Linq.Expressions;

namespace OTI_2025
{
    public partial class Form1 : Form
    {
        string email = ""; //ojti@csharp.ro
        string parola = ""; //Ojti2025
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (tUtilizator.Text != email || tParola.Text != parola)
            {
                MessageBox.Show("Ceva nu a mers bine, mai\r\nîncercați!");
                tUtilizator.Text = "";
                tParola.Text = "";
            }
            else if (tUtilizator.Text == email && tParola.Text == parola)
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
                this.Hide();
            }
        }

        private void tUtilizator_TextChanged(object sender, EventArgs e)
        {

        }

        private void tParola_TextChanged(object sender, EventArgs e)
        {
            tParola.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
