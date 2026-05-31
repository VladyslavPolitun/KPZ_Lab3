using System;

namespace KPZ_Lab3.Bridge
{
    internal class VectorRenderer : Renderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as vector graphics");
        }
    }
}
