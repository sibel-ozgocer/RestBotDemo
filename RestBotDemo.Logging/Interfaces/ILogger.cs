namespace RestBot.Logging.Implementations
{
    public interface ILogger
    {
        void error(string message);
        void warning(string message);

        void info(string message);

        void debug(string message);
        void Critical(string message);

        void LogPerformance(string message, long duration);


        void LogSecurity(string message, string userId, string ipAddress);

    }
}
