using System;
using KPZ_Lab3.Adapter;

namespace KPZ_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADAPTER =====");

            Logger logger = new Logger();

            logger.Log("Program started");
            logger.Warn("Low memory");
            logger.Error("Critical error");

            FileWriter writer = new FileWriter("log.txt");
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(writer);

            fileLogger.Log("Saved to file");
            fileLogger.Warn("Warning saved to file");
            fileLogger.Error("Error saved to file");

            Console.WriteLine("Messages written to log.txt");

            Console.ReadKey();
        }
    }
}
