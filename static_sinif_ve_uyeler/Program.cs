using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calisan.CalisanSayisi);

        }
    }

    static class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }
        static Calisan()
        {
            calisanSayisi++;
        }
    }
}
