namespace KPZ_Lab3.Bridge
{
    internal class Square : Shape
    {
        public Square(Renderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            renderer.Render("Square");
        }
    }
}
