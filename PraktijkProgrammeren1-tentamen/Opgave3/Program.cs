using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;

            Console.WriteLine("Hoeveel dobbelstenen heeft u? ");
            int aantalDobbelstenen = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel keer wilt u de dobbelstenen gooien? ");
            int aantalWorpen = Int32.Parse(Console.ReadLine());

            int[] getallen = new int[aantalWorpen];

            GenereerWorpen(aantalDobbelstenen, getallen[]);
            string aantallen = TurfAantallen(getallen[], 6 * aantalDobbelstenen);
            ToonGrafiek(tellers, min, max);
         }

        static void GenereerWorpen(int aantalDobbelstenen, int getallen)
        {
            int w = 0;
            int worp = 0;
            int d = 0;
            int[] worpen = new int[aantalDobbelstenen];

           foreach (int element in worpen)
            {
                worp = 0;
                d = 0;

                while (d < aantalDobbelstenen)
                {
                    worp = worp + Random(1, 7);
                    d++;
                }
                worpen[w] = worp;
                w++;              
            }

        }

        static void TurfAantallen(int getallen, int maxWaarde)
        {
            int tellers = int[maxwaarde + 1];
            int index = 0;
            
            foreach (int element in getallen)
            {
                waarde = getallen[index];
                tellers[waarde] = tellers[waarde] + 1;
                index++;
            }

            return tellers;
            

        }

        static void ToonGrafiek(tellers, min, max)
        {
            int min = 0;
            int index = min;
            int sterTeller = 0;

            while (index < max + 1)
            {
                Console.Write(index);
                sterTeller = 0;

                while (sterTeller < tellers[index])
                {
                    Console.Write("*");
                    sterTeller++;
                }

                Console.Write("\n");
                index++;
            }

        }

    }
}
