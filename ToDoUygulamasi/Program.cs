using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> todoLine = new();
            List<Card> inProgresLine = new();
            List<Card> doneLine = new();

            todoLine.Add(new Card { Title = "Kitap oku", Contant = "100 sayfa kitap oku", Size = Size.M, AssignedPersonId = 1 });
            todoLine.Add(new Card { Title = "İngilizce çalış", Contant = "İngilizce film izle", Size = Size.L, AssignedPersonId = 1 });
            todoLine.Add(new Card { Title = "Algoritma çalış", Contant = "10 algoritma sorusu çöz", Size = Size.XL, AssignedPersonId = 2 });

            List<AssignedPerson> assignedPeople = new();
            assignedPeople.Add(new AssignedPerson { Id = 1, Name = "Beşir" });
            assignedPeople.Add(new AssignedPerson { Id = 2, Name = "Ahmet" });



            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                "*******************************************\n" +
                "(1) Board Listelemek\n" +
                "(2) Board'a Kart Eklemek\n" +
                "(3) Board'dan Kart Silmek\n" +
                "(4) Kart Taşımak\n");

            try
            {
                int process = Convert.ToInt32(Console.ReadLine());

                switch (process)
                {
                    case 1:
                        BoardListele();
                        break;
                    case 2:
                        BoardKartEkle();
                        break;
                    case 3:
                        BoardKartSil();
                        break;
                    //case 4:
                    //    KartTasi();
                    //    break;
                    default:
                        Console.WriteLine("Hatalı bir işlem yapıldı");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata : {ex.Message}");
            }

            Console.Write("Çıkmak için bir tuşa basınız... ");
            Console.ReadKey();


            void BoardListele()
            {
                Console.WriteLine("TODO Line\n" +
                    "************************\n");

                foreach (var card in todoLine)
                {
                    Console.WriteLine($"Başlık      : {card.Title}\n" +
                                      $"İçerik      : {card.Contant}\n" +
                                      $"Atanan Kişi : {assignedPeople.FirstOrDefault(p => p.Id == card.AssignedPersonId).Name}\n" +
                                      $"Büyüklük    : {card.Size}\n-");
                }

                Console.WriteLine("IN PROGRESS Line\n" +
                    "************************\n");

                foreach (var card in inProgresLine)
                {
                    Console.WriteLine($"Başlık      : {card.Title}\n" +
                                      $"İçerik      : {card.Contant}\n" +
                                      $"Atanan Kişi : {assignedPeople.FirstOrDefault(p => p.Id == card.AssignedPersonId).Name}\n" +
                                      $"Büyüklük    : {card.Size}\n-");
                }

                Console.WriteLine("DONE Line\n" +
                    "************************\n");

                foreach (var card in doneLine)
                {
                    Console.WriteLine($"Başlık      : {card.Title}\n" +
                                      $"İçerik      : {card.Contant}\n" +
                                      $"Atanan Kişi : {assignedPeople.FirstOrDefault(p => p.Id == card.AssignedPersonId).Name}\n" +
                                      $"Büyüklük    : {card.Size}\n-");
                }

            }
            void BoardKartEkle()
            {
                Console.Write("Başlık Giriniz                                  :");
                string title = Console.ReadLine();
                Console.Write("İçerik Giriniz                                  :");
                string contant = Console.ReadLine();
                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kişi Seçiniz                                    :");
                int personId = Convert.ToInt32(Console.ReadLine());

                var findPerson = assignedPeople.FirstOrDefault(person => person.Id == personId);

                if (findPerson is null)
                {
                    Console.Write("Hatalı girişler yaptınız!");
                    return;
                }

                todoLine.Add(new Card { Title = title, Contant = contant, Size = (Size)size, AssignedPersonId = personId });
            }
            void BoardKartSil()
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                    "Lütfen kart başlığını yazınız:");
                var cardTitle = Console.ReadLine();
                var todoLineDeletedCard = todoLine.FirstOrDefault(c => c.Title == cardTitle);
                var inProgressLineDeletedCard = inProgresLine.FirstOrDefault(c => c.Title == cardTitle);
                var doneLineDeletedCard = doneLine.FirstOrDefault(c => c.Title == cardTitle);

                if (todoLineDeletedCard == null && todoLineDeletedCard == null && todoLineDeletedCard == null)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                        "* İşlemi sonlandırmak için : (1)\n" +
                        "* Yeniden denemek için : (2)");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("İşlem sonlandırıldı");
                            break;
                        case 2:
                            BoardKartSil();
                            break;
                        default:
                            Console.WriteLine("Hatalı bir işlem yapıldı");
                            break;
                    }
                }
                else
                {
                    if (todoLineDeletedCard != null)
                        todoLine.Remove(todoLineDeletedCard);
                    if (inProgressLineDeletedCard != null)
                        todoLine.Remove(inProgressLineDeletedCard);
                    if (doneLineDeletedCard != null)
                        todoLine.Remove(doneLineDeletedCard);
                }
            }

        }
    }
}
