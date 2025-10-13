using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p29_OOP
{
    class Complex
    {
        private double re, im; // Var membre
        public void Init(double x, double y) //Metoda
        {
            re = x;
            im = y;
        }
        public void Init() //Metoda
        {
            re = im = 0;
        }
        public void Afis() //Metoda
        {
            Console.WriteLine(re + " + i * " + im);
        }

        public void Adunare(Complex z1, Complex z2)
        {
            this.re = z1.re + z2.re;
            this.im = z1.im + z1.im;
        }

        public void Inmultire(Complex z1, Complex z2)
        {
            this.re = (z1.re * z2.re) - (z1.im * z2.im);
            this.im = (z1.re * z2.im) + (z1.im * z2.re);
        }

        public void Impartire(Complex z1, Complex z2)
        {
            double numitor = z2.re * z2.re + z2.im * z2.im;
            this.re = (z1.re * z2.re + z1.im * z2.im) / numitor;
            this.im = (z1.im * z2.re - z1.re * z2.im) / numitor;
        }

        public double Modul()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public override string ToString()
        {
            return re + " + i * " + im;
        }

        //--------------------Constructori-----------------------
        public Complex(double x, double y)
        {
            Init(x, y);
        }

        public Complex()
        {
            re = im = 0;
        }

        public Complex(Complex z) // Constructor de copiere
        {
            re = z.re;
            im = z.im;
        }
    }
}
