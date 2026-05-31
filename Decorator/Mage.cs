namespace KPZ_Lab3.Decorator
{
    internal class Mage : Hero
    {
        public override string GetDescription()
        {
            return "Mage";
        }

        public override int GetPower()
        {
            return 8;
        }
    }
}
