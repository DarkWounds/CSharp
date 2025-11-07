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
    public partial class Miscare : Form
    {
        List<Point> p = new List<Point>();
        //int R1 = 152;
        //int R2 = 147;
        int R1 = 300;
        int R2 = 200;
        Point pCentru = new Point();

        public Miscare()
        {
            InitializeComponent();
            pbSoare.Size = new Size(100, 100);
            pCentru.X = (pbSoare.Location.X) + pbSoare.Width/2;
            pCentru.Y = (pbSoare.Location.Y) + pbSoare.Height/2;
            this.Paint += Miscare_Paint;
            this.DoubleBuffered = true;
            this.FormClosing += Miscare_FormClosing;
        }

        void Miscare_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);
            g.DrawEllipse(p, pCentru.X - R1, pCentru.Y - R2,  2*R1, 2*R2);
        }


        public void Miscare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Miscare_Load(object sender, EventArgs e)
        {

        }
    }
}
