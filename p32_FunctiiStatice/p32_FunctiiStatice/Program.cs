using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p32_FunctiiStatice
{
    class Program
    {
        static void Main(string[] args)
        {
            Romascu w = new Romascu();
            Romascu v = new Romascu();
            Romascu u = new Romascu();

            w.Incrementa();
            Console.WriteLine(w); // 1 1

            v.Incrementa();
            Console.WriteLine(v); // 1 2

            u.Incrementa();
            Console.WriteLine(u); // 1 3

            Romascu.HitMan(w); 
        }
    }
}
