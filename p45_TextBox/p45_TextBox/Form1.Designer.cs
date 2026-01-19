namespace p45_TextBox
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.tBA = new System.Windows.Forms.TextBox();
            this.tBB = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.tBSuma = new System.Windows.Forms.TextBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(212, 75);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(804, 31);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Adunam dou numere naturale curpinse intre 0 si 999.999.999";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(212, 162);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(71, 33);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A = ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(212, 222);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(71, 33);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B = ";
            // 
            // tBA
            // 
            this.tBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBA.Location = new System.Drawing.Point(289, 162);
            this.tBA.Name = "tBA";
            this.tBA.Size = new System.Drawing.Size(401, 40);
            this.tBA.TabIndex = 3;
            this.tBA.Text = "0";
            this.tBA.TextChanged += new System.EventHandler(this.tBA_TextChanged);
            // 
            // tBB
            // 
            this.tBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBB.Location = new System.Drawing.Point(289, 222);
            this.tBB.Name = "tBB";
            this.tBB.Size = new System.Drawing.Size(401, 40);
            this.tBB.TabIndex = 4;
            this.tBB.Text = "0";
            this.tBB.TextChanged += new System.EventHandler(this.tBB_TextChanged);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(212, 327);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(122, 33);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Suma =";
            // 
            // tBSuma
            // 
            this.tBSuma.Enabled = false;
            this.tBSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSuma.Location = new System.Drawing.Point(349, 324);
            this.tBSuma.Name = "tBSuma";
            this.tBSuma.Size = new System.Drawing.Size(473, 40);
            this.tBSuma.TabIndex = 6;
            this.tBSuma.Text = "0";
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(967, 474);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(152, 51);
            this.btnIesire.TabIndex = 7;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIesire;
            this.ClientSize = new System.Drawing.Size(1185, 570);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.tBSuma);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.tBB);
            this.Controls.Add(this.tBA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adunarea A + B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tBA;
        private System.Windows.Forms.TextBox tBB;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox tBSuma;
        private System.Windows.Forms.Button btnIesire;
    }
}

