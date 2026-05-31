using System.IO;

namespace KPZ_Lab3.Adapter
{
    internal class FileWriter
    {
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void Write(string text)
        {
            File.AppendAllText(_fileName, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(_fileName, text + "\n");
        }
    }
}
