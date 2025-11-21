using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p35_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva<int> st = new Stiva<int>();
            Stiva<char> w = new Stiva<char>();

            int n = 1234;
            while(n > 0)
            {
                st.Push(n % 2);
                n /= 2;
            }

            Console.WriteLine("n in baza 2:");
            while (!st.Empty())
            {
                Console.Write(st.Top() + " ");
                st.Pop();
            }
            Console.WriteLine();

            //--------------------------------------------------------------
            n = 1234;
            while (n > 0)
            {
                st.Push(n % 2);
                n /= 2;
            }

            // Afisam continutul stivei override ToString()
            Console.WriteLine(st);


            for (char c = 'a'; c <= 'z'; c++)
                w.Push(c);
            while (!w.Empty())
            {
                Console.Write(w.Top() + " ");
                w.Pop();
            }
            Console.WriteLine();


            //--------------------------------------------------------------
            for (char c = 'a'; c <= 'z'; c++)
                w.Push(c);

            // Afisam continutul stivei override ToString()
            Console.WriteLine(w);

        }
    }
}
