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
            //weergeef text, lees input en sla het op in variable inputS (string), 
            //convert inputS naar een interger en zet dat in inputI
            Console.WriteLine("Geef aantal seconden: ");
            string inputS = Console.ReadLine();
            int inputI = Int32.Parse(inputS);

            //Declare variable uur, en uurrest. Bereken hoeveel uur in de gegeven hoeveelheid seconden
            // % neemt alleen de 'rest' na een deling
            int uur = inputI / 3600;
            int uurrest = inputI % 3600;

            //declare variable minuut en minuutrest. Bereken hoeveel minuten in de overige seconden zitten
            // % neemt alleen de 'rest' na een deling
            int minuut = uurrest / 60;
            int minuutrest = uurrest % 60;

            //Weergeef antwoord
            Console.WriteLine(uur + ":" + minuut + ":" + minuutrest);

            //wacht totdat er op een toets is gedrukt
            Console.ReadKey();
        }
    }
}
