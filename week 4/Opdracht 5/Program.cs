using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare en lees variabelen
            string schrikkeljaarTrue = "Dit is een schrikkeljaar";
            string schrikkeljaarFalse = "Dit is geen schrikkeljaar";
            string negatiefGetal = "Dit is een negatief getal motherfucker";

            Console.Write("Geef een jaartal: ");
            int jaartal = Int32.Parse(Console.ReadLine());

            //while jaartal is niet gelijk aan 0
            while (jaartal != 0)
            {
                //als jaartal kleiner is dan nul, schrijf 'negatief getal' 
                if (jaartal < 0)
                {
                    Console.WriteLine(negatiefGetal);
                }

                //als jaartal deelbaar is door 4 en niet deelbaar is door 100, geef 'schrikkeljaarTrue'
                //anders als jaartal deelbaar is door 400, geef 'schrikkeljaarTrue'
                //anders 'geef schrikkeljaarFalse'
                //anders 'geef schrikkeljaarFalse'
                if ((jaartal % 4) == 0)
                {
                    if ((jaartal % 100) != 0)
                    {
                        Console.WriteLine(schrikkeljaarTrue);
                    }
                    else
                    {
                        if ((jaartal % 400) == 0)
                        {
                            Console.WriteLine(schrikkeljaarTrue);
                        }
                        else
                        {
                            Console.WriteLine(schrikkeljaarFalse);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(schrikkeljaarFalse);
                }

                
                //lees een nieuwe jaartal
                Console.Write("Geef een jaartal: ");
                jaartal = Int32.Parse(Console.ReadLine());
            }
            Console.ReadKey();


        }
    }
}

     