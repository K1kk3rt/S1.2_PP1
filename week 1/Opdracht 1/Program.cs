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
            // hier wordt variable 'naam' gedeclareerd
            // deze variabele wordt hierna gebruikt
            string naam;

            //lees de naam v/d gebruiker en sla deze op in variable 'naam'
            Console.Write("Geef uw naam: ");
            naam = Console.ReadLine();

            // lees de leeftijd v/d gebruiker en sla deze op in variable 'leeftijd'
            // de variabele wordt hier ook gedeclareerd
            Console.Write("Geef uw leeftijd: ");
            string leeftijd = Console.ReadLine();

            // schrijf naam en leeftijd (terug) naar het scherm
            Console.WriteLine("naam is " + naam);
            Console.WriteLine("Uw leeftijd is " + leeftijd);

            //wacht totdat de gebruiker een toets indrukt
            Console.ReadLine();
        }
    }
}
