using System;

namespace enum_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Perşembe);

            int sicaklik = 36;

            if (sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Havanın ısınmasını bekle");
            }
            else
            {
                Console.WriteLine("Hava sıcak...");
            }

        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba=26,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=0,
        Normal=20
    }
}
