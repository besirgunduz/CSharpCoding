using System;

namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

            var ifade = "Algoritma"; // reşiB
            var ilkKarakter = ifade[0];
            var sonKarakter = ifade[ifade.Length-1];

            var sonuc = string.Empty;

            for (int i = 0; i < ifade.Length; i++)
            {
                if (i == 0)
                {
                    sonuc += sonKarakter;
                }
                else if (i == ifade.Length - 1)
                {
                    sonuc += ilkKarakter;
                }
                else
                {
                    sonuc += ifade[i];
                }
            }

            Console.WriteLine(sonuc);
        }
    }
}
