using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Persona
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public Persona(string n, string c)
        { 
            this.Nome = n;
            this.Cognome = c;
        }
    }
}
