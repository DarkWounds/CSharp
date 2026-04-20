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

namespace p50_DataBase
{
    public partial class Form1 : Form
    {

        private string connString;

        public Form1()
        {
            InitializeComponent();
            string cale = Directory.GetCurrentDirectory();
            int p = cale.LastIndexOf("\\bin\\");
            string s = cale.Substring(0, p + 1) + @"ler.mdf";
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+ s + @";Integrated Security=True";
        }

        private void AfisareDate()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from elevi";
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    listBoxAfisare.Items.Clear();
                    while (r.Read())
                    {
                        string linie = r[1].ToString() + " " + r[2].ToString();
                        listBoxAfisare.Items.Add(linie);
                    }
                    r.Close();
                }

                conn.Close();
            }
        }

        private void AdaugaInregistrare()
        {
            string nume = tbxNume.Text.Trim();
            string punctaj = tbxPunctaj.Text.Trim();
            if (punctaj == String.Empty || nume == String.Empty)
            {
                MessageBox.Show("Nu ai completat datele!");
                return;
            }

            int n = int.Parse(punctaj);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into elevi (nume, punctaj) values ('" + nume + @"' " + "," + n + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            tbxNume.Text = "";
            tbxPunctaj.Text = "";
            tbxNume.Focus();

            AfisareDate();
        }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnAfis_Click(object sender, EventArgs e) { AfisareDate(); }

        private void btnInregistrare_Click(object sender, EventArgs e) { AdaugaInregistrare(); }
    }
}
