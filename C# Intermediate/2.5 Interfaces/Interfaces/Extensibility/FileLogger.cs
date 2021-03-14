using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string error)
        {
            Log("[ERROR]\t" + error);
        }

        public void LogInfo(string info)
        {
            Log("[LOG]\t" + info);
        }

        public void LogWarning(string warning)
        {
            Log("[INFO]\t" + warning);
        }

        private void Log(string message)
        {
            using (var stream = new StreamWriter(_path, true))
            {
                stream.WriteLine(message);
            }
        }
    }
}
