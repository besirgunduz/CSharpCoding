using System;
using System.Collections.Generic;

namespace MutlakKareAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan.
            //Küçük olanların farklarının toplamını,
            //büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

            Console.Write("Kaç tane sayı gireceksiniz : ");
            var n = Convert.ToInt32(Console.ReadLine());

            var kucukSayilar = new List<int>();
            var buyukSayilar = new List<int>();

            var farklarinToplami = 0;
            var farklarinMutlakKareleri = 0;



            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. sayıyı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 67)
                    buyukSayilar.Add(i);
                else
                    kucukSayilar.Add(i);

            }

            foreach (var item in kucukSayilar)
            {
                farklarinToplami -= item;
            }

            foreach (var item in buyukSayilar)
            {
                farklarinMutlakKareleri -= item;
            }

            Console.WriteLine(farklarinToplami);
            Console.WriteLine(Math.Pow(Math.Abs(farklarinMutlakKareleri), 2));

        }
    }
}
