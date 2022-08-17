using System;

namespace constructor_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            Console.WriteLine(calisan.Adi);
        }
    }

    class Calisan
    {
        public Calisan() // yapıcı metotun erişim belirleyicisi private olursa => nesne örneği alınamaz
        {
            Id = 1;
            Adi = "Beşir";
            Soyadi = "Gündüz";
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
