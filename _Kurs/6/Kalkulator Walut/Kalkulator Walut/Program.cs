using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Walut
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal przelicznik_euro = 4.26232299M;
            decimal euro = 50.45m;

            decimal złotówki = przelicznik_euro * euro;
            decimal wartość_zaokrąglona = Math.Round(złotówki, 2);

            Console.WriteLine(wartość_zaokrąglona);
            Console.ReadKey();

        }
    }
}
