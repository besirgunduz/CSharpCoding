using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(1993, "Beşir Gündüz");
            kullanicilar.Add(1453, "İstanbul'un Fethi");

            Console.WriteLine(kullanicilar[1993]);
            Console.WriteLine(kullanicilar.Count);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }

            //Contains - İçeriyor mu?
            Console.WriteLine(kullanicilar.ContainsKey(1993));
            Console.WriteLine(kullanicilar.ContainsValue("Ahmet"));

            //Remove
            kullanicilar.Remove(1993);


        }
    }
}
