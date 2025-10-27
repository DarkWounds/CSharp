using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace OTI_2025
{
    public partial class Save : Form
    {
        int exploratori = 0;
        Expeditie salvare;
        public Save(Expeditie exp)
        {
            this.exploratori = exp.GetExploratori();
            this.salvare = exp;
            InitializeComponent();
            salvare.ListaNume(lbInsule);
            lbInsule.SelectionMode = SelectionMode.One;
            this.FormClosing += Save_FormClosing;
        }

        public void Save_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void lbInsule_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (lbInsule.SelectedItem == null)
            {
                MessageBox.Show("Nu ati selectat o insula!");
                return;
            }
            else
            {
                try
                {
                    string insulaSelectata = lbInsule.SelectedItem.ToString();
                    salvare.SelectareInsulaSalvare(insulaSelectata);
                    salvare.MutareBarca(insulaSelectata);
                    salvare.SalvareImagine();
                }
                catch 
                {
                    MessageBox.Show("Eroare la incarcarea imaginii");
                }
            }
        }
    }
}
