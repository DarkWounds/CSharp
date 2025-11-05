using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p30_OOP
{
    /// <summary>
    /// Clasa tablourilor unidimensionale
    /// </summary>

    class Tablou
    {
        private int[] a;
        private int n; //dimensiunea logica a lui a
        private int N; //dimensiunea fizica a lui a
        // ------------ Constructori ------------ 
        public Tablou(int dim)
        {
            N = 1;
            while (N < dim) N *= 2;
            a = new int[N];
            n = dim;
        }
        public Tablou(int dim, int val)
        {
            n = dim;
            N = 1;
            while (N < dim) N *= 2;
            a = new int[N];
            for (int i = 0; i < n; i++)
                a[i] = val;
        }

        //Preia date dintr-un fisier
        public Tablou(string fisier)
        {
            if (!File.Exists(fisier))
            {
                N = n = 1;
                a = new int[n];
                Console.WriteLine("Fisier inexistent");
                return;
            }
            StreamReader fin = new StreamReader(fisier);
            string linie = fin.ReadLine();
            string[] nr = linie.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            n = nr.Length;
            N = 1;
            while (N < n) N *= 2;
            a = new int[N];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(nr[i]);
            fin.Close();
        }

        //Constructor de copiere
        public Tablou(Tablou z)
        {
            this.N = z.N;
            this.n = z.n;
            this.a = new int[N];
            for (int i = 0; i < n; i++)
                a[i] = z.a[i];
        }

        //-----------End Constructori----------------------

        //----------Propietati-----------------------
        /*
         * Exista 3 tipuri de proprietati:
         * -Read-Only (doar get)
         * -Write-Only (doar set)
         * -Read-Write (si get si set)
         */

        //public string Lungime { get; set; }

        //Prop Read-Only
        public int Lungime
        {
            get 
            {
                return n;
            }
        }

        //Furnizeaza val maxima din vector
        public int Max
        {
            get
            {
                int mx = a[0];
                for (int i = 0; i < n; i++)
                    if (mx < a[i]) mx = a[i];
                return mx;
                //yummyyummy

            }
        }
        //Prop Read_Write
        //(Mai mult ca exemplu, prop periculoasa muehehe) meow :3 ;)
        public int Len
        {
            get
            {
                return n;
            }
            set 
            {
                n = value;
            }
        }

        //-----------End Proprietati----------------------

        //----------------Indexator--------------------

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        //-------------------------------------------------

        public void Afis()
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < n; i++)
                s += a[i] + " ";
            return s;
        }

        //Returneaza prim apoz a lui x
        public int CautaPrimaAparitie(int x)
        { 
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }

        public int CautaUltimaAparitie(int x)
        {
            for (int i = n - 1; i >= 0; i--)
                if (a[i] == x)
                    return i;
            return -1;
        }

        private int Pivot(int st, int dr)
        {
            int i, j = st , aux, piv = a[st];
            for(i = st + 1; i <= dr; i++)
                if (a[i] <= piv)
                {
                    j++;
                    aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;

                }
            aux = a[st];
            a[st] = a[j];
            a[j] = aux;
            return j;
        }

        public void QSort(int st, int dr)
        {
            if (st < dr)
            {
                int p = Pivot(st, dr);
                if (st < p - 1) Pivot(st, p - 1);
                if (p + 1 < dr) Pivot(p + 1, dr);
            }
        }

        public void Sortare()
        {
            // QSort(0, n - 1);
            Array.Sort(a, 0, n);
        }

        public int CautBin(int x)
        {
            int st, dr, mijl;
            st = 0; dr = n - 1;
            while (st <= dr)
            {
                mijl = (st + dr) / 2;
                if (x == a[mijl]) return mijl;
                else if (x > a[mijl]) st = mijl + 1;
                else dr = mijl - 1;
            }
            return -1;
        }

        //Adauga pe x la finalul vectorului a
        public void Add(int x)
        {
            
        }

        //Insereaza la pozitie p in vector valoarea x
        public void Insereaza(int p, int x)
        {
 
        }

        //Sterge elementul la pozitie p in vector
        public void Stergere(int p)
        {
            
        }
    }
}
