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

namespace p55_SubiectAtestat21
{
    public partial class Form1 : Form
    {
        string connString;

        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Pozitie() + ";Integrated Security=True";
        }

        private string Pozitie()
        {
            string dir = Directory.GetCurrentDirectory();
            int p = dir.LastIndexOf(@"\bin\");
            string sub = dir.Substring(0, p + 1) + @"parlament.mdf";
            return sub;
        }

        private void buttonAddMembrii_Click(object sender, EventArgs e)
        {
            string c = textBoxCod.Text.ToString().Trim();
            string nume = textBoxNume.Text.ToString().Trim();
            string partid = textBoxPartid.Text.ToString().Trim();
            string vechi = textBoxVechime.Text.ToString().Trim();

            if (nume == null || partid == null || partid == null || vechi == null)
            {
                MessageBox.Show("Date incomplete");
                ClearAll();
            }

            int cod = int.Parse(c.Trim());
            int vechime = int.Parse(vechi.Trim());
            int nr = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) from membrii where cod = '" + cod + @"'";
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
                cmd.CommandText = @"insert into membrii (cod, numele, partid, vechime) values (" + cod + @", '" + nume + @"' , '" + partid + @"', " + vechime + @")";
                cmd.ExecuteNonQuery();
                conn.Close();
                ClearAll();

            }

            listBox1.Items.Clear();
               
        }

        private void ClearAll()
        {
            textBoxCod.Text = "";
            textBoxNume.Text = "";
            textBoxPartid.Text = "";
            textBoxVechime.Text = "";
            textBoxAfispartid.Text = "";
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAfisNrMembriiPartide_Click(object sender, EventArgs e)
        {
            ClearAll();
            listBox1.Items.Clear();

            List<string> lista = new List<string>();

            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select partid from membrii";

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string t = r[0].ToString();
                        lista.Add(t);
                    }
                    r.Close();
                }

                conn.Close();
            } 

            for (int i = 0; i < lista.Count(); i++)
            {
                int nr = 0;
                string partid = lista[i].ToString();

                using (SqlConnection conn = new SqlConnection(connString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select count(*) as nr from membrii where partid = '" + partid + "'";

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        r.Read();
                        nr = (int)r[0];
                        r.Close();
                    }
                    conn.Close();
                }

                listBox1.Items.Add(lista[i] + ": " + nr);
            }

            ClearAll();
        }

        private void buttonAfisMembriiPartidSpecific_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            string partid = textBoxAfispartid.Text.ToString().Trim();

            if (partid == String.Empty)
            {
                MessageBox.Show("Nu ai scris un partid");
                ClearAll();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select numele as nr from membrii where partid = '" + partid + "'";

                listBox1.Items.Add(partid + ": ");

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string t = r[0].ToString();
                        listBox1.Items.Add(t);
                    }
                    r.Close();
                }
                conn.Close();
            }
        }
    }
}
