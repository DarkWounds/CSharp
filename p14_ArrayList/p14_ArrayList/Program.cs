using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un fisier text contine nume de elevi impreuna cu punctajul la olimpiada de informatica.
 * Sa se afiseze:
 * - descrescator dupa punctaj
 * - alfabetic
 */

namespace p14_ArrayList
{
    struct Elev
    {
        public string nume;
        public int punctaj;
        public Elev(string s, int p)
        {
            nume = s;
            punctaj = p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            ArrayList a = new ArrayList();

            if (!File.Exists("concurs.txt"))
            {
                Console.WriteLine("Nu exista fisierul");
                return;
            }

            StreamReader fin = new StreamReader("concurs.txt");
            StreamWriter f1 = new StreamWriter("alfabetic.txt");
            StreamWriter f2 = new StreamWriter("punctaj.txt");

            string linie;
            while ((linie = fin.ReadLine()) != null)
            {
                int p = linie.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                int punctajElev;
                string numeElev;
                punctajElev = int.Parse(linie.Substring(p).Trim());
                numeElev = linie.Substring(0, p - 1).Trim();
                Elev e = new Elev(numeElev, punctajElev);
                a.Add(e);
            }

            // Sortare alfabetica
            ArrayList b = new ArrayList();
            b.Add(a[0]);
            for (i = 1; i < a.Count; i++)
            {
                Elev w = (Elev)a[i];
                int poz = -1;
                for (j = 0; j < b.Count && poz == -1; j++)
                {
                    string numeElev = ((Elev)b[j]).nume;
                    if (numeElev.CompareTo(w.nume) > 0)
                        poz = j;
                }
                if (poz == -1) b.Add(a[i]);
                else b.Insert(poz, a[i]);
            }

            // Afisare
            foreach (Elev e in b)
                f1.WriteLine(e.nume + " " + e.punctaj);

            // Sortare descresc
            ArrayList c = new ArrayList();
            c.Add(a[0]);
            for (i = 1; i < a.Count; i++)
            {
                Elev w = (Elev)a[i];
                int poz = -1;
                for (j = 0; j < c.Count && poz == -1; j++)
                {
                    int punctajElev = ((Elev)c[j]).punctaj;
                    if (punctajElev <= w.punctaj)
                        poz = j;
                }
                if (poz == -1) c.Add(a[i]);
                else c.Insert(poz, a[i]);
            }

            // Afisare
            foreach (Elev e in c)
                f2.WriteLine(e.nume + " " + e.punctaj);

            fin.Close();
            f1.Close();
            f2.Close();
        }
    }
}