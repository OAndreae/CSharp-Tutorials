using System;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR]\t" + error);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[LOG]\t" + info);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[INFO]\t" + warning);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
