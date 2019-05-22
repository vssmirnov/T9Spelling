using System;

namespace Core
{
    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message, LogType.Information);
        }

        public void Wrtie(string message, LogType type){
            Console.WriteLine(type + ": " + message);
        }
    }
}