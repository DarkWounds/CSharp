using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p19_Test
{
    class Program
    {
        /**
          3 5 17 12
          1 2 2 3
          3 2
         */
        static void Main(string[] args)
        {
            //Problema 1 --------------------------------------
            //In fisierul date.txt se afla [e mai multe randuri numere nat separate
            //prin spatii. Sa se memoreze aceste numere intr-un tablou de nr intregi
            //apoi se ordoneaza crescator
            //Sa se afiseze la ecran pe prima linie numarul de numere din sir,
            //pe a doua linie, numerele memorate in tablou,
            //iar pe a treia linie numerele distincte care se gasesc in tablou.
            /**
             * Exemplu:
                3 5 17 12
                1 2 2 3
                3 2
             * Ecran:
             * 10
             * 1 2 2 2 3 3 5 12 17
             * 1 2 3 5 12 17
             */
            if (!File.Exists("date.txt"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin = new StreamReader("date.txt");

            ArrayList a = new ArrayList();
         
            string linie;

            while ((linie = fin.ReadLine()) != null)
            {
                string[] ch = linie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var e in ch)
                    a.Add(int.Parse(e));
            }

            Console.WriteLine(a.Count);
            a.Sort();

            foreach (var e in a)
                Console.Write(e + " ");
            Console.WriteLine();

            int[] fr = new int[a.Count];
            foreach (int e in a)
                fr[(int)e]++;

            foreach (int e in a)
                if (fr[(int)e] != 0)
                {
                    Console.Write(e + " ");
                    fr[(int)e] = 0;
                }
            Console.WriteLine("\n");
        }
    }
}
