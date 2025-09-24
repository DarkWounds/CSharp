using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace p13_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Citim dintr-un fisier numere eparate prin spatii sau enter.
             * Sa memoram intr-o lista numerele, apoi la suma
             */

            if(!File.Exists("numere.in"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin = new StreamReader("numere.in");

            string lista;
            ArrayList a = new ArrayList();
            while ((lista = fin.ReadLine()) != null)
            {
                string[] cuv = lista.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string e in cuv)
                    a.Add(int.Parse(e));
            }

            // Afisare ArrayList
            foreach(string e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            int suma = 0;
            for (int i = 0; i < a.Count; i++)
                suma += (int)a[i];

            // Alta metoda:

            //foreach (int e in a)
               // suma += e;
               

        }
    }
}
