using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skwark2
{
    class Program
    {
        static void Funkcja(int całkowita)
        {
            int Wynik_funkcji;

            Wynik_funkcji = 2 * całkowita;

            Console.WriteLine($"=== Wartość funkcji y = 2x dla x = {całkowita}  wynosi:");
            Console.WriteLine(Wynik_funkcji);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            
            int x = 1;
            Funkcja(x);

            x = -18;
            Funkcja(x);


            /*
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
    */        
            Console.ReadKey(); 
        }
    }
}
