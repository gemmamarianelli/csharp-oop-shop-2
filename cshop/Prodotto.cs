using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string desrcizione;
        private int prezzo;
        private int iva;

        public Prodotto()
        {

        }
        public Prodotto(int codice, string nome, string descrizione, int prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.desrcizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        
        public int getCodice()
        {

            return codice;
        }
        public string GetNome()
        {
            return nome;
        }
        public string getDescrizione()
        {
            return desrcizione;
        }
        public int getPrezzo()
        {
            return prezzo;
        }
        public int getIva()
        {
            return iva;
        }
        public void setCodice(int codice)
        {


            this.codice = codice;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setDescrizione(string descrizione)
        {
            this.desrcizione = descrizione;
        }
        public void setPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }
        public void setIva(int iva)
        {
            this.iva = iva;
        }
        public void StampaProdotto()
        {
            Console.WriteLine("-------" + "PRODOTTO" + "-------");
            Console.WriteLine("codice: " + codice);
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("descrizione: " + desrcizione);
            Console.WriteLine("prezzo: " + prezzo);
            Console.WriteLine("iva: " + iva);
            Console.WriteLine("----------------------");
        }
    }
}
