using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // lees leeftijd v/d gebruiker
            Console.Write("Geef uw leeftijd: ");
            string invoer = Console.ReadLine();

            // converteer de tekst naar een interger (int)
            int leeftijd = Int32.Parse(invoer);

            // nu kunnen  we rekenen met de (int) leeftijd
            // (dat kon niet met een string waarde)
            leeftijd++;

            // converteer integer naar tekst
            string uitvoer = leeftijd.ToString();

            // schrijf de verhoogde leeftijd (terug) naar het scherm
            Console.WriteLine("Volgend jaar bent u " + leeftijd + " jaar oud.");

            // wacht totdat de gebruiker een toets indrukt
            Console.ReadKey();
        }
    }
}
