using System;
using System.IO;
using System.Linq;
using Core;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            logger.Write("Start");

            var fileHandler = new FileHandler(logger, new Converter(logger));
            var assembly = System.Reflection.Assembly.GetExecutingAssembly().GetModules().FirstOrDefault()?.FullyQualifiedName;
            var rootPath = Path.GetDirectoryName(assembly);
            Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(rootPath, "Out")));

            fileHandler.Handler(Path.Combine(rootPath, "Resources/C-large-practice.in"), Path.Combine(rootPath, "Out/C-large-practice.out"));
            fileHandler.Handler(Path.Combine(rootPath, "Resources/C-small-practice.in"), Path.Combine(rootPath, "Out/C-small-practice.out"));

            logger.Write("Finish");
        }
    }
}
