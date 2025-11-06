using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTI_2025
{
    public partial class Expeditie : Form
    {
        public void ListaNume(ListBox t)
        {
            for (int i = 0; i < nume.Count; i++)
            {
                int x = ((Locatii)nume[i]).id;
                if (x >= 2 && x <= 7)
                    t.Items.Add(insula[x].nume);
            }
        }

        public Bitmap DeseneazaTraseuPeHarta()
        {
            Bitmap bitmap = new Bitmap(900, 600);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(Properties.Resources.Harta900x600, 0, 0, 900, 600);

                using (Pen greenPen = new Pen(Color.Green, 3))
                {
                    foreach (var line in pointsPaint)
                    {
                        g.DrawLine(greenPen, line.Item1, line.Item2);
                    }
                }

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

                InitializareInsule();
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

        public void SalvareImagine(string nume_harta)
        {
            //pictureBoxBack.Image.Save("D:\\C-Start\\OJTI_2025_C#_Resurse\\harta_modificata.png");
            Bitmap bitmap = DeseneazaTraseuPeHarta();
            if (nume_harta == null)
                nume_harta = "harta_modificata";
            string path =pathBase + nume_harta + ".png";
            bitmap.Save(path);
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
    }
}
