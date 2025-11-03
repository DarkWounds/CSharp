using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace p30_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string caleFisier = Directory.GetCurrentDirectory();
            Console.WriteLine(caleFisier);
            int p = caleFisier.LastIndexOf("bin\\");
            caleFisier = caleFisier.Substring(0, p) + "Numere.txt";
            Console.WriteLine(caleFisier);
            Tablou a = new Tablou("Numere.txt");
            a.Afis();

            Tablou b = new Tablou(10, 9);
            b.Afis();

            Tablou c = new Tablou(10);
            c.Afis();

            Tablou d = new Tablou(a);
            d.Afis();

            Console.WriteLine(d);
            Console.WriteLine(d.Lungime);
            Console.WriteLine(d.Max);

           // d.Len = 6;
           // Console.WriteLine(d);

            for (int i = 0; i < d.Lungime; i++)
                Console.Write(d[i] + " ");
            Console.WriteLine();

            d[3] = 5550000;

            Console.WriteLine(d);

            Console.WriteLine(d.CautaUltimaAparitie(7));
            Console.WriteLine(d.CautaPrimaAparitie(7));

            d.Sortare();
            Console.WriteLine(d);
            Console.WriteLine(d.CautBin(7));
        }
    }
}
