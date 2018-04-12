using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees getallen in, zet ze om naar integers in variabelen
            Console.Write("Geef getal 1: ");
            int getal1 = Int32.Parse(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            int getal2 = Int32.Parse(Console.ReadLine());
           
            //Als uit getal1 / getal 2 geen kommagetal komt dan is getal 1 een veelvoud van getal 2
            //Anders als uit getal2 / getal1 geen kommagetal komt dan is getal 2 een veelvoud van getal 1
            //Anders is er geen veelvoud.
            if (getal1 % getal2 == 0)
            {
                Console.WriteLine("Getal 1 is het veelvoud van getal 2");
            }
            else
            {
                if (getal2 % getal1 == 0)
                {
                    Console.WriteLine("Getal 2 is het veelvoud van getal 1");
                }
                else
                {
                    Console.WriteLine("Geen veelvoud");
                }
            }
            Console.ReadKey();
         
        }
    }
}
