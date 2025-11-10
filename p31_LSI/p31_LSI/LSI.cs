using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace p31_LSI
{
    class Nod
    {
        public int info;
        public Nod leg;
        public void Init()
        {
            info = 0;
            leg = null;
        }
        public void Init(int val)
        {
            info = val;
            leg = null;
        }
        public Nod(int val)
        {
            Init(val);
        }
    }

    class LSI
    {
        public int n; //Nr de Noduri
        public Nod head; //Referinta la primul nod din lista

        //-------------------Sectiunea Metode------------------------

        // Adauga la inceputul listei
        public void Add(int val) 
        {
            Nod q = new Nod(val);
            q.leg = head;
            head = q;
            n++;
        }

        // Adauga dupa nodul p
        public void Add(Nod p, int val) 
        {
            Nod q = new Nod(val);
            q = p.leg;
            p.leg = q;
            n++;
        }

        //Sterge primul nod din lista
        public void Erase()
        {
            if (head == null) return;
            Nod p = head;
            head = head.leg;
            p = null;
            n--;
        }

        //Sterge nodul de dupa lista
        public void Erase(Nod p)
        {
            if (p == null) return;
            if (p.leg == null) return;
            Nod q = p.leg;
            p.leg = q.leg;
            q = null;
            n--;
        }

        //-------------------Sectiunea Constructori/Destructori------

        // Constructori

        //Lista nulla
        public LSI()
        {
            head = null;
            n = 0;
        }

        //Lista cu un nod
        public LSI(int val)
        {
            head = new Nod(val);
            n = 1;
        }

        //Citire din fisier
        public LSI(string fisInput)
        {
            if (!File.Exists(fisInput))
            {
                Console.WriteLine("Nu exista fisierul!");
                return;
            }
            head = null;
            n = 0;
            
        }

        //Destructori
        ~LSI()
        {
            head = null;
            n = 0;
        }

        //-------------------Sectiunea Proprietati-------------------

        public int Count
        {
            get { return n; }
        }

        //-------------------Sectiunea Indexatori--------------------

        //-------------------Afisarea Listei-------------------------

        public override string ToString()
        {
            string s = String.Empty;
            for (Nod p = head; p != null; p = p.leg)
                s += (p.info + " ");
            return s;
        }
    }
}
