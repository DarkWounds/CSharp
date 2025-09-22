using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_fisiere_text
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vrem sa memoram in fisierul "fisiere.txt" lista
             * fisierelor text din folderul "Date"
             */
            if (!Directory.Exists("Date"))
            {
                Console.WriteLine("Folder inexistent!");
                return;
            }

            string[] f = Directory.GetFiles("Date", "*.txt");
            StreamWriter fout = new StreamWriter("fisiere.txt");

            foreach (string e in f)
            {
                int p = e.LastIndexOf("\\");
                string fis = e.Substring(p + 1);
                fout.WriteLine(fis);
            }

            fout.Close();
        }
    }
}