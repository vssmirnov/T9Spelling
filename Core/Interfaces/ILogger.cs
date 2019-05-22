namespace Core
{
    public interface ILogger
    {
        void Write(string message);
        void Write(string message, LogType type);
    }
}