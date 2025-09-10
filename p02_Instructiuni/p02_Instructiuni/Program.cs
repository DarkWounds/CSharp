using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_Instructiuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, suma;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            Console.WriteLine(a + " + " + b + " = " + suma);
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            if (a % 2 == 0) Console.WriteLine("{0} este par", a);
            else Console.WriteLine("{0} este impar", a);

            //Suma cifrelor lui n
            int n = 12345, aux = n;
            suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            Console.WriteLine("Suma cifrelor este " + suma);
            Console.WriteLine("Suma cifrelor nr {0} este {1} ", aux, suma);

            //Afisam de la 1 nr divizibile cu 5
            n = 98;
            for (int i = 5; i <= n; i += 5)
                Console.WriteLine(i + " ");
            Console.WriteLine("\n");

            //Nr de cifre ale lui n
            n = 1234567;
            int nrCif = 0;
            do
            {
                n /= 10;
                nrCif++;
            } while (n > 0);
            Console.WriteLine("Nr de cifre este {0}", nrCif);

            a = 12;
            b = 901382734;
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("CMMDC este {0}", a);

            r = 2;
            Console.WriteLine("Aria cercului de raza {0} = {1}", r, r * r * Math.PI);

            a = 145;
            Console.WriteLine(Math.Sqrt(a));

            //Maximul dintree doua numere
            a = 55;
            b = 67;
            Console.WriteLine("max({0}, {1}) = {2}", a, b, Math.Max(a, b));
        }
    }
}