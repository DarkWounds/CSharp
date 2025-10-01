using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_Tablouri
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a, b;
            int n = 20;

            //1.Generam aleator n elemente din vector

            //Initializam pe a
            a = new int[n];

            //Generare random
            Random r = new Random();
            for (int i = 0; i < n; i++)
                a[i] = r.Next(100); //Genereaza un nr random intre 0 si 99
            //a[i] = r.Next(10, 100); //Genereaza un nr random intre 11 si 99

            //Prima afisare:
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");

            //A doua afisare:
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");

            //A treia afisare:
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //Atribuirea
            b = a;
            foreach (int e in b)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //2.Sa se ordoneze crescator a

            //Prima metoda:
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        int x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //A doua metoda:
            Array.Sort(b);
            foreach (int e in b)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //3.Vector constante

            //Prima metoda:
            int[] t = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int e in t)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //A doua metoda:
            int[] v = { 1, 2, 3, 4, 5, 6 };
            foreach (int e in v)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            //4.Cum eliberam memoria?
            a = null;

            //5.Cautari liniare
            int p = Array.IndexOf(b, 32);
            Console.WriteLine(p);

            p = Array.LastIndexOf(b, 32);
            Console.WriteLine(p);

            //6.Cautare binara (in vector sortat!)
            p = Array.BinarySearch(b, b[3]);
            Console.WriteLine(p);

        }
    }
}
