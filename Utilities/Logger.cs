
namespace GloRemit.Rsp.SignGenerator
{
    /// <summary>
    /// Logging implementation with NLog
    /// </summary>
    public class Logger
    {
        private static NLog.Logger logger = NLog.LogManager.GetLogger("SignGeneratorLogger");
        public static void Log(string message, LogType logType)
        {
            switch (logType)
            {
                case LogType.INFO:
                    logger.Info(message);
                    break;
                case LogType.ERROR:
                    logger.Error(message);
                    break;
                case LogType.WARN:
                    logger.Warn(message);
                    break;
                case LogType.FATAL:
                    logger.Fatal(message);
                    break;
                default:
                    logger.Info(message);
                    break;
            }
        }
    }

    public enum LogType
    {
        INFO,
        ERROR,
        FATAL,
        WARN
    }
}