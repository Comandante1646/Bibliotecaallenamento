using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecaallenamento
{
    internal class Utente : Persona
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public Utente (string n, string c, string m, string p, string t): base (n, c)
        {
            this.Mail = m;
            this.Password = p;
            this.Telefono = t;
        }
    }
}
