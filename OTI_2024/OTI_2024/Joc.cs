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
        Image imgStart = null;
        Image imgStop = null;
        Image imgPauza = null;

        List<PictureBox> inamici = new List<PictureBox>();
        List<PictureBox> naveta = new List<PictureBox>();

        public Joc()
        {
            InitializeComponent();
            KeyDown += Joc_KeyDown;
            this.KeyPreview = true;
            this.FormClosing += Joc_FormClosing;

            imgStart = GrayScaleImg(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Start.png"));
            imgStop = GrayScaleImg(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Stop.png"));
            imgPauza = GrayScaleImg(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Pauza.png"));
            btnPauza.Image = imgPauza;
            btnStop.Image = imgStop;

            timerLansare.Interval = 500; 
            timerLansare.Tick += TimerLansare_Tick;

            timerMiscareNaveta.Interval = 16;
            timerMiscareNaveta.Tick += TimerMiscareNaveta_Tick;

            timerInamici.Interval = 2000;
            timerInamici.Tick += TimerInamici_Tick;

            tMiscareInamici.Interval = 30;
            tMiscareInamici.Tick += TimerMiscare_Tick;

            tIntersectare.Interval = 1;
            tIntersectare.Tick += TIntersectare_Tick;
        }

        private void TIntersectare_Tick(object? sender, EventArgs e)
        {
            List<PictureBox> pb = new List<PictureBox>();
            for (int i = 0; i < naveta.Count; i++)
            {
                for (int j = 0; j < inamici.Count; j++)
                {
                    if (naveta[i].Bounds.IntersectsWith(inamici[j].Bounds))
                    {
                        pb.Add(naveta[i]);
                        pb.Add(inamici[j]);
                    }
                }
            }
            foreach (var x in pb)
            {
                x.Dispose();
                naveta.Remove(x);
                inamici.Remove(x);
            }
        }

        private void TimerMiscareNaveta_Tick(object? sender, EventArgs e)
        {
            foreach (var p in naveta)
                if (p.Location.X < 800)
                    p.Left += 10;
                else p.Dispose();
        }

        private void TimerInamici_Tick(object? sender, EventArgs e)
        {
            Size s = new Size(130, 50);
            Point p = new Point(0, 0);
            if (pornit == 1)
            {
                InitAll(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Inamic.gif"), s, 1, p);
            }
        }

        private void TimerMiscare_Tick(object? sender, EventArgs e)
        {
            foreach(var p in inamici)
                if(p.Location.X > 45)
                    p.Left -= 5;
                else p.Dispose();
        }

        private void TimerLansare_Tick(object? sender, EventArgs e)
        {
            Size s = new Size(50, 50);
            if (pornit == 1)
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(pbNava.Location.X - pbNava.Width/2, pbNava.Location.Y - pbNava.Height/2);
                InitAll(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\rachetaNava.png"), s, 0, p2);
                InitAll(Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\asteroid.png"), s, 1, p1);
            } 
        }

        private void InitAll(Image img, Size s, int i, Point pozNava)
        {
            PictureBox p = new PictureBox();
            p.Image = img;
            p.Size = s;
            p.BackgroundImageLayout = ImageLayout.Stretch;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            int randX = new Random().Next(1, 9);
            int baza = 25;
            int x = 845;
            if(pozNava.X != 0 && pozNava.Y != 0)
                p.Location = new Point(pozNava.X, pozNava.Y);
            else p.Location = new Point(x, baza + randX * 40);
            this.Controls.Add(p);
            p.BackColor = Color.Black;
            p.BringToFront();
            if (i == 1) inamici.Add(p);
            else naveta.Add(p);
        }

        private Image GrayScaleImg(Image img)
        {
            int a, r, g, b;
            int med;
            Color p;
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    p = bmp.GetPixel(j, i);
                    a = p.A;
                    r = p.R;
                    g = p.G;
                    b = p.B;
                    med = (r + g + b) / 3;

                    bmp.SetPixel(j, i, Color.FromArgb(a, med, med, med));
                }
            }
            return (Image)bmp;
        }

        private void Joc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Joc_KeyDown(object sender, KeyEventArgs e)
        {
            if (pornit == 1)
            {
                if (e.KeyCode == Keys.W && pbNava.Location.Y - pbNava.Height / 2 >= 88)
                {
                    pbNava.Top -= (pbNava.Height / 2);
                }
                if (e.KeyCode == Keys.S && pbNava.Location.Y + pbNava.Height / 2 <= 530)
                {
                    pbNava.Top += (pbNava.Height / 2);
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
            pornit = 1;
            btnStart.Image = imgStart;
            btnPauza.Image = Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Pauza.png");
            btnStop.Image = Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Stop.png");
            
            tIntersectare.Start();
            timerMiscareNaveta.Start();
            timerLansare.Start();
            timerInamici.Start();
            tMiscareInamici.Start();
        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            btnPauza.Image = imgPauza;
            btnStop.Image = imgStop;
            btnStart.Image = Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Start.png");
            pornit = 0;

            tIntersectare.Stop();
            timerMiscareNaveta.Stop();
            timerLansare.Stop();
            timerInamici.Stop();
            tMiscareInamici.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Image = imgStop;
            btnStart.Image = Image.FromFile("D:\\C-Start\\OJTI_2024_C#_Resurse\\Start.png");
            pornit = 0;

            tIntersectare.Stop();
            timerMiscareNaveta.Stop();
            timerLansare.Stop();
            timerInamici.Stop();
            tMiscareInamici.Stop();
            inamici.Clear();
            naveta.Clear();
        }
    }
}
