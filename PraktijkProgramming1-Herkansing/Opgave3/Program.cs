using System;

namespace Opgave3
{
    class Program
    {
        public static int aantalCijfers = 4;
        public static int maxCijfer = 4;
        public static int maxPogingen = 10;

        public static string gebruikersCode = "";
        public static string geheimeCode = "";

        static void Main(string[] args)
        {
            

            string geheimeCode = MaakGeheimeCode();

            int poging = 0;
            bool codeGekraakt = false;

            while (poging < maxPogingen && (!codeGekraakt))
            {
                poging++;

                gebruikersCode = LeesCode();

                BepaalScore(geheimeCode, gebruikersCode, out int aantalCorrect, out int aantalVerkeerdePlek);

                Console.WriteLine("Aantal correcte cijfers: " + aantalCorrect);
                Console.WriteLine("Aantal verkeerde posities: " + aantalVerkeerdePlek);

                if (aantalCorrect == aantalCijfers) { codeGekraakt = true; }

            }

            if (codeGekraakt)
            {
                Console.WriteLine("Goedzo, je hebt de code gekraakt!");
            }
            else
            {
                Console.WriteLine("Helaas, je hebt de code niet gekraakt: " + geheimeCode);

            }

        }
        static string MaakGeheimeCode()
        {
            string geheimeCode = "";
            int i = 0;
            Random random = new Random();

            while (i<aantalCijfers)
            {
                geheimeCode = geheimeCode + random.Next(1, maxCijfer + 1);
                i++;
            }
            return geheimeCode;
        }

        static string LeesCode()
        {
            string code = "";

            while (code.Length != aantalCijfers)
            {
                Console.WriteLine("Geef een 4-cijferige code: ");
                code = Console.ReadLine();
            }

            return code;
        }

        static void BepaalScore(string geheimeCode, string gebruikersCode, out int aantalCorrect, out int aantalVerkeerdePlek)
        {
            string restCode = "";
            aantalCorrect = 0;

            int i = 0;
            while (i < aantalCijfers)
            {
                if (geheimeCode[i] == gebruikersCode[i])
                {
                    aantalCorrect++;
                }
                else
                {
                    restCode = restCode + geheimeCode[i];
                }
                i++;
            }
            aantalVerkeerdePlek = 0;
            i = 0;

            while (i < aantalCijfers)
            {
                if (geheimeCode[i] != gebruikersCode[i])
                {
                    int pos = restCode.IndexOf(gebruikersCode[i]);
                    if (pos>=0)
                    {
                        aantalVerkeerdePlek++;
                        restCode = restCode.Remove(pos, 1);
                    }
                }
                i++;
            }
        }
    }
}

        

    

