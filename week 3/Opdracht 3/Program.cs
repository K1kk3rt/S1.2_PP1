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
            //Lees getallen en zet het in een integer
            Console.Write("Geef getal 1: ");
            int getal1 = Int32.Parse(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            int getal2 = Int32.Parse(Console.ReadLine());
            Console.Write("Geef getal 3: ");
            int getal3 = Int32.Parse(Console.ReadLine());

            //Als getal1 groter is dan getal3 AND getal2 is kleiner dan getal3, schrijf het derde getal is het kleinste van de drie
            //Anders schrijf het derde getal is niet de kleinste van de drie
            if (getal1 > getal3 && getal2 > getal3) {
                Console.WriteLine("Het derde getal is kleinste van de drie");
            }
            else {
                Console.WriteLine("Het derde getal is niet de kleinste van de drie");
                }

            Console.ReadKey();
        }
    }
}
