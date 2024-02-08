using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futoverseny
{
    public class Futo
    {
        public string Rajtszam { get; set; }
        public string Nev { get; set; }
        public DateTime Szulido { get; set; }
        public string Orszag {  get; set; }
        public string Eredmeny { get; set; }

        public Futo (string sor)
        {
            string[] s = sor.Split(';');
            Rajtszam = s[0];
            Nev = s[1];
            Szulido = DateTime.Parse(s[2]);
            Orszag = s[3];
            Eredmeny = s[4];
        }
    }
}
