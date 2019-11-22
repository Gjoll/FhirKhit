using SVGLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class SEText
    {
        public String Text;
        public Uri HRef;
    }

    public class SENode
    {
        public Int32 WidthEm;
        public List<SEText> Lines = new List<SEText>();
        public List<SENode> Children = new List<SENode>();
        public Color FillColor { get; set; } = Color.LightBlue;
    }

    class SvgEditor
    {
        SvgDoc doc;

        public float BorderWidth { get; set; } = 0.125f;
        public float LineHeight { get; set; } = 1.25f;
        public float BorderMargin { get; set; } = 2.0f;
        public float RectRx { get; set; } = 1f;
        public float RectRy { get; set; } = 2f;

        float screenX = 10;
        float screenY = 10;

        public SvgEditor()
        {
            this.doc = new SvgDoc();
            this.doc.CreateNewDocument();
        }

        public void Render(SENode node)
        {
            String ToEm(float value) => $"{value}em";

            float heightEm = node.Lines.Count * LineHeight + BorderMargin;

            SvgGroup g = this.doc.AddGroup(null);

            SvgRect square = this.doc.AddRect(g);
            square.Stroke = Color.Black;
            square.StrokeWidth = ToEm(BorderWidth);
            square.RX = ToEm(this.RectRx);
            square.RY = ToEm(this.RectRy);
            square.X = ToEm(screenX);
            square.Y = ToEm(screenY);
            square.Width = ToEm(node.WidthEm);
            square.Height = ToEm(heightEm);
            square.Fill = node.FillColor;

            float textX = screenX + 2;
            float textY = screenY + 2;

            foreach (SEText line in node.Lines)
            {
                SvgText t;
                if (line.HRef != null)
                {
                    SvgHyperLink l = this.doc.AddHyperLink(g);
                    l.HRef = line.HRef.ToString();
                    t = this.doc.AddText(l);
                }
                else
                {
                    t = this.doc.AddText(g);
                }
                t.X = ToEm(textX);
                t.Y = ToEm(textY);
                t.Value = line.Text;

                textY += LineHeight;

                //    if (line.HRef != null)
                //    {
                //        //SvgHyperLink link = new SvgHyperLink(line.HRef);
                //        link.Children.Add(text);
                //        //this.doc.Children.Add(link);
                //    }
                //    else
                //    {
                //        //this.doc.Children.Add(text);
                //    }
            }
        }

        public void Save(String path)
        {
            this.doc.SaveToFile(path);
        }
    }
}
