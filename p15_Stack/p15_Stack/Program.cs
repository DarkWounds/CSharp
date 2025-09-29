using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace p15_Stack
{
    /*
     * Clasa Stack:
     * -Push(x) adauga un element x in stiva
     * -Pop() elimina un element din vf stivei
     * -Peek() returneaza elementul din vf stivei ( in c++ Top() )
     * -Count() - propietate - cate elemente sunt in stiva
     * 
     * Citim un nr natural n si afisam reprezentarea sa in baza 2
     * Citim un nr natural n si afisam reprezentarea sa in baza 16
     */
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            int n = 123456789;
            while (n > 0)
            {
                st.Push(n % 2);
                n /= 2;
            }
            while (st.Count > 0)
            {
                Console.Write(st.Peek());
                st.Pop();
            }
            Console.WriteLine("\n");

            // Conversia in baza 16
            n = 1270067091;

            Stack<char> w = new Stack<char>();

            while (n > 0)
            {
                int val = n % 16;
                if (val <= 9) w.Push((char)(val + '0')); //Convertim in char, il vede ca pe obiect
                else w.Push((char)(val - 10 + 'A'));
                n /= 16;
            }

            // Afisare
            while (w.Count > 0)
            {
                Console.Write(w.Peek());
                w.Pop();
            }
            Console.WriteLine("\n");
        }
    }
}
