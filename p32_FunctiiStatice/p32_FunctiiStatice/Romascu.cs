using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p32_FunctiiStatice
{
    class Romascu
    {
        public int pix;
        public static int carioca;

        public Romascu(int p, int c)
        {
            pix = p;
            carioca = c;
        }

        public Romascu()
        {
            pix = 0;
            carioca = 0;
        }

        public override string ToString()
        {
            return (pix + " " + carioca);
        }

        public void Incrementa()
        {
            pix++;
            carioca++;
        }

        public static void HitMan(Romascu R)
        {
            carioca = 555;
            Console.WriteLine(R);
        }
    }
}
