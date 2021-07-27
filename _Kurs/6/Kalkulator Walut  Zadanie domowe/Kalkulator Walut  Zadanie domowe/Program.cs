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
            Console.WriteLine("Wybierz swoją walute: ");
            Console.WriteLine();
            Console.WriteLine(" Euro (EUR) ");
            Console.WriteLine(" Dolar (USD) ");
            Console.WriteLine(" Dolar Kanadyjski (CAD) ");
            Console.WriteLine(" Funt Szterling (GBP) ");
            Console.WriteLine(" Korona Norweska (NOK) ");
            Console.WriteLine(" Korona Szwedzka (SEK) ");
            Console.WriteLine(" Korona Czeska (CZK) ");
            Console.WriteLine(" Frank Szwajcarski (CHF) ");
            Console.WriteLine(" Rubel Rosyjski (RUB) ");
            Console.WriteLine();

            decimal przelicznik = 0;
            Console.WriteLine("Wpisz nazwe waluty waluty : ");
            var symbol_waluty = Console.ReadLine();

            Console.ReadKey();

            switch (symbol_waluty)
            {
                case "Euro":
                    przelicznik = 4.26232299M;
                    break;

                case "Dolar":
                    przelicznik = 3.7581552M;
                    break;

                case "Dolar Kanadyjski":
                    przelicznik = 2.8419M;
                    break;

                case "Funt Szterling":
                    przelicznik = 4.7878822M;
                    break;

                case "Korona Norweska":
                    przelicznik = 0.435701723M;
                    break;

                case "Korona Szwedzka":
                    przelicznik = 0.399830131M;
                    break;

                case "Korona Czeska":
                    przelicznik = 0.166324675M;
                    break;

                case "Frank Szwajcarski":
                    przelicznik = 3.805647M;
                    break;

                case "Rubel Rosyjski":
                    przelicznik = 0.0583M;
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Wpisz ilość posiadanej waluty : ");
            decimal waluta = Czytaj_liczbę();

            Console.WriteLine();
            Console.WriteLine("Ilość złotówek : ");
            decimal złotówki = przelicznik * waluta;
            decimal wartość_zaokrąglona = Math.Round(złotówki, 2);

            Console.WriteLine(wartość_zaokrąglona);
            Console.ReadKey();
            


        }
    }
}
