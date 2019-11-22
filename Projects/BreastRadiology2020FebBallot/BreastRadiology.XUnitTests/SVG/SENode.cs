using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class SENode
    {
        public float WidthEm;
        public List<SEText> TextLines = new List<SEText>();
        public Color FillColor { get; set; } = Color.LightBlue;

        public SENode(float widthEm, Color fillColor)
        {
            this.WidthEm = widthEm;
            this.FillColor = fillColor;
        }

        public SENode()
        {
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
