using System;

namespace hazir_metodlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "Merhaba SCharp";
            string degisken2 = " SCharp";

            //Length
            Console.WriteLine(degisken1.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken1.ToUpper());
            Console.WriteLine(degisken2.ToLower());

            //Concat - Birleştirme işlemi yapar.
            Console.WriteLine(string.Concat(degisken1, " - ", degisken2));

            //Compare, CompareTo - Karşılaştırma yapar
            Console.WriteLine(degisken1.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken1, degisken2));

            //Contains - İçeriyor mu?
            Console.WriteLine(degisken1.Contains(degisken2));

            //IdexOf, LastIndexOf
            Console.WriteLine(degisken1.IndexOf(degisken2));
            Console.WriteLine(degisken1.LastIndexOf('a'));

            //Insert - Ekleme yapar
            Console.WriteLine(degisken1.Insert(0, degisken2));

            //PadLeft, PadRight - Değişkenin başına veya sonuna ekleme yapar.
            Console.WriteLine(degisken1.PadLeft(15, '*'));
            Console.WriteLine(degisken2.PadRight(7, '*'));

            //Remove
            Console.WriteLine(degisken1.Remove(7));
            Console.WriteLine(degisken1.Remove(10, 2));

            //Replace
            Console.WriteLine(degisken1.Replace("SCharp", "C#"));

            //Split
            Console.WriteLine(degisken1.Split(' ')[0]);

            //Substring
            Console.WriteLine(degisken1.Substring(0, 7));

            //Trim
            Console.WriteLine(degisken2.Trim());
        }
    }
}
