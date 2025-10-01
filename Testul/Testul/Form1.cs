using System.Security.Cryptography.Xml;

namespace Testul
{
    
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            cnt++;
            richTextBox1.Text = Convert.ToString(cnt);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
