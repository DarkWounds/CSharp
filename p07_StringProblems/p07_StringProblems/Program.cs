using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_StringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citim un nume complet in forma "Nume, Oren1, Pren2"
            //Vrem sa obtinem numele in forma Pren1 Pren2, Nume"
            string s = "Popescu Vasile Ioan de Hohenzoler";
            int p = s.IndexOf(' ');
            string a = "";
            string NewName = s.Substring(p + 1) + " " + s.Substring(0, p);
            Console.WriteLine(NewName);

            //Se citeste o cal de forma: "d:\aaa\bbb\ccc\ddd\eee"

            s = "d:\\aaa\\bbb\\ccc\\ddd\\eee";
            a = s.Replace("\\", "\n");
            Console.WriteLine(a);

        }
    }
}
