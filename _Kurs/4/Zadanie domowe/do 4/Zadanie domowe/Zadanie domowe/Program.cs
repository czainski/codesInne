using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe
{
    class Program
    {
        static decimal Oblicz(decimal a, decimal b)
        {
            decimal wynik = a + b + 2;
            return wynik;
        }
        static void Main(string[] args)
        {
       //     decimal a = 120.20M;
         //   decimal b = 45.89M;
           // decimal wynik = Oblicz(a, b);

            decimal wynik = Oblicz(120.20m, 45.89M);

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
