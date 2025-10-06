using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p21_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* In fisierul distince.txt se afla pe mai multe randuri numere naturale separate prin spatii. 
             * Sa se memoreze aceste numere intr-un tablou de numere intregi. Sa se verifice apoi daca toate elementele
             * sunt distincte. In caz afirmativ, sa se afiseze la ecran mesajul DISTINCTE. In caz contrar, sa se afiseze un nr
             * care apare de cel putin doua ori in tablou
             * Exemplu:
             * 3 5 17 12
             * 1 2 2 3
             * 3 2
             * Ecran:
             * 2
             */
            if (!File.Exists("distincte.txt"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin = new StreamReader("distincte.txt");
            ArrayList a = new ArrayList();

            string line;
            while ((line = fin.ReadLine()) != null)
            {
                string[] ch = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var e in ch)
                    a.Add(int.Parse(e));
            }

            Console.WriteLine(a.Count);

            int[] fr = new int[10000];
            foreach (int e in a)
                fr[(int)e]++;

            int nr = 0, nrval = 0;
            for (int i = 0; i < a.Count && nr == 0; i++)
                if (fr[(int)a[i]] >= 2) nr = a[i];

            if (nr == 0)
                Console.WriteLine("DISTINCTE");
            else Console.WriteLine(nr);
        }
    }
}
