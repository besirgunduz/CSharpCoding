using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

            var ifade = "Merhaba";

            Karakter_degistirme(ifade);

        }

        private static void Karakter_degistirme(string ifade)
        {
            var ilkKarakter = ifade[0];
            var sonKarakter = ifade[ifade.Length - 1];

            var chars = ifade.ToCharArray();

            chars[0] = sonKarakter;
            chars[ifade.Length - 1] = ilkKarakter;

            Console.WriteLine(new string(chars));
        }
    }
}
