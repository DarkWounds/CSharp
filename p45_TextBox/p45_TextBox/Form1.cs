using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p45_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            /*this.Close();*/ Application.Exit();
        }
        private void tBA_TextChanged(object sender, EventArgs e)
        {
            int i;
            string s = tBA.Text.Trim();
            string t = String.Empty;
            for (i = 0; i < s.Length; i++)
                if ('0' <= s[i] && s[i] <= '9')
                    t += s[i];
            // elimin eventualele zerouri de la inceputul lui t

            for (i = 0; i < t.Length && t[i] == '0'; i++)
                ;
            if (i == t.Length) t = "0";
            else t = t.Substring(i);

            if (t.Length >= 10) t = t.Substring(0, 9);
            tBA.Text = t;

            CalculSuma();
        }

        private void CalculSuma()
        {
            string s = tBA.Text.Trim();
            string t = tBB.Text.Trim();
            if (s == "") s = "0";
            if (t == "") t = "0";

            int a, b;
            a = int.Parse(tBA.Text);
            b = int.Parse(tBB.Text);

            tBA.Text = s;
            tBB.Text = t;
            tBSuma.Text = (a + b).ToString();
        }

        private void tBB_TextChanged(object sender, EventArgs e)
        {
            int i;
            string s = tBB.Text.Trim();
            string t = String.Empty;
            for (i = 0; i < s.Length; i++)
                if ('0' <= s[i] && s[i] <= '9')
                    t += s[i];
            // elimin eventualele zerouri de la inceputul lui t

            for (i = 0; i < t.Length && t[i] == '0'; i++)
                ;
            if (i == t.Length) t = "0";
            else t = t.Substring(i);

            if (t.Length >= 10) t = t.Substring(0, 9);
            tBB.Text = t;

            CalculSuma();
        }
    }
}
