using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] liczby = new decimal [6];

            liczby[0] = 54.1M;
            liczby[1] = 56.12M;
            liczby[2] = 4.5M;
            liczby[3] = 9.8M;
            liczby[4] = 3.2M;
            liczby[5] = 87.7M;

            for (int i  = 0; i < 6; i++)
            {
                Console.WriteLine(liczby[i]);

            }
            Console.ReadKey();
        }
    }

}

