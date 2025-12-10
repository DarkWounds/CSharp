using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 23, 55, 16, 9, 44, 28, 17, 32, 34, 3, 100
 * Nr prim: 7
 * h[0] = 28 
 * h[1] =
 * h[2] = 23, 16, 44, 9, 100
 * h[3] = 17, 3
 * h[4] = 32
 * h[5] =
 * h[6] = 55, 34
 */

namespace p36_UnorderedMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Unorderedmap a = new Unorderedmap();
            string line = "23 55 16 9 44 28 17 32 34 3 100";
            string[] s = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in s)
                a.Add(w);
            a.Afis();
            Console.WriteLine();

            Console.WriteLine(a);
            string st = @"-------------------------------------";
            Console.WriteLine(st);

            Unorderedmap M = new Unorderedmap();
            for (int i = 100; i <= 120; i++)
                M[i + ""] = i;
            //M[i.ToString()] = i;
            M.Afis();
            M["110"]++;
            Console.WriteLine("\n" + M["110"]);
            M["100"] = 0;
            Console.WriteLine("\n");
            M.Afis();
            Console.WriteLine("\n");

            M.Add("Value");
            M["120"] += 120;
            M.Afis();
            Console.WriteLine(M["120"]);
        }
    }
}
