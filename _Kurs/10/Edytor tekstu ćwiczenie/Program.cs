using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edytor_tekstu_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[10];
            int k = 0;

            for (int i = 0; i<999999999999; i++)
            {
                string linia = Console.ReadLine();

                if(linia.Length== 0)  
                     break;

                tablica[k] = linia;
                k++;              
            }

            for (int i = 0; i < 10; i++)
            {
                if (tablica[i] == null)
                    break;

                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey();
        }
    }
}
