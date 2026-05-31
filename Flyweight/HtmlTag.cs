namespace KPZ_Lab3.Flyweight
{
    internal class HtmlTag
    {
        public string TagName { get; private set; }

        public HtmlTag(string tagName)
        {
            TagName = tagName;
        }

        public string Render(string content)
        {
            return $"<{TagName}>{content}</{TagName}>";
        }
    }
}
