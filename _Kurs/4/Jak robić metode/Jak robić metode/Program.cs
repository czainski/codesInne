using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jak_robić_metode
{
    class Program
    {
        static int Dodaj(int liczba1,int liczba2, int liczba3)
        {
            int wynik = liczba1 + liczba2 + liczba3;
            return wynik;
        }
        static void Main(string[] args)
        {
            int liczba1 = 10;
            int liczba2 = 5;
            int liczba3 = 15;
            int wynik = Dodaj(liczba1, liczba2, liczba3);
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
