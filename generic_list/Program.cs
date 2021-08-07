using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            //T -> object

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(10);
            sayiListesi.Add(23);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Sarı");
            renkListesi.Add("Kırmızı");

            //Count
            Console.WriteLine(renkListesi.Count);

            //Elemanlara erişim - foreach,ForEach

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(10); // elemanı çıkarır
            sayiListesi.RemoveAt(0); // indexteki elemanı çıkarır.

            //Liste içinde arama
            if (renkListesi.Contains("Kırmızı"))
            {
                Console.WriteLine("Kırmızı rengi liste içerisindedir.");
            }

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            List<Kullanici> kullanicilar = new List<Kullanici>();
            kullanicilar.Add(new Kullanici()
            {
                Ad = "Beşir",
                Soyad = "Gündüz"
            });

            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Ad);
                Console.WriteLine(kullanici.Soyad);
            }

            kullanicilar.Clear();




        }
    }

    public class Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
