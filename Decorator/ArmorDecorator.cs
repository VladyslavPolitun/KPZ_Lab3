namespace KPZ_Lab3.Decorator
{
    internal class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return hero.GetDescription() + " + Armor";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 5;
        }
    }
}
