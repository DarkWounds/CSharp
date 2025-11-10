using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p31_LSI
{
    class Program
    {
        static void Main(string[] args)
        {
            LSI l = new LSI();
            for (int i = 16; i >= 1; i--)
                l.Add(i * i);
            Console.WriteLine(l);

            LSI q = new LSI("numere.txt");
            Console.WriteLine(q);

            for (int i = 1; i <= q.Count; i++)
                Console.Write(q[i] + " ");
            Console.WriteLine();

            q[4] = 5556666;
            Console.WriteLine(q);

        }
    }
}
