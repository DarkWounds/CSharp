using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p51_TestGrila
{
    public partial class Form1 : Form
    {
        private int n;
        private List<Intrebare> a;
        private int[] v;
        public static Random R;
        private int nrcrt;
        public GroupBox gb;


        public Form1()
        {
            InitializeComponent();
            btnIntrebare.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest.Visible = false;
            btnIntrebare.Visible = true;
            lblBara.Visible = true;
            lblIntrebare.Visible = true;
            lblNrIntrebari.Visible = true;
            lblPagCurent.Visible = true;
            IncarcaIntrebarea();
            gb.Font = new System.Drawing.Font("Times New Roman", 15);
            
        }

        private void IncarcaIntrebarea()
        {
            IncarcaTestul();
            gb.Controls.Clear();
            int i = v[nrcrt];
            lblIntrebare.Text = a[i].enuntIntrebare;
            lblPagCurent.Text = (nrcrt + 1).ToString();

            if (a[i].raspCorect > 9)
            {
                gb.Text = "Varianta multipla de rasp";
                for (int j = 1; j <= 4; j++)
                {
                    CheckBox cb = new CheckBox();
                    cb.Tag = j;
                    cb.Text = a[i].varianteDeRasp[j];
                    cb.Location = new Point(100, (j - 1) * 80 + 60);
                    gb.Controls.Add(cb);

                }
            }
            else
            {
                gb.Text = "Varianta unica de rasp";
                for (int j = 1; j <= 4; j++)
                {
                    RadioButton cb = new RadioButton();
                    cb.Tag = j;
                    cb.Text = a[i].varianteDeRasp[j];
                    cb.Location = new Point(100, (j - 1) * 80 + 60);
                    gb.Controls.Add(cb);

                }
            }
        }

        private void IncarcaTestul()
        {

            /*
             * Init.gb 
             */
            gb = new GroupBox();
            gb.Location = new Point(30, 130);
            gb.Size = new Size(1200, 400);
            this.Controls.Add(gb);

            nrcrt = 0;
            string cale = Directory.GetCurrentDirectory();
            int p = cale.LastIndexOf(@"\bin\");
            cale = cale.Substring(0, p + 1) + "Intrebari.mdf";
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + cale + ";Integrated Security=True";
            a = new List<Intrebare>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from intrebari";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string e = r[1].ToString();
                        string[] variante = new string[5];
                        variante[1] = r[2].ToString();
                        variante[2] = r[3].ToString();
                        variante[3] = r[4].ToString();
                        variante[4] = r[5].ToString();
                        int x = (int)r[6];
                        Intrebare w = new Intrebare(e, variante, x);
                        a.Add(w);
                    }
                    r.Close();
                }
                conn.Close();
            }
            v = new int[10];
            n = a.Count();
            R = new Random();
            int k = 0;
            while (k < 10)
            {
                int x = R.Next(n);
                //caut daca apare x sau nu in v[]
                int i;
                for (i = 0; i < k && v[i] != x; i++) ;
                if (i == k) v[k++] = x;

            }
        }

        private void btnIesire_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnIntrebare_Click(object sender, EventArgs e)
        {
          
        }
    }
}
