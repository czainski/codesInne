using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Walut
{
    class Program
    {
        static decimal Czytaj_liczbę()
        {
            var liczba1konsola = Console.ReadLine();
            decimal liczba1 = decimal.Parse(liczba1konsola);
            return liczba1;
        }
        static void Main(string[] args)
        {

            decimal przelicznik = 0;
            Console.WriteLine("Wpisz symbol waluty : ");
            var symbol_waluty = Console.ReadLine();
            switch (symbol_waluty)
            {
                case "euro":
                    przelicznik = 4.26232299M;
                    break;

                case "dolar":
                    przelicznik = 3.123465M;
                    break;

            }
            Console.WriteLine("Wpisz ilość : ");
            decimal waluta = Czytaj_liczbę();

            Console.WriteLine("Ilość złotówek : ");
            decimal złotówki = przelicznik * waluta;
            decimal wartość_zaokrąglona = Math.Round(złotówki, 2);

            Console.WriteLine(wartość_zaokrąglona);
            Console.ReadKey();

        }
    }
}
