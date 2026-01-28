using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p48_Paint
{
    public partial class Form1 : Form
    {

        private bool apasat;
        private int grosime;
        /*
         * apasat = true; //apas stanga
         * apasat = false; //altfel
        */
        public Form1()
        {
            InitializeComponent();
            apasat = false;
            grosime = (int)numericUpDown1.Minimum;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { grosime = (int)numericUpDown1.Value; }

        private void Form1_MouseDown(object sender, MouseEventArgs e) { apasat = true; }

        private void Form1_MouseUp(object sender, MouseEventArgs e) { apasat = false; }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (apasat)
            {
                Graphics g = CreateGraphics();
                g.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, grosime, grosime);
            }
        }
    }
}
