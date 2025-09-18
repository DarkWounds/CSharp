using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Tipuri in C#: valoare, referinta.
 * Tipurile valoare trebuie initializate printr-o atribuire.
 * Tipurile referinta trebuie initializate cu new.
 */
namespace p06___String
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "buna";
            string b = "ziua";

            // Functii si opreatori pt. stringuri

            /*   1.Operatorii:
             * -relationari(==, !=)
             * -concatenare(+)
             * -atribuire(=)
             */

            if (a != b) Console.Write("Nu sunt egale\n");
            else Console.Write("Sunt egale\n");

            if (b == "ziua!") Console.Write("Sunt egale\n");
            else Console.Write("Nu sunt egale\n");

            string c = a + " " + b + "!\n";
            Console.Write(c);

            c = String.Empty;
            for (int i = 1; i <= 3; i++)
                c += b + " ";
            Console.WriteLine(c);

            // 2.Secventele Escape: \n, \t, \a, \\, \', \", \r

            string cale = "d:\\lucru\\cpp\\12A\\testari\\date.txt";
            Console.WriteLine(cale);

            //cale = Console.ReadLine();
            //Console.WriteLine(cale);

            c = "Ana\tare\tmere\tmakjfsio\tpp";
            Console.WriteLine(c);

            // 3. Caractere Verbatim
            cale = @"d:\aaa\bbb\ccc\ddd\eee";
            Console.WriteLine(cale);

            // 4. Indexatorul pentru stringuri: proprietatea Length
            c = "abcdefghijklmnopqrstuvWxyz";
            Console.WriteLine("{0} are lungimea {1}", c, c.Length);

            // 5. Compararea sirurilor. Funciile Equals, CompareTo, StartsWith, EndsWith

            a = b;
            if (a.Equals(b)) Console.WriteLine("Sunt egale");
            else Console.WriteLine("Sunt diferite");

            /*
            a.CompareTo(b) ret. 1 daca a >lex b
             *                  0 daca a = b
             *                  -1 daca a <lex b
             * */

            int p = a.CompareTo(b);
            Console.WriteLine(p);

            string[] s = { "start", "stop", "final", "epocal", "stare", "stima", "stop", "banal" };
            Console.WriteLine("Cuvinte care incep cu \'st\' : ");
            foreach (string e in s)
                if (e.StartsWith("st")) Console.WriteLine(e);
            Console.WriteLine("Cuvinte care se termina cu \'al\' : ");
            foreach (string e in s)
                if (e.EndsWith("al")) Console.WriteLine(e);

            // 6. Localizarea caracterelor in sir. Functiile IndexOf, LastIndexOf
            a = "Dubai, Dubay, Dubay, viata ca-n rai";
            p = a.IndexOf("Dubay");
            Console.WriteLine(p);
            p = a.LastIndexOf("Dubay");
            Console.WriteLine(p);
            p = a.IndexOf("y", 15); //cauta in sir incepand cu pozitia 15
            Console.WriteLine(p);

            // 7. Extragerea subsirurilor. Functia Substring
            b = "Ana are mere, pere si caise";
            c = b.Substring(14); //extrage de la pozitia 14 pana la final
            Console.WriteLine(c);
            c = b.Substring(4, 8); //extrage 8 caractere incepand de la pozitia 4
            Console.WriteLine(c);
            //c = b.Substring(4, 100); - nu pot extrage 100 de caractere pentru ca nu exista atatea

            // 8. Actualizarea sirurilor. Functiile Replace, ToUpper, ToLower, Remove, Trim
            b = "Ana are mere, pere si caise";
            a = b.Replace('e', 'E'); // inlocuim b cu B peste tot
            Console.WriteLine(a);

            a = b.Insert(8, "struguri, ");
            Console.WriteLine(a);

            a = b.ToUpper();
            Console.WriteLine(a);

            a = b.ToLower();
            Console.WriteLine(a);

            a = b.Remove(12);
            Console.WriteLine(a);

            a = b.Remove(12, 6); // sterge 6 caractere de la pozitia 12
            Console.WriteLine(a);

            a = "   Popescu       Vasile    Ioan             ";
            b = a.Trim();
            a = b.Remove(12);
            Console.WriteLine("*" + b + "*");

            a = "   Popescu       Vasile    Ioan             ";
            b = a.TrimEnd();
            a = b.Remove(12);
            Console.WriteLine("*" + b + "*");

            a = "   Popescu       Vasile    Ioan             ";
            b = a.TrimStart();
            a = b.Remove(12);
            Console.WriteLine("*" + b + "*");
        }
    }
}