using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTI_2024
{
    public partial class Alege_opțiunea : Form
    {
        public Alege_opțiunea()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (ckbJoc.Checked == true)
            {
                Joc joc = new Joc();
                joc.Show();
                this.Close();
            }
            else if (ckbMiscare.Checked == true)
            {
                Miscare miscare = new Miscare();
                miscare.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Alegeți o opțiune!");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void PbMiscare_Click(object sender, EventArgs e)
        {
            ckbJoc.Checked = false;
            ckbMiscare.Checked = true;
        }

        private void PbJoc_Click(object sender, EventArgs e)
        {
            ckbMiscare.Checked = false;
            ckbJoc.Checked = true;
        }

        private void CbMiscare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CbJoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CbJoc_Click(object sender, EventArgs e)
        {
            ckbMiscare.Checked = false;
        }

        private void cbMiscare_Click(object sender, EventArgs e)
        {
            ckbJoc.Checked = false;
        }
    }
}
