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
        public String HRef {get; set; }

        public SENode(float widthEm,
            Color fillColor,
            String hRef = null)
        {
            this.Width = widthEm;
            this.FillColor = fillColor;
            this.HRef = hRef;
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
            if (this.Width < text.Text.Length)
                this.Width = text.Text.Length;
            this.TextLines.Add(text);
            return this;
        }

        public SENode AddTextLine(String text, String hRef = null)
        {
            return this.AddTextLine(new SEText(text, hRef));
        }
    }
}
