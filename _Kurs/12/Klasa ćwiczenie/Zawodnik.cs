using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_ćwiczenie
{
    class Zawodnik
    {
        public string Imię { set; get; }
        public string Nazwisko { set; get; }
        public decimal Wzrost { set; get; }
        public decimal Stawka_za_mecz { set; get; }
        public decimal Ilość_meczy_w_miesiącu { set; get; }

        public void DaneZawodnika()
        {
            Console.WriteLine($"{Imię} {Nazwisko} Wzrost :{Wzrost}");
        }

        public void Wynagrodzenie_miesięczne()
        {
            decimal Wynagrodzenie_miesięczne = Stawka_za_mecz * Ilość_meczy_w_miesiącu;
            Console.WriteLine($"{Wynagrodzenie_miesięczne}");
        }
    }
}
