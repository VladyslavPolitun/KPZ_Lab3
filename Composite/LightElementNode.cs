using System.Collections.Generic;
using System.Linq;

namespace KPZ_Lab3.Composite
{
    internal class LightElementNode : LightNode
    {
        private string tagName;
        private string displayType;
        private bool isSelfClosing;
        private List<string> cssClasses;
        private List<LightNode> children;

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.isSelfClosing = isSelfClosing;
            cssClasses = new List<string>();
            children = new List<LightNode>();
        }

        public void AddClass(string className)
        {
            cssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            if (!isSelfClosing)
                children.Add(child);
        }

        public override string InnerHTML()
        {
            return string.Join("", children.Select(child => child.OuterHTML()));
        }

        public override string OuterHTML()
        {
            string classes = cssClasses.Count > 0
                ? $" class=\"{string.Join(" ", cssClasses)}\""
                : "";

            if (isSelfClosing)
                return $"<{tagName}{classes}/>";

            return $"<{tagName}{classes}>{InnerHTML()}</{tagName}>";
        }
    }
}
