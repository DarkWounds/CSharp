using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTI_2025
{
    public partial class Expeditie : Form
    {
        public Expeditie()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Harta900x600;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
