using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

/*
 * Clasa ArrayList din System.Collection
 * Functii membre:
 * - Add - adauga un element la finalul listei
 * - Insert - insereaza un element
 * - Remove - elimina un element 
 * - Contains - verifica daca exista sau nu un element dat
 * - Clear - sterge tot din lista
 * - RemoveAt - sterge un element de la o pozitie anume din lista 
 * - Sort - ordoneaza lista 
 * - BinarySearch - cautare binara in lista sortata
 * - IndexOf(x) - cauta linear prima aparitie a lui x
 * - LastIndexOf(x) - cauta linear ultima aparitie a lui x
 */

namespace p12_Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(); // Asta e lista vida
            // Adauga primele 20 de patrate perfecte nenule
            for (int i = 1; i <= 20; i++)
                a.Add(i * i);
            // Afisez
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            Console.WriteLine(a[2] + "\n");
            for (int i = 0; i < a.Count; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");

            a.Insert(2, 7);
            a.Insert(2, 7);
            a.Insert(2, 7);
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            a.Remove(7);

            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            a.RemoveAt(2);
            a.RemoveAt(2);
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            if (a.Contains(25))
                Console.WriteLine("Valoarea 25 exista!");
            else Console.WriteLine("Valoarea 25 nu exista!");

            a.RemoveRange(2, 4); // De la 2 se sterg 4 numere
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            a.Add(24);
            a.Add(60);
            a.Add(3);
            a.Sort();
            foreach (int e in a)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            int p = a.BinarySearch(81);
            if (p < 0) Console.WriteLine("Nu exista");
            else Console.WriteLine("Exista la poz " + p);

            a.Clear(); // Elimina tot din lista
            Console.WriteLine(a.Count);
        }
    }
}
