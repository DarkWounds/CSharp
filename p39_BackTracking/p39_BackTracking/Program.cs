using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p39_BackTracking
{

    class Program
    {
        static void Main(string[] args)
        {
            /*int n;
            //Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            string s = String.Empty;
            s = Console.ReadLine() + " ";
            Problema P = new Problema(n, 1, n, s);
            P.Back(1);
            P.Rezultat();*/
            //Problema Permutari (Rasp Da sau Nu)

            int n;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Perm P = new Perm(n, 1, n);
            P.Back(1);
            Console.WriteLine("Pentru aranjamente : ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Aranjamente A = new Aranjamente(k, 1, n);
            A.Back(1);

            Console.WriteLine("Generarea combinarilor :");
            Combinari C = new Combinari(k, 1, n);
            C.Back(1);

            Console.WriteLine("Scrierea lui S ca suma");
            Console.Write("S =");
            int S = int.Parse(Console.ReadLine());
            Suma Sum = new Suma(S, 1, S);
            Sum.Back(1);

        }
    }
}
