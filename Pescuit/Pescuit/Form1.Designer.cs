
namespace Pescuit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Min = new RichTextBox();
            ToggleV = new Button();
            Reset = new Button();
            Timer1 = new System.Windows.Forms.Timer(components);
            Timer2 = new System.Windows.Forms.Timer(components);
            Timer3 = new System.Windows.Forms.Timer(components);
            Timer4 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            Done1 = new Button();
            Add1 = new RichTextBox();
            CLB1 = new CheckedListBox();
            Minus1 = new Button();
            Plus1 = new Button();
            RTB1 = new RichTextBox();
            Setari1 = new Button();
            Minute1 = new RichTextBox();
            Btn1 = new Button();
            LB1 = new ListBox();
            panel2 = new Panel();
            Done2 = new Button();
            Add2 = new RichTextBox();
            Minus2 = new Button();
            Plus2 = new Button();
            RTB2 = new RichTextBox();
            CLB2 = new CheckedListBox();
            Minute2 = new RichTextBox();
            Setari2 = new Button();
            Btn2 = new Button();
            LB2 = new ListBox();
            panel3 = new Panel();
            Done3 = new Button();
            Add3 = new RichTextBox();
            Minus3 = new Button();
            Plus3 = new Button();
            RTB3 = new RichTextBox();
            CLB3 = new CheckedListBox();
            Minute3 = new RichTextBox();
            Setari3 = new Button();
            Btn3 = new Button();
            LB3 = new ListBox();
            panel4 = new Panel();
            Done4 = new Button();
            Add4 = new RichTextBox();
            Minus4 = new Button();
            Plus4 = new Button();
            RTB4 = new RichTextBox();
            CLB4 = new CheckedListBox();
            Minute4 = new RichTextBox();
            Setari4 = new Button();
            Btn4 = new Button();
            LB4 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Min
            // 
            Min.BackColor = SystemColors.Info;
            Min.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Min.Location = new Point(19, 168);
            Min.Name = "Min";
            Min.Size = new Size(89, 35);
            Min.TabIndex = 16;
            Min.Text = "  Minute";
            Min.TextChanged += Min_TextChanged;
            // 
            // ToggleV
            // 
            ToggleV.BackColor = SystemColors.ActiveBorder;
            ToggleV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToggleV.Location = new Point(19, 42);
            ToggleV.Name = "ToggleV";
            ToggleV.Size = new Size(89, 35);
            ToggleV.TabIndex = 18;
            ToggleV.Text = "Hide";
            ToggleV.UseVisualStyleBackColor = false;
            ToggleV.Click += ToggleV_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.IndianRed;
            Reset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reset.Location = new Point(19, 102);
            Reset.Name = "Reset";
            Reset.Size = new Size(89, 35);
            Reset.TabIndex = 40;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // Timer1
            // 
            Timer1.Tick += Timer1_Tick;
            // 
            // Timer2
            // 
            Timer2.Tick += Timer2_Tick;
            // 
            // Timer3
            // 
            Timer3.Tick += Timer3_Tick;
            // 
            // Timer4
            // 
            Timer4.Tick += Timer4_Tick;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(Done1);
            panel1.Controls.Add(Add1);
            panel1.Controls.Add(CLB1);
            panel1.Controls.Add(Minus1);
            panel1.Controls.Add(Plus1);
            panel1.Controls.Add(RTB1);
            panel1.Controls.Add(Setari1);
            panel1.Controls.Add(Minute1);
            panel1.Controls.Add(Btn1);
            panel1.Controls.Add(LB1);
            panel1.Location = new Point(114, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 393);
            panel1.TabIndex = 49;
            panel1.DragDrop += Panel1_DragDrop;
            panel1.DragEnter += Panel1_DragEnter;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += Panel1_MouseDown;
            // 
            // Done1
            // 
            Done1.BackColor = Color.MediumSeaGreen;
            Done1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Done1.ForeColor = SystemColors.ButtonHighlight;
            Done1.ImageAlign = ContentAlignment.TopCenter;
            Done1.Location = new Point(10, 169);
            Done1.Name = "Done1";
            Done1.Size = new Size(131, 54);
            Done1.TabIndex = 60;
            Done1.Text = "Done";
            Done1.UseVisualStyleBackColor = false;
            Done1.Click += Done1_Click;
            // 
            // Add1
            // 
            Add1.BackColor = SystemColors.InactiveCaption;
            Add1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add1.Location = new Point(10, 131);
            Add1.Name = "Add1";
            Add1.Size = new Size(131, 32);
            Add1.TabIndex = 59;
            Add1.Text = "";
            Add1.TextChanged += Add1_TextChanged;
            // 
            // CLB1
            // 
            CLB1.FormattingEnabled = true;
            CLB1.Location = new Point(22, 131);
            CLB1.Name = "CLB1";
            CLB1.Size = new Size(110, 220);
            CLB1.TabIndex = 54;
            CLB1.SelectedIndexChanged += CLB1_SelectedIndexChanged;
            // 
            // Minus1
            // 
            Minus1.BackColor = SystemColors.ControlDarkDark;
            Minus1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minus1.ForeColor = Color.Red;
            Minus1.Location = new Point(83, 95);
            Minus1.Name = "Minus1";
            Minus1.Size = new Size(49, 30);
            Minus1.TabIndex = 57;
            Minus1.Text = "-";
            Minus1.TextAlign = ContentAlignment.TopCenter;
            Minus1.UseVisualStyleBackColor = false;
            Minus1.Click += Minus1_Click;
            // 
            // Plus1
            // 
            Plus1.BackColor = SystemColors.ControlDarkDark;
            Plus1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Plus1.ForeColor = Color.Chartreuse;
            Plus1.Location = new Point(22, 95);
            Plus1.Name = "Plus1";
            Plus1.Size = new Size(49, 30);
            Plus1.TabIndex = 56;
            Plus1.Text = "+";
            Plus1.TextAlign = ContentAlignment.TopCenter;
            Plus1.UseVisualStyleBackColor = false;
            Plus1.Click += Plus1_Click;
            // 
            // RTB1
            // 
            RTB1.BackColor = Color.Bisque;
            RTB1.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RTB1.Location = new Point(22, 54);
            RTB1.Name = "RTB1";
            RTB1.Size = new Size(110, 35);
            RTB1.TabIndex = 55;
            RTB1.Text = " Momeala";
            RTB1.TextChanged += RTB1_TextChanged;
            // 
            // Setari1
            // 
            Setari1.BackColor = SystemColors.ControlLight;
            Setari1.Font = new Font("Segoe UI", 9.75F);
            Setari1.Location = new Point(123, 0);
            Setari1.Name = "Setari1";
            Setari1.Size = new Size(27, 27);
            Setari1.TabIndex = 53;
            Setari1.Text = "⚙️";
            Setari1.UseVisualStyleBackColor = false;
            Setari1.Click += Setari1_Click;
            // 
            // Minute1
            // 
            Minute1.BackColor = SystemColors.Info;
            Minute1.Font = new Font("Segoe UI", 14.25F);
            Minute1.Location = new Point(39, 116);
            Minute1.Name = "Minute1";
            Minute1.Size = new Size(78, 38);
            Minute1.TabIndex = 52;
            Minute1.Text = "00:00";
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.Salmon;
            Btn1.Font = new Font("Segoe UI", 21.75F);
            Btn1.Location = new Point(39, 23);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(78, 78);
            Btn1.TabIndex = 51;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // LB1
            // 
            LB1.BackColor = Color.MistyRose;
            LB1.FormattingEnabled = true;
            LB1.ItemHeight = 15;
            LB1.Location = new Point(39, 162);
            LB1.Name = "LB1";
            LB1.Size = new Size(78, 214);
            LB1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(Done2);
            panel2.Controls.Add(Add2);
            panel2.Controls.Add(Minus2);
            panel2.Controls.Add(Plus2);
            panel2.Controls.Add(RTB2);
            panel2.Controls.Add(CLB2);
            panel2.Controls.Add(Minute2);
            panel2.Controls.Add(Setari2);
            panel2.Controls.Add(Btn2);
            panel2.Controls.Add(LB2);
            panel2.Location = new Point(276, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 393);
            panel2.TabIndex = 50;
            panel2.DragDrop += Panel2_DragDrop;
            panel2.DragEnter += Panel2_DragEnter;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += Panel2_MouseDown;
            // 
            // Done2
            // 
            Done2.BackColor = Color.MediumSeaGreen;
            Done2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Done2.ForeColor = SystemColors.ButtonHighlight;
            Done2.ImageAlign = ContentAlignment.TopCenter;
            Done2.Location = new Point(11, 169);
            Done2.Name = "Done2";
            Done2.Size = new Size(131, 54);
            Done2.TabIndex = 56;
            Done2.Text = "Done";
            Done2.UseVisualStyleBackColor = false;
            Done2.Click += Done2_Click;
            // 
            // Add2
            // 
            Add2.BackColor = SystemColors.InactiveCaption;
            Add2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add2.Location = new Point(11, 131);
            Add2.Name = "Add2";
            Add2.Size = new Size(131, 32);
            Add2.TabIndex = 55;
            Add2.Text = "";
            Add2.TextChanged += Add2_TextChanged;
            // 
            // Minus2
            // 
            Minus2.BackColor = SystemColors.ControlDarkDark;
            Minus2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minus2.ForeColor = Color.Red;
            Minus2.Location = new Point(84, 95);
            Minus2.Name = "Minus2";
            Minus2.Size = new Size(49, 30);
            Minus2.TabIndex = 53;
            Minus2.Text = "-";
            Minus2.TextAlign = ContentAlignment.TopCenter;
            Minus2.UseVisualStyleBackColor = false;
            Minus2.Click += Minus2_Click;
            // 
            // Plus2
            // 
            Plus2.BackColor = SystemColors.ControlDarkDark;
            Plus2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Plus2.ForeColor = Color.Chartreuse;
            Plus2.Location = new Point(23, 95);
            Plus2.Name = "Plus2";
            Plus2.Size = new Size(49, 30);
            Plus2.TabIndex = 52;
            Plus2.Text = "+";
            Plus2.TextAlign = ContentAlignment.TopCenter;
            Plus2.UseVisualStyleBackColor = false;
            Plus2.Click += Plus2_Click;
            // 
            // RTB2
            // 
            RTB2.BackColor = Color.Bisque;
            RTB2.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RTB2.Location = new Point(23, 54);
            RTB2.Name = "RTB2";
            RTB2.Size = new Size(110, 35);
            RTB2.TabIndex = 51;
            RTB2.Text = " Momeala";
            RTB2.TextChanged += RTB2_TextChanged;
            // 
            // CLB2
            // 
            CLB2.FormattingEnabled = true;
            CLB2.Location = new Point(23, 131);
            CLB2.Name = "CLB2";
            CLB2.Size = new Size(110, 220);
            CLB2.TabIndex = 50;
            CLB2.SelectedIndexChanged += CLB2_SelectedIndexChanged;
            // 
            // Minute2
            // 
            Minute2.BackColor = SystemColors.Info;
            Minute2.Font = new Font("Segoe UI", 14.25F);
            Minute2.Location = new Point(40, 116);
            Minute2.Name = "Minute2";
            Minute2.Size = new Size(78, 38);
            Minute2.TabIndex = 49;
            Minute2.Text = "00:00";
            // 
            // Setari2
            // 
            Setari2.BackColor = SystemColors.ControlLight;
            Setari2.Font = new Font("Segoe UI", 9.75F);
            Setari2.Location = new Point(124, 0);
            Setari2.Name = "Setari2";
            Setari2.Size = new Size(27, 27);
            Setari2.TabIndex = 48;
            Setari2.Text = "⚙️";
            Setari2.UseVisualStyleBackColor = false;
            Setari2.Click += Setari2_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Salmon;
            Btn2.Font = new Font("Segoe UI", 21.75F);
            Btn2.Location = new Point(40, 23);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(78, 78);
            Btn2.TabIndex = 47;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // LB2
            // 
            LB2.BackColor = Color.MistyRose;
            LB2.FormattingEnabled = true;
            LB2.ItemHeight = 15;
            LB2.Location = new Point(40, 162);
            LB2.Name = "LB2";
            LB2.Size = new Size(78, 214);
            LB2.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(Done3);
            panel3.Controls.Add(Add3);
            panel3.Controls.Add(Minus3);
            panel3.Controls.Add(Plus3);
            panel3.Controls.Add(RTB3);
            panel3.Controls.Add(CLB3);
            panel3.Controls.Add(Minute3);
            panel3.Controls.Add(Setari3);
            panel3.Controls.Add(Btn3);
            panel3.Controls.Add(LB3);
            panel3.Location = new Point(440, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 393);
            panel3.TabIndex = 51;
            panel3.DragDrop += Panel3_DragDrop;
            panel3.DragEnter += Panel3_DragEnter;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += Panel3_MouseDown;
            // 
            // Done3
            // 
            Done3.BackColor = Color.MediumSeaGreen;
            Done3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Done3.ForeColor = SystemColors.ButtonHighlight;
            Done3.ImageAlign = ContentAlignment.TopCenter;
            Done3.Location = new Point(9, 169);
            Done3.Name = "Done3";
            Done3.Size = new Size(131, 54);
            Done3.TabIndex = 57;
            Done3.Text = "Done";
            Done3.UseVisualStyleBackColor = false;
            Done3.Click += Done3_Click;
            // 
            // Add3
            // 
            Add3.BackColor = SystemColors.InactiveCaption;
            Add3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add3.Location = new Point(9, 131);
            Add3.Name = "Add3";
            Add3.Size = new Size(131, 32);
            Add3.TabIndex = 56;
            Add3.Text = "";
            Add3.TextChanged += Add3_TextChanged;
            // 
            // Minus3
            // 
            Minus3.BackColor = SystemColors.ControlDarkDark;
            Minus3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minus3.ForeColor = Color.Red;
            Minus3.Location = new Point(82, 95);
            Minus3.Name = "Minus3";
            Minus3.Size = new Size(49, 30);
            Minus3.TabIndex = 54;
            Minus3.Text = "-";
            Minus3.TextAlign = ContentAlignment.TopCenter;
            Minus3.UseVisualStyleBackColor = false;
            Minus3.Click += Minus3_Click;
            // 
            // Plus3
            // 
            Plus3.BackColor = SystemColors.ControlDarkDark;
            Plus3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Plus3.ForeColor = Color.Chartreuse;
            Plus3.Location = new Point(21, 95);
            Plus3.Name = "Plus3";
            Plus3.Size = new Size(49, 30);
            Plus3.TabIndex = 53;
            Plus3.Text = "+";
            Plus3.TextAlign = ContentAlignment.TopCenter;
            Plus3.UseVisualStyleBackColor = false;
            Plus3.Click += Plus3_Click;
            // 
            // RTB3
            // 
            RTB3.BackColor = Color.Bisque;
            RTB3.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RTB3.Location = new Point(21, 54);
            RTB3.Name = "RTB3";
            RTB3.Size = new Size(110, 35);
            RTB3.TabIndex = 52;
            RTB3.Text = " Momeala";
            RTB3.TextChanged += RTB3_TextChanged;
            // 
            // CLB3
            // 
            CLB3.FormattingEnabled = true;
            CLB3.Location = new Point(21, 131);
            CLB3.Name = "CLB3";
            CLB3.Size = new Size(110, 220);
            CLB3.TabIndex = 51;
            CLB3.SelectedIndexChanged += CLB3_SelectedIndexChanged;
            // 
            // Minute3
            // 
            Minute3.BackColor = SystemColors.Info;
            Minute3.Font = new Font("Segoe UI", 14.25F);
            Minute3.Location = new Point(38, 116);
            Minute3.Name = "Minute3";
            Minute3.Size = new Size(78, 38);
            Minute3.TabIndex = 50;
            Minute3.Text = "00:00";
            // 
            // Setari3
            // 
            Setari3.BackColor = SystemColors.ControlLight;
            Setari3.Font = new Font("Segoe UI", 9.75F);
            Setari3.Location = new Point(122, 0);
            Setari3.Name = "Setari3";
            Setari3.Size = new Size(27, 27);
            Setari3.TabIndex = 49;
            Setari3.Text = "⚙️";
            Setari3.UseVisualStyleBackColor = false;
            Setari3.Click += Setari3_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.Salmon;
            Btn3.Font = new Font("Segoe UI", 21.75F);
            Btn3.Location = new Point(38, 23);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(78, 78);
            Btn3.TabIndex = 48;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // LB3
            // 
            LB3.BackColor = Color.MistyRose;
            LB3.FormattingEnabled = true;
            LB3.ItemHeight = 15;
            LB3.Location = new Point(38, 162);
            LB3.Name = "LB3";
            LB3.Size = new Size(78, 214);
            LB3.TabIndex = 55;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(Done4);
            panel4.Controls.Add(Add4);
            panel4.Controls.Add(Minus4);
            panel4.Controls.Add(Plus4);
            panel4.Controls.Add(RTB4);
            panel4.Controls.Add(CLB4);
            panel4.Controls.Add(Minute4);
            panel4.Controls.Add(Setari4);
            panel4.Controls.Add(Btn4);
            panel4.Controls.Add(LB4);
            panel4.Location = new Point(609, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 393);
            panel4.TabIndex = 52;
            panel4.DragDrop += Panel4_DragDrop;
            panel4.DragEnter += Panel4_DragEnter;
            panel4.Paint += panel4_Paint;
            panel4.MouseDown += Panel4_MouseDown;
            // 
            // Done4
            // 
            Done4.BackColor = Color.MediumSeaGreen;
            Done4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Done4.ForeColor = SystemColors.ButtonHighlight;
            Done4.ImageAlign = ContentAlignment.TopCenter;
            Done4.Location = new Point(23, 169);
            Done4.Name = "Done4";
            Done4.Size = new Size(131, 54);
            Done4.TabIndex = 58;
            Done4.Text = "Done";
            Done4.UseVisualStyleBackColor = false;
            Done4.Click += Done4_Click;
            // 
            // Add4
            // 
            Add4.BackColor = SystemColors.InactiveCaption;
            Add4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add4.Location = new Point(23, 131);
            Add4.Name = "Add4";
            Add4.Size = new Size(131, 32);
            Add4.TabIndex = 57;
            Add4.Text = "";
            Add4.TextChanged += Add4_TextChanged;
            // 
            // Minus4
            // 
            Minus4.BackColor = SystemColors.ControlDarkDark;
            Minus4.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minus4.ForeColor = Color.Red;
            Minus4.Location = new Point(89, 93);
            Minus4.Name = "Minus4";
            Minus4.Size = new Size(49, 30);
            Minus4.TabIndex = 55;
            Minus4.Text = "-";
            Minus4.TextAlign = ContentAlignment.TopCenter;
            Minus4.UseVisualStyleBackColor = false;
            Minus4.Click += Minus4_Click;
            // 
            // Plus4
            // 
            Plus4.BackColor = SystemColors.ControlDarkDark;
            Plus4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Plus4.ForeColor = Color.Chartreuse;
            Plus4.Location = new Point(28, 93);
            Plus4.Name = "Plus4";
            Plus4.Size = new Size(49, 30);
            Plus4.TabIndex = 54;
            Plus4.Text = "+";
            Plus4.TextAlign = ContentAlignment.TopCenter;
            Plus4.UseVisualStyleBackColor = false;
            Plus4.Click += Plus4_Click;
            // 
            // RTB4
            // 
            RTB4.BackColor = Color.Bisque;
            RTB4.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RTB4.Location = new Point(28, 54);
            RTB4.Name = "RTB4";
            RTB4.Size = new Size(110, 35);
            RTB4.TabIndex = 53;
            RTB4.Text = " Momeala";
            RTB4.TextChanged += RTB4_TextChanged;
            // 
            // CLB4
            // 
            CLB4.FormattingEnabled = true;
            CLB4.Location = new Point(28, 131);
            CLB4.Name = "CLB4";
            CLB4.Size = new Size(110, 220);
            CLB4.TabIndex = 52;
            CLB4.SelectedIndexChanged += CLB4_SelectedIndexChanged;
            // 
            // Minute4
            // 
            Minute4.BackColor = SystemColors.Info;
            Minute4.Font = new Font("Segoe UI", 14.25F);
            Minute4.Location = new Point(43, 116);
            Minute4.Name = "Minute4";
            Minute4.Size = new Size(78, 38);
            Minute4.TabIndex = 51;
            Minute4.Text = "00:00";
            // 
            // Setari4
            // 
            Setari4.BackColor = SystemColors.ControlLight;
            Setari4.Font = new Font("Segoe UI", 9.75F);
            Setari4.Location = new Point(127, 0);
            Setari4.Name = "Setari4";
            Setari4.Size = new Size(27, 27);
            Setari4.TabIndex = 50;
            Setari4.Text = "⚙️";
            Setari4.UseVisualStyleBackColor = false;
            Setari4.Click += Setari4_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.Salmon;
            Btn4.Font = new Font("Segoe UI", 21.75F);
            Btn4.Location = new Point(43, 23);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(78, 78);
            Btn4.TabIndex = 49;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += Btn4_Click;
            // 
            // LB4
            // 
            LB4.BackColor = Color.MistyRose;
            LB4.FormattingEnabled = true;
            LB4.ItemHeight = 15;
            LB4.Location = new Point(43, 162);
            LB4.Name = "LB4";
            LB4.Size = new Size(78, 214);
            LB4.TabIndex = 56;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(Reset);
            Controls.Add(ToggleV);
            Controls.Add(Min);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox Min;
        private Button ToggleV;
        private Button Reset;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.Timer Timer4;
        private Panel panel1;
        private Button Done1;
        private RichTextBox Add1;
        private Button Minus1;
        private Button Plus1;
        private RichTextBox RTB1;
        private CheckedListBox CLB1;
        private Button Setari1;
        private RichTextBox Minute1;
        private Button Btn1;
        private ListBox LB1;
        private Panel panel2;
        private Button Done2;
        private RichTextBox Add2;
        private Button Minus2;
        private Button Plus2;
        private RichTextBox RTB2;
        private CheckedListBox CLB2;
        private RichTextBox Minute2;
        private Button Setari2;
        private Button Btn2;
        private ListBox LB2;
        private Panel panel3;
        private Button Done3;
        private RichTextBox Add3;
        private Button Minus3;
        private Button Plus3;
        private RichTextBox RTB3;
        private CheckedListBox CLB3;
        private RichTextBox Minute3;
        private Button Setari3;
        private Button Btn3;
        private ListBox LB3;
        private Panel panel4;
        private Button Done4;
        private RichTextBox Add4;
        private Button Minus4;
        private Button Plus4;
        private RichTextBox RTB4;
        private CheckedListBox CLB4;
        private RichTextBox Minute4;
        private Button Setari4;
        private Button Btn4;
        private ListBox LB4;
    }
}
