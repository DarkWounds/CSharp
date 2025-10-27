namespace OTI_2025
{
    partial class Save
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
            pbBarca = new PictureBox();
            lbInsule = new ListBox();
            btnFoto = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBarca).BeginInit();
            SuspendLayout();
            // 
            // pbBarca
            // 
            pbBarca.BackgroundImage = Properties.Resources.barcaAI;
            pbBarca.BackgroundImageLayout = ImageLayout.Stretch;
            pbBarca.Location = new Point(23, 56);
            pbBarca.Name = "pbBarca";
            pbBarca.Size = new Size(324, 294);
            pbBarca.TabIndex = 0;
            pbBarca.TabStop = false;
            // 
            // lbInsule
            // 
            lbInsule.FormattingEnabled = true;
            lbInsule.ItemHeight = 15;
            lbInsule.Location = new Point(407, 56);
            lbInsule.Name = "lbInsule";
            lbInsule.Size = new Size(139, 289);
            lbInsule.TabIndex = 1;
            lbInsule.SelectedIndexChanged += lbInsule_SelectedIndexChanged;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(597, 56);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(126, 91);
            btnFoto.TabIndex = 2;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(597, 254);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 91);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Save
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnFoto);
            Controls.Add(lbInsule);
            Controls.Add(pbBarca);
            Name = "Save";
            Text = "Save";
            ((System.ComponentModel.ISupportInitialize)pbBarca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBarca;
        private ListBox lbInsule;
        private Button btnFoto;
        private Button btnExit;
    }
}