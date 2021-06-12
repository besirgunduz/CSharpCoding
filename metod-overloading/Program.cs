using System;

namespace metod_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
        //Metod imzası => metotAdı + parametresayisi + parametre tipleri

        //Geri dönüş tipi metot imzasına dahil değildir.
        //Yani sadece geri dönüş tipini değiştirerek bir metotu aşırı yükleyemeyiz. Derleyici hata verecektir.

        //Out Kullanımının Özellikleri:

         //Out olarak kullanılmak istenen değişken önüne mutlaka "out" yazılmalıdır.
         //out değişkenin bir ilk değeri olmak zorunda değildir.Hatırlarsanız bu ref kullanırken zorunluydu.

            string sayi = "278";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            static void Topla(int sayi1, int sayi2, out int toplam)
            {
                toplam = sayi1 + sayi2;
            }

            // Method Overloading - Metod aşırı yükleme
            int sayi2 = 100;
            string isim = "Beşir";
            Metodlar.EkranaYazdir(sayi2);
            Metodlar.EkranaYazdir(isim);
        }
    }
}
