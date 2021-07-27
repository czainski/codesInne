using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
   
    class Program
    {
        static void Main()
        {
            //int i = 10;
            //int[] t = new int[10];

            Pracownik pracownik = new Pracownik();
            pracownik.Imię = "Jan";
            pracownik.Nazwisko = "Kowalski";
            pracownik.StawkaGodzinowa = 12.50m;
            pracownik.IlośćGodzin = 210;

            Pracownik pracownik2 = new Pracownik();
            pracownik2.Imię = "Jan";
            pracownik2.Nazwisko = "Kalski";
            pracownik2.StawkaGodzinowa = 34.20m;
            pracownik2.IlośćGodzin = 120;


            pracownik.DanePracownika();
            pracownik.Płaca();

            pracownik2.DanePracownika();
            pracownik2.Płaca();

            Console.ReadKey();

        }
    }
}
