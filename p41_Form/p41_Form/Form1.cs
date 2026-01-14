using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p41_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIesire_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnIncendiu_Click(object sender, EventArgs e) { MessageBox.Show("Am zis in caz de incendiu!"); }

    }
}
