using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Biblioteca
    {
        public Documento[] documenti;
        public int ndoc;
        public int nutenti;
        public int nprestiti;
        public Utente[] utenti;
        public Prestito[] prestiti;

        public Biblioteca()
        {
            this.documenti = new Documento [100000];
            this.utenti =new  Utente [1000000];
            this.prestiti =new Prestito[1000000] ;
            ndoc = 0; nutenti = 0; nprestiti = 0;
        }
        public void Aggiungidoc(Documento D) 
        {
            if (ndoc< 100000)
            {
                documenti[ndoc] = D;
                ndoc++;
            }
        }
        public void Aggiungiutente (Utente u)
        {
            if (nutenti < 100000)
            {
                utenti[nutenti] = u;
                nutenti++;
            }
        }
        public void Aggiungiprestito (Prestito p)
        {
            if (nprestiti<100000)
            {
                prestiti[nprestiti] = p;
                nprestiti++;
            }
        }
        public string Researchbytitle (string title)
        {
            for (int i=0; i < ndoc; i++)
            {
                if (documenti[i].Titolo == title)
                {
                    return documenti[i].ToString();
                }
            }
            return "Documento non trovato";
        }
    }
}
