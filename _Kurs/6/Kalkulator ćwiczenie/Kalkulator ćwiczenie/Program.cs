using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_ćwiczenie
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
            decimal kurs_euro = 4.26232299M;
            Console.WriteLine("Wpisz ilość euro:");
            decimal ilość_euro = Czytaj_liczbę();
            decimal przelicznik = kurs_euro * ilość_euro;
            decimal zaokrąglenie = Math.Round(przelicznik, 2);
            Console.WriteLine($"Ilość złotówek: {zaokrąglenie}");
            Console.ReadKey();
        }
    }
}

