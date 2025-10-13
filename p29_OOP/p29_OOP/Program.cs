using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Clasa - un tip de data definit de utilizator 
 * Impreuna cu operatiile de acest tip
 * Instanta (obiect) - o variabila de tip clasa
 * Variabila membra este o variabila definita intr-o clasa
 * Metoda (functie membra) este o functie definita in clasa
 * Datele membre sunt : 
 * - Var memre
 * - Metode
 * - Constructori
 * - Destructor
 * - Proprietati
 * - Indexatori
 * - Operatori supradefiniti
 * - Evenimente (Events)
 * - Delegati (Delegates)
 * Modificatori de acces: 
 * - private (accesibile doar in clasa)
 * - public (accesibile de orice)
 * - protected (se comporta precum cele private, dar sunt accesibile si in clasele derivate)
 * 
 * OBS: Orice data membra a unei clase trebuie sa aiba specificat modificatorul de acces. Daca nu este mentionat, atunci 
 * data membra respectiva este implicit private
 * 
 * Notiunile de baza/esentiale legate de OOP:
 * - Incapsularea
 * - Polimorfism
 * - Mostenire
 * 
 * Constructorii:
 * - Au rol de initializare
 * - Poarta numele clasei
 * - Nu returneaza nimic, nici macar void
 * - Pot exista mai multi constructori care difera din parametrii
 * (default = implicit, copy = de copiere, alti constructori)
 * - Daca nu s-a definit in clasa un constructor se creeaza unul implicit
 * - Pot fi public, protected, private
 * - Constructorii se apeleaza implicit
 * 
 */

namespace p29_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z, z1, z2;
            z = new Complex();
            z1 = new Complex();
            z2 = new Complex();
            z1.Init(2, 5); z1.Afis();
            z2.Init(3, 4); z2.Afis();

            z.Adunare(z1, z2);
            z.Afis();

            z.Inmultire(z1, z2);
            z.Afis();

            z.Impartire(z1, z2);
            z.Afis();

            Console.WriteLine(z2.Modul());

            Console.WriteLine(z1);

            Complex z3 = new Complex(z1);
            z3.Afis();
        }
    }
}
