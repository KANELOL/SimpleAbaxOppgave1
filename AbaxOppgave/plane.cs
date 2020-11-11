using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxOppgave
{
    class plane : vehicle
    {
        public string vingespenn;
        public int lasteevne;
        public int weight;
        public string kjøretøy;
        public plane(string regnr, int kwEffekt, string vingespenn, int lasteevne, int weight, string kjøretøy) : base(regnr, kwEffekt)
        {
            this.vingespenn = vingespenn;
            this.lasteevne = lasteevne;
            this.weight = weight;
            this.kjøretøy = kjøretøy;
        }

        public void Fly()
        {
            Console.WriteLine($"{kjøretøy}:{regNr} is flying away! You can fly away to if you want :D");
        }
    }
}
