namespace interface_kullanimi
{
    class LogManager:ILogger
    {
        ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
