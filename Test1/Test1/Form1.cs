namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Propietati button
            //Testarea propietatilor unui buton

            // AccessibleName property
            this.button1.AccessibleName = "Buton1";
            // AccessibleRole property
            this.button1.AccessibleRole = AccessibleRole.PushButton;
            // Anchor property
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // AllowDrop property
            this.button1.AllowDrop = true;
            // AutoElipsis property
            this.button1.AutoEllipsis = true;
            // AutoSize property
            this.button1.AutoSize = true;
            // AutoSizeMode property
            this.button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // BackGroundImage property
            string poza = @"D:\C-Start\OJTI_2024_C#_Resurse\inamic.gif";
            this.button1.BackgroundImage = Image.FromFile(poza);
            // BackGroundImageLayout property
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            // CausesValidation property
            this.button1.CausesValidation = false;
            // ContextMenuStrip property
            //this.button1.ContextMenuStrip = this.contextMenuStrip1;
            // Cursor property
            //this.button1.Cursor = Cursors.Hand;
            // DialogResult property
            this.button1.DialogResult = DialogResult.OK;
            // Dock property
            this.button1.Dock = DockStyle.Bottom;
            // Enabled property
            this.button1.Enabled = false;
            // FlatAppearance property
            this.button1.FlatAppearance.BorderColor = Color.Red;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            // (BorderColor, BorderSize, MouseDownBackColor, MouseOverBackColor)
            // FlatStyle property
            this.button1.FlatStyle = FlatStyle.Flat;
            // Font property
            // (Name, Size, Unit, Bold, GdiCharSet, GdiVerticalFont, Italic, Strikeout, Underline)
            this.button1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            this.button1.Size = new Size(200, 100);
            this.button1.Text = "Click Me!";

            // ForeColor property
            this.button1.ForeColor = Color.White;
          
            // Image property
            poza = @"D:\C-Start\OJTI_2024_C#_Resurse\luna.png";
            this.button2.Image = Image.FromFile(poza);
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.MaximumSize = new Size(500, 500);
            this.button2.MinimumSize = new Size(100, 100);
            this.button2.Padding = new Padding(10);
            // ImageAlign property
            this.button1.ImageAlign = ContentAlignment.MiddleLeft;
            // ImageIndex property
            // (All, Normal, Disabled, Hot, Pressed)
            this.button1.ImageIndex = 0;

            // ImageList property
            //this.button1.ImageList = this.imageList1;

            // ImageKey property
            this.button1.ImageKey = "inamic.gif";

            // Location property(X, Y)
            this.button1.Location = new Point(100, 100);
            // Locked property
            //this.button1.Locked = false;

            // Margin property
            // (All, Left, Top, Right, Bottom)
            this.button1.Margin = new Padding(10);
            // MaximumSize property
            // (Width, Height)
            this.button1.MaximumSize = new Size(300, 150);
            // MinimumSize property
            // (Width, Height)
            this.button1.MinimumSize = new Size(100, 50);
            // Modifier property

            // Padding property
            this.button1.Padding = new Padding(5);
            // (All, Left, Top, Right, Bottom)

            // RightToLeft property
            //this.button2.RightToLeft = RightToLeft.Yes;
            // Size property
            // (Width, Height)
            //this.button1.Size = new Size(150, 75);
            // TabIndex property
            this.button1.TabIndex = 1;
            // TabStop property
            this.button1.TabStop = false;
            // Tag property
            this.button1.Tag = "Buton1";
            // Text property
            this.button1.Text = "Apasa Ma!";
            // TextAlign property
            this.button1.TextAlign = ContentAlignment.MiddleRight;
            // TextImageRelation property
            this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            // UseCompatibleTextRendering property
            this.button1.UseCompatibleTextRendering = true;
            // UseMnemonic property
            this.button1.UseMnemonic = false;
            // UseVisualStyleBackColor property
            this.button1.UseVisualStyleBackColor = false;
            // UseWaitCursor property
            this.button1.UseWaitCursor = true;
            // Visible property
            this.button1.Visible = true;
        }
    }
}
