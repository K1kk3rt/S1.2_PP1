using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef woord: ");
            string woord1 = Console.ReadLine();

            Console.Write("Geef een ander woord: ");
            string woord2 = Console.ReadLine();

            bool anagram = woord1.Length == woord2.Length;

            int pos = 0;

            string test = woord2;

            int index = 0;

            while ((index < woord1.Length) && (anagram)) {

                pos = test.IndexOf(woord1[index]);

                if (pos >= 0)
                {
                    test = test.Remove(pos, 1);
                    index++;
                }
                else
                {
                    anagram = false;
                }
            }

            if (anagram)
            {
                Console.WriteLine("'" + woord2 + "'" + " is een anagram van " + "'" + woord1 + "'" );
            }
            else
            {
                Console.WriteLine("'" + woord2 + "'" + " is geen anagram van " + "'" + woord1 + "'");
            }

            Console.ReadKey();
       
        }
    }
}
