using System.Collections.Generic;

namespace KPZ_Lab3.Flyweight
{
    internal class HtmlTagFactory
    {
        private Dictionary<string, HtmlTag> tags = new Dictionary<string, HtmlTag>();

        public HtmlTag GetTag(string tagName)
        {
            if (!tags.ContainsKey(tagName))
            {
                tags[tagName] = new HtmlTag(tagName);
            }

            return tags[tagName];
        }

        public int Count()
        {
            return tags.Count;
        }
    }
}
