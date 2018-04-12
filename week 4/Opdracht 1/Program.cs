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
            //Declare variabelen
            double som = 0;
            double aantal = 0;
            double gemiddelde = 0;

            Console.Write("Geef een getal: ");
            double getal = Double.Parse(Console.ReadLine());

            //while getal is niet 0
            while (getal != 0)
            {
                //if getal is groter dan 0, som = som + getal
                if (getal > 0)
                {
                    som = som + getal;
                    aantal = aantal + 1;
                }
                //vraag om nieuw getal
                Console.Write("Geef een getal: ");
                getal = Int32.Parse(Console.ReadLine());
            }
            //if aantal is groter dan 0, gemiddelde = som / aantal
            // else gemiddelde = 0
            if (aantal > 0)
            {
                gemiddelde = som / aantal;
            }
            else
            {
                gemiddelde = 0;
            }

            // schrijf het gemiddelde uit
            Console.WriteLine("Het Gemiddelde is: " + gemiddelde.ToString("0.00"));
            Console.ReadKey();
        }

    }
}
