namespace p44_Button
{
    partial class Form1
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
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.gbButoane = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nUpDown
            // 
            this.nUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown.Location = new System.Drawing.Point(463, 155);
            this.nUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(66, 38);
            this.nUpDown.TabIndex = 1;
            this.nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // gbButoane
            // 
            this.gbButoane.Location = new System.Drawing.Point(56, 233);
            this.gbButoane.Name = "gbButoane";
            this.gbButoane.Size = new System.Drawing.Size(948, 231);
            this.gbButoane.TabIndex = 2;
            this.gbButoane.TabStop = false;
            this.gbButoane.Text = "0 butoane";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 519);
            this.Controls.Add(this.gbButoane);
            this.Controls.Add(this.nUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.GroupBox gbButoane;
    }
}

