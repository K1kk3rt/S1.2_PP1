using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees variabelen en zit het in integeres
            Console.WriteLine("Geef de hoeveelheid werkuren: ");
            int werkuren = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Geef de hoeveelheid jaren in gebruik: ");
            int jaren = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Geef het aantal storingen per jaar: ");
            int storingen = Int32.Parse(Console.ReadLine());

            //Als het aantal werkuren groter is dan 10000 moet de metaaldraaibank vervangen worden
            //Anders als het aantal jaren groter is dan 7 moet de metaaldraaibank vervangen worden
            //Anders als het aantal storingen groter is dan 25 moet de metaaldraaibank vervangen worden
            //Anders hoeft de metaaldraaibank niet vervangen worden.
            if (werkuren >= 10000)
            {
                Console.WriteLine("De metaaldraaibank moet vervangen worden!");
            }
            else
            {
                if (jaren >= 7)
                {
                    Console.WriteLine("De metaaldraaibank moet vervangen worden!");
                }
                else
                {
                    if (storingen >= 25)
                    {
                        Console.WriteLine("De metaaldraaibank moet vervangen worden!");
                    }
                    else
                    {
                        Console.WriteLine("De metaaldraaibank hoeft niet vervangen te worden!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
