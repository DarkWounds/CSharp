using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Matrice:
 * - regulate (dreptunghiulare)
 * -neregulate (jagged)
 */

namespace p04_Matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matricile drepumghiulare
            int[,] a;
            int n, m;
            n = 5; m = 9;
            Random r = new Random();

            // Init
            a = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(10);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine("\n");
            }

            //Initializare la declarare
            int[,] b = new int[4, 6] { { 1, 1, 1, 1, 1, 1 },
                                        { 2, 2, 2, 2, 2, 2 },
                                        { 3, 3, 3, 3, 3, 3 },
                                        { 4, 4, 4, 4, 4, 4 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(a[i,j] + " ");
                Console.WriteLine("\n");
            }
        }
    }
}
