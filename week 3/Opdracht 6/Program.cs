using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees score en zet het in integer punten
            Console.WriteLine("Geef de Score: ");
            int punten = Int32.Parse(Console.ReadLine());

            //Declare variabele
            string letter;

            //Als punten groter of gelijk is aan 90, heb je een A
            //Anders als punten groter of gelijk is aan 80, heb je een B
            //Anders als punten groter of gelijk is aan 70, heb je een C
            //Anders als punten groter of gelijk is aan 60, heb je een D
            //Anders heb je een E
            if (punten >= 90)
            {
                letter = "A";
            }
            else
            {
                if (punten >= 80)
                {
                    letter = "B";
                }
                else
                {
                    if (punten >= 70)
                    {
                        letter = "C";
                    }
                    else
                    {
                        if (punten >= 60)
                        {
                            letter = "D";
                        }
                        else
                        {
                            letter = "F";
                        }
                    }
                }
            }

            //Schrijf de letter
            Console.WriteLine("letter: " + letter);

            //Als letter A OR B OR C is, schrijf je hebt het gehaald
            //Anders schrijf je hebt het niet gehaald
            if (letter == "A" || letter == "B" || letter == "C")  {
                Console.WriteLine("Je hebt het gehaald!");
            }

            else
            {
                Console.WriteLine("Je hebt het niet gehaald");
            }
            Console.ReadKey();
        } 
    }
    
}
