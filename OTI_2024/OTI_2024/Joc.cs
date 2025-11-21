using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic;
using System.IO;
using NAudio.Wave;

namespace OTI_2024
{
    public partial class Joc : Form
    {
        int pornit = 0;
        Image imgStart = null;
        Image imgStop = null;
        Image imgPauza = null;
        string pathbaza = null;
        Keys last = Keys.None;

        List<PictureBox> inamici = new List<PictureBox>();
        List<PictureBox> naveta = new List<PictureBox>();

        List<AudioFileReader> sunete = new List<AudioFileReader>();
        WaveOutEvent outputDevice = new WaveOutEvent();

        Image imgNavaStop, imgNavaUp, imgNavaDown, imgNavaMove, imgNavaFire, imgInamic, imgAsteroid, imgViata;

        public Joc()
        {
            InitializeComponent();
            FindPath();
            sunete.Add(new AudioFileReader(pathbaza + "sunetFundal.mp3"));
            outputDevice.Init(sunete[0]);
            KeyDown += Joc_KeyDown;
            KeyUp += Joc_KeyUp;
            outputDevice.Volume = 1f;
            this.KeyPreview = true;
            this.FormClosing += Joc_FormClosing;
            pbNava.SizeMode = PictureBoxSizeMode.StretchImage;

            imgInamic = Image.FromFile(pathbaza + "Inamic.gif");
            imgViata = Image.FromFile(pathbaza + "viata.gif");
            imgAsteroid = Image.FromFile(pathbaza + "asteroid.png");

            imgNavaStop = Image.FromFile(pathbaza + "navaStop.png");
            imgNavaUp = Image.FromFile(pathbaza + "navaUp.png");
            imgNavaDown = Image.FromFile(pathbaza + "navaDown.png");
            imgNavaMove = Image.FromFile(pathbaza + "navaMove.png");
            imgNavaFire = Image.FromFile(pathbaza + "navaFire.png");
            pbNava.Image = imgNavaStop;

            imgStart = GrayScaleImg(Image.FromFile(pathbaza + "Start.png"));
            imgStop = GrayScaleImg(Image.FromFile(pathbaza + "Stop.png"));
            imgPauza = GrayScaleImg(Image.FromFile(pathbaza + "Pauza.png"));
            btnPauza.Image = imgPauza;
            btnStop.Image = imgStop;
            InitTimere(0);
        }

        private void InitTimere(int i)
        {
            timerAsteroizi.Interval = 1000;
            timerMiscareNaveta.Interval = 16;
            timerInamici.Interval = 2000;
            tMiscareInamici.Interval = 30;
            tIntersectare.Interval = 4;
            timerViata.Interval = 7000;

            if (i != 0)
            {
                timerViata.Tick += TimerViata_Tick;
                timerAsteroizi.Tick += TimerAsteroizi_Tick;
                timerMiscareNaveta.Tick += TimerMiscareNaveta_Tick;
                timerInamici.Tick += TimerInamici_Tick;
                tMiscareInamici.Tick += TimerMiscare_Tick;
                tIntersectare.Tick += TIntersectare_Tick;

                timerViata.Start();
                timerAsteroizi.Start();
                tIntersectare.Start();
                timerMiscareNaveta.Start();
                timerInamici.Start();
                tMiscareInamici.Start();
            }
            else
            {
                timerViata.Tick -= TimerViata_Tick;
                timerAsteroizi.Tick -= TimerAsteroizi_Tick;
                timerMiscareNaveta.Tick -= TimerMiscareNaveta_Tick;
                timerInamici.Tick -= TimerInamici_Tick;
                tMiscareInamici.Tick -= TimerMiscare_Tick;
                tIntersectare.Tick -= TIntersectare_Tick;

                timerViata.Stop();
                timerAsteroizi.Stop();
                tIntersectare.Stop();
                timerMiscareNaveta.Stop();
                timerInamici.Stop();
                tMiscareInamici.Stop();
            }
        }

        private void PlayOnce(string filePath)
        {
            var reader = new AudioFileReader(filePath);
            var player = new WaveOutEvent();

            player.Init(reader);

            player.PlaybackStopped += (s, e) =>
            {
                player.Dispose();
                reader.Dispose();
            };

            player.Play();
        }

        private void FindPath()
        {
            string s = Directory.GetCurrentDirectory();
            pathbaza = s + "\\Resurse\\";
        }

        private void TimerViata_Tick(object? sender, EventArgs e)
        {
            Size s = new Size(50, 20);
            Point p = new Point(0, 0);
            if (pornit == 1)
            {
                InitAll(imgViata, s, 1, p);
            }
        }

        private void TimerAsteroizi_Tick(object? sender, EventArgs e)
        {
            Size s = new Size(10, 10);
            Point p = new Point(0, 0);
            if (pornit == 1)
            {
                InitAll(imgAsteroid, s, 1, p);
            }
        }

