using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;

                case 2:
                    Console.WriteLine("Ocak ayındasınız");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;


                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }
        }
    }
}
