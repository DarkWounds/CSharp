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
            Btn1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tUtilizator = new TextBox();
            tParola = new TextBox();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.Image = Properties.Resources.barca;
            Btn1.Location = new Point(12, 35);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(123, 121);
            Btn1.TabIndex = 0;
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(159, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 28);
            textBox1.TabIndex = 1;
            textBox1.Text = "Utilizator";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(190, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 28);
            textBox2.TabIndex = 2;
            textBox2.Text = "Parola";
            // 
            // tUtilizator
            // 
            tUtilizator.Location = new Point(286, 49);
            tUtilizator.Name = "tUtilizator";
            tUtilizator.Size = new Size(199, 23);
            tUtilizator.TabIndex = 3;
            tUtilizator.TextChanged += tUtilizator_TextChanged;
            // 
            // tParola
            // 
            tParola.Location = new Point(286, 97);
            tParola.Name = "tParola";
            tParola.Size = new Size(199, 23);
            tParola.TabIndex = 4;
            tParola.TextChanged += tParola_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(543, 181);
            Controls.Add(tParola);
            Controls.Add(tUtilizator);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Btn1);
            Name = "Form1";
            Text = "Autentificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tUtilizator;
        private TextBox tParola;
    }
}
