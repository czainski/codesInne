using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_ćwiczenie
{
         
    class Program
    {
        static void Main(string[] args)
        {
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.Imię = "Hubert";
            zawodnik.Nazwisko = "Skwark";
            zawodnik.Wzrost = 187;
            zawodnik.Stawka_za_mecz = 50;
            zawodnik.Ilość_meczy_w_miesiącu = 21;

            Zawodnik zawodnik2 = new Zawodnik();
            zawodnik2.Imię = "Marcin";
            zawodnik2.Nazwisko = "Gortat";
            zawodnik2.Wzrost = 216;
            zawodnik2.Stawka_za_mecz = 1000;
            zawodnik2.Ilość_meczy_w_miesiącu = 21;

            zawodnik.DaneZawodnika();
            zawodnik.Wynagrodzenie_miesięczne();

            zawodnik2.DaneZawodnika();
            zawodnik2.Wynagrodzenie_miesięczne();


            Console.ReadKey();
            
        }
    }
}
