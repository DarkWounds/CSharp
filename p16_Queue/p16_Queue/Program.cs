using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16_Queue
{
    /*
     *Coada-----------------
     *Operatii:
     *-Enqueue(x) adauga in coada pe x
     *-Dequeue() elimina primul elem din coada
     *-Peek() returneaza valoarea primul element din coada
     *- Count - ret. numarul de elemente din coada
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* Punem un sir de numere in coada
            Le eliminam pe rand pana ce dam peste un nr divizibil cu 10
            Facem apoi suma elementelor ramase in coada
             4 17 3 9 20 3 5 7 1 10
             - -  - - 20 3 5 7 1 10
             20 + 3 + 5 + 7 + 1 + 10 = 46
             */
            Queue q = new Queue();
            Stack w = new Stack();
            string s = Console.ReadLine();
            string[] nr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string e in nr)
                q.Enqueue(e);
            
            //Scoatem pana gasim un nr divizibil cu 10

            while (q.Count > 0 && Convert.ToInt32(q.Peek()) % 10 != 0) //Nu merge convesia
                q.Dequeue();

            // facem suma celor ramase
            int suma = 0;
            while (q.Count > 0)
            {
                suma += Convert.ToInt32(q.Peek());
                q.Dequeue();
            }
            Console.WriteLine(suma);
        }
    }
}
