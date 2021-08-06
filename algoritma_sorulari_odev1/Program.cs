using System;

namespace algoritma_sorulari_odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.çözüm


            Console.Write("Pozitif bir tam sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{sayi} adet pozitif tam sayı giriniz : ");

            var sayilar = Console.ReadLine().Split(' ');

            foreach (var item in sayilar)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------");


            // 2. çözüm


            Console.Write("Pozitif iki tam sayı giriniz : ");
            var sayilar2 = Console.ReadLine().Split(' ');
            int nSayisi = Convert.ToInt32(sayilar2[0]);
            int mSayisi = Convert.ToInt32(sayilar2[1]);

            Console.Write($"{nSayisi} adet pozitif sayı giriniz : ");
            var sayilar3 = Console.ReadLine().Split(' ');

            foreach (var item in sayilar3)
            {
                if (Convert.ToInt32(item) == mSayisi || Convert.ToInt32(item) % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------");


            //3. çözüm


            Console.Write("Pozitif bir tam sayı giriniz : ");
            int PozitifSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{PozitifSayi} adet kelime giriniz : ");
            var kelimeler = Console.ReadLine().Split(' ');

            for (int i = kelimeler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }

            Console.WriteLine("----------------------------------------------------------------------------");


            //4. çözüm


            Console.Write("Bir cümle yazınız : ");
            var cumle = Console.ReadLine().Split(' ');
            Console.WriteLine("Toplam kelime sayısı : "+cumle.Length);

            int harfSayisi = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                harfSayisi += cumle[i].Length;
            }

            Console.WriteLine("Toplam harf sayısı : " + harfSayisi);


        }
    }
}
