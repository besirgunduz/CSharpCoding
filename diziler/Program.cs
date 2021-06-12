using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            Console.WriteLine(renkler[0]);

            //Döngüler le dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] diziOrt = new int[diziuzunlugu];
            int diziToplam = 0;
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine($"Lütfen dizinin {i+1} elemanını giriniz");
                diziOrt[i] = int.Parse(Console.ReadLine());
                diziToplam += diziOrt[i];
            }

            Console.WriteLine("Ortalama = " +diziToplam/diziuzunlugu);

        }
    }
}
