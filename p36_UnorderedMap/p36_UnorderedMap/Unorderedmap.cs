using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p36_UnorderedMap
{
    /// <summary>
    /// Hash table
    /// </summary>
    /// 

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

    class Unorderedmap
    {
        private int P = 123457;
        private List<Element>[] h;
        private int n; // Numarul de elemente distincte din hash

        public Unorderedmap()
        {
            h = new List<Element>[P];
            for (int i = 0; i < P; i++)
                h[i] = new List<Element>();
            n = 0;
        }

        public int Count //numarul de elemente distincte din hash
        {
            get { return n; }
        }

        public void Add(string x)
        {
            int i, r = 0; // r = x % P
            foreach (char ch in x)
                r = (256 * r + (int)ch) % P;

            //Cautam pe x in h[r], daca apare, doar crestem frecventa sa
            //daca nu il gasim, atunci il adaugam pe x cu frecventa 1

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

        //Sterge o aparitie a lui x; Daca apare o singura data, il stergem de tot 
        //Altfel decrementam
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

        //Stergem toate aparitiile lui x
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

        //Afiseaza elementele din h[r]
        public void Afis(int r)
        {
             foreach (Element e in h[r])
                    Console.Write(e.val + " ");     
        }

        public void Afis()
        {
            for (int i = 0; i < P; i++)
            {
                if (h[i].Count > 0)
                {  
                    Afis(i);
                    Console.WriteLine();
                } 
            }
        }

        /*
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.P; i++)
            {
                foreach (Element e in h[i])
                    s += (e.val + " ");
                s += "\n";
            }
            return s;
        }
         * */
    }
}
