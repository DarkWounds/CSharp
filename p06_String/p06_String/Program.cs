using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Tipuri in C3 : valoare, referinta
 * Tipurile valoare trebuie initializate printr-o atribuire
 * Tipurile referinta trebuie initializate cu new
**/

namespace p06_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = " I am Sith Lord";
            string b = " Nu stiu ";
            string c;
            //Functii si operatori pentru stringuri 

            /* 1. Operatorii
             * - relationari (==, !=)
             * - concatenare (+, -)
             * - atribuire (=)
             * */

            if (a == b) Console.WriteLine("Sunt identice..");
            else Console.WriteLine("Diff");

            c = a + " " + b;
            Console.WriteLine(c);

            c = String.Empty;
            for (int i = 1; i <= 3; i++)
                c += b + " ";
            Console.WriteLine(c);

            //2. Secventele Escape: \n, \t, \\, \', \", \r....

            string cale = "D:\\12A";
            Console.WriteLine(cale);

            c = "Ana\tare\tmere\tsi\tpere\a";
            Console.WriteLine(c);

            //3. Caractere Verbatim

            cale = @"D:\a\b";
            Console.WriteLine(cale);

            c = @"Popa Ioan
Vasilescu George
Bla Bla";
            Console.WriteLine(c);

            c = @"Proverb persan: \'E bine ca atunci cand stii adevarul sa-l spui, dar mai intelept este sa vorbesti despre palmieri'";
            Console.WriteLine(c);

            //4. Indexatorul pentru stringuri: propiretatea Length

            c = "";
            for (char ch = 'a'; ch <= 'z'; ch++) 
                c += ch;
            Console.WriteLine("{0} are lungimea {1}", c, c.Length);

            //5. Compararea sirurilor, Functiile Equals, CompareTo, StartsWith, EndsWith

            a = b;
            if (a.Equals(b)) Console.WriteLine("Egale..");
            else Console.WriteLine("Nu-s egale");

            b = "SSith";
            a = "tre";

            /*
             *a.CompareTo(b) ret 1. Daca a > lex b
             *                   0. Daca a = b
             *                  -1. Daca a < lex b
             */

            int p = a.CompareTo(b); 
            Console.WriteLine(p);

            Console.WriteLine("Cuvinte care incep cu \'st\'");
            string[] s = { "start", "stop", "final", "epocal", "stare", "stima", "stop", "banal" };
            foreach (string e in s)
                if (e.StartsWith("st")) Console.WriteLine(e);

            Console.WriteLine("Cuvinte care se safrsesc cu \'al\'");
            foreach (string e in s)
                if (e.EndsWith("al")) Console.WriteLine(e);

            //6. Localizarea caracterelor in sir. Functiile IndexOf, LastIndexOf

            a = "Dubai, Dubay, Dubay, viata ca-n rai";
            p = a.IndexOf("Dubay");
            Console.WriteLine(p);

            p = a.LastIndexOf("Dubay");
            Console.WriteLine(p);

            p = a.IndexOf("y", 15); //Cauta in sir incepand cu poz 15;ret -1 daca nu gaseste
            Console.WriteLine(p);

            //7. Extragerea subsirurilor. Functia substring

            b = "Ana are mere, pere si caise";
            c = b.Substring(14); // Extrage de la poz 14 pana la final
            Console.WriteLine(c);

            c = b.Substring(4, 8); // Extrage 8 caractere incepand de la poz 4
            Console.WriteLine(c);

            //c = b.Substring(4, 100); // Index/Argument out of range. Nu pot extrage 100 de carcatere fiindca nu sunt atatea

            //8. Actualizarea sirurilor. Functiile Replace, ToUpper, ToLower, Remove, Trim

            b = "Ana are mere, pere si caise";
            for (int i = 0; i < b.Length; i++)
                Console.Write(b[i]);
            Console.WriteLine();

            a = b.Replace('e', 'E');
            Console.WriteLine(a);

            a = b.Insert(8, "struguri, ");
            Console.WriteLine(a);

            a = b.ToUpper();
            Console.WriteLine(a);

            a = b.ToLower();
            Console.WriteLine(a);

            a = b.Remove(12);
            Console.WriteLine(a);

            a = b.Remove(12, 6); //Sterge 6 caractere de la pozitia 12;
            Console.WriteLine(a);

            a = "   Popescu     Vasile  Ioan                    ";
            b = a.Trim();
            Console.WriteLine("*" + b + "*");
        }
    }
}
