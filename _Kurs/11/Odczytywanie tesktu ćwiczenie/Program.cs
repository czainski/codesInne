using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odczytywanie_tesktu_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[10];
            string ścieżka = @"C:\Skwark\Tekst_ćwiczenie.txt";
            tablica =  File.ReadAllLines(ścieżka);          
            int k = 0;
            for (int i = 0; i < 10; i++)
                
            {
                Console.WriteLine(tablica[k]);
                k++;
            }
            
         

            tablica[3] = "Drugi elelment";
            File.WriteAllLines(ścieżka, tablica);
            Console.ReadKey();

        }
    }
}
