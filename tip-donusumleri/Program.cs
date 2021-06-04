using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion(Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            long h = d;
            float i = h;

            string e = "Beşir";
            char f = 'k';
            object g = e + f + d;

            Console.WriteLine(g);


            // Explicit Convertion (Bilinçli Dönüşüm)

            int x = 5;
            byte y = (byte)x;
            Console.WriteLine(y);

            int xx = 6;
            string yy = xx.ToString();

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            string s1 = "10";
            int sayi1 = Convert.ToInt32(s1);

            ParseMethod();
        }

        private static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1 = int.Parse(metin1);
            double rakam2 = double.Parse(metin2);

            string tarih = "10.10.1993";
            var datetime = DateTime.Parse(tarih);
            Console.WriteLine(tarih);

        }
    }
}
