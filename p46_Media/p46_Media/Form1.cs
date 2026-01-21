using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p46_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniesire_Click(object sender, EventArgs e) { Application.Exit(); }

        private void tbxNotele_TextChanged(object sender, EventArgs e)
        {
            if (tbxNotele.Text == "")
            {
                tbxMedia.Text = "0";
                return;
            }
            else
            { 
                string s = tbxNotele.Text.Trim();
                string t = String.Empty;
                int i = 0;
                for (i = 0; i < s.Length; i++)
                    if (s[i] >= '0' && s[i] <= '9')
                    {
                        if (s[i] != '0')
                            t += s[i];
                        else
                        {
                            if (i != 0 && s[i - 1] == '1')
                                t += s[i];
                        }
                    }
                if (t == "")
                {
                    tbxNotele.Text = "";
                    tbxMedia.Text = "0";
                    return;
                }

                tbxNotele.Text = t;
                int nota, nrNote = 0;
                double media = 0;
                for (i = 0; i < t.Length;)
                {
                    nota = t[i] - '0';
                    if (nota == 1 && i <= t.Length - 2 && t[i + 1] == '0')
                    {
                        nota = 10;
                        i ++;
                    }
                    media += nota;
                    nrNote++;
                    i++;
                }
                media /= nrNote;
                media = (int)(media * 100);
                media /= 100;
                tbxMedia.Text = media.ToString();
            }
            
        }
    }
}
