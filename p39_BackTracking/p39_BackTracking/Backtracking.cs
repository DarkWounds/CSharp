using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p39_BackTracking
{
    class Backtracking
    {
        protected int[] st;
        protected int n; //Lungimea stivei
        protected int vmin, vmax; // Val min si max de pe un niv pe stiva;

        public Backtracking(int _n, int _vmin, int _vmax)
        {
            st = new int[n + 1];
            n = _n;
            vmin = _vmin;
            vmax = _vmax;
        }

        public virtual bool Valid(int top, int x)
        {
            return true;
        }

        public virtual void Afis(int k)
        {
            for (int i = 1; i <= k; i++)
                Console.Write(st[i] + " ");
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int i = 1; i <= n; i++)
                s += (st[i] + " ");
            return s;
        }

        public virtual void Back(int top)
        {
            if (top == n + 1) Afis(n);
            else
                for (int i = vmin; i <= vmax; i++)
                    if (Valid(top, i))
                    {
                        st[top] = i;
                        Back(top + 1);
                    }
        }
    }

    class Perm : Backtracking
    {
        protected int[] ap; // ap[i] = 1; Daca i este deja pe stiva, ap[i] = 0; Daca nu e pe stiva inca

        public Perm(int _n, int _vmin, int _vmax)
            : base(_n, _vmin, _vmax)
        {
            st = new int[n + 1];
            ap = new int[n + 1];
        }

        public virtual bool Valid(int top, int x)
        {
           /* if (ap[x] == 1)
                return false;
            return true;*/

            return (ap[x] == 0);
        }

        public override void Back(int top)
        {
            if (top == n + 1) Afis(n);
            else
                for (int i = vmin; i <= vmax; i++)
                    if (Valid(top, i))
                    {
                        ap[i] = 1;
                        st[top] = i;
                        Back(top + 1);
                        ap[i] = 0;
                    }
        }
    }

    class Aranjamente : Perm
    {
        public Aranjamente(int _n, int _vmin, int _vmax)
            : base(_n, _vmin, _vmax)
        {
            st = new int[n + 1];
            ap = new int[vmax + 1];
        }
    }

    class Combinari : Backtracking
    {
        public Combinari(int _n, int _vmin, int _vmax)
            : base(_n, _vmin, _vmax)
        {
            st = new int[n + 1];
        }

        public override void Back(int top)
        {
            if (top == n + 1) Afis(n);
            else 
                for (int i = st[top - 1] + 1; i <= vmax; i++)
                {
                    st[top] = i;
                    Back(top + 1);
                }
        }
    }

    /*Se da S, sa se scrie S ca suma de nr. nat. nenule distincte
     * S = 10;
     * 1 + 2 + 3 + 4
     * 1 + 3 + 6
     * 1 + 9
     * 2 + 3 + 5
     * 2 + 8
     * 3 + 7
     * 4 + 6 
    */

    class Suma : Backtracking
    {
        int suma;

        public Suma(int _n, int _vmin, int _vmax)
            : base(_n, _vmin, _vmax)
        {
            st = new int[n + 1];
            suma = 0;
        }

        public override void Back(int top)
        {
            if (suma == n) Afis(top - 1);
            else for (int i = st[top - 1] + 1; i <= vmax; i++)
                {
                    st[top] = i;
                    suma += i;
                    Back(top + 1);
                    suma -= i;
                }
        }
    }

    //--------------------------------------------------
    class Problema : Perm
    {

        string adv = "NU";
        string perm = "";

        public Problema(int _n, int _vmin, int _vmax, string s)
            : base(_n, _vmin, _vmax)
        {
            perm = s;
            st = new int[n + 1];
            ap = new int[n + 1];
        }

        public override void Afis(int k)
        {
            string g = String.Empty;
            for (int i = 1; i <= k; i++)
                g += (st[i] + " ");
            if (g == perm)
                adv = "DA";
        }

        public void Rezultat()
        {
            Console.WriteLine(adv);
        }
    }
}
