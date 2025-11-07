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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miscare));
            pbSoare = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSoare).BeginInit();
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
            // 
            // btnStop
            // 
            btnStop.Location = new Point(969, 275);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(216, 90);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // Miscare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1319, 687);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pbSoare);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Miscare";
            Text = "Miscare";
            Load += Miscare_Load;
            ((System.ComponentModel.ISupportInitialize)pbSoare).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSoare;
        private Button btnStart;
        private Button btnStop;
    }
}