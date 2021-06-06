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
        }
    }
}
