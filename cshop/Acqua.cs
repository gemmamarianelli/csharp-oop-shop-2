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

        public Acqua(int litri, int ph, string sorgente)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
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

    }
}

