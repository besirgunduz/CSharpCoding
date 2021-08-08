using System;
using System.Collections;

namespace algoritma_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin ve sayı giriniz : ");
            string[] girdi = Console.ReadLine().Split(',');

            string metin = girdi[0];
            int sayi = Convert.ToInt32(girdi[1]);

            metin = metin.Remove(sayi, 1);

            Console.WriteLine(metin);
            

        }
    }
}
