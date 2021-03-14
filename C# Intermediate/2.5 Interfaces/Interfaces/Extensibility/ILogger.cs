namespace Extensibility
{
    public interface ILogger
    {
        void LogInfo(string info);
        void LogError(string error);
        void LogWarning(string warning);
    }
}
