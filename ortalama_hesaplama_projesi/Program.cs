using System;
using System.Collections;

namespace ortalama_hesaplama_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen derinlik için bir pozitif tam sayı giriniz : ");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            if (derinlik == 1)
            {
                Console.WriteLine("Rakamların ortalaması : 0");
            }
            else if (derinlik == 2)
            {
                Console.WriteLine("Rakamların ortalaması : "+(1/2));
            }
            if (derinlik>2)
            {
                var list = FibonacciSerisi(derinlik);
                int ortalama = OrtalamaBul(list);
                Console.WriteLine($"Rakamların ortalaması : {ortalama}");
            }


        }

        static ArrayList FibonacciSerisi(int derinlik)
        {

            int sayi1 = 0;
            int sayi2 = 1;

            ArrayList fibonacciList = new ArrayList();
            fibonacciList.Add(sayi1);
            fibonacciList.Add(sayi2);

            for (int i = 2; i < derinlik; i++)
            {
                int temp = sayi1 + sayi2;
                fibonacciList.Add(temp);
                sayi1 = sayi2;
                sayi2 = temp;
            }

            return fibonacciList;

        }

        static int OrtalamaBul(ArrayList arrayList)
        {
            int toplam = 0;
            foreach (var item in arrayList)
            {
                toplam += (int)item;
            }

            return toplam / arrayList.Count;
        }
    }
}
