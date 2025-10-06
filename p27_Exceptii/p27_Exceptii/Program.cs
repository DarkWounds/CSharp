using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace p27_Exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            //Incercam sa deschidem un fisier care nu exista
            StreamReader fin;
            try
            {
                fin = new StreamReader("aaa.txt");
                fin.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fisier inexistent");
            }

            //fin.Close(); - Eroare unassigned (va fi declarat in try, momentan nu)
        }
    }
}
