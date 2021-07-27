using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Pracownik
    {
        public string Nazwisko { set; get; }
        public string Imię { set; get; }
        public decimal StawkaGodzinowa { set; get; }
        public decimal IlośćGodzin { set; get; }


        public void DanePracownika()
        {

            Console.WriteLine($" {Nazwisko} {Imię}");
        }

        public void Płaca()
        {
            decimal płaca = StawkaGodzinowa * IlośćGodzin;
            Console.WriteLine($"{płaca}");
        }
    }
}
