using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoper_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czas teraz:");
            Console.WriteLine();
            DateTime czas_początkowy = DateTime.Now;
            int godzina_początkowa = czas_początkowy.Hour;
            int minuta_początkowa = czas_początkowy.Minute;
            int sekunda_początkowa = czas_początkowy.Second;

            Console.WriteLine($"{godzina_początkowa}:{minuta_początkowa}:{sekunda_początkowa}");

            Console.WriteLine();
            Console.WriteLine("Kliknij Enter aby zatrzymać czas:");
            Console.ReadKey();
            Console.WriteLine();

            DateTime czas_końcowy = DateTime.Now;
            int godzina_końcowa = czas_końcowy.Hour;
            int minuta_końcowa = czas_końcowy.Minute;
            int sekunda_końcowa = czas_końcowy.Second;

            Console.WriteLine($"{godzina_końcowa}:{minuta_końcowa}:{sekunda_końcowa}");
            Console.WriteLine();
            Console.WriteLine("Różnica czasów:");
            Console.WriteLine();
            Console.WriteLine();
            TimeSpan różnica_czasów = czas_końcowy - czas_początkowy;

            int godzina_różnicy = różnica_czasów.Hours;
            int minuta_różnicy = różnica_czasów.Minutes;
            int sekunda_różnicy = różnica_czasów.Seconds;

            Console.WriteLine($"{godzina_różnicy}:{minuta_różnicy}:{sekunda_różnicy}");
            Console.ReadKey();
        }
    }
}
