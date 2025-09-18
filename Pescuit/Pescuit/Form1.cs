namespace Pescuit
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private System.ComponentModel.Container Components;
        System.Windows.Forms.Timer uiTimer = new System.Windows.Forms.Timer();
        private Stopwatch Mins1 = new Stopwatch(), Mins2 = new Stopwatch()
            , Mins3 = new Stopwatch(), Mins4 = new Stopwatch();
        void Vizibilitate(Button Plus, Button Minus, RichTextBox RTB, CheckedListBox CLB, Boolean t)
        {
            Plus.Visible = t;
            Minus.Visible = t;
            RTB.Visible = t;
            CLB.Visible = t;
            if (CLB1.Visible == false && CLB2.Visible == false && CLB3.Visible == false && CLB4.Visible == false)
                ToggleV.Text = "Unhide";
            else ToggleV.Text = "Hide";
        }

        void Ticks(Stopwatch TimeClock, RichTextBox Minute)
        {
            TimeSpan ts = TimeClock.Elapsed;
            Minute.Text = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }

        void ClearTotal(CheckedListBox CLB, ListBox LB, RichTextBox RBT)
        {
            RBT.Clear();
            RBT.Text = "00:00";
            CLB.ClearSelected();
            for (int i = 0; i < CLB.Items.Count; i++)
            {
                CLB.SetItemChecked(i, false);
            }
            LB.Items.Clear();
        }

        void AdaugareInLista(ListBox LB, CheckedListBox CLB)
        {
            LB.Items.Clear();
            for (int i = 0; i < CLB.CheckedItems.Count; i++)
            {
                LB.Items.Add(CLB.CheckedItems[i]);
            }
        }

        void Stop(ListBox LB, Button Btn, Stopwatch TimeClock)
        {
            if (Btn.BackColor == Color.LightSteelBlue)
            {
                Btn.BackColor = Color.Salmon;
                LB.BackColor = Color.MistyRose;
                TimeClock.Stop();
                TimeClock.Reset();
            }
            else
            {
                TimeClock.Start();
                Btn.BackColor = Color.LightSteelBlue;
                LB.BackColor = Color.Lavender;

            }
        }

        private void Initializare()
        {
            Done1.Visible = false;
            Done2.Visible = false;
            Done3.Visible = false;
            Done4.Visible = false;
            Add1.Visible = false;
            Add2.Visible = false;
            Add3.Visible = false;
            Add4.Visible = false;
            Timer1.Stop();
            Timer2.Stop();
            Timer3.Stop();
            Timer4.Stop();
            string[] Momeala = { "BoilesG", "Flotant", "LUsturoi", "Canepa", "Nada", "LAditiv", "LVierme", "BoilesR" };
            for (int i = 0; i < Momeala.Length; i++)
            {
                CLB1.Items.Add(Momeala[i]);
                CLB2.Items.Add(Momeala[i]);
                CLB3.Items.Add(Momeala[i]);
                CLB4.Items.Add(Momeala[i]);
            }
            CLB1.CheckOnClick = true;
            CLB3.CheckOnClick = true;
            CLB2.CheckOnClick = true;
            CLB4.CheckOnClick = true;
            Vizibilitate(Plus1, Minus1, RTB1, CLB1, false);
            Vizibilitate(Plus2, Minus2, RTB2, CLB2, false);
            Vizibilitate(Plus3, Minus3, RTB3, CLB3, false);
            Vizibilitate(Plus4, Minus4, RTB4, CLB4, false);
        }
        public Form1()
        {
            //Init
            InitializeComponent();
            Initializare();
            Form1_Load(this, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Add1.BringToFront();
            Add2.BringToFront();
            Add3.BringToFront();
            Add4.BringToFront();
            Done1.BringToFront();
            Done2.BringToFront();
            Done3.BringToFront();
            Done4.BringToFront();
        }
        private void Min_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Visible and not visible Checkbox +-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleV_Click(object sender, EventArgs e)
        {
            if (CLB1.Visible == true || CLB2.Visible == true || CLB3.Visible == true || CLB4.Visible == true)
            {
                ToggleV.Text = "Unhide";
                Vizibilitate(Plus1, Minus1, RTB1, CLB1, false);
                Vizibilitate(Plus2, Minus2, RTB2, CLB2, false);
                Vizibilitate(Plus3, Minus3, RTB3, CLB3, false);
                Vizibilitate(Plus4, Minus4, RTB4, CLB4, false);
            }
            else
            {
                ToggleV.Text = "Hide";
                Vizibilitate(Plus1, Minus1, RTB1, CLB1, true);
                Vizibilitate(Plus2, Minus2, RTB2, CLB2, true);
                Vizibilitate(Plus3, Minus3, RTB3, CLB3, true);
                Vizibilitate(Plus4, Minus4, RTB4, CLB4, true);
            }
        }

        /// <summary>
        /// Setari -edit checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Setari1_Click(object sender, EventArgs e)
        {
            if (CLB1.Visible == false)
                Vizibilitate(Plus1, Minus1, RTB1, CLB1, true);
            else
                Vizibilitate(Plus1, Minus1, RTB1, CLB1, false);
        }

        private void Setari2_Click(object sender, EventArgs e)
        {
            if (CLB2.Visible == false)
                Vizibilitate(Plus2, Minus2, RTB2, CLB2, true);
            else
                Vizibilitate(Plus2, Minus2, RTB2, CLB2, false);
        }

        private void Setari3_Click(object sender, EventArgs e)
        {
            if (CLB3.Visible == false)
                Vizibilitate(Plus3, Minus3, RTB3, CLB3, true);
            else
                Vizibilitate(Plus3, Minus3, RTB3, CLB3, false);
        }

        private void Setari4_Click(object sender, EventArgs e)
        {
            if (CLB4.Visible == false)
                Vizibilitate(Plus4, Minus4, RTB4, CLB4, true);
            else
                Vizibilitate(Plus4, Minus4, RTB4, CLB4, false);
        }

        /// <summary>
        /// RTB - will not change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void RTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTB4_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Butons - color, timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            Stop(LB1, Btn1, Mins1);
            if (Btn1.BackColor == Color.LightSteelBlue)
                Timer1.Start();
            else
                Timer1.Stop();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Stop(LB2, Btn2, Mins2);
            if (Btn2.BackColor == Color.LightSteelBlue)
                Timer2.Start();
            else
                Timer2.Stop();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Stop(LB3, Btn3, Mins3);
            if (Btn3.BackColor == Color.LightSteelBlue)
                Timer3.Start();
            else
                Timer3.Stop();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Stop(LB4, Btn4, Mins4);
            if (Btn4.BackColor == Color.LightSteelBlue)
                Timer4.Start();
            else
                Timer4.Stop();
        }

        /// <summary>
        /// Delete selected checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Minus1_Click(object sender, EventArgs e)
        {
            if (CLB1.SelectedIndex != null)
                CLB1.Items.RemoveAt(CLB1.SelectedIndex);
        }

        private void Minus2_Click(object sender, EventArgs e)
        {
            if (CLB2.SelectedIndex != null)
                CLB2.Items.RemoveAt(CLB2.SelectedIndex);
        }

        private void Minus3_Click(object sender, EventArgs e)
        {
            if (CLB3.SelectedIndex != null)
                CLB3.Items.RemoveAt(CLB3.SelectedIndex);
        }

        private void Minus4_Click(object sender, EventArgs e)
        {
            if (CLB4.SelectedIndex != null)
                CLB4.Items.RemoveAt(CLB4.SelectedIndex);
        }

        /// <summary>
        /// Plus - add checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plus1_Click(object sender, EventArgs e)
        {
            Add1.Visible = true;
            Done1.Visible = true;

        }

        private void Plus2_Click(object sender, EventArgs e)
        {
            Add2.Visible = true;
            Done2.Visible = true;
        }

        private void Plus3_Click(object sender, EventArgs e)
        {
            Add3.Visible = true;
            Done3.Visible = true;
        }

        private void Plus4_Click(object sender, EventArgs e)
        {
            Add4.Visible = true;
            Done4.Visible = true;
        }

        /// <summary>
        /// CLB - check the boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CLB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaugareInLista(LB1, CLB1);
        }

        private void CLB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaugareInLista(LB2, CLB2);
        }

        private void CLB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaugareInLista(LB3, CLB3);
        }

        private void CLB4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaugareInLista(LB4, CLB4);
        }
        /// <summary>
        /// Reset everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Reset_Click(object sender, EventArgs e)
        {
            if (LB1.BackColor == Color.Lavender)
                Stop(LB1, Btn1, Mins1);
            if (LB2.BackColor == Color.Lavender)
                Stop(LB2, Btn2, Mins2);
            if (LB3.BackColor == Color.Lavender)
                Stop(LB3, Btn3, Mins3);
            if (LB4.BackColor == Color.Lavender)
                Stop(LB4, Btn4, Mins4);
            ClearTotal(CLB1, LB1, Minute1);
            ClearTotal(CLB2, LB2, Minute2);
            ClearTotal(CLB3, LB3, Minute3);
            ClearTotal(CLB4, LB4, Minute4);

        }
        /// <summary>
        /// Timer -Reloads minutes and seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Btn1.BackColor == Color.LightSteelBlue)
                Ticks(Mins1, Minute1);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Btn2.BackColor == Color.LightSteelBlue)
                Ticks(Mins2, Minute2);
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (Btn4.BackColor == Color.LightSteelBlue)
                Ticks(Mins4, Minute4);
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (Btn3.BackColor == Color.LightSteelBlue)
                Ticks(Mins3, Minute3);
        }
        /// <summary>
        /// Done - Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done1_Click(object sender, EventArgs e)
        {
            string Item = Add1.Text;
            if (Item != "")
            {
                CLB1.Items.Add(Item);
                Add1.Clear();
                Add1.Visible = false;
                Done1.Visible = false;
            }
        }

        private void Done2_Click(object sender, EventArgs e)
        {
            string Item = Add2.Text;
            if (Item != "")
            {
                CLB2.Items.Add(Item);
                Add2.Clear();
                Add2.Visible = false;
                Done2.Visible = false;
            }
        }

        private void Done3_Click(object sender, EventArgs e)
        {
            string Item = Add3.Text;
            if (Item != "")
            {
                CLB3.Items.Add(Item);
                Add3.Clear();
                Add3.Visible = false;
                Done3.Visible = false;
            }
        }

        private void Done4_Click(object sender, EventArgs e)
        {
            string Item = Add4.Text;
            if (Item != "")
            {
                CLB4.Items.Add(Item);
                Add4.Clear();
                Add4.Visible = false;
                Done4.Visible = false;
            }
        }
        /// <summary>
        /// Add (RichText)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
