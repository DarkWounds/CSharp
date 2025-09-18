namespace Counter
{
    public partial class Counter : Form
    {
        int count = 0;
        public Counter()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            richTextBox1.Text = count.ToString();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn3.BackColor == Color.DeepSkyBlue)
                Btn3.BackColor = Color.MediumPurple;
            else Btn3.BackColor = Color.DeepSkyBlue;

            richTextBox1.Visible = !richTextBox1.Visible;
        }
    }
}
