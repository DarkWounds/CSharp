using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p38_UnorderedMap
{
    class Program
    {
        static void Main(string[] args)
        {
            UnorderedMap M = new UnorderedMap();
            string linie;
            int n;
            n = int.Parse(Console.ReadLine());
            linie = Console.ReadLine();
            string[] nume = linie.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
            foreach (string e in nume)
                M[e]++;
            // cautam numarul minim cu frecventa 1
            Console.WriteLine(M.FrecvMin());
        }
    }
}