namespace KPZ_Lab3.Bridge
{
    internal class Circle : Shape
    {
        public Circle(Renderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            renderer.Render("Circle");
        }
    }
}
