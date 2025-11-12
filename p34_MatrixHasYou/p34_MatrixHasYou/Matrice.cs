using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p34_MatrixHasYou
{

    /// <summary>
    /// Clasa Matricelor patratice
    /// </summary>
    class Matrice
    {
        private int n;
        private int[,] a;

        public Matrice(int dim)
        {
            n = dim;
            a = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = r.Next(10, 99);
        }

        public Matrice(int dim, int val)
        {
            n = dim;
            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = val;
        }

        public Matrice(Matrice A)
        {
            this.n = A.Size;
            this.a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = A.a[i, j];
        }

        public void Afis()
        {
           List <int> a = new List <int>();
            a.Add(1); a.Add(3);
           Console.Write(string.Join(" ", a));
        }

        public int Size
        {
            get { return n; }
        }

        public int this[int i, int j]
        {
            get { return a[i, j]; }
            set { a[i, j] = value; }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    s += a[i, j] + " ";
                s += "\n";
            }
            return s;
        }

        public static Matrice operator +(Matrice A, Matrice B)
        {
            Matrice C = new Matrice(A.Size, 0);
            for (int i = 0; i < A.Size; i++)
                for (int j = 0; j < A.Size; j++)
                    C[i, j] += B[i,j];
            return C;
        }

        public static Matrice operator *(Matrice A, Matrice B)
        {
            Matrice C = new Matrice(A.Size, 0);
            for (int i = 0; i < A.Size; i++)
                for (int j = 0; j < A.Size; j++)
                {
                    //Calculam C[i,j] = A[i,0] * B[0,i] + A[i, 1] * B[1, i] + .. + A[i, n - 1] * B[n - 1, i]
                    for (int k = 0; k < A.Size; k++)
                        C[i, j] += A[i, k] * B[k, i];
                }
            return C;
        }
    }
}

