namespace KPZ_Lab3.Decorator
{
    internal class Warrior : Hero
    {
        public override string GetDescription()
        {
            return "Warrior";
        }

        public override int GetPower()
        {
            return 10;
        }
    }
}
