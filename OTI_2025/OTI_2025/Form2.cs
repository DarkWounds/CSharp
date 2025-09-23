using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OTI_2025
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            limg.View = View.LargeIcon;
            limg.LargeImageList = imageList1;
            limg.Items.Add("", 2);
            textBox1.ReadOnly = true;
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(tbExploratori.Text);
                if (value < 30 || value > 200)
                {
                    MessageBox.Show("Numarul de exploratori trebuie sa fie intre 30 si 200!");
                    tbExploratori.Text = "";
                    return;
                }
                else
                {
                    Expeditie form3 = new();
                    form3.Show();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nu ati introdus un nr!");
                tbExploratori.Text = "";
            }
        }

        private void TbExploratori_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbExploratori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
