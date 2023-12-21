using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Documento
    {
        public string ID { get; set; }
        public string Titolo { get; set; }
        public string Settore { get; set; }
        public int Anno { get; set; }
        public string Scaffale { get; set; }
        public bool Disponibile { get; set; }
        public Autore[] Autori { get; set; }

        public Documento(string iD, string titolo, string settore, int anno, string scaffale, bool disponibile)
        {
            ID = iD;
            Titolo = titolo;
            Settore = settore;
            Anno = anno;
            Scaffale = scaffale;
            Disponibile = disponibile;
            Autori = new Autore[4];
        }

        public override string ToString()
        {
           return ID+" "+Titolo+" "+Settore+" "+Anno+" "+Scaffale+" "+Disponibile+" "+Autori.ToString();
        }
        public void Impostaprestito() 
        {
            this.Disponibile = false;
        }
        public void Impostadisponibile()
        {
            this.Disponibile = true;
        }
    }
}
