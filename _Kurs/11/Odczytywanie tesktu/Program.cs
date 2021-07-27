using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odczytywanie_tesktu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[10];
            string ścieżka = @"C:\Skwark\Tekst_ćwiczenie.txt";
            tablica=File.ReadAllLines(ścieżka);
            int k = 0;
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(tablica[k]);
                k++;
            }


            Console.WriteLine("Tekst zmieniany:");
            string zmienionyTekst = Console.ReadLine();

            Console.WriteLine("Indeks tablicy:");
            string indeks = Console.ReadLine();
            int ind = int.Parse(indeks);
            tablica[ind] = zmienionyTekst;

            File.WriteAllLines(ścieżka,tablica);

            Console.ReadKey();

        }
    }
}
