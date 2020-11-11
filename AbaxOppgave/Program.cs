using System;

namespace AbaxOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bil1 = new car("NF123456",147,200,"green","Lett Kjøretøy");
            var bil2 = new car("NF654321", 150,195,"blue","Lett Kjøretøy");
            bil1.Drive();
            bil2.Drive();
            bil1.CompareVehicle(bil2.regNr);
            var plane1 = new plane("LN1234",1000,"30m",2,10,"Jetfly");
            Console.WriteLine($"This plane reg.Nr:{plane1.regNr}, it has a kwEffect of: {plane1.KwEffekt}, It wingspan is {plane1.vingespenn}. You can put {plane1.lasteevne}Tons in this bad boy." +
                              $"It weights {plane1.weight}TONS!, thats a alot. And it is a vehicle class of: {plane1.kjøretøy}");
            plane1.Fly();
            var boat1 = new boat("ABC123",100,30,500);
            boat1.checkBoat();

            //Info : bil1, reg.nr : NF123456, kw effekt:147, maksfart:200km/t, farge: grønn, kjøretøy: Lett Kjøretøy.
            //Info : bil2, reg.nr : NF654321, kw effekt:150, maksfart:195km/t, farge: blå, kjøretøy: Lett Kjøretøy.
            //sammenlikne bilene er det sammekjøretøy?
            //Info : fly, reg.nr : LN1234, kw effekt:1000, vingespenn:30m, lasteevne:2tonn, egenvekt:10tonn, kjøretøy:jetfly
            //Skal kunne be flyet om å fly.
            //Skal kunne be bil om å kjøre.
            //Info: båt, reg.nr: ABC123, kw effekt:100, maksfart:30knop, 500kg bruttotonnasje
        }
    }
}
