using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


/*
 Hash set cu functiile
 * -Add
 * -Remove
 * -UnionWith -Reuninune
 * -IntersectWith -Intersectie
 * -ExeptWith -Diferenta
 */
namespace p23_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 10; i >= 1; i--)
                s.Add(i * i);
            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");
            s.Add(9);

            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            s.Remove(9);
            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            if (s.Contains(16)) Console.WriteLine("Exista\n");
            else Console.WriteLine("Nu exista\n");

            HashSet<int> s1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 16 };
            s.UnionWith(s1);

            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            s.IntersectWith(new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 16, 25 });
            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");

            s.ExceptWith(new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, });
            foreach (var e in s)
                Console.Write(e + " ");
            Console.WriteLine("\n");
        }
    }
}
