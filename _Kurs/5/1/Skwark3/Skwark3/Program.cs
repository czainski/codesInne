using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hubertskwark@gmai.com
namespace Skwark3
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
         
            Console.WriteLine("Wpisz pierwszą liczbę: ");

          decimal liczba1 = Czytaj_liczbę();
 
            Console.WriteLine("Wpisz drugą liczbę: ");

            decimal liczba2 = Czytaj_liczbę();
            //c) dodanie  liczb
            decimal wynik = liczba1 + liczba2;

            //d) wyświetlenie  wyniku na ekranie
            Console.WriteLine();
            Console.WriteLine("Wynik dodawania: ");
            Console.WriteLine(wynik);
            Console.ReadKey();

            //Uwaga:
            //Jeżeli wpisujemy liczy niecałkowite na ekranie, 
            //to piszemy je z przecinkiem np. 78,45
    
        }
    }
}
