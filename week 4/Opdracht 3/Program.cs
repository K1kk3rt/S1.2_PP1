using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare en lees variabelen
            int aantal = 0;
            int som = 0;

            Console.Write("Geef een getal: ");
            int getal = Int32.Parse(Console.ReadLine());

            //while getal is niet gelijk aan 0, aantal = aantal + 1
            while (getal != 0)
            {
                aantal++;
                //als aantal deelbaar is door 5, som = som + getal
                if ((aantal % 5) == 0)
                {
                    som = som + getal;
                }
                //lees nieuw getal
                Console.Write("Geef een getal: ");
                getal = Int32.Parse(Console.ReadLine());
            }
            //output
            Console.WriteLine("De som van het 5-de, 10-de, 15-de ... getal is: " + som);
            Console.ReadKey();
        }
    }
}
