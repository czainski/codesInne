using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkullator
{
    class Program
    {
        static void Main(string[] args)
        {
            //wczytujemy dwie liczby
            //wczytujemy znak działania
            //rozpoznać znak działania
            //wykonać odpowiednie działenie w zależności od rozpoznanego znaku
            //zabezpieczenie przed dzieleniem przez 0

            Console.WriteLine("Wpisz pierwszą liczbę: ");

            
            var liczba1konsola = Console.ReadLine();
        
            decimal liczba1 = decimal.Parse(liczba1konsola);
            
            Console.WriteLine("Wpisz drugą liczbę: ");

            var liczba2konsola = Console.ReadLine();

            decimal liczba2 = decimal.Parse(liczba2konsola);

            Console.WriteLine("Wpisz znak działania: ");
            var znak_działania = Console.ReadLine();

            decimal wynik = 0;
            switch(znak_działania)
            {
                case "+":
                    wynik = liczba1 + liczba2;
                    Console.WriteLine();
                    Console.Write(liczba1 + "+" + liczba2 + "=");
                    break;

                case "-":
                    wynik = liczba1 - liczba2;
                    Console.WriteLine();
                    Console.Write(liczba1 + "-" + liczba2 + "=");
                    break;
                    
                case "*":
                    wynik = liczba1 * liczba2;
                    Console.WriteLine();
                    Console.Write(liczba1 + "*" + liczba2 + "=");
                    break;

                case "/":
                    //zabezpieczenie przed dzieleniem przez 0
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Dzielenie przez 0! ");
                        break; 
                    }
                    wynik = liczba1 / liczba2;
                    Console.WriteLine();
                    Console.Write(liczba1 + "/" + liczba2 + "=");
                    break; 

            }
            Console.Write(wynik);
            Console.ReadKey();

        }
    }
}
