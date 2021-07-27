using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edytor_tekstu
{
    class Program
    {
        static void Main(string[] args)
        {
            int wymiar = 10;

            string[] tablica = new string[wymiar];

            int k = 0;
            for (int i = 0; i<999999999999; i++)
            {
                string linia = Console.ReadLine();
                if (linia.Length == 0)
                {
                    break;
                }
                tablica[k] = linia;
                k++;
            }

            string path = @"c:\Skwark\MyTest.txt";

            string createText = "Hello and Welcome" + Environment.NewLine;
            File1 .WriteAllText(path, createText);

        }
    }
}
