using System;

namespace ucgen_cizme_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen boyut için bir pozitif tam sayı giriniz : ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            if (boyut<2)
            {
                Console.WriteLine("Üçgen çizilebilmesi için boyut sayısı en az 2 olmalı !!!");
            }
            else
            {
                UcgenCiz(boyut);
            }

            Console.ReadKey();

        }

        static void UcgenCiz(int boyut)
        {
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

            }
        }
    }
}
