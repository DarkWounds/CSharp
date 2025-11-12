using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p33_ApelProramCuParametrii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argumentele introduse sunt in nr de " + args.Length);
            if (args.Length > 0)
            {
                Console.WriteLine("Lista argumentelor:");
                foreach (var e in args)
                    Console.WriteLine(e);
            }
            else Console.WriteLine("N-am argumente");

            Console.ReadKey();
        }
    }
}
