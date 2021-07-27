using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_znakowa
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nazwa;
            string nazwa = "awwww1111";

            string[] tablica = new string[5];

            tablica[0] = "Hubert";
            tablica[1] = "Skwark";
            tablica[2] = "15";

            for (int i = 0; i<5; i++)
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
