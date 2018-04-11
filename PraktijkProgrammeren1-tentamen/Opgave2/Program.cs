using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw Cesar Cipher? ");
            int cipher = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tik uw bericht: ");
            string bericht = Console.ReadLine();

            string codeBericht = "";
            char letter;
            int letterNummer = 0;
            int nieuwNummer = 0;
            string nieuweLetter = "";

            int teller = 0;

            char[] berichtArray = bericht.ToCharArray();

            foreach (char element in bericht)
            {

                letter = berichtArray[teller];
                if ('A' <= letter && letter <= 'Z')
                {
                    letterNummer = letter - 'A';
                    nieuwNummer = (letterNummer + 26 - cipher) % 26;
                    //Console.WriteLine("nieuweLetter oud: " + nieuweLetter);
                    nieuweLetter = 'A' + nieuwNummer;
                    //Console.WriteLine("nieuweLetter nieuw: " + nieuweLetter);
                }
                else
                {
                    nieuweLetter = letter.ToString();
                }
                codeBericht = codeBericht + nieuweLetter;
                teller++;
            }

            Console.WriteLine("Het gecodeerde bericht: " + codeBericht);

            Console.ReadKey();
        }
    }
}
