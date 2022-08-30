using System;
using System.Diagnostics;
using System.Text;

namespace StringvsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100000;
            Stopwatch sw = Stopwatch.StartNew();


            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < counter; i++)
            {
                sb.Append(i.ToString());
            }

            sw.Stop();
            Console.WriteLine("StringBuilder : " + sw.ElapsedMilliseconds);


            sw.Restart();
            string test = "";
            for (int i = 1; i < counter; i++)
            {
                test += i.ToString();
            }

            sw.Stop();
            Console.WriteLine("String : " + sw.ElapsedMilliseconds);
        }
    }
}
