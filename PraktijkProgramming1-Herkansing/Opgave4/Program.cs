using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] olympischeSpelen = new string[] { "Turijn", "Vancouver", "Sotsji", "Pyeongchang" };
            int[] jaren = new int[] { 2006, 2010, 2014, 2018 };
            int[] medailles = new int[] { 9, 8, 24, 17 };

            int i = 0;
            while (i < olympischeSpelen.Length)
            {
                Console.WriteLine((i + 1) + ". " + olympischeSpelen[i] + " (" + jaren[i] + ")");
                i++;
            }

            Console.WriteLine("Geef een getal (1.." + olympischeSpelen.Length + "):" );
            int getal = Int32.Parse(Console.ReadLine());
            int index = getal - 1;

            Console.WriteLine("In " + jaren[index] + " won Nederland " + medailles[index] + " medailles in " + olympischeSpelen[index]+ ".");

            Console.ReadKey();
        
        }
    }
}
