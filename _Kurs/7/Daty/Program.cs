 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daty
{
    class Program
    {
        static void Main(string[] args)
        {

            var data_z_konsoli = "12.10.2019";

            DateTime data = Convert.ToDateTime(data_z_konsoli);

            Console.WriteLine(data.ToShortDateString());

            DateTime dzisiaj = DateTime.Today;

            Console.WriteLine(dzisiaj);
            Console.WriteLine(dzisiaj.ToShortDateString());

            TimeSpan rożnica_dat = data - dzisiaj;

            Console.WriteLine(rożnica_dat.Days);


            Console.ReadKey();

        }
    }
}
