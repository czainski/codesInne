using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_zadanie_domowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[15];
            int k = 0;
            for (int i = 0; i < 999999999999; i++)
            {
                string linia = Console.ReadLine();

                if (linia.Length == 0)
                    break;

                tablica[k] = linia;
                k++;
            }

            for (int i = 0; i < 15; i++)
            {
              //  if (tablica[i] == null)
                //    break;

                Console.WriteLine(tablica[i]);
            }
            string ścieżka = @"C:\Skwark\11\Zapisy\Plik tekstowy 2.txt";
            File.WriteAllLines(ścieżka, tablica);
            Console.ReadKey();
            
        }
    }
}
