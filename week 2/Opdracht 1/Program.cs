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
            //Weergeef text 
            Console.Write("Geef Prijs: ");
            //Lees ingevoerde text en zet dat in variable prijs (string)
            String prijs = Console.ReadLine();
            //convert string naar double en zet dat in variable prijsex
            double prijsex = Double.Parse(prijs);
            //declare variable outputprijs (double)
            double outputprijs = prijsex * 1.21;
            //declare variable outputbtw (double)
            double outputbtw = prijsex * 0.21;
            //declare variable outputex (double)
            double outputex = prijsex;

            //Geef de prijs, btw en totaalprijs
            Console.WriteLine("prijs: " + prijs);
            Console.WriteLine("btw: " + outputbtw);
            Console.WriteLine("totaal: " + outputprijs);

            //wacht totdat de gebruiker op een toets drukt voordat het programma gesloten wordt.
            Console.ReadKey();
           
        }
    }
}
