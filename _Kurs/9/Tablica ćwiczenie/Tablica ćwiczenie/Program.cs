using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[5];

            liczby[0] = 1;
            liczby[1] = 56;
            liczby[2] = 45;
            liczby[3] = 98;
            liczby[4] = 32;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(liczby[i]);

            }
            Console.ReadKey();
        }
    }
}
