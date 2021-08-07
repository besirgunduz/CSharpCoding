using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Beşir");
            arrayList.Add(true);


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------------");

            //AddRange - tek seferde birden fazla eleman eklememizi sağlar.
            string[] renkler = new string[] { "kırmızı", "sarı" };
            List<int> sayilar = new List<int> { 1, 4, 5, 3 };
            arrayList.AddRange(renkler);
            arrayList.AddRange(sayilar);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Sort
            sayilar.Sort();

            //Reverse - Tersine çevirir.
            arrayList.Reverse();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
