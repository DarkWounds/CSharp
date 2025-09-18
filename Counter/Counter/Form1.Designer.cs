namespace Counter
{
    partial class Counter
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
            Btn1 = new Button();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.ActiveCaption;
            Btn1.Location = new Point(120, 194);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(169, 68);
            Btn1.TabIndex = 0;
            Btn1.Text = "Counter ";
            Btn1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Salmon;
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(123, 109);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(166, 69);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "0";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(123, 191);
            button1.Name = "button1";
            button1.Size = new Size(169, 68);
            button1.TabIndex = 2;
            button1.Text = "Counter ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.MediumSeaGreen;
            Btn2.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Btn2.Location = new Point(123, 268);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(169, 68);
            Btn2.TabIndex = 3;
            Btn2.Text = "Reset";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.DeepSkyBlue;
            Btn3.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Btn3.Location = new Point(123, 342);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(169, 68);
            Btn3.TabIndex = 4;
            Btn3.Text = "Toggle";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // Counter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(415, 450);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(Btn1);
            Name = "Counter";
            Text = "Counter";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button Btn2;
        private Button Btn3;
    }
}
