using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Walut
{
    class Program
    {
        /*
        static decimal Symbol_Waluty(var symbol_waluty)
        {
            switch (symbol_waluty)
            {
                case "EUR":
                    przelicznik = 4.26232299M;
                    break;

                case "USD":
                    przelicznik = 3.7581552M;
                    break;

                case "CAD":
                    przelicznik = 2.8419M;
                    break;

                case "GBP":
                    przelicznik = 4.7878822M;
                    break;

                case "NOK":
                    przelicznik = 0.435701723M;
                    break;

                case "SEK":
                    przelicznik = 0.399830131M;
                    break;

                case "CZK":
                    przelicznik = 0.166324675M;
                    break;

                case "CHF":
                    przelicznik = 3.805647M;
                    break;

                case "RUB":
                    przelicznik = 0.0583M;
                    break;

            }
            Console.WriteLine();

        } */
        static void Konsola()
        {
            Console.WriteLine("Wybierz swoją walute (WPISZ SYMBOL): ");
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
            Console.WriteLine("Twoja Waluta:");
        }
        static decimal Czytaj_liczbę()
        {
            var liczba1konsola = Console.ReadLine();
            decimal liczba1 = decimal.Parse(liczba1konsola);
            return liczba1;
        }
        static void Main(string[] args)
        {
            Konsola(); 
            
            decimal przelicznik = 0;
            var symbol_waluty = Console.ReadLine();

            Console.ReadKey();
           
            switch (symbol_waluty)
            {
                case "EUR":
                    przelicznik = 4.26232299M;
                    break;

                case "USD":
                    przelicznik = 3.7581552M;
                    break;

                case "CAD":
                    przelicznik = 2.8419M;
                    break;

                case "GBP":
                    przelicznik = 4.7878822M;
                    break;

                case "NOK":
                    przelicznik = 0.435701723M;
                    break;

                case "SEK":
                    przelicznik = 0.399830131M;
                    break;

                case "CZK":
                    przelicznik = 0.166324675M;
                    break;

                case "CHF":
                    przelicznik = 3.805647M;
                    break;

                case "RUB":
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
            Console.WriteLine();

            var data_walut_1 = "10.06.2019";
            DateTime data_walut = Convert.ToDateTime(data_walut_1);

            DateTime data_dzisiaj = DateTime.Today;
            TimeSpan ilość_dni_miniętych = data_dzisiaj - data_walut;
            Console.WriteLine($"Ilość dni od rejestracji kursów : {ilość_dni_miniętych.Days}" );
            Console.ReadKey();


        }
    }
}
