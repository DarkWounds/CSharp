namespace Testul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCounter = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // BtnCounter
            // 
            BtnCounter.BackColor = SystemColors.ActiveCaption;
            BtnCounter.Location = new Point(257, 95);
            BtnCounter.Name = "BtnCounter";
            BtnCounter.Size = new Size(277, 23);
            BtnCounter.TabIndex = 0;
            BtnCounter.Text = "Counter";
            BtnCounter.UseVisualStyleBackColor = false;
            BtnCounter.Click += BtnCounter_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MistyRose;
            richTextBox1.Location = new Point(257, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 212);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(BtnCounter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCounter;
        private RichTextBox richTextBox1;
    }
}
