using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace OTI_2025
{
    public partial class Expeditie : Form
    {
        int exploratori = 0, hrana = 0, bogatii = 0, incTotala = 0;
        int exploratoriInitiali = 0;
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 0);
        int zile = 100;
        int[,] a;

        List<(Point, Point)> pointsPaint = new List<(Point, Point)>();
        public ArrayList distanteInsule = new ArrayList();
        public ArrayList nume = new ArrayList();

        Locatii pozBarca;

        public void ListaNume(ListBox t)
        {
            for (int i = 0; i < nume.Count; i++)
            {
                int x = ((Locatii)nume[i]).id;
                if(x >= 2 && x <= 7)
                    t.Items.Add(insula[x].nume);
            }
        }

        struct Locatii
        {
            public int x;
            public int y;
            public int id;
        }

        public struct insule
        {
            public int id;
            public int x;
            public int y;
            public string nume;
            public int bogatii;
            public int virusi;
            public string descriere;
            public int viz;
        };

        struct distante
        {
            public int dist;
            public int x;
            public int y;
        };

        insule[] insula = new insule[12];

        public void SelectareInsulaSalvare(string name)
        {
            ArrayList temporar = new ArrayList();
            int i = 0;
            int p = ((Locatii)nume[i]).id;
            for (i = 0; i < nume.Count && insula[p].nume != name; i++)
            {
                p = ((Locatii)nume[i]).id;
                temporar.Add(nume[i]);
            }
            nume = temporar;
        }

        public void MutareBarca(string name)
        {
            for (int i = 0; i < nume.Count; i++)
            {
                int p = ((Locatii)nume[i]).id;
                if (insula[p].nume != name)
                {
                    int x = insula[p].x;
                    int y = insula[p].y;
                    start.Location = new Point(x, y);
                }

            }
        }

        public Bitmap DeseneazaTraseuPeHarta()
        {
            // Creează un bitmap nou cu dimensiunile hărții
            Bitmap bitmap = new Bitmap(900, 600);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Desenează harta de fundal
                g.DrawImage(Properties.Resources.Harta900x600, 0, 0, 900, 600);

                // Desenează liniile verzi ale traseului
                using (Pen greenPen = new Pen(Color.Green, 3))
                {
                    foreach (var line in pointsPaint)
                    {
                        g.DrawLine(greenPen, line.Item1, line.Item2);
                    }
                }

                // Desenează distanțele
                using (Brush transparentBrush = new SolidBrush(Color.FromArgb(128, Color.Black)))
                {
                    foreach (var d in distanteInsule)
                    {
                        int x = ((distante)d).x;
                        int y = ((distante)d).y;
                        int dist = ((distante)d).dist;
                        g.DrawString(dist + " km ", new Font("Arial", 16, FontStyle.Bold), transparentBrush, new PointF(x, y));
                    }
                }

                // Desenează numele insulelor
                using (Brush transparentBrush = new SolidBrush(Color.FromArgb(128, Color.Black)))
                {
                    foreach (var d in nume)
                    {
                        int x = ((Locatii)d).x;
                        int y = ((Locatii)d).y;
                        string numeInsula = insula[((Locatii)d).id].nume;
                        g.DrawString(numeInsula, new Font("Arial", 16, FontStyle.Bold), transparentBrush, new PointF(x, y));
                    }
                }

                // Desenează imaginile insulelor
                ImgInsule();
                for (int i = 2; i <= 11; i++)
                {
                        Bitmap insulaImg = GetInsulaImage(i);
                        if (insulaImg != null 
                        && insula[i].x != pozBarca.x && insula[i].y != pozBarca.y)
                       {
                           g.DrawImage(insulaImg, insula[i].x, insula[i].y, 50, 50);
                       }
                }
                g.DrawImage(start.Image, pozBarca.x, pozBarca.y, 50, 50);
            }
            return bitmap;
        }

        public Bitmap GetInsulaImage(int x)
        {
            string id = x.ToString();
            string s = "pictureBox" + id;
            PictureBox pb = this.Controls.Find(s, true).FirstOrDefault() as PictureBox;
            Bitmap bitmap = new Bitmap(pb.Image);
            return bitmap;
        }


        public void SalvareImagine()
        {
            //pictureBoxBack.Image.Save("D:\\C-Start\\OJTI_2025_C#_Resurse\\harta_modificata.png");
            Bitmap bitmap = DeseneazaTraseuPeHarta();
            string path = @"D:\C-Start\OJTI_2025_C#_Resurse\harta_modificata.png";
            bitmap.Save(path);
        }

        public void PictureBoxBack_Paint(object sender, PaintEventArgs e)
        {
            using (Pen greenPen = new Pen(Color.Green, 3))
            {
                foreach (var line in pointsPaint)
                {
                    e.Graphics.DrawLine(greenPen, line.Item1, line.Item2);
                }
            }

            using (Brush transparentBrush = new SolidBrush(Color.FromArgb(128, Color.Black)))
            {
                foreach(var d in distanteInsule)
                {
                    int x = ((distante)d).x;
                    int y = ((distante)d).y;
                    int dist = ((distante)d).dist;
                    e.Graphics.DrawString(dist + " km ", new Font("Arial", 16, FontStyle.Bold), transparentBrush, new PointF(x, y));
                }
            }

            using (Brush transparentBrush = new SolidBrush(Color.FromArgb(128, Color.Black)))
            {
                foreach (var d in nume)
                {
                    int x = ((Locatii)d).x;
                    int y = ((Locatii)d).y;
                    string nume = insula[((Locatii)d).id].nume;
                    e.Graphics.DrawString(nume, new Font("Arial", 16, FontStyle.Bold), transparentBrush, new PointF(x, y));
                }
            }
        }

        public int GetExploratori()
        {
            return exploratoriInitiali;
        }

        public Expeditie(int exploratori)
        {
            InitializeComponent();
            InitializareTotala(exploratori);
            this.KeyPreview = true;
            this.KeyDown += Expeditie_KeyDown;
        }

        public void Expeditie_Closed(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Expeditie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.Visible = false;
                Save saveForm = new Save(this);
                saveForm.Visible = true;
            }
        }

        public void AllActions(object sender)
        {
            string name = "";
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                name = pb.Name;
            }
            int i = int.Parse(name.Substring(10));
            if (insula[i].viz == 0)
            {
                insula[i].viz = 1;
                Pen greenPen = new Pen(Color.Green, 3);
                p1 = new Point(pozBarca.x, pozBarca.y);
                p2 = new Point(insula[i].x, insula[i].y);
                distante d;
                d.dist = (int)a[i, pozBarca.id];
                int zil = d.dist / 100;
                int hrn = 2 * exploratori * zil;
                hrana -= hrn;
                if(hrana < 0)
                {
                    MessageBox.Show("Esuat, hrana insuficienta!");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Close();
                    return;
                    
                }
                MessageBox.Show("Ai navigat " + zil + " zile si ai consumat " + hrn + " kg");
                d.x = (pozBarca.x + insula[i].x) / 2;
                d.y = (pozBarca.y + insula[i].y) / 2;
                distanteInsule.Add(d);
                pointsPaint.Add((p1, p2));
                this.Invalidate();
                pozBarca.x = insula[i].x;
                pozBarca.y = insula[i].y;
                pozBarca.id = insula[i].id;
                start.Location = new Point(pozBarca.x, pozBarca.y);
                if (insula[i].id >= 2 && insula[i].id <= 7)
                {
                    hrn = 2 * exploratori * zile;
                    int incTot = hrn + 90 * exploratori + bogatii;
                    hrana = 2 * exploratori * zile;
                    if (incTot > 100 * 1000)
                    {
                        incTotala = 100 * 1000;
                        bogatii = incTotala - hrana - 90 * exploratori;
                    }
                    else incTotala = incTot;
                }
                listView1.Items[3].Text = "hrana " + hrana + "kg";
                listView1.Items[0].Text = "incarcatura " + incTotala / 1000 + " t";
                listView1.Items[1].Text = "bogatii " + bogatii + " kg";
                int bgt = 0;
                if (insula[i].bogatii > 0)
                {
                    Random r = new Random();
                    bgt = r.Next(10, 101);
                    int val = 0;
                    if (incTotala + bgt * 1000 < 100 * 1000)
                    {
                        val = bgt;
                        bogatii += (bgt * 1000);
                    }
                    else
                    {
                        bogatii += (100 * 1000 - incTotala);
                        val = (100 * 1000 - incTotala) / 1000;
                        incTotala = 100 * 1000;
                    }
                    MessageBox.Show(insula[i].descriere + "\n" + "Pe insula sunt " + bgt 
                        + " tone de bogatii" + "\n" + "Exploratorii incarca " + val + " tone de bogatii");
                }
                listView1.Items[3].Text = "hrana " + hrana + " kg";
                listView1.Items[0].Text = "incarcatura " + incTotala / 1000 + " t";
                listView1.Items[1].Text = "bogatii " + bogatii + " kg";
                if(insula[i].virusi > 0 && insula[i].id >= 8 && insula[i].id <= 11 )
                {
                   exploratori /= 2;
                    if(exploratori < 30)
                    {
                        MessageBox.Show("Esuat, prea putini exploratori!");
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Close();
                        return;
                    }
                    else incTotala = hrana + 90 * exploratori + bogatii;
                }
                listView1.Items[3].Text = "hrana " + hrana + " kg";
                listView1.Items[2].Text = "exploratori" + exploratori;
                listView1.Items[0].Text = "incarcatura " + incTotala / 1000 + " t";
                listView1.Items[1].Text = "bogatii " + bogatii + " kg";
                Locatii numeInsule;
                numeInsule.x = insula[i].x;
                numeInsule.y = insula[i].y - 20;
                numeInsule.id = insula[i].id;
                nume.Add(numeInsule);
            }
            else MessageBox.Show("Interzi!");
        }

        public void ImgInsule()
        {
            PictureBox[] pBox = { start, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11 };
            foreach (var pb in pBox)
            {
                pb.Parent = pictureBoxBack;
                pb.BackColor = Color.Transparent;
                pb.Size = new Size(50, 50);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            start.Image = Properties.Resources.barca1;
            pictureBox2.Image = Properties.Resources.insula2;
            pictureBox3.Image = Properties.Resources.insula3;
            pictureBox4.Image = Properties.Resources.insula4;
            pictureBox5.Image = Properties.Resources.insula5;
            pictureBox6.Image = Properties.Resources.insula6;
            pictureBox7.Image = Properties.Resources.insula7;
            pictureBox8.Image = Properties.Resources.insula8;
            pictureBox9.Image = Properties.Resources.insula9;
            pictureBox10.Image = Properties.Resources.insula10;
            pictureBox11.Image = Properties.Resources.insula11;
        }

        public void Insule(insule[] ins)
        {
            string path = @"D:\C-Start\OJTI_2025_C#_Resurse\insule.txt";
            int i = 1;
            try
            {
                StreamReader insuleInfo = new StreamReader(path);
                string linie;
                linie = insuleInfo.ReadLine();
                while ((linie = insuleInfo.ReadLine()) != null)
                {
                    string[] date = linie.Split('#');
                    ins[i].id = int.Parse(date[0]);
                    ins[i].nume = date[1];
                    ins[i].x = int.Parse(date[2]);
                    ins[i].y = int.Parse(date[3]);
                    ins[i].bogatii = int.Parse(date[4]);
                    ins[i].virusi = int.Parse(date[5]);
                    ins[i].descriere = date[6];
                    ins[i].viz = 0;
                    if (i == 1)
                    {
                        pozBarca.x = ins[i].x;
                        pozBarca.y = ins[i].y;
                        pozBarca.id = ins[i].id;
                    }
                    i++;
                }
                insuleInfo.Close();
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului insule.txt:\n");
            }

            a = new int[i + 1, i + 1];
            for (int x = 0; x <= i; x++)
                for (int y = 0; y <= i; y++)
                    a[x, y] = 0;

            string path2 = @"D:\C-Start\OJTI_2025_C#_Resurse\distante.txt";
            try
            {
                StreamReader insuleInfo2 = new StreamReader(path2);
                string linie;
                i = 1;
                linie = insuleInfo2.ReadLine();
                while ((linie = insuleInfo2.ReadLine()) != null)
                {
                    string[] date = linie.Split('#');
                    for (int j = 1; j < i; j++)
                        if (i != j)
                        {
                            a[i, j] = int.Parse(date[j]);
                            a[j, i] = a[i, j];
                        } 
                        else
                            a[i, j] = 0;
                    i++;
                }
                insuleInfo2.Close();
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului insule.txt:\n");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.BackColor = TransparencyKey;
            hrana = 2 * exploratori * zile;
            incTotala = (hrana + 90 * exploratori + bogatii);
            listView1.Items.Add(new ListViewItem("incarcatura " + incTotala/1000 + " t", 0));
            listView1.Items.Add(new ListViewItem("bogatii " + bogatii + " kg", 1));
            listView1.Items.Add(new ListViewItem("explorator " + exploratori, 2));
            listView1.Items.Add(new ListViewItem("hrana " + hrana + " kg", 3));
        }

        public void InitializareInsule()
        {
            pictureBox1.Location = new Point(insula[1].x, insula[1].y);
            pictureBox2.Location = new Point(insula[2].x, insula[2].y);
            pictureBox3.Location = new Point(insula[3].x, insula[3].y);
            pictureBox4.Location = new Point(insula[4].x, insula[4].y);
            pictureBox5.Location = new Point(insula[5].x, insula[5].y);
            pictureBox6.Location = new Point(insula[6].x, insula[6].y);
            pictureBox7.Location = new Point(insula[7].x, insula[7].y);
            pictureBox8.Location = new Point(insula[8].x, insula[8].y);
            pictureBox9.Location = new Point(insula[9].x, insula[9].y);
            pictureBox10.Location = new Point(insula[10].x, insula[10].y);
            pictureBox11.Location = new Point(insula[11].x, insula[11].y);

            start.Location = new Point(insula[1].x, insula[1].y);
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
           // pictureBoxBack.Image.Save("D:\\C-Start\\OJTI_2025_C#_Resurse\\harta_modificata.png");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int incremented = 0;
            for (int i = 0; i < insula.Length - 1; i++)
            {
                insule t, d;
                t.viz = insula[i].viz; t.id = insula[i].id;
                d.viz = insula[i + 1].viz; d.id = insula[i + 1].id;

                if (t.viz == 1 && d.viz == 1 && t.id < d.id && t.id >= 2 && t.id <= 7
                    && d.id >= 2 && d.id <= 7)
                    incremented++;
            }

            if(incremented == 5)
            {
                MessageBox.Show("Felicitări, ai refăcut traseul lui Columb! ");
            }
            else MessageBox.Show("Traseu incomplet! " + incremented);
        }

        public void InitializareTotala(int exploratori)
        {
            this.exploratori = exploratori;
            exploratoriInitiali = exploratori;
            listView1.BackColor = TransparencyKey;
            pictureBoxBack.Image = Properties.Resources.Harta900x600;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.listView1.SmallImageList = this.imageList1;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.Controls.Add(this.listView1);
            listView1.BringToFront();
            Insule(insula);
            InitializareInsule();
            ImgInsule();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AllActions(sender);
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }
    }
}
