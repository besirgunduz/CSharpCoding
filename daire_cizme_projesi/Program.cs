using System;

namespace daire_cizme_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int yaricap;
            double yaricap_kalinlik = 0.4;

            Console.Write("Yarıçap Giriniz : ");
            yaricap = Convert.ToInt32(Console.ReadLine());

            DaireCiz(yaricap, yaricap_kalinlik);

            Console.ReadKey();
        }

        static void DaireCiz(int yaricap, double yaricap_kalinlik)
        {
            double rIn = yaricap - yaricap_kalinlik, rOut = yaricap + yaricap_kalinlik;

            for (double y = yaricap; y >= -yaricap; --y)
            {
                for (double x = -yaricap; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
