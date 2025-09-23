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
            //Problema 4 --------------------------------------------------------

            string p = Console.ReadLine();
            int s = int.Parse(p);

            StreamWriter fout = new StreamWriter("patrate.in");

            if (s < 1) 
                fout.WriteLine("Nu exista");
            else
                for (int i = 1; i * i <= s; i++)
                    fout.WriteLine(i);

            fout.Close();

            //Problema 5 --------------------------------------------------------

            StreamWriter fout2 = new StreamWriter("trei.txt");

            if (!File.Exists("unu.txt"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            if (!File.Exists("doi.txt"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin = new StreamReader("unu.txt");
            StreamReader fin2 = new StreamReader("doi.txt");

            string linie;
            while ((linie = fin.ReadLine()) != null)
            {
                string[] cuv = linie.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string e in cuv)
                    fout2.Write(e + " ");
            }

            while ((linie = fin2.ReadLine()) != null)
            {
                string[] cuv = linie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string e in cuv)
                    fout2.Write(e + " ");
            }

            fin.Close();
            fin2.Close();
            fout2.Close();

            //Problema 6 --------------------------------------------------------

            StreamWriter fout3 = new StreamWriter("date.out");

            if (!File.Exists("date.in"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin3 = new StreamReader("date.in");

            int lenght = 0;
            int[] a = new int[1000];
            while ((linie = fin3.ReadLine()) != null)
            {
                string[] cuv = linie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //a[++lenght] = int.Parse(cuv[0]);
                //Alta metoda de conversie
                a[lenght++] = Convert.ToInt16(cuv[0]);

            }

            Array.Sort(a, 0, lenght);
            foreach (int e in a)
                if (e != 0)
                    fout3.Write(e + " ");

            fin3.Close();
            fout3.Close();
        }
    }
}
