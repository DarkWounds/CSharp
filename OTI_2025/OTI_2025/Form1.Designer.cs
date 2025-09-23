namespace OTI_2025
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tUtilizator = new TextBox();
            tParola = new TextBox();
            Btn1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumPurple;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(145, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 37);
            textBox1.TabIndex = 1;
            textBox1.Text = "Utilizator";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MediumPurple;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold | FontStyle.Italic);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(187, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(83, 37);
            textBox2.TabIndex = 2;
            textBox2.Text = "Parola";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // tUtilizator
            // 
            tUtilizator.BackColor = Color.Azure;
            tUtilizator.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            tUtilizator.Location = new Point(286, 49);
            tUtilizator.Name = "tUtilizator";
            tUtilizator.Size = new Size(199, 29);
            tUtilizator.TabIndex = 3;
            tUtilizator.TextChanged += tUtilizator_TextChanged;
            // 
            // tParola
            // 
            tParola.BackColor = Color.Azure;
            tParola.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            tParola.Location = new Point(286, 112);
            tParola.Name = "tParola";
            tParola.Size = new Size(199, 29);
            tParola.TabIndex = 4;
            tParola.TextChanged += tParola_TextChanged;
            // 
            // Btn1
            // 
            Btn1.Image = Properties.Resources.barca;
            Btn1.Location = new Point(12, 35);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(123, 123);
            Btn1.TabIndex = 0;
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(544, 181);
            Controls.Add(tParola);
            Controls.Add(tUtilizator);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Btn1);
            Name = "Form1";
            Text = "Autentificare";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tUtilizator;
        private TextBox tParola;
        private Button Btn1;
    }
}
