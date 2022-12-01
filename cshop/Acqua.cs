using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshop
{
    internal class Acqua
    {

        private int litri;
        private int ph;
        private string sorgente;
        private double capienza;

        public Acqua(int litri, int ph, string sorgente)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            this.capienza = 1.5;
        }
        public int getLitri()
        {

            return litri;
        }
        public int getPh()
        {
            return ph;
        }

        public string getSorgente()
        {
            return sorgente;
        }
        public double getCapienza()
        {
            return capienza;
        }
        
    }
}

