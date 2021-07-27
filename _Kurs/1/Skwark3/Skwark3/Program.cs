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
        static void Main(string[] args)
        {
            //TEMAT:  "Zaprogramować kalkulator dodający dwie liczby".
            //W tym celu należy: 
            //a) odczytać liczbę pierwszą z ekranu (konsoli)
            //b) odczytać liczbę drugą z ekranu
            //c) dodać te dwie liczby
            //d) wyświetlić wynik na ekranie

            //REALIZACJA
            //a) odczytanie  pierwszej liczby  z ekranu (konsoli)
            
            //Komuniklat wyświetlanay na ekranie
            //zapraszający do wpisania pierwszej liczby
            Console.WriteLine("Wpisz pierwszą liczbę: ");

            //Czytanie znaków z ekranu i zapamiętanie w zmiennej liczba1konsola
            var liczba1konsola = Console.ReadLine();

            //decimal - rezewuje miejsce  w pamięci gdzie można zapisywać wartość liczby

            //Przeczytane znaki musimy zamienić na liczbę czyli na decimal.
            //Do tego celu używamy metody decimal.Parse.
            //Metoda ta zamienia ciąg znaków przeczytanych z ekranu 
            //i zapamiętanych w liczba1konsola na liczbę, która będzie zaamiętana jest w liczba1
            decimal liczba1 = decimal.Parse(liczba1konsola);

            //a) odczytanie  drugiej liczby  z ekranu 
            Console.WriteLine("Wpisz drugą liczbę: ");

            var liczba2konsola = Console.ReadLine();

            decimal liczba2 = decimal.Parse(liczba2konsola);

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
