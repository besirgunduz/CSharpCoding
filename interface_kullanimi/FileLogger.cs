namespace interface_kullanimi
{
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Dosyaya log yazar");
        }
    }
}
