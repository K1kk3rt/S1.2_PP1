using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lees/define variabelen
            int aantal = 0;

            Console.Write("Geef het richtgetal: ");
            int richtgetal = Int32.Parse(Console.ReadLine());

            Console.Write("Geef een getal: ");
            int getal = Int32.Parse(Console.ReadLine());

            //while getal is niet gelijk aan 0
            while (getal != 0)
            {
                //if getal gelijk is aan richtgetal, aantal = aantal + 1
                if (getal == richtgetal)
                {
                    aantal++;
                }
                //Lees een nieuw getal in
                Console.Write("Geef een getal: ");
                getal = Int32.Parse(Console.ReadLine());
            }
            //output
            Console.WriteLine("Het aantal getallen dat gelijk is aan het richtgetal is: " + aantal);
            Console.ReadKey();
        }
    }
}
