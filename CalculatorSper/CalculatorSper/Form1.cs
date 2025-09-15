using System.Data;

namespace CalculatorSper
{
    public partial class Form1 : Form
    {
        int ParaD = 0;
        int ParaI = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "2";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "3";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "3";
        }

        private void Adunare_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last != '%' && last != '+' && last != '-' && last != '*' && last != '/')
                Calc.Text += "+";
        }

        private void Scadere_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last != '%' && last != '+' && last != '-' && last != '*' && last != '/')
                Calc.Text += "-";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "6";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "6";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "5";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "5";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "4";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "4";
        }

        private void Inmultire_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last != '%' && last != '+' && last != '-' && last != '*' && last != '/')
                Calc.Text += "*";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "9";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "9";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "8";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "8";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "7";
                ParaD = 0;
                ParaI = 0;
            }
            else Calc.Text += "7";
        }

        private void Paranteze_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last == '%' || last == '+' || last == '-' || last == '*' || last == '/')
            {
                Calc.Text += "(";
                ParaD++;
            }
            else if(ParaD > ParaI)
            {
                Calc.Text += ")";
                ParaI++;
            }
                
        }

        private void Punct_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last != '%' && last != '+' && last != '-' && last != '*' 
                && last != '/' && last != '(' && last != ')')
                    Calc.Text += ".";
        }

        private void Sterge1_Click(object sender, EventArgs e)
        {
            if (Calc.Text.Length > 1 && Calc.Text != "Invalid")
            {
                Calc.Text = Calc.Text.Remove(Calc.Text.Length - 1, 1);
            }
            else
            {
                Calc.Text = "0";
                ParaD = 0;
                ParaI = 0;
            }
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "" && Calc.Text != "Invalid")
            {
                try
                {
                    var table = new DataTable();
                    var result = table.Compute(Calc.Text, string.Empty);
                    Calc.Text = result.ToString();
                }
                catch
                {
                    Calc.Text = "Invalid";
                }

            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0" || Calc.Text != "Invalid") Calc.Text += "0";
            else
            {
                Calc.Text = "0";
                ParaD = 0;
                ParaI = 0;
            }
        }

        private void StergeTot_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0" || Calc.Text == "Invalid")
            {
                Calc.Text = "0";
                ParaD = 0;
                ParaI = 0;
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0" || Calc.Text == "Invalid") Calc.Text += "1";
            else
            {
                Calc.Text = "1";
                ParaD = 0;
                ParaI = 0;
            }
        }

        private void Calc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Procent_Click(object sender, EventArgs e)
        {
            string exp = Calc.Text;
            char last = exp[exp.Length - 1];
            if (last != '%' && last != '+' && last != '-' && last != '*' && last != '/')
                Calc.Text += "%";
        }

        private void Impartire_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0" || Calc.Text == "Invalid") Calc.Text = "Invalid";
            else Calc.Text += '/';
        }

        private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 48 || e.KeyValue > 57 || e.KeyValue != 189
               || e.KeyValue != 187 || e.KeyValue != 56 || e.KeyValue != 53)
                e.SuppressKeyPress = true;
        }

        private void Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
