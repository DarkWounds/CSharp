using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cu ajutorul functiei Split separam un text in itemi
             * --------------------------------------------------
             * Se da un text format din cuvinte (litere) separate prin separatorii:
             * space ! . ? ; : - ,
             * Vrem sa afisam pe cate o linie un cuvant si lungimea sa
             */
            string text;
            char[] sep = { ' ', '.', '?', ';', ',', '-', ':', ';' };
            text = "Blabla bla. fhsjfj., fdf";
            string[] cuv = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach (string e in cuv)
                Console.WriteLine(e + " " + e.Length);

            /*
             *  Citim un sir de numere naturale. Sa se calculeze suma lor
             */

            text = "2 4  7 4 78   9";
            int S = 0;
            string[] a = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
          
            // Metoda 1
            foreach (string e in a)
                S += Convert.ToInt16(e);
            Console.WriteLine(S);

            // Metoda 2
            S = 0;
            foreach (string e in a)
                S += int.Parse(e);
            Console.WriteLine(S);


        }
    }
}
