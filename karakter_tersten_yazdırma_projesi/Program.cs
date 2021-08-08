using System;
using System.Collections;

namespace karakter_tersten_yazdırma_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

            Console.Write("Bir metin giriniz : ");
            string metin = Console.ReadLine();
            ArrayList terstenMetin = new ArrayList();

            for (int i = 0; i < metin.Length-1; i++)
            {
                terstenMetin.Add(metin[i + 1]);
            }

            terstenMetin.Add(metin[0]);

            foreach (var item in terstenMetin)
            {
                Console.Write(item);
            }
        }
    }
}
