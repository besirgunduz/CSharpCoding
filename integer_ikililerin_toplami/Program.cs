using System;
using System.Collections;

namespace integer_ikililerin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen n tane integer ikililerin toplamını alan,
            //eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran,
            //sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

            //Input:
            //2 3
            //1 5
            //2 5
            //3 3

            //Output:
            //5
            //6
            //7
            //81

            Console.Write("Kaç tane integer ikilisi girmek istiyorsunuz : ");
            int n = Convert.ToInt32(Console.ReadLine());

            integer_ikililerin_toplami(n);

        }

        private static void integer_ikililerin_toplami(int n)
        {
            ArrayList sonucSayi = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}'inci integer ikilisi giriniz : ");
                var ikiliSayi = Console.ReadLine().Split(' ');

                if (ikiliSayi[0] != ikiliSayi[1])
                {
                    int sayi = Convert.ToInt32(ikiliSayi[0]) + Convert.ToInt32(ikiliSayi[1]);
                    sonucSayi.Add(sayi);
                }
                else
                {
                    int sayi = Convert.ToInt32(ikiliSayi[0]) + Convert.ToInt32(ikiliSayi[1]);
                    sonucSayi.Add(sayi * sayi);
                }
            }

            foreach (var item in sonucSayi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
