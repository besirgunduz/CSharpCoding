using System;

namespace Encapsulation_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Ogrenci
    {
        public Ogrenci(string isim)
        {
            this.isim = isim;
        }

        private string isim;
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

    }
}
