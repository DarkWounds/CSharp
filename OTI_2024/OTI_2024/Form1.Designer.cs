namespace OTI_2024
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbSoare = new PictureBox();
            rtbEmail = new RichTextBox();
            rtbParola = new RichTextBox();
            tbEmail = new TextBox();
            tbParola = new TextBox();
            btnAutentificare = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSoare).BeginInit();
            SuspendLayout();
            // 
            // pbSoare
            // 
            pbSoare.BackColor = Color.Transparent;
            pbSoare.BackgroundImage = (Image)resources.GetObject("pbSoare.BackgroundImage");
            pbSoare.BackgroundImageLayout = ImageLayout.Stretch;
            pbSoare.Location = new Point(35, 62);
            pbSoare.Name = "pbSoare";
            pbSoare.Size = new Size(177, 173);
            pbSoare.TabIndex = 0;
            pbSoare.TabStop = false;
            // 
            // rtbEmail
            // 
            rtbEmail.BackColor = Color.Lavender;
            rtbEmail.BorderStyle = BorderStyle.None;
            rtbEmail.Font = new Font("SimSun-ExtG", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbEmail.Location = new Point(311, 101);
            rtbEmail.Name = "rtbEmail";
            rtbEmail.Size = new Size(176, 21);
            rtbEmail.TabIndex = 1;
            rtbEmail.Text = "";
            rtbEmail.TextChanged += RtbEmail_TextChanged;
            // 
            // rtbParola
            // 
            rtbParola.BackColor = Color.Lavender;
            rtbParola.BorderStyle = BorderStyle.None;
            rtbParola.Font = new Font("SimSun-ExtG", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbParola.Location = new Point(311, 158);
            rtbParola.Name = "rtbParola";
            rtbParola.Size = new Size(176, 21);
            rtbParola.TabIndex = 2;
            rtbParola.Text = "";
            rtbParola.TextChanged += RtbParola_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.MistyRose;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(243, 101);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(62, 21);
            tbEmail.TabIndex = 3;
            tbEmail.Text = "Email";
            tbEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // tbParola
            // 
            tbParola.BackColor = Color.MistyRose;
            tbParola.BorderStyle = BorderStyle.None;
            tbParola.Font = new Font("MS PGothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbParola.Location = new Point(243, 158);
            tbParola.Name = "tbParola";
            tbParola.ReadOnly = true;
            tbParola.Size = new Size(62, 21);
            tbParola.TabIndex = 4;
            tbParola.Text = "Parola";
            tbParola.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAutentificare
            // 
            btnAutentificare.BackColor = Color.Transparent;
            btnAutentificare.BackgroundImage = (Image)resources.GetObject("btnAutentificare.BackgroundImage");
            btnAutentificare.BackgroundImageLayout = ImageLayout.Stretch;
            btnAutentificare.Location = new Point(515, 62);
            btnAutentificare.Name = "btnAutentificare";
            btnAutentificare.Size = new Size(182, 173);
            btnAutentificare.TabIndex = 5;
            btnAutentificare.UseVisualStyleBackColor = false;
            btnAutentificare.Click += BtnAutentificare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            ClientSize = new Size(722, 337);
            Controls.Add(btnAutentificare);
            Controls.Add(tbParola);
            Controls.Add(tbEmail);
            Controls.Add(rtbParola);
            Controls.Add(rtbEmail);
            Controls.Add(pbSoare);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbSoare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSoare;
        private RichTextBox rtbEmail;
        private RichTextBox rtbParola;
        private TextBox tbEmail;
        private TextBox tbParola;
        private Button btnAutentificare;
    }
}
