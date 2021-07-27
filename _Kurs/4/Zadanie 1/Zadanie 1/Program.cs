using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {

        static void Wyświetl(int liczba1,int liczba2, int liczba3)
        {
            Console.WriteLine();
            for (int i = liczba1; i <= liczba2; i = i + liczba3)
            {

                Console.WriteLine(i);
            }
        }
            
        static void Main(string[] args)
        {
            /*            
                        int liczba1 = 5;
                        int liczba2 = 1000;
                        int liczba3 = 100;
                        for (int i = liczba1; i <= liczba2; i = i + liczba3)
                        {

                            Console.WriteLine(i);
                        }

              */
            int liczba1 = 1;
            int liczba2 = 5;
            int liczba3 = 1;
            Wyświetl(liczba1,liczba2,liczba3);

            Wyświetl(-1, 7, 2);

            //
            Console.ReadKey();

        }
    }
}
