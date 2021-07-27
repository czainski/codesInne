using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal liczba_rzeczywista = 123.34M;
            liczba_rzeczywista = 1;

            //  ////
            // <  > <= >= ==
          /*  int n = -10;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n=n+1;
            }
            */
           
            decimal d = -100;
            while (d <= 200)
            {
                Console.WriteLine(d);
                d = d + 1.35M;
            }

            // //////
            Console.ReadKey();
        }
    }
}
