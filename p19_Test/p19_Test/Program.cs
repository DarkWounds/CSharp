using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p19_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int cnt = 0;
            while(((w = Console.ReadLine()) != null))
            {
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
