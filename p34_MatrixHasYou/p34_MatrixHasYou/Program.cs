using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p34_MatrixHasYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrice A, B, C;
            A = new Matrice(6);
            B = new Matrice(6);

            C = A + B;
            Console.WriteLine(C);

            C = A * B;
            Console.WriteLine(C);

            A = new Matrice(6, 1);
            B = new Matrice(6, 2);

            C = A + B;
            Console.WriteLine(C);

            C = A * B;
            Console.WriteLine(C);

            C.Afis();
        }
    }
}
