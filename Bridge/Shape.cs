namespace KPZ_Lab3.Bridge
{
    internal abstract class Shape
    {
        protected Renderer renderer;

        protected Shape(Renderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}
