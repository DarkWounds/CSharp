using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p50_FourInLine
{
    class Matrice
    {
        private int[,] a;
        public int nrLibere;
        public Matrice()
        {
            a = new int[8, 9];
            InitMat();
        }
        public void InitMat()
        {
            for (int i = 0; i <= 7; i++)
                for (int j = 0; j <= 8; j++)
                    a[i, j] = -1;
            nrLibere = 42;
        }
        public int this[int i, int j]
        {
            get { return a[i, j]; }
            set { a[i, j] = value; }
        }

        // ret. cea mai de jos linie i cu a[i,j]=-1
        // sau ret. 0, daca toata coloana j are doar 0 sau 1
        public int Cauta(int j)
        {
            for (int i = 6; i >= 1; i--)
                if (a[i, j] == -1) return i;
            return 0;
        }
        // ret. 1 daca mutarea de la pozitia (i,j) s-a terminat cu victorie
        // pentru cine a mutat acolo, dau 0 daca nu e inca victorie
        public int Victorie(int i, int j)
        {
            int x, y, d, cnt;
            int[] dx = new int[] { -1, -1, -1, 1, 1, 1, 0, 0 };
            int[] dy = new int[] { -1, 0, 1, -1, 0, 1, -1, 1 };
            for (d = 0; d < 8; d++)
            {
                cnt = 1;
                x = i + dx[d];
                y = j + dy[d];
                while (a[x, y] == a[i, j])
                {
                    cnt++;
                    x = x + dx[d];
                    y = y + dy[d];
                    if (cnt >= 4) return 1;
                }
            }
            return 0;
        }
    }
}
