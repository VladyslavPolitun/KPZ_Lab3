namespace KPZ_Lab3.Decorator
{
    internal abstract class HeroDecorator : Hero
    {
        protected Hero hero;

        public HeroDecorator(Hero hero)
        {
            this.hero = hero;
        }
    }
}
