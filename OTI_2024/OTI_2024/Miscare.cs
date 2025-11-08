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

namespace OTI_2024
{
    public partial class Miscare : Form
    {
        List<Point> p = new List<Point>();
        double currentAngle = 0; // Unghiul curent în radiani
        double speed = 0.02; // Viteza de rotație (radiani pe tick)
        int cerc = 0;
        int startVerif = 0;

        //int R1 = 152;
        //int R2 = 147;
        //x = R1· cos α  
        //y = R2· sin α

        int R1 = 300;
        int R2 = 200;
        Point pCentru = new Point();

        public Miscare()
        {
            InitializeComponent();
            timerVerif.Start();
            timerVerif.Interval = 16;
            pbSoare.Size = new Size(100, 100);
            pCentru.X = (pbSoare.Location.X) + pbSoare.Width / 2;
            pCentru.Y = (pbSoare.Location.Y) + pbSoare.Height / 2;
            this.Paint += Miscare_Paint;
            this.DoubleBuffered = true;
            this.FormClosing += Miscare_FormClosing;
        }

        private void InitializareAnimatie()
        {
            animationTimer.Interval = 16; // ~60 FPS (16ms ≈ 1000ms/60)
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void DrawLine()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            Point p = new Point();
            p.X =pbPamant.Location.X + pbPamant.Width / 2;
            p.Y = pbPamant.Location.Y + pbPamant.Height / 2;
            g.DrawLine(pen, pCentru, p);

            this.Invalidate();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            DrawLine();
            // Incrementează unghiul
            currentAngle += speed;

            // Resetează unghiul după o rotație completă (2π)
            if (currentAngle >= 2 * Math.PI)
                currentAngle = 0;

            // Calculează noua poziție folosind formulele parametrice
            // x = R1 * cos(α)
            // y = R2 * sin(α)
            int newX = pCentru.X + (int)(R1 * Math.Cos(currentAngle));
            int newY = pCentru.Y + (int)(R2 * Math.Sin(currentAngle));

            // Ajustează pentru a centra PictureBox-ul pe elipsă
            pbPamant.Location = new Point(newX - pbPamant.Width / 2, newY - pbPamant.Height / 2);

            if (cerc == 0)
                this.Invalidate();
        }

        void Miscare_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);
            g.DrawEllipse(p, pCentru.X - R1, pCentru.Y - R2, 2 * R1, 2 * R2);
        }

        public void Miscare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Miscare_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!animationTimer.Enabled)
                    InitializareAnimatie();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
            animationTimer.Tick -= AnimationTimer_Tick;
        }
    }
}
