using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var data_z_konsoli = "25.07.2019";
            DateTime data = Convert.ToDateTime(data_z_konsoli);
            Console.WriteLine(data.ToShortDateString ());

            DateTime dzisiaj = DateTime.Today;
            TimeSpan ilość_dni = data - dzisiaj;
            Console.WriteLine(ilość_dni.Days);

            Console.ReadKey();
            

        }
    }
}
