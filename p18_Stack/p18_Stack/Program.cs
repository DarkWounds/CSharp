using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

/*
10
push 3 
push 5
push 7
top
push 8
pop 
top
pop
top
pop
 * 
 * st = 3
 * 
 */

namespace p18_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i; //n - nr operatii
            string op, s; // op- operatii
            int x; //val
            Stack<int> st = new Stack<int>();

            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                s = Console.ReadLine();
                s = s.Trim();
                if (s == "pop")
                {
                    if (st.Count > 0)
                        st.Pop();
                }
                else if (s == "top")
                {
                    if (st.Count > 0)
                        Console.WriteLine(st.Peek());
                }
                else
                {
                    int p = s.IndexOf(" ");
                    x = int.Parse(s.Substring(p + 1).Trim());
                    st.Push(x);
                }
            }
        }
    }
}
