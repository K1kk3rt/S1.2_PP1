using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] huizen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int h = 0;

            while (h < 12)
            {
                huizen[h] = 4;
                h++;
            }

            int punten = 0;

            ToonSpel(huizen, punten);

            Console.Write("Van welk huis wilt u de zaden zaden? ");
            int nummer = Int32.Parse(Console.ReadLine());

            while (nummer > 0)
            {
                nummer = nummer - 1;

                Zaaien(huizen, nummer);
                ToonSpel(huizen, Punten);
                punten = punten + Oogsten(huizen, nummer);
                ToonSpel(huizen, punten);

                Console.Write("Van welk huis wilt u de zaden zaden? ");
                int nummer = Int32.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }


        static void ToonSpel(int[] huizen, int punten)
        {
            int h = 0;
            int huis = 0;
        

            foreach (int element in huizen)
            {
                huis = huizen[h];
                Console.Write(" " + huis + " ");
                h++;
            }

            Console.WriteLine(punten + "punten");
        }

        static void Zaaien(huizen, huisNummer)
        {
            int korrels = huizen[huisNummer];
            huizen[huisNummer] = 0;



    }
}
