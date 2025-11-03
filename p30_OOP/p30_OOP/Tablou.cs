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
        private int n; //dimensiunea lui a
        // ------------ Constructori ------------ 
        public Tablou(int dim)
        {
            a = new int[dim];
            n = dim;
        }
        public Tablou(int dim, int val)
        {
            n = dim;
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = val;
        }

        //Preia date dintr-un fisier
        public Tablou(string fisier)
        {
            if (!File.Exists(fisier))
            {
                n = 1;
                a = new int[n];
                Console.WriteLine("Fisier inexistent");
                return;
            }
            StreamReader fin = new StreamReader(fisier);
            string linie = fin.ReadLine();
            string[] nr = linie.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            n = nr.Length;
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(nr[i]);
            fin.Close();
        }

        //Constructor de copiere
        public Tablou(Tablou z)
        {
            this.n = z.n;
            this.a = new int[n];
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

        public void Sortare()
        {
            Array.Sort(a);
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
    }
}
