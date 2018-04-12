using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variabelen
            int grootste;
            int kleinste;

            //Lees getallen in en zet dat in variabelen
            Console.Write("getal1: ");
            int getal1 = Int32.Parse(Console.ReadLine());
            Console.Write("getal 2: ");
            int getal2 = Int32.Parse(Console.ReadLine());

            //Als getal1 groter is dan getal2 is getal1 de grootste en getal2 de kleinste
            // anders is getal1 de kleinste en getal2 de grootste
            if (getal1 > getal2) {
                grootste = getal1;
                kleinste = getal2;
            }
            else {
                grootste = getal2;
                kleinste = getal1;
            }


            //Schrijf het antwoord
            Console.WriteLine("Het grootste getal is: " + grootste);
            Console.WriteLine("Het kleinste getal is: " + kleinste);

            Console.ReadKey();
        }
    }
}
