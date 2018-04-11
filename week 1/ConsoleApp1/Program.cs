using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int leeftijd = 0;
            bool teOud;
            Console.WriteLine("Geef uw leeftijd: ");
            leeftijd = Int32.Parse(Console.ReadLine());
            Console.WriteLine("boolean antwoord {0}", leeftijd);
           

            // wacht totdat de gebruiker een toets indrukt
            Console.ReadLine();

        }
    }
}
