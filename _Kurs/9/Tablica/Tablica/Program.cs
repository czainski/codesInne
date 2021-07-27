using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[3];
            liczby[0] = 10;
            liczby[1] = 15;
            liczby[2] = 69;
            /*
            Console.WriteLine(liczby[0]);
            Console.WriteLine(liczby[1]);
            Console.WriteLine(liczby[2]);
            */
            for (int i=0; i<3; i++ )
            {
                Console.WriteLine(liczby[i]);
            }
            
            Console.ReadKey();
        }
    }
}
