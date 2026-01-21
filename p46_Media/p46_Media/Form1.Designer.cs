namespace p46_Media
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNotele = new System.Windows.Forms.TextBox();
            this.tbxMedia = new System.Windows.Forms.TextBox();
            this.btniesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scrieti notele fara spatii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Media:";
            // 
            // tbxNotele
            // 
            this.tbxNotele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotele.Location = new System.Drawing.Point(130, 196);
            this.tbxNotele.Name = "tbxNotele";
            this.tbxNotele.Size = new System.Drawing.Size(258, 29);
            this.tbxNotele.TabIndex = 2;
            this.tbxNotele.TextChanged += new System.EventHandler(this.tbxNotele_TextChanged);
            // 
            // tbxMedia
            // 
            this.tbxMedia.Enabled = false;
            this.tbxMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMedia.Location = new System.Drawing.Point(231, 277);
            this.tbxMedia.Name = "tbxMedia";
            this.tbxMedia.Size = new System.Drawing.Size(84, 29);
            this.tbxMedia.TabIndex = 3;
            this.tbxMedia.Text = "0";
            // 
            // btniesire
            // 
            this.btniesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniesire.Location = new System.Drawing.Point(485, 319);
            this.btniesire.Name = "btniesire";
            this.btniesire.Size = new System.Drawing.Size(112, 71);
            this.btniesire.TabIndex = 4;
            this.btniesire.Text = "Iesire";
            this.btniesire.UseVisualStyleBackColor = true;
            this.btniesire.Click += new System.EventHandler(this.btniesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniesire;
            this.ClientSize = new System.Drawing.Size(626, 429);
            this.Controls.Add(this.btniesire);
            this.Controls.Add(this.tbxMedia);
            this.Controls.Add(this.tbxNotele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNotele;
        private System.Windows.Forms.TextBox tbxMedia;
        private System.Windows.Forms.Button btniesire;
    }
}

