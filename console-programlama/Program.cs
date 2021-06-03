using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz: ");
            var name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            var surname = Console.ReadLine();

            Console.WriteLine($"Merhaba {name} {surname}");
            Console.ReadKey();
        }
    }
}
