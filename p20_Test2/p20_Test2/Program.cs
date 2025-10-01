using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p20_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 2-----------------------
            //Se citeste de la tastaura un sir de caractere format numai din litere mici.
            //Daca un caracter apare de mai multe ori, atunci sa se elimine toate aparitile sale,
            //iar daca un carcater apare o singura data, atunci acesta va ramane in sir.
            /*
             *Exemplu:
             *s = "abcdbcdbcddxyywb";
             *Rasp:
             *s = "axw";
             */
            string s = Console.ReadLine();
            string aux = s;
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                int lastIndex = 0, firstIndex = 0;
                lastIndex = s.LastIndexOf(s[i]);
                firstIndex = s.IndexOf(s[i]);
                if (lastIndex == firstIndex)
                    a += s[i];
            }
            s = a;
            a = null;
            Console.WriteLine(s);
            
        }
    }
}
