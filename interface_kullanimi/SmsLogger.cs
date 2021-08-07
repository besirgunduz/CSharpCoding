namespace interface_kullanimi
{
    class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Sms olarak log yazar.");
        }
    }
}
