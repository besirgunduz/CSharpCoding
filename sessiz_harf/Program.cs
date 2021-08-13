using System;

namespace sessiz_harf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

            string ifade = "Arya";

            var sonuc = sessiz_harf(ifade) == true ? "true" : "false";

            Console.WriteLine(sonuc);

        }

        private static bool sessiz_harf(string ifade)
        {
            var sesli = "aeıioöuü";

            ifade = ifade.ToLower();

            for (int i = 0; i < ifade.Length; i++)
            {
                if ((i + 1) < ifade.Length && !sesli.Contains(ifade[i]) && !sesli.Contains(ifade[i + 1]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
