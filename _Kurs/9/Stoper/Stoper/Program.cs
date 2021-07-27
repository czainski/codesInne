using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoper_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odczyt daty
            DateTime czas_początkowy = DateTime.Now;
            int godzina_początkowa = czas_początkowy.Hour;
            int minuta_początkowa = czas_początkowy.Minute;
            int sekunda_początkowa = czas_początkowy.Second;

            Console.WriteLine($"{godzina_początkowa}:{minuta_początkowa}:{sekunda_początkowa} ");

            ///////////////////////
            // i= i +1
            for (int i = 1; i<500000000000000; i= i+1)
            {
                Console.Clear();
                Console.WriteLine($"{godzina_początkowa}:{minuta_początkowa}:{sekunda_początkowa} ");

                Console.WriteLine("Wciśnij enter");
                Console.ReadKey();

                DateTime czas_końcowy = DateTime.Now;
                int godzina_końcowa = czas_końcowy.Hour;
                int minuta_końcowa = czas_końcowy.Minute;
                int sekunda_końcowa = czas_końcowy.Second;

                Console.WriteLine($"{godzina_końcowa}:{minuta_końcowa}:{sekunda_końcowa}");
                Console.WriteLine("Różnica czasów :");
                TimeSpan różnica_czasów = czas_końcowy - czas_początkowy;
                int godziny_różnica = różnica_czasów.Hours;
                int minuty_różnica = różnica_czasów.Minutes;
                int sekundy_różnica = różnica_czasów.Seconds;

                Console.WriteLine($"{godziny_różnica}:{minuty_różnica}:{sekundy_różnica}");

                Console.WriteLine("Wciśnij r żeby zresetować ");
                var konsola=Console.ReadLine();
                if (konsola == "r")
                {
                     czas_początkowy = DateTime.Now;
                     godzina_początkowa = czas_początkowy.Hour;
                     minuta_początkowa = czas_początkowy.Minute;
                     sekunda_początkowa = czas_początkowy.Second;
                }
                Console.ReadKey();
            }

            //Console.ReadKey();


        }
    }
}
