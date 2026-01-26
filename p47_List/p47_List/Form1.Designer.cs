namespace p47_List
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
            this.lbxStanga = new System.Windows.Forms.ListBox();
            this.lbxDreapta = new System.Windows.Forms.ListBox();
            this.btnAddLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCauta = new System.Windows.Forms.TextBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnAddRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStanga
            // 
            this.lbxStanga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStanga.FormattingEnabled = true;
            this.lbxStanga.ItemHeight = 25;
            this.lbxStanga.Location = new System.Drawing.Point(157, 213);
            this.lbxStanga.Name = "lbxStanga";
            this.lbxStanga.Size = new System.Drawing.Size(224, 254);
            this.lbxStanga.TabIndex = 0;
            this.lbxStanga.DoubleClick += new System.EventHandler(this.lbxStanga_DoubleClick);
            // 
            // lbxDreapta
            // 
            this.lbxDreapta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDreapta.FormattingEnabled = true;
            this.lbxDreapta.ItemHeight = 25;
            this.lbxDreapta.Location = new System.Drawing.Point(705, 213);
            this.lbxDreapta.Name = "lbxDreapta";
            this.lbxDreapta.Size = new System.Drawing.Size(224, 254);
            this.lbxDreapta.TabIndex = 1;
            this.lbxDreapta.DoubleClick += new System.EventHandler(this.lbxDreapta_DoubleClick);
            // 
            // btnAddLeft
            // 
            this.btnAddLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLeft.Location = new System.Drawing.Point(462, 376);
            this.btnAddLeft.Name = "btnAddLeft";
            this.btnAddLeft.Size = new System.Drawing.Size(162, 61);
            this.btnAddLeft.TabIndex = 3;
            this.btnAddLeft.Text = "<<";
            this.btnAddLeft.UseVisualStyleBackColor = true;
            this.btnAddLeft.Click += new System.EventHandler(this.btnAddLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cauta";
            // 
            // tbxCauta
            // 
            this.tbxCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCauta.Location = new System.Drawing.Point(186, 105);
            this.tbxCauta.Name = "tbxCauta";
            this.tbxCauta.Size = new System.Drawing.Size(269, 38);
            this.tbxCauta.TabIndex = 5;
            this.tbxCauta.TextChanged += new System.EventHandler(this.tbxCauta_TextChanged);
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(462, 536);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(162, 61);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnAddRight
            // 
            this.btnAddRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRight.Location = new System.Drawing.Point(463, 274);
            this.btnAddRight.Name = "btnAddRight";
            this.btnAddRight.Size = new System.Drawing.Size(162, 61);
            this.btnAddRight.TabIndex = 7;
            this.btnAddRight.Text = ">>";
            this.btnAddRight.UseVisualStyleBackColor = true;
            this.btnAddRight.Click += new System.EventHandler(this.btnAddRight_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 609);
            this.Controls.Add(this.btnAddRight);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.tbxCauta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddLeft);
            this.Controls.Add(this.lbxDreapta);
            this.Controls.Add(this.lbxStanga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAddRight_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lbxStanga;
        private System.Windows.Forms.ListBox lbxDreapta;
        private System.Windows.Forms.Button btnAddLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCauta;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnAddRight;
    }
}

