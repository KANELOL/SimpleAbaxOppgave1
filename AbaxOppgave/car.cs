using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxOppgave
{
    class car : vehicle
    {
        
        public int Maksfart;
        public string Farge;
        public string Kjøretøy;
        public car(string regnr, int kwEffekt, int maksfart, string farge, string kjøretøy) : base(regnr, kwEffekt)
        {
            Maksfart = maksfart;
            Farge = farge;
            Kjøretøy = kjøretøy;
        }

        public void Drive()
        {
            Console.WriteLine($"Vrom vrom the car {regNr} is driving away in {Maksfart}km/h!! You only see a {Farge} blurry line after it. Wow so fast!");
        }
    }
}
