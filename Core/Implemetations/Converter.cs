using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core 
{
    public class Converter : IConverter {
        private readonly ILogger logger;
        private Dictionary<char, string> codes;    

        public Converter(ILogger logger) {
            this.logger = logger; 
            Init();
        }

        private void Init() {
            codes = new Dictionary<char, string> {
                {'2', "abc" },
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"},
                {Constants.CodeZero, " "},
                {Constants.EndMessage, new string(Constants.EndMessage, 1)}
            };
        }    

        private string ConvertFromSymbolToDigitalsCode(char symbol){
            var code = codes.FirstOrDefault(t => t.Value.Contains(symbol));
            if (default(KeyValuePair<char, string>).Equals(code)) {
                logger.Write("Символ не найден");
                return string.Empty;
            }
            return new string(code.Key, code.Value.IndexOf(symbol) + 1);
        }

        public string CodingMessage(string message){
            var builder = new StringBuilder();
            logger.Write($"Start coding message: {message}", LogType.Debug);

            char previousCode = char.MinValue;
                
            foreach(char symbol in message) {
                var codes = ConvertFromSymbolToDigitalsCode(symbol);
                if (string.IsNullOrEmpty(codes))
                    continue;
                var currentCode = codes.First();

                if (previousCode != char.MinValue && previousCode == currentCode)
                    builder.Append(Constants.CharSplitter);

                builder.Append(codes);
                previousCode = currentCode;
            }

            var result = builder.ToString();
            logger.Write($"End coding message, result is: {result}", LogType.Debug);

            return result;
        }
    }
}