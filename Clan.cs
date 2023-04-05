using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe3
{
    class Clan
    {
        private string ime;
        private string sport;
        private string telefon;

        public string Ime
        {
            set { this.Ime = value; }
        }

        public string Sport
        {
            set { this.Sport = value; }
        }

        public string Telefon
        {
            set { this.Telefon = value; }
        }

        public override string ToString()
        {
            return "Ime i prezime: " + this.ime + " Sport: " + this.sport + " Telefon " + this.telefon + "\n\r";
        }

    }
}
