using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string woord = Console.ReadLine();

            string checkWoord = woord.ToUpper();

            int som = 0;
            int teller = 0;

            while (teller < checkWoord.Length)
            {
                char letter = checkWoord[teller];
                int waarde = (int)letter - 65 + 1;
                Console.WriteLine(" {0} => {1,2}", letter, waarde);
                som = som + waarde;
                teller++;
            }

            if ((som%2) == 0)
            {
                Console.WriteLine("som van '" + woord + "' is even: "+ som);
            }
            else
            {
                Console.WriteLine("som van '" + woord + "' is oneven: " + som);

            }

            Console.ReadKey();

        }
    }
}
