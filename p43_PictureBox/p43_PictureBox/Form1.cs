using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p43_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           // pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
           // pictureBox1.BackgroundImage = Image.FromFile(@"D:\12A\p43_PictureBox\p43_PictureBox\bin\Debug\Hungary.jpg");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = Image.FromFile(@"D:\12A\p43_PictureBox\p43_PictureBox\bin\Debug\Strawberry.jpg");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = Image.FromFile(@"D:\12A\p43_PictureBox\p43_PictureBox\bin\Debug\Hungary.jpg");
        }
    }
}
