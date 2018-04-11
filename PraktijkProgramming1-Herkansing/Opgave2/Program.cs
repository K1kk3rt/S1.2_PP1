using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = Int32.Parse(Console.ReadLine());

            int faculteit = 0;
            

            while (getal > 0)
            {
                Console.Write(getal + "! = ");
                faculteit = 1;
                int i = 1;

                while (i <= getal)
                {
                    if (i == 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" x " + i);
                    }
                    faculteit = faculteit * i;
                    i++;
                }

                Console.WriteLine(" = " + faculteit);
                Console.Write("Geef een getal: ");
                getal = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
