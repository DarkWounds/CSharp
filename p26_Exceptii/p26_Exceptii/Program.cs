using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p26_Exceptii
{

    //Vorbim despre try-catch-finally

    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            string s;
            Console.Write("Introduceti valoarea lui n: ");
            s = Console.ReadLine();
            try
            {
                n = int.Parse(s);
                n++;
                Console.WriteLine(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Nu este numar nat");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Nr nu este de tip int");
            }
            //Finally nu este obligatoriu
            finally
            {
                n++;
                Console.WriteLine(n);
            }

        }
    }
}
