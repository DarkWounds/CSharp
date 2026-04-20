using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p51_TestGrila
{
    class Intrebare
    {
        public string enuntIntrebare;
        public string[] varianteDeRasp;
        public int raspCorect;
        public int raspConcurent;

        public Intrebare(string e, string[] variante, int corect)
        {
            enuntIntrebare = e;
            varianteDeRasp = new string[5];
            for (int i = 1; i <= 4; i++)
                varianteDeRasp[i] = variante[i];
            raspCorect = corect;
            raspConcurent = 0;
        }
    }
}
