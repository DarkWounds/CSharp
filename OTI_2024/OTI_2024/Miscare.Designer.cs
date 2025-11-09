namespace OTI_2024
{
    partial class Miscare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miscare));
            pbSoare = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            animationTimer = new System.Windows.Forms.Timer(components);
            pbPamant = new PictureBox();
            timerVerif = new System.Windows.Forms.Timer(components);
            pbLuna = new PictureBox();
            rtbData = new RichTextBox();
            Data = new RichTextBox();
            Anotimp = new RichTextBox();
            rtbAnotimp = new RichTextBox();
            Distanta = new RichTextBox();
            rtbDistanta = new RichTextBox();
            timerData = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbSoare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPamant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLuna).BeginInit();
            SuspendLayout();
            // 
            // pbSoare
            // 
            pbSoare.BackColor = Color.Transparent;
            pbSoare.BackgroundImage = (Image)resources.GetObject("pbSoare.BackgroundImage");
            pbSoare.BackgroundImageLayout = ImageLayout.Stretch;
            pbSoare.ErrorImage = null;
            pbSoare.Location = new Point(386, 289);
            pbSoare.Name = "pbSoare";
            pbSoare.Size = new Size(100, 100);
            pbSoare.TabIndex = 0;
            pbSoare.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(969, 24);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(216, 90);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(969, 156);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(216, 90);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // animationTimer
            // 
            animationTimer.Tick += timer1_Tick;
            // 
            // pbPamant
            // 
            pbPamant.BackColor = Color.Transparent;
            pbPamant.BackgroundImage = Properties.Resources.Pamant;
            pbPamant.BackgroundImageLayout = ImageLayout.Stretch;
            pbPamant.Location = new Point(562, 189);
            pbPamant.Name = "pbPamant";
            pbPamant.Size = new Size(25, 25);
            pbPamant.TabIndex = 4;
            pbPamant.TabStop = false;
            // 
            // pbLuna
            // 
            pbLuna.BackColor = Color.Transparent;
            pbLuna.BackgroundImage = Properties.Resources.moon;
            pbLuna.BackgroundImageLayout = ImageLayout.Stretch;
            pbLuna.Location = new Point(587, 129);
            pbLuna.Name = "pbLuna";
            pbLuna.Size = new Size(10, 10);
            pbLuna.TabIndex = 5;
            pbLuna.TabStop = false;
            // 
            // rtbData
            // 
            rtbData.Location = new Point(1085, 289);
            rtbData.Name = "rtbData";
            rtbData.ReadOnly = true;
            rtbData.Size = new Size(177, 27);
            rtbData.TabIndex = 6;
            rtbData.Text = "";
            // 
            // Data
            // 
            Data.Location = new Point(969, 289);
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Size = new Size(100, 27);
            Data.TabIndex = 7;
            Data.Text = "Data";
            // 
            // Anotimp
            // 
            Anotimp.Location = new Point(969, 347);
            Anotimp.Name = "Anotimp";
            Anotimp.ReadOnly = true;
            Anotimp.Size = new Size(100, 27);
            Anotimp.TabIndex = 9;
            Anotimp.Text = "Anotimp";
            // 
            // rtbAnotimp
            // 
            rtbAnotimp.Location = new Point(1085, 347);
            rtbAnotimp.Name = "rtbAnotimp";
            rtbAnotimp.ReadOnly = true;
            rtbAnotimp.Size = new Size(177, 27);
            rtbAnotimp.TabIndex = 8;
            rtbAnotimp.Text = "";
            // 
            // Distanta
            // 
            Distanta.Location = new Point(969, 402);
            Distanta.Name = "Distanta";
            Distanta.ReadOnly = true;
            Distanta.Size = new Size(100, 46);
            Distanta.TabIndex = 11;
            Distanta.Text = "Distanta";
            // 
            // rtbDistanta
            // 
            rtbDistanta.Location = new Point(1085, 402);
            rtbDistanta.Name = "rtbDistanta";
            rtbDistanta.ReadOnly = true;
            rtbDistanta.Size = new Size(177, 46);
            rtbDistanta.TabIndex = 10;
            rtbDistanta.Text = "";
            // 
            // Miscare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1319, 687);
            Controls.Add(Distanta);
            Controls.Add(rtbDistanta);
            Controls.Add(Anotimp);
            Controls.Add(rtbAnotimp);
            Controls.Add(Data);
            Controls.Add(rtbData);
            Controls.Add(pbLuna);
            Controls.Add(pbPamant);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pbSoare);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Miscare";
            Text = "Miscare";
            Load += Miscare_Load;
            ((System.ComponentModel.ISupportInitialize)pbSoare).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPamant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLuna).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSoare;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer animationTimer;
        private PictureBox pbPamant;
        private System.Windows.Forms.Timer timerVerif;
        private PictureBox pbLuna;
        private RichTextBox rtbData;
        private RichTextBox Data;
        private RichTextBox Anotimp;
        private RichTextBox rtbAnotimp;
        private RichTextBox Distanta;
        private RichTextBox rtbDistanta;
        private System.Windows.Forms.Timer timerData;
    }
}