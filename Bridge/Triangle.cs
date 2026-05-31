namespace KPZ_Lab3.Bridge
{
    internal class Triangle : Shape
    {
        public Triangle(Renderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            renderer.Render("Triangle");
        }
    }
}
