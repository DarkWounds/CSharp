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

namespace p56_Subiect31
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\12A\p56_Subiect31\p56_Subiect31\Romania.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sterge()
        {
            textBoxCNP.Text = "";
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxSeria.Text = "";
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string cnp = textBoxCNP.Text.Trim();
            string nume = textBoxNume.Text.Trim();
            string prenume = textBoxPrenume.Text.Trim();
            string seria = textBoxSeria.Text.Trim();

            if (cnp == null || nume == null || prenume == null || seria == null)
            {
                MessageBox.Show("Gresit");
                Sterge();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"insert into populatie (cnp, nume, prenume, seria) values ('" +
                    cnp + @"','" + nume + @"','" + prenume + @"','" + seria + @"')";
                cmd.ExecuteNonQuery();
                conn.Close();
                Sterge();
                textBoxCNP.Focus();
            }
        }

        private void buttonCautaNume_Click(object sender, EventArgs e)
        {
            string numeCautat = textBoxNumeCauta.Text.Trim();
            Sterge();
            listBoxAfis.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select nume, prenume from populatie where nume = '" + numeCautat + @"'";

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string t = r[0].ToString() + " " + r[1].ToString();
                        listBoxAfis.Items.Add(t);
                    }
                    r.Close();
                }
                conn.Close();
                textBoxCNP.Focus();
            }

            textBoxNumeCauta.Text = "";

        }

        private void buttonPersMasculin_Click(object sender, EventArgs e)
        {
            listBoxAfis.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from populatie where left(cnp,1) = '1' or left(cnp,1) = '5'";
                string n = "";

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        n = r[0].ToString();
                    }
                    r.Close();
                }

                conn.Close();
                Sterge();
                listBoxAfis.Items.Add(n);
                textBoxCNP.Focus();
            }
        }

        private void buttonPersELA_Click(object sender, EventArgs e)
        {
            listBoxAfis.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from populatie where right(prenume, 3) = 'ela'";
                string n = "";

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        n = r[0].ToString();
                        listBoxAfis.Items.Add(n);
                    }
                    r.Close();
                }

                conn.Close();
                Sterge();
                textBoxCNP.Focus();
            }
        }

    }
}
