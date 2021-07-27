using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_znakowa_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = "Tablica";
            string[] tablica = new string[5];

            tablica[0] = "Hubert";
            tablica[1] = "Skwark";
            tablica[2] = "Koszykówka";

            for (int i=0; i< 4; i++) 
            {
                if (tablica[i] == null)
                {
                    break;
                }
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
