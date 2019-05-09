using System;

namespace Strategia___Wzorzec_Projektowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaczka zwykleKaczatko = new ZwyklaKaczka(new LatajSkrzydlami(), new Kwak());
            zwykleKaczatko.Kwac();
            zwykleKaczatko.Lec();
            Kaczka gumoweKaczatko = new GumowaKaczka(new NieLatam(), new Niema());
            gumoweKaczatko.Kwac();
            gumoweKaczatko.Lec();
            gumoweKaczatko.UstawLatanie(new LatajSkrzydlami());
            gumoweKaczatko.Lec();

            Console.ReadLine();
        }
    }
}
