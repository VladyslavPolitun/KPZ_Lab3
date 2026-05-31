using System;
using KPZ_Lab3.Adapter;
using KPZ_Lab3.Decorator;
using KPZ_Lab3.Bridge;

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

            Console.WriteLine();
            Console.WriteLine("===== DECORATOR =====");

            Hero warrior = new Warrior();
            warrior = new ArmorDecorator(warrior);
            warrior = new WeaponDecorator(warrior);

            Console.WriteLine(warrior.GetDescription());
            Console.WriteLine("Power: " + warrior.GetPower());

            Hero mage = new Mage();
            mage = new ArtifactDecorator(mage);
            mage = new WeaponDecorator(mage);

            Console.WriteLine(mage.GetDescription());
            Console.WriteLine("Power: " + mage.GetPower());

            Hero paladin = new Paladin();
            paladin = new ArmorDecorator(paladin);
            paladin = new ArtifactDecorator(paladin);
            paladin = new WeaponDecorator(paladin);

            Console.WriteLine(paladin.GetDescription());
            Console.WriteLine("Power: " + paladin.GetPower());

            Console.WriteLine();
            Console.WriteLine("===== BRIDGE =====");

            Renderer vector = new VectorRenderer();
            Renderer raster = new RasterRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(raster);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.ReadKey();
        }
    }
}
