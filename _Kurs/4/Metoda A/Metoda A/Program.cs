using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {

        static int Odejmij(int liczba1, int liczba2, int liczba3)
        {
            Console.WriteLine();
            int wynik = liczba1-liczba2-liczba3;

            return wynik;
        }

        static void Main(string[] args)
        {
            
            int liczba1 = 100;
            int liczba2 = 5;
            int liczba3 = 1;
            int wynik = Odejmij(liczba1, liczba2, liczba3);

            Console.WriteLine(wynik);
            //
            Console.ReadKey();

        }
    }
}
