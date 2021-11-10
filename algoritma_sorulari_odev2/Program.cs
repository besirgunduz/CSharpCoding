using System;
using System.Collections;
using System.Collections.Generic;

namespace algoritma_sorulari_odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Koleksiyonlar_Soru_1();
            //Koleksiyonlar_Soru_2();
            //Koleksiyonlar_Soru_3();

            Console.ReadKey();

        }

        private static void Koleksiyonlar_Soru_1()
        {
            ArrayList asalList = new ArrayList();
            ArrayList asalOlmayanList = new ArrayList();

            Console.WriteLine("20 adet pozitif tam sayı giriniz ");


            int sayac = 1;
            while (sayac <= 20)
            {
                try
                {
                    Console.Write($"{sayac}. sayıyı giriniz : ");
                    int sayi = Convert.ToInt32(Console.ReadLine());

                    if (sayi > 0)
                    {
                        int kontrol = 0;
                        for (int j = 2; j < sayi; j++)
                        {
                            if (sayi % j == 0)
                            {
                                kontrol++;
                            }
                        }

                        if (kontrol == 0 && sayi != 1)
                            asalList.Add(sayi);

                        else
                            asalOlmayanList.Add(sayi);

                        sayac++;
                    }
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş...Tekrar giriniz...");
                }

            }


            asalList.Sort();
            asalList.Reverse();

            asalOlmayanList.Sort();
            asalOlmayanList.Reverse();



            int asalToplam = 0;
            foreach (var asal in asalList)
            {
                asalToplam += (int)asal;
            }

            int asalOlmayanToplam = 0;
            foreach (var asalOlmayan in asalOlmayanList)
            {
                asalOlmayanToplam += (int)asalOlmayan;
            }

            Console.WriteLine();
            Console.Write("Asal liste : ");
            foreach (var asal in asalList)
            {
                Console.Write(asal + " ");
            }

            Console.WriteLine();
            Console.Write("Asal olmayan liste : ");
            foreach (var asalolmayan in asalOlmayanList)
            {
                Console.Write(asalolmayan + " ");
            }

            Console.WriteLine();

            Console.Write($"Asal listenin eleman sayısı : {asalList.Count}");
            if (asalList.Count > 0)
            {
                Console.WriteLine($" ortalaması : {asalToplam / asalList.Count}");
            }
            else
            {
                Console.WriteLine($" ortalaması : {0}");
            }

            Console.Write($"Asal olmayan listenin eleman sayısı : {asalOlmayanList.Count}");
            if (asalList.Count > 0)
            {
                Console.WriteLine($" ortalaması : {asalToplam / asalList.Count}");
            }
            else
            {
                Console.WriteLine($" ortalaması : {0}");
            }
        }
        private static void Koleksiyonlar_Soru_2()
        {
            int[] sayilar = new int[20];
            int[] buyukSayilar = new int[3];
            int[] kucukSayilar = new int[3];


            Console.WriteLine("20 adet sayı giriniz ");

            int sayac = 1;
            while (sayac <= 20)
            {
                try
                {
                    Console.Write($"{sayac}. sayıyı giriniz : ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar[sayac - 1] = sayi;
                    sayac++;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş...Tekrar giriniz...");
                }
            }

            Array.Sort(sayilar);
            int sayilarCount = sayilar.Length;

            for (int i = 0; i < 3; i++)
            {
                kucukSayilar[i] = sayilar[i];
                buyukSayilar[i] = sayilar[sayilar.Length - 1 - i];
            }
            int kucukSayilarToplami = 0;
            int buyukSayilarToplami = 0;

            foreach (var kucukSayi in kucukSayilar)
            {
                kucukSayilarToplami += kucukSayi;
            }

            foreach (var buyukSayi in buyukSayilar)
            {
                buyukSayilarToplami += buyukSayi;
            }

            Console.WriteLine($"En büyük 3 sayının ortalaması : {buyukSayilarToplami / 3}");
            Console.WriteLine($"En küçük 3 sayının ortalaması : {kucukSayilarToplami / 3}");
        }
        private static void Koleksiyonlar_Soru_3()
        {
            Console.Write("Bir cümle giriniz : ");

            var cumle = (Console.ReadLine()).ToLower();

            var sesliHarfler = "aeıioöuü";

            ArrayList harfler = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliHarfler.Contains(cumle[i]))
                {
                    harfler.Add(cumle[i]);
                }
            }

            harfler.Sort();

            foreach (var harf in harfler)
            {
                Console.Write(harf);
            }
        }
    }
}
