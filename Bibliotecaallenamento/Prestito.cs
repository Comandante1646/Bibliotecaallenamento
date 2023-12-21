using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Prestito
    {
        public String Numero { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }

        public Prestito(String Numero, DateTime Dal, DateTime Al, Utente Utente, Documento Doc)
        {
            this.Numero = Numero;
            this.Dal = Dal;
            this.Al = Al;
            this.Utente = Utente;
            this.Documento = Doc;

        }


    }
}
