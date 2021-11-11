using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contactsList = new();

            contactsList.Add(new Person { Name = "Besir", SurName = "Gunduz", PhoneNumber = 05317674565 });
            contactsList.Add(new Person { Name = "Ridvan", SurName = "Gunduz", PhoneNumber = 05317674565 });
            contactsList.Add(new Person { Name = "Ahmet", SurName = "Demir", PhoneNumber = 0531444444446 });
            contactsList.Add(new Person { Name = "Mehmet", SurName = "Forsa", PhoneNumber = 05316666666 });
            contactsList.Add(new Person { Name = "Okan", SurName = "Cetin", PhoneNumber = 0531222222222 });

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                "*******************************************\n" +
                "(1) Yeni Numara Kaydetmek\n" +
                "(2) Varolan Numarayı Silmek\n" +
                "(3) Varolan Numarayı Güncelleme\n" +
                "(4) Rehberi Listelemek\n" +
                "(5) Rehberde Arama Yapmak﻿\n");

            try
            {
                int process = Convert.ToInt32(Console.ReadLine());

                switch (process)
                {
                    case 1:
                        SaveNewNumber();
                        break;
                    case 2:
                        DeleteNumber();
                        break;
                    case 3:
                        UpdatedNumber();
                        break;
                    case 4:
                        ContactsList();
                        break;
                    case 5:
                        SearchContact();
                        break;
                    default:
                        Console.WriteLine("Hatalı bir işlem yapıldı");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata : {ex.Message}");
            }

            Console.ReadKey();


            void SaveNewNumber()
            {
                Console.Write("Lütfen isim giriniz             : ");
                var name = Console.ReadLine();
                Console.Write("Lütfen soyisim giriniz          : ");
                var surName = Console.ReadLine();
                Console.Write("Lütfen telefon numarası giriniz : ");
                var phoneNumber = Convert.ToInt64(Console.ReadLine());

                contactsList.Add(new Person { Name = name, SurName = surName, PhoneNumber = phoneNumber });
                Console.WriteLine($"\n{name} {surName} {phoneNumber} kaydı eklendi");
            }
            void DeleteNumber()
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz: ");

                var fullName = Console.ReadLine().Split(" ");
                var personToRemove = contactsList.FirstOrDefault(person => person.Name == fullName[0] && person.SurName == fullName[1]);

                if (personToRemove is null)
                {
                    Console.Write("\nAradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                     "* Silmeyi sonlandırmak için : (1)\n" +
                     "* Yeniden denemek için      : (2)\n");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("İşlem sonlandırıldı");
                            break;
                        case 2:
                            DeleteNumber();
                            break;
                        default:
                            Console.WriteLine("Hatalı bir işlem yapıldı");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine($"{string.Join(" ", fullName)} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string yesNo = Console.ReadLine();

                    if (yesNo.ToLower() == "y")
                    {
                        contactsList.Remove(personToRemove);
                        Console.WriteLine($"\n{string.Join(" ", fullName)} kaydı silindi");
                    }
                    else
                        Console.WriteLine("Kayıt silme iptal edildi.");
                }
            }
            void UpdatedNumber()
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve  soyadını giriniz:");
                var fullName = Console.ReadLine().Split(" ");

                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin numarasını giriniz:");
                var phoneNumber = Convert.ToInt64(Console.ReadLine());

                var personUpdated = contactsList.FirstOrDefault(person => person.Name == fullName[0] && person.SurName == fullName[1]);

                if (personUpdated is null)
                {
                    Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                     "* Güncellemeyi sonlandırmak için : (1)\n" +
                     "* Yeniden denemek için      : (2)");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("İşlem sonlandırıldı");
                            break;
                        case 2:
                            UpdatedNumber();
                            break;
                        default:
                            Console.WriteLine("Hatalı bir işlem yapıldı");
                            break;
                    }

                }
                else
                {
                    personUpdated.PhoneNumber = phoneNumber;
                    Console.WriteLine($"\n{string.Join(" ", fullName)} kaydı güncellendi");
                }
            }
            void ContactsList()
            {
                Console.WriteLine("Telefon Rehberi\n" +
                    "**********************************************\n");
                foreach (var person in contactsList)
                {
                    Console.WriteLine(
                    $"isim: {person.Name}\n" +
                    $"Soyisim: {person.SurName}\n" +
                    $"Telefon Numarası: {person.PhoneNumber}\n" +
                    $"-");
                }
            }
            void SearchContact()
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n" +
                    "**********************************************\n\n" +
                    "İsim ve soyisime göre arama yapmak için: (1)\n" +
                    "Telefon numarasına göre arama yapmak için: (2)\n");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("İsim ve soyisim giriniz");
                        var fullName = Console.ReadLine().Split(" ");
                        var list1 = contactsList.FindAll(person => person.Name == fullName[0] && person.SurName == fullName[1]);

                        Console.WriteLine("Arama Sonuçlarınız:\n" +
                         "**********************************************\n");
                        foreach (var person in list1)
                        {
                            Console.WriteLine(
                            $"isim: {person.Name}\n" +
                            $"Soyisim: {person.SurName}\n" +
                            $"Telefon Numarası: {person.PhoneNumber}\n" +
                            $"-");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Telefon numarası  giriniz");
                        var phoneNumber = Convert.ToInt64(Console.ReadLine());
                        var list2 = contactsList.FindAll(person => person.PhoneNumber == phoneNumber);

                        Console.WriteLine("Arama Sonuçlarınız:\n" +
                         "**********************************************\n");
                        foreach (var person in list2)
                        {
                            Console.WriteLine(
                            $"isim: {person.Name}\n" +
                            $"Soyisim: {person.SurName}\n" +
                            $"Telefon Numarası: {person.PhoneNumber}\n" +
                            $"-");
                        }

                        break;
                    default:
                        Console.WriteLine("Hatalı bir işlem yapıldı");
                        break;
                }

            }

        }

    }
}
