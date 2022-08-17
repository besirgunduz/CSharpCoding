using System;

namespace interface_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileLogger fileLogger = new FileLogger();
            //fileLogger.WriteLog();

            //DatabaseLogger databaseLogger = new();
            //databaseLogger.WriteLog();

            //ILogger logger = new SmsLogger();
            //logger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
