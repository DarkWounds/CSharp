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
        }
    }
}
