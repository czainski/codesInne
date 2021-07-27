using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // i=i+1 i++
/*            for (int i = 0; i < 5; i=i+1)
            {
                Console.WriteLine(i);
            }
            */
            for (decimal i = -100; i < 20000000000; i = i + 2.5M)
            {
                //....
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
