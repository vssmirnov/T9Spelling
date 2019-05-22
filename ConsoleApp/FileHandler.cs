using System;
using System.IO;
using System.Linq;
using Core;

namespace ConsoleApp
{
    internal class FileHandler {
        private readonly ILogger logger;
        private readonly IConverter converter;        

        public FileHandler(ILogger logger, IConverter converter) {
            this.logger = logger;
            this.converter = converter;
        }

        public void Handler(string fileSource, string fileTarget) {
            logger.Write($"Start the handling: {fileSource}");            

            try {
                var text = File.ReadAllLines(fileSource).ToList();
                var targetText = text.Select((t, i) => $"Case #{i}: {converter.CodingMessage(t)}").ToList();                
                using(var targetFile = File.CreateText(fileTarget)){
                    targetText.ForEach(t => targetFile.WriteLine(t));
                }
            } catch (Exception ex) {
                logger.Write(ex.Message, LogType.Error);
            }

            logger.Write($"Finished the handling: {fileSource}");
        }        
    }
}