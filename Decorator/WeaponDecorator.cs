namespace KPZ_Lab3.Decorator
{
    internal class WeaponDecorator : HeroDecorator
    {
        public WeaponDecorator(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return hero.GetDescription() + " + Weapon";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 7;
        }
    }
}
