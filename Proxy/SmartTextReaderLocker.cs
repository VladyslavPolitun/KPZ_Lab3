using System;
using System.Text.RegularExpressions;

namespace KPZ_Lab3.Proxy
{
    internal class SmartTextReaderLocker : TextDocument
    {
        private readonly TextDocument _document;
        private readonly string _blockedPattern;

        public SmartTextReaderLocker(TextDocument document, string blockedPattern)
        {
            _document = document;
            _blockedPattern = blockedPattern;
        }

        public void Read(string filePath)
        {
            if (Regex.IsMatch(filePath, _blockedPattern))
            {
                Console.WriteLine("Access denied: " + filePath);
                return;
            }

            _document.Read(filePath);
        }
    }
}
