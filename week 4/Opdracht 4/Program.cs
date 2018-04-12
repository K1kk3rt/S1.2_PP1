using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
C:\Users\eugen\source\repos\LesPP4\Opdracht 4\Program.cs
namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variabelen
            int getal1 = 1;
            int getal2 = 1;
            int getal3;
            
            //toon getal1 en getal2
            Console.Write(getal1 + " " + getal2 + " ");
            
            //declare variabelen
            int aantal = 2;

            //While aantal is kleiner dan 20, getal3 = getal1 + getal2, toon getal 3,
            //getal1 = getal2, getal2 = getal3, aantal = aantal + 1
            while (aantal < 20)
            {
                getal3 = getal1 + getal2;
                Console.Write(getal3 + " ");
                getal1 = getal2;
                getal2 = getal3;
                aantal++;
            }
            Console.ReadKey();
        }
    }
}
