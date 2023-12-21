using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b= new Biblioteca();
            Documento d1 = new Documento("5","Info","scuola", 1999, "h7", true);
            b.Aggiungidoc(d1);
            Utente u = new Utente("Mario","bianchi","wsihby","pass", "3467923857");
            Prestito p1 = new Prestito("P00001", new DateTime(2019, 1, 20), new DateTime(2019, 2, 20), u, d1);
            b.Aggiungiprestito(p1);
            b.Aggiungiutente(u);
            d1.Impostaprestito();
        }
    }
}
