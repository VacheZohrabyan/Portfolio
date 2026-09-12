namespace GameDataParser
{
    public class Logger
    {
        public readonly string LogFileName;

        public Logger(string logFileName)
        {
            LogFileName = logFileName;
        }
        
        public void Log(Exception exception)
        {
            string entry = 
$@"[{DateTime.Now}]
Exception message: {exception.Message}
Stack trace: {exception.StackTrace}

";
            File.AppendAllText(LogFileName, entry);
        }
    }
}