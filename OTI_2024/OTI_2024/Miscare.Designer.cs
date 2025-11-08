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
            ((System.ComponentModel.ISupportInitialize)pbSoare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPamant).BeginInit();
            SuspendLayout();
            // 
            // pbSoare
            // 
            pbSoare.BackColor = Color.Transparent;
            pbSoare.BackgroundImage = (Image)resources.GetObject("pbSoare.BackgroundImage");
            pbSoare.BackgroundImageLayout = ImageLayout.Stretch;
            pbSoare.ErrorImage = null;
            pbSoare.Location = new Point(374, 315);
            pbSoare.Name = "pbSoare";
            pbSoare.Size = new Size(50, 50);
            pbSoare.TabIndex = 0;
            pbSoare.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(969, 103);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(216, 90);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(969, 275);
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
            pbPamant.Location = new Point(494, 176);
            pbPamant.Name = "pbPamant";
            pbPamant.Size = new Size(50, 50);
            pbPamant.TabIndex = 4;
            pbPamant.TabStop = false;
            // 
            // Miscare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1319, 687);
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSoare;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer animationTimer;
        private PictureBox pbPamant;
        private System.Windows.Forms.Timer timerVerif;
    }
}