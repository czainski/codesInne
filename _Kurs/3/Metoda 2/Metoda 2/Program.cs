using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_2
{
    class Program
    {
        static void Wynik(decimal wynik)
        {
            Console.Write(wynik);
            Console.ReadKey();
        } 
        static void Main(string[] args)
        {

            Wynik(123.78M);

        }
    }
}
