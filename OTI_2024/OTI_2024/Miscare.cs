using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        double speed = 0.0107; // Viteza de rotație (radiani pe tick)
        double speedLuna = (0.04918); // Viteza de rotație a lunii (radiani pe tick)
        double angleLuna = 0;
        int cerc = 0;
        int startVerif = 0;

        //x = R1· cos α  
        //y = R2· sin α

        int R1 = 150;
        int R2 = (int)(150 * Math.Sqrt(1-0.17*0.17));

        int R2Luna = (int)(147/4);
        int R1Luna = (int)(147/4 * Math.Sqrt(1 - 0.17 * 0.17));
        int zi = 3,  an = 2024;
        string luna = " ianuarie ";

        int secundeData = 0;

        //int R1 = 300;
        //int R2 = (int)(300 * (0.98544)) / 2;

        Point pCentruSoare = new Point();
        Point pCentruPamant = new Point();

        // Adaugă variabilă pentru a număra secundele
        private int secundeTrecute = 0;

        public Miscare()
        {
            InitializeComponent();
            pbSoare.Size = new Size(50, 50);
            rtbAnotimp.Text = " iarna ";
            rtbDistanta.Text = "147000000 km";
            rtbData.Text = zi + luna + an;
            pCentruSoare.X = (pbSoare.Location.X) + pbSoare.Width / 2;
            pCentruSoare.Y = (pbSoare.Location.Y) + pbSoare.Height / 2;

            pbPamant.Location = new Point(pCentruSoare.X + R1 - pbPamant.Width / 2, pCentruSoare.Y - pbPamant.Height / 2);
            pbLuna.Location = new Point(pbPamant.Location.X + R1Luna - pbLuna.Width / 2, pbPamant.Location.Y - pbLuna.Height / 2);

            this.Paint += Miscare_Paint;
            this.DoubleBuffered = true;
            this.FormClosing += Miscare_FormClosing;
        }

        private void InitializareAnimatie()
        {
            animationTimer.Interval = 16; // ~60 FPS
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
            
            // Timer separat pentru secunde
            timerVerif.Interval = 1000; // 1 secundă
            timerVerif.Tick += TimerVerif_Tick;
            timerVerif.Start();
            
            // Timer data
            timerData.Interval = 46; // 
            timerData.Tick += TimerData_Tick;
            timerData.Start();


            // Resetează contorul
            //secundeTrecute = 0;
        }

        private void TimerData_Tick(object sender, EventArgs e)
        {


            if (zi == 31 && luna == " ianuarie ")
            {
                zi = 1;
                luna = " februarie ";
            }
            else if (zi == 28 && luna == " februarie ")
            {
                zi = 1;
                luna = " martie ";
                rtbAnotimp.Text = " primăvara ";
            }
            else if (zi == 31 && luna == " martie ")
            {
                zi = 1;
                luna = " aprilie ";
            }
            else if (zi == 30 && luna == " aprilie ")
            {
                zi = 1;
                luna = " mai ";
            }
            else if (zi == 31 && luna == " mai ")
            {
                zi = 1;
                luna = " iunie ";
                rtbAnotimp.Text = " vara ";
            }
            else if (zi == 30 && luna == " iunie ")
            {
                zi = 1;
                luna = " iulie ";
            }
            else if (zi == 31 && luna == " iulie ")
            {
                zi = 1;
                luna = " august ";
            }
            else if (zi == 31 && luna == " august ")
            {
                zi = 1;
                luna = " septembrie ";
                rtbAnotimp.Text = " toamna ";
            }
            else if (zi == 30 && luna == " septembrie ")
            {
                zi = 1;
                luna = " octombrie ";
            }
            else if (zi == 31 && luna == " octombrie ")
            {
                zi = 1;
                luna = " noiembrie ";
            }
            else if (zi == 30 && luna == " noiembrie ")
            {
                zi = 1;
                luna = " decembrie ";
                rtbAnotimp.Text = " iarna ";
            }
            else if (zi == 31 && luna == " decembrie ")
            {
                zi = 1;
                luna = " iarna ";
                an++;
            }
            else
            {
                zi++;
            }

            rtbData.Text = zi + luna + an;
            
        }

        private void TimerVerif_Tick(object sender, EventArgs e)
        {
            
        }

        private void DrawLine(PictureBox pb, Pen pen, Point pcentru)
        {
            Graphics g = this.CreateGraphics();
            Point p1 = new Point();
            p1.X = pb.Location.X + pb.Width / 2;
            p1.Y = pb.Location.Y + pb.Height / 2;
            g.DrawLine(pen, pcentru, p1);

            this.Invalidate();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Desenare linie
            Pen pen = new Pen(Color.Red, 2);
            DrawLine(pbPamant, pen, pCentruSoare);
            pen = new Pen(Color.Yellow, 2);

            // Distanța Soare - Pământ
            double distanta = Math.Sqrt(Math.Pow(pbPamant.Location.X - pbSoare.Location.X, 2)
                + Math.Pow(pbPamant.Location.Y - pbSoare.Location.Y, 2));

            distanta *= 1000000;
            rtbDistanta.Text = Math.Round(distanta).ToString() + " km";

            pCentruPamant.X = (pbPamant.Location.X) + pbPamant.Width / 2;
            pCentruPamant.Y = (pbPamant.Location.Y) + pbPamant.Height / 2;

            DrawLine(pbLuna, pen, pCentruPamant);

            // Incrementează unghiul
            currentAngle -= speed;
            angleLuna -= speedLuna;

            // Resetează unghiul după o rotație completă (2π)
            if (currentAngle <= -2 * Math.PI)
            { 
                currentAngle = 0;
                //rtbData.Text = secundeTrecute + "";
            }
                

            if(angleLuna <= -2 * Math.PI)
                angleLuna = 0;

            // Calculează noua poziție
            int newX = pCentruSoare.X + (int)(R1 * Math.Cos(currentAngle));
            int newY = pCentruSoare.Y + (int)(R2 * Math.Sin(currentAngle));

            int newXLuna = pCentruPamant.X + (int)(R1Luna * Math.Cos(2 * angleLuna));
            int newYLuna = pCentruPamant.Y + (int)(R2Luna * Math.Sin(2 * angleLuna));

            // Ajustează pentru a centra PictureBox-ul pe elipsă
            pbPamant.Location = new Point(newX - pbPamant.Width / 2, newY - pbPamant.Height / 2);
            pbLuna.Location = new Point(newXLuna - pbLuna.Width / 2, newYLuna - pbLuna.Height / 2);

            if (cerc == 0)
                this.Invalidate();
        }

        void Miscare_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);
            g.DrawEllipse(p, pCentruSoare.X - R1, pCentruSoare.Y - R2, 2 * R1, 2 * R2);

            p = new Pen(Color.Green, 3);
            g.DrawEllipse(p, pCentruPamant.X - R1Luna, pCentruPamant.Y - R2Luna, 2 * R1Luna, 2 * R2Luna);
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
            
            timerVerif.Stop();
            timerVerif.Tick -= TimerVerif_Tick;

            timerData.Stop();
            timerData.Tick -= TimerData_Tick;
        }
    }
}
