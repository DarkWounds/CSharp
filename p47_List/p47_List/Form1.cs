using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p47_List
{
    public partial class Form1 : Form
    {

        private ArrayList nume;

        public Form1()
        {
            InitializeComponent();
            nume = new ArrayList();
            IncarcaLista();
        }

        private void IncarcaLista()
        {
            if (!File.Exists("NumeDomnitori.txt"))
            {
                MessageBox.Show("Nu exista!");
                return;
            }

            lbxDreapta.Items.Clear();
            lbxStanga.Items.Clear();
            string s;
            StreamReader fin = new StreamReader("NumeDomnitori.txt");

            while ((s = fin.ReadLine()) != null) { lbxStanga.Items.Add(s); nume.Add(s); }

            fin.Close();
        }

        private void btnIesire_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnAddLeft_Click(object sender, EventArgs e)
        {
            if (lbxDreapta.SelectedItem == null) return;
            nume.Add(lbxDreapta.SelectedItem.ToString());
            lbxStanga.Items.Add(lbxDreapta.SelectedItem);
            lbxDreapta.Items.Remove(lbxDreapta.SelectedItem);
        }

        private void btnAddRight_Click_1(object sender, EventArgs e)
        {
            if (lbxStanga.SelectedItem == null)
                return;
            nume.Remove(lbxStanga.SelectedItem.ToString());
            lbxDreapta.Items.Add(lbxStanga.SelectedItem);
            lbxStanga.Items.Remove(lbxStanga.SelectedItem);
        }

        private void tbxCauta_TextChanged(object sender, EventArgs e)
        {
            string s = tbxCauta.Text.Trim();
            lbxStanga.Items.Clear();
            if (s == String.Empty)
            {
                foreach (var i in nume)
                    lbxStanga.Items.Add(i);
                return;
            }
            foreach (var i in nume)
            {
                string x = i.ToString();
                int p = x.IndexOf(s);
                if (p == 0) lbxStanga.Items.Add(x);
            }
        }

        private void lbxDreapta_DoubleClick(object sender, EventArgs e)
        {
            btnAddLeft_Click(sender, e);
        }

        private void lbxStanga_DoubleClick(object sender, EventArgs e)
        {
            btnAddRight_Click_1(sender, e);
        }

    }
}
