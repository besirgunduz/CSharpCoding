using System;

namespace metod_overloading
{
    class Metodlar
    {
        public static void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public static void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
