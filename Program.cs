using System;
using System.IO;
using KPZ_Lab3.Proxy;
using KPZ_Lab3.Adapter;
using KPZ_Lab3.Decorator;
using KPZ_Lab3.Bridge;
using KPZ_Lab3.Composite;
using KPZ_Lab3.Flyweight;

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

            Console.WriteLine();
            Console.WriteLine("===== PROXY =====");

            File.WriteAllText("public.txt", "This is public file.");
            File.WriteAllText("secret.txt", "This is secret file.");

            TextDocument document = new RealTextDocument();
            TextDocument protectedDocument = new SmartTextReaderLocker(document, "secret");

            protectedDocument.Read("public.txt");
            protectedDocument.Read("secret.txt");

            Console.WriteLine();
            Console.WriteLine("===== COMPOSITE =====");

            LightElementNode page = new LightElementNode("div", "block", false);
            page.AddClass("page");

            LightElementNode title = new LightElementNode("h1", "block", false);
            title.AddChild(new LightTextNode("LightHTML example"));

            LightElementNode paragraph = new LightElementNode("p", "block", false);
            paragraph.AddClass("text");
            paragraph.AddChild(new LightTextNode("This paragraph was created with Composite pattern."));

            LightElementNode image = new LightElementNode("img", "inline", true);
            image.AddClass("picture");

            page.AddChild(title);
            page.AddChild(paragraph);
            page.AddChild(image);

            Console.WriteLine(page.OuterHTML());

            Console.WriteLine();
            Console.WriteLine("===== FLYWEIGHT =====");

            HtmlTagFactory tagFactory = new HtmlTagFactory();

            string[] lines =
            {
                "ACT V",
                "Scene I. Mantua. A Street.",
                " Dramatis Personae",
                "ESCALUS, Prince of Verona.",
                "PARIS, a young Nobleman."
            };

            foreach (string line in lines)
            {
                HtmlTag tag;

                if (line == lines[0])
                    tag = tagFactory.GetTag("h1");
                else if (line.Length < 20)
                    tag = tagFactory.GetTag("h2");
                else if (line.StartsWith(" "))
                    tag = tagFactory.GetTag("blockquote");
                else
                    tag = tagFactory.GetTag("p");

                Console.WriteLine(tag.Render(line.Trim()));
            }

            Console.WriteLine("Unique tag objects: " + tagFactory.Count());

            Console.ReadKey();
        }
    }
}
