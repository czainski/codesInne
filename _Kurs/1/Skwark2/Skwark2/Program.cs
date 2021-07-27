using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skwark2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Proste obliczenie:");
            
            //Wynonanie bbliczeń
            Console.WriteLine(2*2+3+8);
            Console.WriteLine(8 * 4 + (5 - 4) * 3);

            //linia pusta na ekranie, oddzielająca od następnego komunikatu na ekranie  
            Console.WriteLine();

            //Funkcje
            //y=2x ; x=1 y= ; x=-18  y= 

            //Argument funkcji
            // int czyli intiger oznacza liczę całkowitą
            int x = 1;

            //Zarezerwoano pamięć na wynik obliczenia funkcji
            int y;

            //Obliczenie wartości funkcji czyli pomnożenie wartości argumentu  przez dwa 
            y = 2 * x;

            Console.WriteLine("=== Wartość funkcji y = 2x dla x =1  wynosi:");
            Console.WriteLine(y);
            Console.WriteLine(); 

            x = -18;
            y = 2*x;
            Console.WriteLine("=== Wartość funkcji y = 2x dla x = -18 wynosi:");
            Console.WriteLine(y);
            Console.WriteLine(); 

            //decimal (liczba rzeczywista) - liczbę rzeczywistą kończy się literką M 
            //Argument funkcji
            decimal r = 29.45M;

            //Zarezerwoano pamięć na wynik obliczeń
            decimal z; 

            //Obliczenie wartości funkcji  
            z = 2 * r;

            Console.WriteLine("=== Wartość funkcji z=2r dla liczby 29.45 wynosi:");
            Console.WriteLine(z);
            Console.WriteLine();

            r = 25.35M;
            z = 3 * x + 5;
            Console.WriteLine("=== Wartość funkcji z=2r dla liczby 29.45 wynosi:");
            Console.WriteLine(z);
            Console.WriteLine(); //linia pusta na ekranie 

            Console.WriteLine("=== Proszę zacisnąć dowolny klawisz, a by zakończyć program ======");
            //Instrukcja czekania na naciśnięcie klawisza
            Console.ReadKey(); 
        }
    }
}
