using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace p11_Probleme
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = Console.ReadLine();
            int s;
            s = int.Parse(p);

            if( !File.Exists("patrate.in"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamWriter fout = new StreamWriter("patrate.in");

            if (s < 1) 
                fout.WriteLine("Nu exista");
            else
                for (int i = 1; i * i <= s; i++)
                    fout.WriteLine(i);

        }
    }
}
