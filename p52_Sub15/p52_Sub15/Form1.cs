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

namespace p52_Sub15
{
    public partial class Form1 : Form
    {

        private string connString;

        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\12A\p52_Sub15\p52_Sub15\ler.mdf;Integrated Security=True";
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string denumire;
            int cod, pret, cant;
            

            cod = int.Parse(textBoxCod.Text.Trim());
            denumire = textBoxDenumire.Text.Trim();
            pret = int.Parse(textBoxPret.Text.Trim());
            cant = int.Parse(textBoxCantitate.Text.Trim());

            if (cod == null || denumire == String.Empty || pret == null || cant == null)
            {
                MessageBox.Show("Date incomplete");
                return;
            }

            int nr = 0;
            //Caut denumire
            using (SqlConnection conn = new SqlConnection(connString))
            {   
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from produse where denumire = '" + denumire + @"'";
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
                cmd.CommandText = @"insert into produse (cod, denumire, pret, cant) values (" + cod + @", '" + denumire + @"' , " + pret + @", " + cant + @")";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBoxCantitate.Text = "";
                textBoxCod.Text = "";
                textBoxDenumire.Text = "";
                textBoxPret.Text = "";
                textBoxCod.Focus();

            }
        }

        private void buttonAfisNrProd_Click(object sender, EventArgs e)
        {
            int nr = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as nr from produse";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    r.Read();
                    nr = (int)r[0];
                    r.Close();
                }
                conn.Close();
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(nr);
        }

        private void buttonAfisPretMaiMic_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                int valoare = Int32.MaxValue;
                string v = textBoxAfisPret.Text.Trim();
                if (v != String.Empty)
                    valoare = int.Parse(v);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select denumire,pret from produse where pret <= " + valoare.ToString();
                listBox1.Items.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string w = r[0].ToString() + " - " + r[1].ToString();
                        listBox1.Items.Add(w);
                    }
                    r.Close();
                }
                conn.Close();
            }
        }

        private void buttonAfisPretMaxim_Click(object sender, EventArgs e)
        {
            // aflam pretul maxim
            int maxim = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select max(pret) as mx_pret from produse";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    r.Read();
                    maxim = (int)r[0];
                    r.Close();
                }
                conn.Close();
            }
            // afisam produsele cu pret maxim
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select denumire,pret from produse where pret =" + maxim;
                listBox1.Items.Clear();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string w = r[0].ToString() + " - " + r[1].ToString();
                        listBox1.Items.Add(w);
                    }
                    r.Close();
                }
                conn.Close();
            }
        }
    }
}
