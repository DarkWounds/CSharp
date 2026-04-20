using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p50_FourInLine
{
    public partial class Form1 : Form
    {
        Image[] img;
        Button[,] b; // matricea de butoane - tabla de joc
        int laMutare; // laMutare = 0, daca muta verdele
                      // laMutare = 1, daca muta negrul
        bool gameOver; // true daca jocul s-a incheiat, false daca nu
        Matrice A;

        private void Init()
        {
            img = new Image[2];
            img[0] = Image.FromFile("imagini\\verde100.png");
            img[1] = Image.FromFile("imagini\\negru100.png");
            b = new Button[8, 9];
            A = new Matrice();
        }

        private void NewGame()
        {
            int i, j;
            panelJoc.Controls.Clear();
            for (i = 1; i <= 6; i++)
                for (j = 1; j <= 7; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].BackColor = SystemColors.Control;
                    b[i, j].Tag = i * 10 + j;
                    b[i, j].Size = new Size(100, 100);
                    b[i, j].Location = new Point((j - 1) * 100 + 10, (i - 1) * 100 + 10);
                    b[i, j].MouseEnter += Form1_MouseEnter;
                    b[i, j].MouseLeave += Form1_MouseLeave;
                    b[i, j].Click += Form1_Click;
                    //b[i, j].Text = i + " , " + j;
                    panelJoc.Controls.Add(b[i, j]);
                }
            laMutare = 0;
            gameOver = false;
        }

        void Form1_Click(object sender, EventArgs e)
        {
            if (gameOver) return;
            Button but = sender as Button;
            int j = (int)but.Tag % 10;
            PuneBila(j);
        }

        void Form1_MouseLeave(object sender, EventArgs e)
        {
            int i, j;
            Button but = sender as Button;
            j = (int)but.Tag % 10;
            for (i = 1; i <= 6; i++)
                b[i, j].BackColor = SystemColors.Control;
        }

        void Form1_MouseEnter(object sender, EventArgs e)
        {
            int i, j;
            Button but = sender as Button;
            j = (int)but.Tag % 10;
            for (i = 1; i <= 6; i++)
                b[i, j].BackColor = Color.LightGray;
        }

        void PuneBila(int j)
        {
            if (gameOver) return;
            if (A[1, j] != -1) return;
            int i = A.Cauta(j);
            if (i == 0) return;
            b[i, j].BackgroundImage = img[laMutare];
            b[i, j].BackgroundImageLayout = ImageLayout.Stretch;
            A[i, j] = laMutare;
            (A.nrLibere)--;
            if (A.Victorie(i, j) == 1)
            {
                gameOver = true;
                string w = "verde";
                if (laMutare == 1) w = "negru";
                MessageBox.Show("Victorie pentru " + w);
                return;
            }
            else if (A.nrLibere == 0)
            {
                gameOver = true;
                MessageBox.Show("Remiza!");
                return;
            }
            laMutare = 1 - laMutare;
        }

        public Form1()
        {
            InitializeComponent();
            Init();
            NewGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            A.InitMat();
            NewGame();
        }
    }
}
