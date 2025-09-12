using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a;
            int[] t;
            int n = 8;

            //1. Generam vectorul t de lungime n cu valori aleatoare
            //Construim matricea cu n linii si in crae fiecare linie i contine t[i] elemente
            Random r = new Random();
            t = new int[n];
            for (int i = 0; i < n; i++)
                t[i] = r.Next(3, 12);

            //Init matrice
            a = new int[n][];

            //Init fiecrae linie
            for (int i = 0; i < n; i++)
                a[i] = new int[t[i]];

            //Completam matricea cu valori random
            for (int i = 0; i < n; i++)
                for (int j = 0; j < t[i]; j++)
                    a[i][j] = r.Next(10, 99);

            //Afisare 1:
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t[i]; j++)
                    Console.Write(a[i][j] + " ");
                Console.WriteLine();
            }

            //Afisare 2;
            foreach (int[] v in a)
            {
                foreach (int e in v)
                    Console.Write(e + " ");
                Console.WriteLine();
            }

            //Init la declarare
            int[][] b = new int[4][]
                        {
                        new int[] { 1, 3, 2, 4},
                        new int[] {2, 3, 5, 4},
                        new int[] {4, 3, 5, 6},
                        new int[] {6, 5, 4, 7}
                        };
            foreach (int[] v in b)
            {
                foreach (int e in v)
                    Console.Write(e + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Sortam lini e cu linie
            foreach (int[] v in b)
                Array.Sort(v);

            foreach (int[] v in b)
            {
                foreach (int e in v)
                    Console.Write(e + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
