namespace OTI_2024
{
    partial class Alege_opțiunea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alege_opțiunea));
            pbJoc = new PictureBox();
            pbMiscare = new PictureBox();
            btnStart = new Button();
            btnExit = new Button();
            ckbMiscare = new CheckBox();
            ckbJoc = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbJoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMiscare).BeginInit();
            SuspendLayout();
            // 
            // pbJoc
            // 
            pbJoc.BackgroundImage = Properties.Resources.Back2;
            pbJoc.BackgroundImageLayout = ImageLayout.Stretch;
            pbJoc.Location = new Point(687, 39);
            pbJoc.Name = "pbJoc";
            pbJoc.Size = new Size(550, 400);
            pbJoc.TabIndex = 1;
            pbJoc.TabStop = false;
            pbJoc.Click += PbJoc_Click;
            // 
            // pbMiscare
            // 
            pbMiscare.BackgroundImage = Properties.Resources.sistem_solar;
            pbMiscare.BackgroundImageLayout = ImageLayout.Stretch;
            pbMiscare.Location = new Point(52, 39);
            pbMiscare.Name = "pbMiscare";
            pbMiscare.Size = new Size(550, 400);
            pbMiscare.TabIndex = 2;
            pbMiscare.TabStop = false;
            pbMiscare.Click += PbMiscare_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.BlueViolet;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold);
            btnStart.Location = new Point(52, 550);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 100);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.BlueViolet;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold);
            btnExit.Location = new Point(1090, 550);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 100);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // ckbMiscare
            // 
            ckbMiscare.AutoSize = true;
            ckbMiscare.BackColor = Color.Transparent;
            ckbMiscare.Font = new Font("SimSun-ExtG", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbMiscare.ForeColor = SystemColors.ButtonFace;
            ckbMiscare.Location = new Point(214, 471);
            ckbMiscare.Name = "ckbMiscare";
            ckbMiscare.Size = new Size(209, 23);
            ckbMiscare.TabIndex = 5;
            ckbMiscare.Text = "Mișcare Pământ-Lună";
            ckbMiscare.UseVisualStyleBackColor = false;
            ckbMiscare.CheckedChanged += CbMiscare_CheckedChanged;
            ckbMiscare.Click += cbMiscare_Click;
            // 
            // ckbJoc
            // 
            ckbJoc.AutoSize = true;
            ckbJoc.BackColor = Color.Transparent;
            ckbJoc.Font = new Font("SimSun-ExtG", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbJoc.ForeColor = SystemColors.ButtonFace;
            ckbJoc.Location = new Point(925, 471);
            ckbJoc.Name = "ckbJoc";
            ckbJoc.Size = new Size(118, 23);
            ckbJoc.TabIndex = 6;
            ckbJoc.Text = "Space War";
            ckbJoc.UseVisualStyleBackColor = false;
            ckbJoc.CheckedChanged += CbJoc_CheckedChanged;
            ckbJoc.Click += CbJoc_Click;
            // 
            // Alege_opțiunea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            ClientSize = new Size(1280, 692);
            Controls.Add(ckbJoc);
            Controls.Add(ckbMiscare);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(pbMiscare);
            Controls.Add(pbJoc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Alege_opțiunea";
            Text = "Alege_opțiunea";
            ((System.ComponentModel.ISupportInitialize)pbJoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMiscare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbJoc;
        private PictureBox pbMiscare;
        private Button btnStart;
        private Button btnExit;
        private CheckBox ckbMiscare;
        private CheckBox ckbJoc;
    }
}