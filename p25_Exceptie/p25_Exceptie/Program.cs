using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p25_Exceptie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Citim un nr natural n sa afisam succesorul lui
            //EX: n = 12 => n = 13;
            int n;
            Console.Write("n = ");

            //Metoda 1

            try
            {
                n = int.Parse(Console.ReadLine());
                n++;
                Console.WriteLine(n);
            }
            catch
            {
                //Format
                Console.WriteLine("NU este un nr valid!");
            }

            //Metoda 2

            Console.Write("n = ");
            string sir = Console.ReadLine();
            if(Int32.TryParse(sir, out n))
                Console.WriteLine(n++);
            else Console.WriteLine("Nu este valid!");
        }
    }
}
