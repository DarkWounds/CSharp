using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p53_Sub25
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\12A\p53_Sub25\p53_Sub25\apartamente.mdf;Integrated Security=True";
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string adresa;
            int cod, pret, camere, etajul;


            cod = int.Parse(textBoxCod.Text.Trim());
            adresa = textBoxAdresa.Text.Trim();
            pret = int.Parse(textBoxPret.Text.Trim());
            camere = int.Parse(textBoxCamere.Text.Trim());
            etajul = int.Parse(textBoxEtaj.Text.Trim());

            if (cod == null || adresa == String.Empty || pret == null || camere == null || etajul == null)
            {
                MessageBox.Show("Date incomplete");
                return;
            }

            int nr = 0;
            //Caut cod
            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from apartament where cod = '" + cod + @"'";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    r.Read();
                    nr = (int)r[0];
                    r.Close();
                }
                conn.Close();
            }

            if (nr != 0)
            {
                MessageBox.Show("Exista deja produsul");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"insert into apartament (cod, adresa, etajul ,camere, pret) values (" + cod + @", '" + adresa + @"' , " + etajul + @" ," + camere + @", " + pret + @")";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBoxCamere.Text = "";
                textBoxCod.Text = "";
                textBoxEtaj.Text = "";
                textBoxPret.Text = "";
                textBoxAdresa.Text = "";
                textBoxCod.Focus();

            }
        }

        private void buttonAfisNrAp_Click(object sender, EventArgs e)
        {
            int nr = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as nr from apartament";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    r.Read();
                    nr = (int)r[0];
                    r.Close();
                }
                conn.Close();
            }
            listBoxAfis.Items.Clear();
            listBoxAfis.Items.Add(nr);
        }

        private void buttonAfisPretMinim_Click(object sender, EventArgs e)
        {
            int nr = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select * from apartament";
                listBoxAfis.Items.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        int s = ';
                        if()
                        string w = ;
                        listBoxAfis.Items.Add(w);
                    }
                    r.Close();
                }
                conn.Close();
            }
        }

        private void buttonAfisCamereEgal_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                int valoare = Int32.MaxValue;
                string v = textBoxEgalCamere.Text.Trim();
                if (v != String.Empty)
                    valoare = int.Parse(v);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select cod,adresa,etajul from apartament where camere = " + valoare.ToString();
                listBoxAfis.Items.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string w = r[0].ToString() + " - " + r[1].ToString() + " - " + r[2].ToString();
                        listBoxAfis.Items.Add(w);
                    }
                    r.Close();
                }
                conn.Close();
            }
        }
    }
}
