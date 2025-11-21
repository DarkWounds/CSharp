using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p35_Template
{
    /// <summary>
    /// Lista inlantuita de tip template
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 

    class Nod<T>
    {
        public T info;
        public Nod<T> leg;
        public Nod(T val)
        {
            info = val;
            leg = null;
        }
    }

    class Stiva<T>
    {
        public Nod<T> top;
        int n; // numarul de noduri

        public void Init()
        {
            top = null;
            n = 0;
        }

        public Stiva()
        {
            Init();
        }

        public int Size
        {
            get { return n; }
        }

        //Adauga pe x in stiva
        public void Push(T x)
        {
            Nod<T> p = new Nod<T>(x);
            p.leg = top;
            top = p;
            n++;
        }

        public void Pop()
        {
            Nod<T> p = top;
            top = top.leg;
            p = null;
            n--;
        }

        public T Top()
        {
            return top.info;
        }

        public bool Empty()
        {
            return (top == null);
        }

        public override string ToString()
        {
            string s = "";
            while (!this.Empty())
            {
                s += this.Top() + " ";
                this.Pop();
            }
            return s;
        }

    }
}
