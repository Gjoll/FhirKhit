using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    [DebuggerDisplay("{AllText()}]")]
    public class SENode
    {
        public float Width;
        public List<SEText> TextLines = new List<SEText>();
        public Color FillColor { get; set; } = Color.LightBlue;

        public SENode(float widthEm, Color fillColor)
        {
            this.Width = widthEm;
            this.FillColor = fillColor;
        }

        public SENode()
        {
        }

        public String AllText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SEText t in this.TextLines)
                sb.Append($"{t.Text} ");
            return sb.ToString();
        }

        public SENode AddTextLine(SEText text)
        {
            this.TextLines.Add(text);
            return this;
        }

        public SENode AddTextLine(String text, Uri hRef = null)
        {
            return this.AddTextLine(new SEText(text, hRef));
        }
    }
}
