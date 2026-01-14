using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p44_Button
{
    public partial class Form1 : Form
    {
        private int n; //nr butoane
        public Form1()
        {
            InitializeComponent();
            n = 1;
            IncarcaButoane();
        }

        public void IncarcaButoane()
        {
            gbButoane.Controls.Clear();
            gbButoane.Text = n + " butoane";
            int D = 100;
            int x = 60;
            for (int i = 0; i < n; i++)
            {
                Button b = new Button();
                b.Size = new Size(D,D);
                b.Show();
                b.Location = new Point(x + i * D, x);
                b.Tag = i + 1;
                b.Text = (i+1).ToString();
                gbButoane.Controls.Add(b);
            }
        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {
            n = (int)nUpDown.Value;
            IncarcaButoane();
        }
    }
}
