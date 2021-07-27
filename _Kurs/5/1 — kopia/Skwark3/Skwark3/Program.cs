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
        static decimal Czytaj_Liczbę()
        {
            var liczba_konsola = Console.ReadLine();
            decimal liczba = decimal.Parse(liczba_konsola);
            return liczba;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wpisz pierwszą liczbę: ");
            decimal liczba1 = Czytaj_Liczbę();

            //var liczba1konsola = Console.ReadLine();
            //decimal liczba1 = decimal.Parse(liczba1konsola);

            //a) odczytanie  drugiej liczby  z ekranu 
            Console.WriteLine("Wpisz drugą liczbę: ");
            decimal liczba2 = Czytaj_Liczbę();

            //var liczba2konsola = Console.ReadLine();
            //decimal liczba2 = decimal.Parse(liczba2konsola);

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
