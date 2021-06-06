using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for

            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            int tek = 0;
            int cift = 0;
            for (int i = 1; i <=100; i++)
            {
                if (i%2==1)
                {
                    tek += i;
                }
                else
                {
                    cift += i;
                }
            }

            Console.WriteLine("Tek toplam= " +tek);
            Console.WriteLine("Çift toplam= "+cift);

            //while

            int sayi = 10;
            int sayac2 = 1;
            int toplam = 0;
            while (sayi>=sayac)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam);

            char c = 'a';
            while (c<='z')
            {
                Console.WriteLine(c);
                c++;
            }

            //foreach

            string[] arabalar = { "BMW", "Ford", "Fiat" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
