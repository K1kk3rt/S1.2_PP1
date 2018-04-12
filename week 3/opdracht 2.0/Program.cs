using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees getal
            Console.WriteLine("Geef getal 1, 2, 3 of 4:");
            int getal = Int32.Parse(Console.ReadLine());

            //Bepaal aan de hand van getal wat er getoond moet worden (if statement)
            switch (getal)
            {
                case 1:             
                    Console.WriteLine("klaveren");
                    break;
                case 2:
                    Console.WriteLine("ruiten");
                    break;
                case 3:
                    Console.WriteLine("harten");
                    break;
                case 4:
                    Console.WriteLine("schoppen");
                    break;
                default:
                    Console.WriteLine("Dit is geen geldig getal");
                    break;
            }

            Console.ReadKey();
        }
    }
}
