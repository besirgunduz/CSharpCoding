﻿using System;

namespace hazir_metodlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(10));
            Console.WriteLine(DateTime.Now.AddYears(28));

            //DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("---------------------------------------------------------");

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25));  //Mutlak değer

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); //yuvarlama

            Console.WriteLine(Math.Max(2.3, 18.9));

            Console.WriteLine(Math.Pow(2, 3)); //üs
            Console.WriteLine(Math.Sqrt(9));

        }
    }
}
