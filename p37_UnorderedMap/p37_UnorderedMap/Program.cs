using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p37_UnorderedMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Unorderedmap M = new Unorderedmap();
            string linie;
            int n;
            n = int.Parse(Console.ReadLine());
            while ((linie = Console.ReadLine()) != null)
            {
                string[] nume = linie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string e in nume)
                    M[e]++;
            }
            //Cautam elevul cu frecventa maxima
            Element s = M.FrecvMax();
            Console.WriteLine(s.val + " " + s.fr);
        }
    }
}