        private void TIntersectare_Tick(object? sender, EventArgs e)
        {
            var inamiciStergere = new HashSet<PictureBox>();
            var stergereGenerala = new HashSet<PictureBox>();

            // Verificare coliziuni rachete cu inamici
            for (int i = naveta.Count - 1; i >= 0; i--)
            {
                var rocket = naveta[i];
                for (int j = inamici.Count - 1; j >= 0; j--)
                {
                    var enemy = inamici[j];
                    if (rocket.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        if (enemy.Image == imgInamic)
                            PlayOnce(pathbaza + "sunetDistrugere.mp3");
                        stergereGenerala.Add(rocket);
                        inamiciStergere.Add(enemy);
                        break;
                    }
                }
            }

            // Verificare coliziuni inamici cu nava
            for (int j = inamici.Count - 1; j >= 0; j--)
            {
                var enemy = inamici[j];
                if (pbNava.Bounds.IntersectsWith(enemy.Bounds))
                {
                    if (enemy.Image != imgViata)
                    {
                        stergereGenerala.Add(enemy);
                        int vieti = (int.Parse(tbScor.Text) - 1);
                        if (vieti >= 0)
                            tbScor.Text = vieti + "";
                        else
                        {
                            outputDevice.Pause();
                            btnPauza.Image = imgPauza;
                            btnStop.Image = imgStop;
                            btnStart.Image = Image.FromFile(pathbaza + "Start.png");
                            InitTimere(0);
                            pornit = 0;
                            last = Keys.None;
                            pbNava.Image = imgNavaStop;
                        }
                    }
                    else
                    {
                        stergereGenerala.Add(enemy);
                        PlayOnce(pathbaza + "sunetBonus.mp3");
                        tbScor.Text = (int.Parse(tbScor.Text) + 1) + "";
                    }
                }
            }

            foreach (var p in stergereGenerala)
            {
                inamici.Remove(p);
                this.Controls.Remove(p);
                p.Dispose();
            }

            foreach (var p in inamiciStergere)
            {
                inamici.Remove(p);
                this.Controls.Remove(p);
                p.Dispose();
                tbScor.Text = (int.Parse(tbScor.Text) + 1) + "";
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
            Size s = new Size(90, 30);
            Point p = new Point(0, 0);
            if (pornit == 1)
            {
                InitAll(imgInamic, s, 1, p);
            }
        }

        private void TimerMiscare_Tick(object? sender, EventArgs e)
        {
            foreach (var p in inamici)
                if (p.Location.X > 45)
                    p.Left -= 5;
                else p.Dispose();
        }

        private void InitAll(Image img, Size s, int i, Point pozNava)
        {
            PictureBox p = new PictureBox();
            int[] poz = { 0, 107, 147, 187, 227, 267, 307, 347, 387, 427, 467 };
            p.Image = img;
            p.Size = s;
            p.BackgroundImageLayout = ImageLayout.Stretch;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            int randX = new Random().Next(1, 10);
            int baza = 22;
            int x = 845;
            if (pozNava.X != 0 && pozNava.Y != 0)
                p.Location = new Point(pozNava.X + 23, pozNava.Y + 44);
            else p.Location = new Point(x, poz[randX]);
            this.Controls.Add(p);
            p.BackColor = Color.Black;
            p.BringToFront();
            pbNava.BringToFront();
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

        private void Joc_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Joc_KeyDown(object sender, KeyEventArgs e)
        {
            if (pornit == 1)
            {
                if (e.KeyCode == Keys.Space)
                {
                    last = Keys.Space;
                    PlayOnce(pathbaza + "sunetFire.mp3");
                    pbNava.Image = imgNavaFire;
                    Size s = new Size(10, 10);
                    if (pornit == 1)
                    {
                        Point p = new Point(pbNava.Location.X - pbNava.Width / 2, pbNava.Location.Y - pbNava.Height / 2);
                        InitAll(Image.FromFile(pathbaza + "rachetaNava.png"), s, 0, p);
                    }
                }
                if (e.KeyCode == Keys.W && pbNava.Location.Y - 20 >= 85)
                {
                    last = Keys.W;
                    pbNava.Image = imgNavaUp;
                    pbNava.Top -= 20;
                }
                else if (e.KeyCode == Keys.S && pbNava.Location.Y + 20 <= 500)
                {
                    last = Keys.S;
                    pbNava.Image = imgNavaDown;
                    pbNava.Top += 20;
                }
                else if (e.KeyCode == Keys.A && pbNava.Location.X - 20 >= 43)
                {
                    last = Keys.A;
                    pbNava.Image = imgNavaMove;
                    pbNava.Left -= 20;
                }
                else if (e.KeyCode == Keys.D && pbNava.Location.X + 20 <= 775)
                {
                    last = Keys.D;
                    pbNava.Image = imgNavaMove;
                    pbNava.Left += 20;
                }
            }
            pbNava.Refresh();
        }

        private void Joc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == last)
            {
                last = Keys.None;
                pbNava.Image = imgNavaStop;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pornit != 1)
            {
                outputDevice.Play();
                pornit = 1;
                btnStart.Image = imgStart;
                btnPauza.Image = Image.FromFile(pathbaza + "Pauza.png");
                btnStop.Image = Image.FromFile(pathbaza + "Stop.png");
                InitTimere(1);
            }
        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            if (pornit == 1)
            {
                outputDevice.Pause();
                btnPauza.Image = imgPauza;
                btnStop.Image = imgStop;
                btnStart.Image = Image.FromFile(pathbaza + "Start.png");
                InitTimere(0);
                pornit = 0;
                last = Keys.None;
                pbNava.Image = imgNavaStop;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (pornit == 1)
            {
                //MessageBox.Show();
                /*
                btnStop.Image = imgStop;
                btnStart.Image = Image.FromFile(pathbaza + "Start.png");
                InitTimere(0);
                tbScor.Text = 0 + "";
                tbVieti.Text = 3 + "";
                foreach (var p in inamici)
                    p.Dispose();
                foreach (var p in naveta)
                    p.Dispose();
                inamici.Clear();
                naveta.Clear();
                pbNava.Location = new Point(50, 296);
                pbNava.Image = imgNavaStop;
                last = Keys.None;
                pornit = 2;
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = new WaveOutEvent();
                outputDevice.Volume = 0.5f;
                outputDevice.Init(sunete[0]);*/
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {

        }

        private void vSlide_Load(object sender, EventArgs e)
        {
            //if(outputDevice.Volume + vSlide.Volume > 0f)
             //   outputDevice.Volume += vSlide.Volume;
        }
    }
}
