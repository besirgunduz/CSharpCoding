using System;

namespace recursive_extension_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli
            //3^4 

            int sonuc = 1;
            for (int i = 0; i < 4; i++)
            {
                sonuc = sonuc * 3;
            }
            Console.WriteLine(sonuc); //normal çözüm

            Islemler islem = new();
            Console.WriteLine(islem.Expo(3, 4)); //rekürsif çözüm


            // Extension Metotlar

            string ifade = "Beşir Gündüz";
            bool sonucIfade = ifade.CheckSpaces();
            Console.WriteLine(sonucIfade);

            if (sonucIfade)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.GetFirstCharacter());


        }

    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us == 1)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
