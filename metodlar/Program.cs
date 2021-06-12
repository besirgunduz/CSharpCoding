using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(5, 10));
            Metotlar metod = new Metotlar();
            metod.EkranaYazdir(Topla(5, 10).ToString());

            int a = 2;
            int b = 3;

            metod.EkranaYazdir(metod.ArttirVeTopla(ref a,ref b).ToString());
            metod.EkranaYazdir(metod.ArttirVeTopla(ref a, ref b).ToString());

        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
