using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

/*
 HashTable:
 * - Contine perechi de valori (Key, Value)
 * Operatiile:
 * -Add()
 * -Remove()
 * -Contains(), ContainsKey()
 * -Count
 * -Clear()
 */

namespace p24_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "aaa");
            h.Add(2, "bbb");
            h.Add(18, "fff");
            h.Add(3, "ccc");
            h.Add(10, "zzz");
            h.Add(4, "ddd");
            h.Add(5, "eee");
            //Afisam tot hashtable:
            foreach (DictionaryEntry e in h)
                Console.WriteLine(e.Key + " " + e.Value);

            if (h.ContainsKey(10)) Console.WriteLine("Apare");
            else Console.WriteLine("Nu apare");

            Console.WriteLine("Acest hash contine {0} perechi\n", h.Count);
            h.Remove(10);
            Console.WriteLine("Acest hash contine {0} perechi\n", h.Count);

            try
            {
                h.Add(3, "iii");// - Crapa programul (Cheia trb sa fie unica)
            }
            catch
            {
                Console.WriteLine("Problema la ADDDDDD, AI DEJA 333333333");
            }

            h.Add(13, "eee");
            Console.WriteLine("Acest hash contine {0} perechi", h.Count);

            //Cum modificam o valoare a unie anumite key

            foreach (DictionaryEntry e in h)
                Console.WriteLine(e.Key + " " + e.Value);
            Console.WriteLine("\n");

            int x = 4;
            string sir = "Ana are mere";

            if (h.ContainsKey(x)) h[x] = sir;
            foreach (DictionaryEntry e in h)
                Console.WriteLine(e.Key + " " + e.Value);
            Console.WriteLine("\n");

            h[222] = "I am a acceptable"; //Daca nu gaseste sa modifice adauga el
            foreach (DictionaryEntry e in h)
                Console.WriteLine(e.Key + " " + e.Value);
            Console.WriteLine("\n");

            h.Clear();
            Console.WriteLine("Acest Hashtable are {0} perechi\n", h.Count);

            //Facem alt Hashtable
            Hashtable w = new Hashtable()
            {
                {"unu", "1"}, {"doi", "2"}, {"trei", 3}, 
                {"patru", 3.14}, {"cinci", null}
            };

            foreach (DictionaryEntry e in w)
                if (e.Value == null) Console.WriteLine(e.Key + " NULLLLLL");
                else Console.WriteLine(e.Key + " " + e.Value); 
            Console.WriteLine("\n");

            //w[null] = "test"; - Crapa programul (cheia nu poate fi nula)
            try
            {
                w[null] = "Test";
            }
            catch
            {
                Console.WriteLine("Cheia nu poate fi NULLLL\n");
            }
        }
    }
}
