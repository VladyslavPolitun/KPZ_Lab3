namespace KPZ_Lab3.Decorator
{
    internal class ArtifactDecorator : HeroDecorator
    {
        public ArtifactDecorator(Hero hero) : base(hero)
        {
        }

        public override string GetDescription()
        {
            return hero.GetDescription() + " + Artifact";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 10;
        }
    }
}
