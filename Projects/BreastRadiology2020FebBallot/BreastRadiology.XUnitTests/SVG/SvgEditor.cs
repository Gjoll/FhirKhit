using SVGLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class SvgEditor
    {
        SvgDoc doc;

        public float BorderWidth { get; set; } = 0.125f;
        public float LineHeight { get; set; } = 1.25f;
        public float BorderMargin { get; set; } = 2.0f;
        public float NodeGapX { get; set; } = 2.0f;
        public float NodeGapY { get; set; } = 2.0f;
        public float RectRx { get; set; } = 1f;
        public float RectRy { get; set; } = 2f;

        float screenX = 10f;
        float screenY = 10f;

        String ToEm(float value) => $"{value}em";

        public SvgEditor()
        {
            this.doc = new SvgDoc();
            this.doc.CreateNewDocument();
        }

        public void Render(SENodeGroup group,
            float screenX = -1,
            float screenY = -1)
        {
            if (screenX == -1)
                screenX = this.BorderMargin;
            if (screenY == -1)
                screenY = this.BorderMargin;

            RenderGroup(group, screenX, screenY, out float widthEm, out float heightEm, out List<PointF> endConnectors);
        }

        void CreateArrow(SvgGroup g, float xStart, float yStart, float xEnd, float yEnd)
        {
            SvgLine stub = this.doc.AddLine(g);
            stub.Stroke = Color.Black;
            stub.X1 = ToEm(xStart);
            stub.X2 = ToEm(xEnd);
            stub.Y1 = this.ToEm(yStart);
            stub.Y2 = this.ToEm(yEnd);
            stub.StrokeWidth = ToEm(BorderWidth);
        }

        void CreateLine(SvgGroup g, float x1, float y1, float x2, float y2)
        {
            SvgLine stub = this.doc.AddLine(g);
            stub.Stroke = Color.Black;
            stub.X1 = ToEm(x1);
            stub.X2 = ToEm(x2);
            stub.Y1 = this.ToEm(y1);
            stub.Y2 = this.ToEm(y2);
            stub.StrokeWidth = ToEm(BorderWidth);
        }

        void RenderGroup(SENodeGroup group,
            float screenX,
            float screenY,
            out float widthEm,
            out float heightEm,
            out List<PointF> endConnectors)
        {
            widthEm = 0;
            heightEm = 0;
            SvgGroup g = this.doc.AddGroup(null);
            float col1ScreenY = screenY;
            float col1Width = 0;
            float col1Height = 0;

            float topConnectorY = float.MaxValue;
            float bottomConnectorY = float.MinValue;

            endConnectors = new List<PointF>();
            List<PointF> startConnectors = new List<PointF>();

            foreach (SENode node in group.Nodes)
            {
                Render(g, node, screenX, col1ScreenY, out float nodeWidthEm, out float nodeHeightEm);
                if (col1Width < nodeWidthEm)
                    col1Width = nodeWidthEm;

                float connectorY = col1ScreenY + nodeHeightEm / 2;
                if (topConnectorY > connectorY)
                    topConnectorY = connectorY;
                if (bottomConnectorY < connectorY)
                    bottomConnectorY = connectorY;
                startConnectors.Add(new PointF(screenX + nodeWidthEm, col1ScreenY + nodeHeightEm / 2));
                endConnectors.Add(new PointF(screenX, col1ScreenY + nodeHeightEm / 2));
                col1Height += nodeHeightEm + NodeGapY;
                col1ScreenY += nodeHeightEm + NodeGapY;
            }

            if (group.Children.Count > 0)
            {
                foreach (PointF stubStart in startConnectors)
                    CreateLine(g, stubStart.X, stubStart.Y, screenX + col1Width + NodeGapX, stubStart.Y);
            }
            float col2ScreenX = screenX + col1Width + 2 * NodeGapX;
            float col2ScreenY = screenY;
            float col2Width = 0;
            float col2Height = 0;
            foreach (SENodeGroup child in group.Children)
            {
                RenderGroup(child, 
                    col2ScreenX, 
                    col2ScreenY, 
                    out float childGroupWidthEm, 
                    out float childGroupHeightEm, 
                    out List<PointF> col2EndConnectors);
                if (col2Width < childGroupWidthEm)
                    col2Width = childGroupWidthEm;
                col2Height += childGroupHeightEm + NodeGapY;
                foreach (PointF stubEnd in col2EndConnectors)
                {
                    CreateLine(g, screenX + col1Width + NodeGapX, stubEnd.Y, stubEnd.X, stubEnd.Y);
                    if (topConnectorY > stubEnd.Y)
                        topConnectorY = stubEnd.Y;
                    if (bottomConnectorY < stubEnd.Y)
                        bottomConnectorY = stubEnd.Y;
                }
            }

            // Make vertical line that connects all stubs.
            if (group.Children.Count > 0)
            {
                float x = screenX + col1Width + this.NodeGapX;
                CreateLine(g, x, topConnectorY, x, bottomConnectorY);
            }

            widthEm += col1Width + col2Width + 2 * this.NodeGapX;
        }

        void Render(SvgGroup parentGroup,
            SENode node,
            float screenX,
            float screenY,
            out float widthEm,
            out float heightEm)
        {
            heightEm = node.TextLines.Count * LineHeight + BorderMargin;
            widthEm = node.WidthEm;

            SvgGroup g = this.doc.AddGroup(parentGroup);

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

            foreach (SEText line in node.TextLines)
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
            }
        }

        public void Save(String path)
        {
            this.doc.SaveToFile(path);
        }
    }
}
