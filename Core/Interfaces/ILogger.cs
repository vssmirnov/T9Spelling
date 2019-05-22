namespace Core
{
    public interface ILogger
    {
        void Write(string message);
        void Wrtie(string message, LogType type);
    }
}