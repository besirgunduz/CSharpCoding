using System;

namespace diziler_array_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort - küçükten büyüğe sıralama

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 17 };

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------------------------------");

            //clear

            Array.Clear(sayiDizisi, 0, 2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------------------------------");

            //Reverse - tersine çevirme

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-----------------------------------------------");

            //IndexOf

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("-----------------------------------------------");

            //Resize

            Array.Resize<int>(ref sayiDizisi, 10);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
