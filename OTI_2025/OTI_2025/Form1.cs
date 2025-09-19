using System.Linq.Expressions;

namespace OTI_2025
{
    public partial class Form1 : Form
    {
        string email = "ojti@csharp.ro";
        string parola = "Ojti2025";
        string inputEmail = "";
        string inputParola = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (inputEmail != email || inputParola != parola)
               MessageBox.Show("Ceva nu a mers bine, mai\r\nîncercați! ");
        }

        private void tUtilizator_TextChanged(object sender, EventArgs e)
        {
            string inputEmail = tUtilizator.Text;
        }

        private void tParola_TextChanged(object sender, EventArgs e)
        {
            string inputParola = tParola.Text;
        }
    }
}
