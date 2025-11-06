namespace OTI_2025
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            imageList1 = new ImageList(components);
            limg = new ListView();
            textBox1 = new TextBox();
            tbExploratori = new TextBox();
            btnSet = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "barca5.png");
            // 
            // limg
            // 
            limg.BackColor = Color.MediumBlue;
            limg.BorderStyle = BorderStyle.None;
            limg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limg.LargeImageList = imageList1;
            limg.Location = new Point(12, 23);
            limg.Name = "limg";
            limg.Size = new Size(174, 146);
            limg.TabIndex = 0;
            limg.TabStop = false;
            limg.UseCompatibleStateImageBehavior = false;
            limg.SelectedIndexChanged += limg_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(192, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 26);
            textBox1.TabIndex = 1;
            textBox1.Text = "Cati exploratori aiiii capitane?";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tbExploratori
            // 
            tbExploratori.BackColor = SystemColors.Info;
            tbExploratori.BorderStyle = BorderStyle.None;
            tbExploratori.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbExploratori.Location = new Point(486, 54);
            tbExploratori.Name = "tbExploratori";
            tbExploratori.Size = new Size(45, 26);
            tbExploratori.TabIndex = 2;
            tbExploratori.TextChanged += TbExploratori_TextChanged;
            tbExploratori.KeyPress += TbExploratori_KeyPress;
            // 
            // btnSet
            // 
            btnSet.BackColor = Color.MediumTurquoise;
            btnSet.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSet.Location = new Point(192, 95);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(339, 31);
            btnSet.TabIndex = 3;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = false;
            btnSet.Click += BtnSet_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(544, 181);
            Controls.Add(btnSet);
            Controls.Add(tbExploratori);
            Controls.Add(textBox1);
            Controls.Add(limg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Exploratori";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ListView limg;
        private TextBox textBox1;
        private TextBox tbExploratori;
        private Button btnSet;
    }
}