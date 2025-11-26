using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p38_UnorderedMap
{
    class Element
    {
        public string val;
        public int fr;
        public Element(string x)
        {
            val = x;
            fr = 1;
        }
    }

    class UnorderedMap
    {
        private int P = 123457;
        private List<Element>[] h;
        private int n; // numarul de elemente distincte din hash
        public UnorderedMap()
        {
            h = new List<Element>[P];
            for (int i = 0; i < P; i++)
                h[i] = new List<Element>();
            n = 0;
        }
        public int Count // numarul de elemente distincte din hash
        {
            get { return n; }
        }
        public void Add(string x)
        {
            int i, r = 0; // r = x % P
            foreach (char ch in x)
                r = (256 * r + (int)ch) % P;
            // cautam pe x in h[r], daca apare, doar crestem frecventa sa
            // daca nu apare, atunci adaugam pe x cu frecventa 1
            for (i = 0; i < h[r].Count; i++)
                if (h[r][i].val == x)
                {
                    (h[r][i].fr)++;
                    return;
                }
            Element e = new Element(x);
            h[r].Add(e);
            n++;
        }

        // sterge o aparitie a lui x; daca x aparea o singura data,
        // il stergem de tot
        public void Erase(string x)
        {
            int i, r = 0; // r = x % P
            foreach (char ch in x)
                r = (256 * r + (int)ch) % P;
            for (i = 0; i < h[r].Count; i++)
                if (h[r][i].val == x)
                {
                    (h[r][i].fr)--;
                    if (h[r][i].fr == 0)
                    {
                        h[r].RemoveAt(i);
                        n--;
                    }
                    return;
                }
        }
        // sterge toate aparitiile lui x
        public void EraseAll(string x)
        {
            int i, r = 0; // r = x % P
            foreach (char ch in x)
                r = (256 * r + (int)ch) % P;
            for (i = 0; i < h[r].Count; i++)
                if (h[r][i].val == x)
                {
                    h[r].RemoveAt(i);
                    n--;
                    return;
                }
        }

        // afiseaza elementele din h[r]
        public void Afis(int r)
        {
            foreach (Element e in h[r])
                Console.Write(e.val + " ");
        }

        public void Afis()
        {
            for (int i = 0; i < P; i++)
                if (h[i].Count > 0)
                {
                    Afis(i);
                    Console.WriteLine();
                }
        }

        public int FrecvMin()
        {
            int x, valMin = 2000000001;
            for (int i = 0; i < P; i++)
                if (h[i].Count > 0)
                    foreach (Element w in h[i])
                        if (w.fr == 1)
                        {
                            x = int.Parse(w.val);
                            if (x < valMin) valMin = x;
                        }
            return valMin;
        }

        public Element FrecvMax()
        {
            Element e = new Element("zzzzzzzzzzzzzzz");
            e.fr = 0;
            for (int i = 0; i < P; i++)
                if (h[i].Count > 0)
                    foreach (Element w in h[i])
                        if ((w.fr > e.fr) || (w.fr == e.fr && (w.val).CompareTo(e.val) < 0))
                            e = w;
            return e;
        }

        public int this[string x]
        {
            get
            {
                int r = 0;
                foreach (char ch in x)
                    r = (256 * r + (int)ch) % P;
                //for (i = 0; i < h[r].Count; i++)
                //    if (h[r][i].val == x)
                //        return h[r][i].fr;
                foreach (Element e in h[r])
                    if (e.val == x) return e.fr;
                return 0;
            }
            set
            {
                int i, r = 0;
                foreach (char ch in x)
                    r = (256 * r + (int)ch) % P;
                for (i = 0; i < h[r].Count; i++)
                    if (h[r][i].val == x)
                    {
                        h[r][i].fr = value;
                        if (h[r][i].fr == 0)
                        {
                            h[r].RemoveAt(i);
                            n--;
                        }
                        return;
                    }
                if (value > 0)
                {
                    Element e = new Element(x);
                    e.fr = value;
                    h[r].Add(e);
                    n++;
                }
            }
        }
    }

}
