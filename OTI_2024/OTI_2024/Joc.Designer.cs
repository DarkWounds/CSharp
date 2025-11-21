namespace OTI_2024
{
    partial class Joc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pbBack = new PictureBox();
            btnPauza = new Button();
            btnStop = new Button();
            btnStart = new Button();
            Scor = new TextBox();
            Vieti = new TextBox();
            tbVieti = new TextBox();
            tbScor = new TextBox();
            pbNava = new PictureBox();
            timerInamici = new System.Windows.Forms.Timer(components);
            timerViata = new System.Windows.Forms.Timer(components);
            tMiscareInamici = new System.Windows.Forms.Timer(components);
            timerMiscareNaveta = new System.Windows.Forms.Timer(components);
            tIntersectare = new System.Windows.Forms.Timer(components);
            timerAsteroizi = new System.Windows.Forms.Timer(components);
            timerAnimatii = new System.Windows.Forms.Timer(components);
            vSlide = new NAudio.Gui.VolumeSlider();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNava).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(150, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbBack
            // 
            pbBack.BackColor = Color.Black;
            pbBack.BackgroundImageLayout = ImageLayout.Stretch;
            pbBack.Location = new Point(39, 59);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(800, 500);
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // btnPauza
            // 
            btnPauza.BackColor = Color.Transparent;
            btnPauza.BackgroundImage = Properties.Resources.Pauza;
            btnPauza.BackgroundImageLayout = ImageLayout.Stretch;
            btnPauza.Location = new Point(1065, 459);
            btnPauza.Name = "btnPauza";
            btnPauza.Size = new Size(100, 100);
            btnPauza.TabIndex = 2;
            btnPauza.UseVisualStyleBackColor = false;
            btnPauza.Click += btnPauza_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Transparent;
            btnStop.BackgroundImage = Properties.Resources.Stop;
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Location = new Point(1197, 459);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 100);
            btnStop.TabIndex = 3;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImage = Properties.Resources.Start;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Location = new Point(933, 459);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 100);
            btnStart.TabIndex = 4;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Scor
            // 
            Scor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Scor.BorderStyle = BorderStyle.None;
            Scor.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            Scor.Location = new Point(996, 88);
            Scor.Name = "Scor";
            Scor.ReadOnly = true;
            Scor.Size = new Size(81, 36);
            Scor.TabIndex = 5;
            Scor.Text = "Scor";
            Scor.TextAlign = HorizontalAlignment.Center;
            // 
            // Vieti
            // 
            Vieti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Vieti.BorderStyle = BorderStyle.None;
            Vieti.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            Vieti.Location = new Point(996, 164);
            Vieti.Name = "Vieti";
            Vieti.ReadOnly = true;
            Vieti.Size = new Size(81, 36);
            Vieti.TabIndex = 6;
            Vieti.Text = "Vieti";
            Vieti.TextAlign = HorizontalAlignment.Center;
            // 
            // tbVieti
            // 
            tbVieti.BorderStyle = BorderStyle.None;
            tbVieti.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            tbVieti.Location = new Point(1083, 164);
            tbVieti.Name = "tbVieti";
            tbVieti.ReadOnly = true;
            tbVieti.Size = new Size(53, 36);
            tbVieti.TabIndex = 7;
            tbVieti.Text = "3";
            tbVieti.TextAlign = HorizontalAlignment.Center;
            // 
            // tbScor
            // 
            tbScor.BorderStyle = BorderStyle.None;
            tbScor.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            tbScor.Location = new Point(1083, 88);
            tbScor.Name = "tbScor";
            tbScor.ReadOnly = true;
            tbScor.Size = new Size(53, 36);
            tbScor.TabIndex = 8;
            tbScor.Text = "0";
            tbScor.TextAlign = HorizontalAlignment.Center;
            // 
            // pbNava
            // 
            pbNava.BackColor = Color.Black;
            pbNava.BackgroundImage = Properties.Resources.navaStop;
            pbNava.BackgroundImageLayout = ImageLayout.Stretch;
            pbNava.Location = new Point(50, 296);
            pbNava.Name = "pbNava";
            pbNava.Size = new Size(70, 50);
            pbNava.TabIndex = 9;
            pbNava.TabStop = false;
            // 
            // vSlide
            // 
            vSlide.Location = new Point(1197, 415);
            vSlide.Name = "vSlide";
            vSlide.Size = new Size(96, 24);
            vSlide.TabIndex = 10;
            vSlide.Load += vSlide_Load;
            // 
            // Joc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 612);
            Controls.Add(vSlide);
            Controls.Add(pbNava);
            Controls.Add(tbScor);
            Controls.Add(tbVieti);
            Controls.Add(Vieti);
            Controls.Add(Scor);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnPauza);
            Controls.Add(pbBack);
            Controls.Add(pictureBox1);
            Name = "Joc";
            RightToLeft = RightToLeft.No;
            Text = "Joc";
            KeyDown += Joc_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbBack;
        private Button btnPauza;
        private Button btnStop;
        private Button btnStart;
        private TextBox Scor;
        private TextBox Vieti;
        private TextBox tbVieti;
        private TextBox tbScor;
        private PictureBox pbNava;
        private System.Windows.Forms.Timer timerInamici;
        private System.Windows.Forms.Timer timerViata;
        private System.Windows.Forms.Timer tMiscareInamici;
        private System.Windows.Forms.Timer timerMiscareNaveta;
        private System.Windows.Forms.Timer tIntersectare;
        private System.Windows.Forms.Timer timerAsteroizi;
        private System.Windows.Forms.Timer timerAnimatii;
        private NAudio.Gui.VolumeSlider vSlide;
    }
}