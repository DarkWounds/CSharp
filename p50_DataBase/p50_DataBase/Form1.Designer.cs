namespace p50_DataBase
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
            this.listBoxAfisare = new System.Windows.Forms.ListBox();
            this.btnAfis = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPunctaj = new System.Windows.Forms.TextBox();
            this.tbxNume = new System.Windows.Forms.TextBox();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAfisare
            // 
            this.listBoxAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAfisare.FormattingEnabled = true;
            this.listBoxAfisare.ItemHeight = 24;
            this.listBoxAfisare.Location = new System.Drawing.Point(12, 110);
            this.listBoxAfisare.Name = "listBoxAfisare";
            this.listBoxAfisare.Size = new System.Drawing.Size(481, 412);
            this.listBoxAfisare.TabIndex = 0;
            // 
            // btnAfis
            // 
            this.btnAfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfis.Location = new System.Drawing.Point(138, 40);
            this.btnAfis.Name = "btnAfis";
            this.btnAfis.Size = new System.Drawing.Size(201, 53);
            this.btnAfis.TabIndex = 1;
            this.btnAfis.Text = "Afisare date";
            this.btnAfis.UseVisualStyleBackColor = true;
            this.btnAfis.Click += new System.EventHandler(this.btnAfis_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(912, 553);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adaugare Inregistrari";
            // 
            // tbxPunctaj
            // 
            this.tbxPunctaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPunctaj.Location = new System.Drawing.Point(759, 236);
            this.tbxPunctaj.Name = "tbxPunctaj";
            this.tbxPunctaj.Size = new System.Drawing.Size(90, 31);
            this.tbxPunctaj.TabIndex = 8;
            // 
            // tbxNume
            // 
            this.tbxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNume.Location = new System.Drawing.Point(759, 163);
            this.tbxNume.Name = "tbxNume";
            this.tbxNume.Size = new System.Drawing.Size(262, 31);
            this.tbxNume.TabIndex = 9;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(635, 329);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(376, 53);
            this.btnInregistrare.TabIndex = 10;
            this.btnInregistrare.Text = "Adauga Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Punctaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1160, 626);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.tbxNume);
            this.Controls.Add(this.tbxPunctaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAfis);
            this.Controls.Add(this.listBoxAfisare);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAfisare;
        private System.Windows.Forms.Button btnAfis;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPunctaj;
        private System.Windows.Forms.TextBox tbxNume;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

