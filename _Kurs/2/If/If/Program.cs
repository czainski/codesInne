using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//huberto.2004@wp.pl
namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę: ");


            var liczba1konsola = Console.ReadLine();

            decimal liczba1 = decimal.Parse(liczba1konsola);

            Console.WriteLine("Wpisz drugą liczbę: ");

            var liczba2konsola = Console.ReadLine();

            decimal liczba2 = decimal.Parse(liczba2konsola);
            /*
            if (liczba2==0)
            {
                Console.WriteLine("Dzielenie przez 0! ");
            }
            else
            {
                Console.WriteLine("Wartość liczby prawidłowa");
            }

            if (liczba2 > liczba1)
            {
                Console.WriteLine("Liczba druga jest większa. ");
            }
            else
            {
                Console.WriteLine("Liczba druga jest mniejsza. ");
            }


            if (liczba2 >= liczba1)
            {
                Console.WriteLine("Liczba druga jest większa lub równa ");
            }
            else
            {
                Console.WriteLine("Liczba druga jest mniejsza. ");
            }

    */
            // ////////////////////////////////////////
            if (liczba2 == 0)
            {
                Console.WriteLine("liczba2=0");
            }
            else if (liczba2 > liczba1)
            {
                Console.WriteLine("liczba2 > liczba1");
            }
       

            Console.ReadKey();

        }
    }
}
