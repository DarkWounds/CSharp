using OTI_2025.Properties;
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
using static System.Windows.Forms.AxHost;
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
        
        //Path
        string pathBase = null;

        List<(Point, Point)> pointsPaint = new List<(Point, Point)>();
        public ArrayList distanteInsule = new ArrayList();
        public ArrayList nume = new ArrayList();

        Locatii pozBarca;


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

        public void GasirePath()
        {
            pathBase = Directory.GetCurrentDirectory();
            int p = pathBase.LastIndexOf(@"\bin");
            pathBase = pathBase.Substring(0, p) + @"\Resources\";
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
            this.FormClosing += Expeditie_Closed;
        }
        public void Expeditie_Closed(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
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

        public void Insule(insule[] ins)
        {
            string path = pathBase + @"insule.txt";
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

            string path2 =  pathBase + @"distante.txt";
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
            PictureBox[] pBox = { pictureBox1, pictureBox2, pictureBox3, pictureBox4,
                pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11 };
            for (int i = 0; i < pBox.Length; i++)
            {
                int t = i + 1;
                string name = "insula" + t;
                object nameresource = Properties.Resources.ResourceManager.GetObject(name);

                pBox[i].Location = new Point(insula[t].x, insula[t].y);
                pBox[i].Parent = pictureBoxBack;
                pBox[i].BackColor = Color.Transparent;
                pBox[i].Size = new Size(50, 50);
                pBox[i].SizeMode = PictureBoxSizeMode.StretchImage;

                if (nameresource != null)
                {
                    pBox[i].Image = (Image)nameresource;
                }
            }

            start.Location = new Point(insula[1].x, insula[1].y);
            start.Parent = pictureBoxBack;
            start.BackColor = Color.Transparent;
            start.Size = new Size(50, 50);
            start.SizeMode = PictureBoxSizeMode.StretchImage;
            start.BringToFront();

            object barcaResource = Properties.Resources.ResourceManager.GetObject("barca");
            if (barcaResource != null && barcaResource is Image)
            {
                start.Image = (Image)barcaResource;
            }
            else
            {
                try
                {
                    start.Image = Properties.Resources.barca;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la încărcarea imaginii barca: {ex.Message}");
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
         
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
            GasirePath();
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

            textBox1.Text = Directory.GetCurrentDirectory();
            textBox1.BringToFront();
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
