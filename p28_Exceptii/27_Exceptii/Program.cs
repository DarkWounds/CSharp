using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            //Citim a si b, numere naturale nenule
            //Si afisam catul impartirii lui a si b
            int a = -1, b = -1, c = -1;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException e) //In obiectul e este catata erarea
            {
                Console.WriteLine("b trebuia sa fie nenul!");
                //Console.WriteLine(e); - Afisarea erorii
            }
            finally
            {
                Console.WriteLine(c);
            }
        }
    }
}
