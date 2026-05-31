namespace KPZ_Lab3.Decorator
{
    internal class Paladin : Hero
    {
        public override string GetDescription()
        {
            return "Paladin";
        }

        public override int GetPower()
        {
            return 12;
        }
    }
}
