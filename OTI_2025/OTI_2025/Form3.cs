using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OTI_2025
{
    public partial class Expeditie : Form
    {
        int exploratori = 0, hrana = 0, bogatii = 0, incTotala = 0;
        int[][] a;
        Locatii pozBarca;

        struct Locatii
        {
            public int x;
            public int y;
            public int id;
        }

        struct insule
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

        insule[] insula = new insule[12];

        public Expeditie(int exploratori)
        {
            InitializeComponent();
            this.exploratori = exploratori;
            listView1.BackColor = TransparencyKey;
            pictureBoxBack.Image = Properties.Resources.Harta900x600;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.listView1.SmallImageList = this.imageList1;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.Controls.Add(this.listView1);
            listView1.BringToFront();
            Insule();
            InitializareInsule();
            ImgInsule();

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

        public void Insule()
        {
            string path = @"D:\C-Start\OJTI_2025_C#_Resurse\insule.txt";
            try
            {
                StreamReader insuleInfo = new StreamReader(path);
                string linie;
                int i = 1;
                linie = insuleInfo.ReadLine();
                while ((linie = insuleInfo.ReadLine()) != null)
                {
                    string[] date = linie.Split('#');
                    insula[i].id = int.Parse(date[0]);
                    insula[i].nume = date[1];
                    insula[i].x = int.Parse(date[2]);
                    insula[i].y = int.Parse(date[3]);
                    insula[i].bogatii = int.Parse(date[4]);
                    insula[i].virusi = int.Parse(date[5]);
                    insula[i].descriere = date[6];
                    insula[i].viz = 0;
                    if (i == 1)
                    {
                        pozBarca.x = insula[i].x;
                        pozBarca.y = insula[i].y;
                        pozBarca.id = insula[i].id;
                    }
                    i++;
                }
                a = new int[i + 1][];

                        
                    
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului insule.txt:\n");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.BackColor = TransparencyKey;
            hrana = 2 * exploratori * 100;
            incTotala = hrana + 90 * exploratori + bogatii;
            listView1.Items.Add(new ListViewItem("incarcatura " + incTotala, 0));
            listView1.Items.Add(new ListViewItem("bogatii " + bogatii, 1));
            listView1.Items.Add(new ListViewItem("explorator " + exploratori, 2));
            listView1.Items.Add(new ListViewItem("hrana " + hrana, 3));
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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (a[3][pozBarca.id] == 0)
            {
                a[3][pozBarca.id] = 1;
                pozBarca.x = insula[3].x;
                pozBarca.y = insula[3].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }   
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (a[8][pozBarca.id] == 0)
            {
                a[8][pozBarca.id] = 1;
                pozBarca.x = insula[8].x;
                pozBarca.y = insula[8].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }

            else MessageBox.Show("Interzis!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (a[5][pozBarca.id] == 0)
            {
                a[5][pozBarca.id] = 1;
                pozBarca.x = insula[5].x;
                pozBarca.y = insula[5].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }

            else MessageBox.Show("Interzis!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (a[2][pozBarca.id] == 0)
            {
                a[2][pozBarca.id] = 1;
                pozBarca.x = insula[2].x;
                pozBarca.y = insula[2].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }

            else MessageBox.Show("Interzi!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

             a[3][pozBarca.id] = 1;
             pozBarca.x = insula[3].x;
             pozBarca.y = insula[3].y;
             start.Location = new Point(pozBarca.x, pozBarca.y);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (a[11][pozBarca.id] == 0)
            {
                a[11][pozBarca.id] = 1;
                pozBarca.x = insula[11].x;
                pozBarca.y = insula[11].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (a[10][pozBarca.id] == 0)
            {
                a[10][pozBarca.id] = 1;
                pozBarca.x = insula[10].x;
                pozBarca.y = insula[10].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (a[9][pozBarca.id] == 0)
            {
                a[9][pozBarca.id] = 1;
                pozBarca.x = insula[9].x;
                pozBarca.y = insula[9].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (a[4][pozBarca.id] == 0)
            {
                a[4][pozBarca.id] = 1;
                pozBarca.x = insula[4].x;
                pozBarca.y = insula[4].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (a[6][pozBarca.id] == 0)
            {
                a[6][pozBarca.id] = 1;
                pozBarca.x = insula[6].x;
                pozBarca.y = insula[6].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
            }
            else MessageBox.Show("Interzi!");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                pozBarca.x = insula[7].x;
                pozBarca.y = insula[7].y;
                start.Location = new Point(pozBarca.x, pozBarca.y);
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }
    }
}
