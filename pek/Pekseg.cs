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
        List<Pekaru> termekek = new List<Pekaru>();
        DateTime alapitva = DateTime.Now;

        public Pekseg(string nev)
        {
            this.Nev = nev;
            
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        internal List<Pekaru> Termekek { get => termekek;}

        public override string ToString()
        {
            string s = this.nev + " - " + this.alapitva;
            return s;
        }

       
    }
}
