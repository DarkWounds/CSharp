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

namespace Baze_De_Date
{
    public partial class Form1 : Form
    {
        string connString;
        List<string> l;

        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + CurrentPos() + @"\cinematograf.mdf;Integrated Security=True";
            l = new List<string>();
        }

        private string CurrentPos()
        {
            string dir = Directory.GetCurrentDirectory();
            int p = dir.LastIndexOf(@"\bin\");
            string directory = dir.Substring(0, p);
            return directory;
        }

        private void ClearAll()
        {
            textBoxCod.Text = "";
            textBoxRegizor.Text = "";
            textBoxAn.Text = "";
            textBoxNumele.Text = "";
            textBoxDurata.Text = "";
            listBox1.Items.Clear();
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string cod = textBoxCod.Text.Trim();
            string regizor = textBoxRegizor.Text.Trim();
            string an = textBoxAn.Text.Trim();
            string numele = textBoxNumele.Text.Trim();
            string durata = textBoxDurata.Text.Trim();

            if (cod == null || regizor == null || an == null || numele == null || durata == null)
            {
                MessageBox.Show("Ai gresit ceva");
                ClearAll();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                int codul = int.Parse(cod);
                int durataFilm = int.Parse(durata); 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"insert into filme(cod, regizor, an, nume, durata) values (" + codul + @", '" + regizor + @"', " + an + @", '" + numele + @"', " + durataFilm + @")";
                cmd.ExecuteNonQuery();
                ClearAll();
                conn.Close();
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAfisDurMax_Click(object sender, EventArgs e)
        {
            int d = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select durata from filme where durata >" + d;
                ClearAll();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    { 
                        int durata = (int)r[0];
                        if (durata > d)
                        d = durata;
                    }
                    
                }

                listBox1.Items.Add(d);
                conn.Close();
            }
        }

        private void buttonAfisFilmeAn_Click(object sender, EventArgs e)
        {
            string anulFilmului = textBoxFilmAn.Text.Trim();
            if (anulFilmului == String.Empty)
            {
                MessageBox.Show("Nu ai pus un an");
                ClearAll();
                return;
            }

            int n = int.Parse(anulFilmului);
            ClearAll();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select nume from filme where an =" + n;
                int s = 0;
                ClearAll();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        listBox1.Items.Add(r[0].ToString());
                        s++;
                    }

                }
                string text = "Nu s-au gaist filme din anul "+ n;
                if (s == 0)
                    listBox1.Items.Add(text);
                conn.Close();
            }

        }

        private int CautNume(string name)
        {
            for (int i = 0; i < l.Count(); i++)
                if (l[i] == name)
                    return 1;
            return 0;
        }

        private void buttonAfisFilmeReg_Click(object sender, EventArgs e)
        {

            ClearAll();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select regizor from filme";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string regizor = r[0].ToString();
                        if (CautNume(regizor) == 0)
                            l.Add(regizor);
                    }
                }
                conn.Close();
            }

            AdaugRegizori();
                
        }

        private void AdaugRegizori()
        {
            for (int i = 0; i < l.Count; i++)
            {
                string regizor = l[i];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select count(*) from filme where regizor = '" + regizor + @"'";
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        r.Read();
                        regizor = regizor + " " + (int)r[0];
                    }

                    listBox1.Items.Add(regizor);

                    conn.Close();
                }

            }
        }

    }
}
