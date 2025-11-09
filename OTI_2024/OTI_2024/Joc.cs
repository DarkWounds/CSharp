using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTI_2024
{
    public partial class Joc : Form
    {
        int pornit = 0;
        public Joc()
        {
            InitializeComponent();
            KeyDown += Joc_KeyDown;
            this.KeyPreview = true;
            this.FormClosing += Joc_FormClosing;
        }

        private void Joc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Joc_KeyDown(object sender, KeyEventArgs e)
        {
            if (pornit == 1)
            {
                if (e.KeyCode == Keys.W && pbNava.Location.Y - pbNava.Height >= 88)
                {
                    pbNava.Top -= pbNava.Height;
                }
                if (e.KeyCode == Keys.S && pbNava.Location.Y + pbNava.Height <= 538)
                {
                    pbNava.Top += pbNava.Height;
                }
                if (e.KeyCode == Keys.A && pbNava.Location.X - pbNava.Width >= 43)
                {
                    pbNava.Left -= pbNava.Width;
                }
                if (e.KeyCode == Keys.D && pbNava.Location.X + pbNava.Width <= 775)
                {
                    pbNava.Left += pbNava.Width;
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pornit == 1)
            {
                pornit = 0;
                Image img = Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Start");
                btnStart.Image = img;
            }
        }
    }
}
