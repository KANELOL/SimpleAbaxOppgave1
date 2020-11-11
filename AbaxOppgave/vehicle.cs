using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxOppgave
{
    class vehicle
    {
        public string regNr;
        public int KwEffekt;

        public vehicle(string regnr, int kwEffekt)
        {
            regNr = regnr;
            KwEffekt = kwEffekt;
        }

        public void CompareVehicle(string regNrToChek)
        {
            if (regNr != regNrToChek)
            {
                Console.WriteLine($"{regNr} is not this vehicle: {regNrToChek}");
            }

            if (regNr == regNrToChek)
            {
                Console.WriteLine($"This is the same vehicle: {regNr} and {regNrToChek}");
            }
        }
    }
}
