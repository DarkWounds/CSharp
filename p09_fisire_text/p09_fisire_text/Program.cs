using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_fisire_text
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citim cuvinte din fisier si le afisam pe cate un rand
            if (!File.Exists("Date.in"))
            {
                Console.WriteLine("Fisierul nu exista!");
                return;
            }

            StreamReader fin = new StreamReader("Date.in");
            StreamWriter fout = new StreamWriter("Date.out");

            string linie;
            while ((linie = fin.ReadLine()) != null)
            {
                string[] cuv = linie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string e in cuv)
                    fout.WriteLine("*" + e + "*");
            }

            fin.Close();
            fout.Close();

        }
    }
}
