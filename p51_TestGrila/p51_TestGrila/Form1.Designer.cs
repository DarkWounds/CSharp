namespace p51_TestGrila
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.lblPagCurent = new System.Windows.Forms.Label();
            this.lblNrIntrebari = new System.Windows.Forms.Label();
            this.lblBara = new System.Windows.Forms.Label();
            this.btnIntrebare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(391, 220);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(509, 145);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Incepe testul";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(1131, 528);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(105, 44);
            this.btnIesire.TabIndex = 1;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrebare.Location = new System.Drawing.Point(109, 74);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(125, 20);
            this.lblIntrebare.TabIndex = 2;
            this.lblIntrebare.Text = "Aici va fi textul";
            this.lblIntrebare.Visible = false;
            // 
            // lblPagCurent
            // 
            this.lblPagCurent.AutoSize = true;
            this.lblPagCurent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagCurent.Location = new System.Drawing.Point(1045, 50);
            this.lblPagCurent.Name = "lblPagCurent";
            this.lblPagCurent.Size = new System.Drawing.Size(19, 20);
            this.lblPagCurent.TabIndex = 3;
            this.lblPagCurent.Text = "1";
            this.lblPagCurent.Visible = false;
            // 
            // lblNrIntrebari
            // 
            this.lblNrIntrebari.AutoSize = true;
            this.lblNrIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrIntrebari.Location = new System.Drawing.Point(1105, 50);
            this.lblNrIntrebari.Name = "lblNrIntrebari";
            this.lblNrIntrebari.Size = new System.Drawing.Size(29, 20);
            this.lblNrIntrebari.TabIndex = 5;
            this.lblNrIntrebari.Text = "10";
            this.lblNrIntrebari.Visible = false;
            // 
            // lblBara
            // 
            this.lblBara.AutoSize = true;
            this.lblBara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBara.Location = new System.Drawing.Point(1080, 50);
            this.lblBara.Name = "lblBara";
            this.lblBara.Size = new System.Drawing.Size(14, 20);
            this.lblBara.TabIndex = 6;
            this.lblBara.Text = "/";
            this.lblBara.Visible = false;
            // 
            // btnIntrebare
            // 
            this.btnIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntrebare.Location = new System.Drawing.Point(863, 439);
            this.btnIntrebare.Name = "btnIntrebare";
            this.btnIntrebare.Size = new System.Drawing.Size(261, 74);
            this.btnIntrebare.TabIndex = 7;
            this.btnIntrebare.Text = "Next question";
            this.btnIntrebare.UseVisualStyleBackColor = true;
            this.btnIntrebare.Click += new System.EventHandler(this.btnIntrebare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIesire;
            this.ClientSize = new System.Drawing.Size(1274, 608);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnIntrebare);
            this.Controls.Add(this.lblBara);
            this.Controls.Add(this.lblNrIntrebari);
            this.Controls.Add(this.lblPagCurent);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.btnIesire);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.Label lblPagCurent;
        private System.Windows.Forms.Label lblNrIntrebari;
        private System.Windows.Forms.Label lblBara;
        private System.Windows.Forms.Button btnIntrebare;
    }
}

