using System;

namespace class_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler
            //Public - heryerden erişilebilir
            //Private - sadece tanımlandığı sınıftan erişilebilir
            //Internal - Sadece bulunduğu proje içerisinden erişilebilir
            //Protected - Sadece tanımlandığı sınıftan ve o sınıfı miras alan sınıflardan erişilebilir.

            Calisan calisan = new Calisan()
            {
                Id = 1,
                Adi = "Beşir",
                Soyad = "Gündüz"
            };

            Console.WriteLine(calisan.Adi);

        }
    }

    class Calisan
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
    }
}
