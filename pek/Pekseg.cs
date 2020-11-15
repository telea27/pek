using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pek
{
    class Pekseg
    {
        string nev;
        List<Pekaru> termekek;
        DateTime alapitva;

        public Pekseg(string nev, List<Pekaru> termekek, DateTime alapitva)
        {
            this.Nev = nev;
            this.Termekek = termekek;
            this.Alapitva = alapitva;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }

        public override string ToString()
        {
            string s = nev + " - " + alapitva;
            return s;
        }
    }
}
