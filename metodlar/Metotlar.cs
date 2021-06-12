using System;

namespace metodlar
{
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;

            return deger1 + deger2;
        }

    }
}
