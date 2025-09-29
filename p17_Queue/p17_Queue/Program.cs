using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p17_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Se da un sir de nr nat din [0, 1000] 
             * Sa se det. lungimea maxima a unei secvente de nr distincte
             * Ex: 7 1 3 1 6 9 8 1 3 5 2 11 31 12 24 25 7 24
             * Val distincte sir: 6 9 8 1 3 5 2 11 31 12 24 25 7
             * Raspnsul este: 13
             * 
             *      0 1 2 3 4 5 .... 1000
             *  fr  0 1 1 1 0 .........    
             *  
             * Rezolvare:
             * q = 7 1 3
             * lg max = 3
             *  // Dau de 1 si scad
             * 
             * q = 3 1 6 9 8 
             * lg max = 5
             * //Dau de 1 si scad
             * 
             * q = 6 9 8 1 3 5 2 11 31 12 24 25 7 // Dau de 14 si scad
             * lg max = 13 
             */

            Queue<int> q = new Queue<int>();
            int i, lgmax = 0;
            int[] fr = new int[1001];

            for(i = 0; i <= 1000; i++)
                fr[i] = 0;

            string s = Console.ReadLine();
            string[] ch = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string e in ch)
            {
                int val = int.Parse(e);
                while(fr[val] > 0)
                {
                   fr[q.Peek()]--;
                   q.Dequeue();
                }
                q.Enqueue(val);
                fr[val]++;
                if (q.Count > lgmax) lgmax = q.Count;
            }
            Console.WriteLine(lgmax);
        }
    }
}
