using System;
using System.IO;

namespace KPZ_Lab3.Proxy
{
    internal class RealTextDocument : TextDocument
    {
        public void Read(string filePath)
        {
            Console.WriteLine("Reading file: " + filePath);

            if (File.Exists(filePath))
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
