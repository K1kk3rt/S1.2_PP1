using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees variablen in
            Console.WriteLine("Geef uw gewicht in kilo: ");
            double gewicht = Double.Parse(Console.ReadLine());

            Console.WriteLine("Geef uw lengte in cm: ");
            double lengte = Double.Parse(Console.ReadLine());

            Console.WriteLine("Geef uw sekse (man/vrouw): ");
            String sekse = Console.ReadLine();


            //Declare veriabele en reken ermee
            Double BMI = gewicht / ((lengte/100) * (lengte/100));

            if (sekse == "man")
            {
                if (BMI > 20 && BMI < 25)
                {
                    Console.WriteLine("Gewicht is gezond");
                }
                else
                {
                    Console.WriteLine("gewicht is ongezond");
                }
            }
            else
            {
                if (BMI > 19 && BMI < 24)
                {
                    Console.WriteLine("Gewicht is gezond");                
                }
                else
                {
                    Console.WriteLine("Gewicht is ongezond");
                }
            }

            //declare variabelen
            double gezondgewichtmanmin;
            double gezondgewichtmanmax;
            double gezondgewichtvrouwmin;
            double gezondgewichtvrouwmax;

            //Bereken minimaal en maximaal gewicht man
            if (sekse == "man")
            {
                gezondgewichtmanmin = 20 * ((lengte / 100) * (lengte / 100));
                gezondgewichtmanmax = 25 * ((lengte / 100) * (lengte / 100));
                Console.WriteLine("Het minimale gezonde gewicht is " + gezondgewichtmanmin  +  ".");
                Console.WriteLine("Het maximale gezonde gewicht is " + gezondgewichtmanmax + ".");
                Console.WriteLine("Uw BMI waarde is: " + BMI.ToString("0.00"));
                Console.WriteLine("De normale BMI waarde ligt tussen de 20 en 25.");
            }
            //Bereken minimaal en maximaal gewicht vrouw
            else
            {
                gezondgewichtvrouwmin = 19 * ((lengte / 100) * (lengte / 100));
                gezondgewichtvrouwmax = 24 * ((lengte / 100) * (lengte / 100));
                Console.WriteLine("Het minimale gezonde gewicht is " + gezondgewichtvrouwmin + ".");
                Console.WriteLine("Het maximale gezonde gewicht is " + gezondgewichtvrouwmax + ".");
                Console.WriteLine("Uw BMI waarde is: " + BMI.ToString("0.00"));
                Console.WriteLine("De normale BMI waarde ligt tussen de 19 en 24.");
            }

            Console.ReadKey();
        }
    }
}
