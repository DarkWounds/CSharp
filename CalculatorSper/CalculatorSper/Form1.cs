namespace CalculatorSper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "2";
            else Calc.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "3";
            else Calc.Text += "3";
        }

        private void Adunare_Click(object sender, EventArgs e)
        {
            Calc.Text += "+";
        }

        private void Scadere_Click(object sender, EventArgs e)
        {
            Calc.Text += "-";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "6";
            else Calc.Text += "6";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "5";
            else Calc.Text += "5";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "4";
            else Calc.Text += "4";
        }

        private void Inmultire_Click(object sender, EventArgs e)
        {
            Calc.Text += "*";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "9";
            else Calc.Text += "9";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "8";
            else Calc.Text += "8";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (Calc.Text == "0") Calc.Text = "7";
            else Calc.Text += "7";
        }

        private void Paranteze_Click(object sender, EventArgs e)
        {
            Calc.Text = "Not now :)";
        }

        private void Punct_Click(object sender, EventArgs e)
        {
            Calc.Text += ".";
        }

        private void Sterge1_Click(object sender, EventArgs e)
        {
            if (Calc.Text.Length > 0)
            {
                Calc.Text = Calc.Text.Remove(Calc.Text.Length - 1, 1);
            }
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "")
            {
                //var result = new DataTable().Compute(Calc.Text, null);
                Calc.Text = "Hello world!";//result.ToString();
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0") Calc.Text += "0";
        }

        private void StergeTot_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0") Calc.Text = "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Calc.Text != "0") Calc.Text += "1";
            else Calc.Text = "1";
        }

        private void Calc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Procent_Click(object sender, EventArgs e)
        {
            Calc.Text += "%";
        }

        private void Impartire_Click(object sender, EventArgs e)
        {
            if(Calc.Text == "0") Calc.Text = "Not posiible";
        }
    }
}
