using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees getallen en zet ze in double variabelen
            Console.Write("Geef getal 1: ");
            double getal1 = Double.Parse(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            double getal2 = Double.Parse(Console.ReadLine());
            Console.Write("Geef getal 3: ");
            double getal3 = Double.Parse(Console.ReadLine());

            //Declare variabelen en reken hiermee
            double som = getal1 + getal2 + getal3;
            double gemiddelde = som / 3;
            double product = getal1 * getal2 * getal3;
            double grootste = getal1;
            double kleinste = getal1;

            //Als getal 2 kleiner is dan 'kleinste', is getal 2 de kleinste
            //Anders als getal2 groter is dan 'grootste', is getal2 de grootste
            //Als getal 3 kleiner is dan kleinste is getal 3 de kleinste
            //Anders als getal3 groter is dan grootste, is getal 3 de grootste
            if (getal2 < kleinste)
            {
                kleinste = getal2;
            }
            else
            {
                if (getal2 > grootste)
                {
                    grootste = getal2;
                }
            }

            if (getal3 < kleinste)
            {
                kleinste = getal3;
            }
            else
            {
                if (getal3 > grootste)
                {
                    grootste = getal3;
                }
            }

            string gemiddeldeS = gemiddelde.ToString("0.00");

            //Schrijf de variabelen met tekst ervoor
            Console.WriteLine("Som: " + som);
            Console.WriteLine("Gemiddelde: " + gemiddeldeS);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Grootste: " + grootste);
            Console.WriteLine("Kleinste: " + kleinste);

            Console.ReadKey();


        }
    }
}
