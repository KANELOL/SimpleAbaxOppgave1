using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxOppgave
{
    class boat:vehicle
    {
        public int maksfart;
        public int bruttonnasje;

        public boat(string regNr, int kwEffekt, int maksfart, int bruttonnasje) : base(regNr, kwEffekt)
        {
            this.maksfart = maksfart;
            this.bruttonnasje = bruttonnasje;
        }

        public void checkBoat()
        {
            Console.WriteLine($"This boat have the following attributes \n RegNr: {regNr}.\n KwEffekt: {KwEffekt}.\n MaxSpeed: {maksfart}knop.\n Bruttonnasje: {bruttonnasje}kg");
        }
    }
}
