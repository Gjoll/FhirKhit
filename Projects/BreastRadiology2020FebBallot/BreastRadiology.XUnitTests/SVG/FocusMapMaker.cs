using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic for each resourece showing fragment parents and children..
    /// </summary>
    class FocusMapMaker
    {
        class FocusNode
        {
            public MapNode Focus;
            public List<MapNode> Parents = new List<MapNode>();
            public List<MapNode> Children = new List<MapNode>();
        }

        Dictionary<String, FocusNode> focusNodes = new Dictionary<string, FocusNode>();
        String graphicsDir;
        String contentDir;

        ResourcesMaker resourcesMaker;

        public FocusMapMaker(ResourcesMaker resourcesMaker,
            String graphicsDir,
            String contentDir)
        {
            this.resourcesMaker = resourcesMaker;
            this.graphicsDir = graphicsDir;
            this.contentDir = contentDir;
        }

        String FocusMapName(MapNode mapNode) => $"Focus-{mapNode.Name}.svg";
        String IntroName(MapNode mapNode) => $"StructureDefinition-{mapNode.Name}-intro.xml";

        IEnumerable<MapLink> FocusLinks(MapNode n)
        {
            foreach (MapLink link in n.Links)
            {
                switch (link.LinkType)
                {
                    case "target":
                        yield return link;
                        break;
                }
            }
        }

        void LinkNodes()
        {
            foreach (MapNode focusMapNode in ResourceMap.Self.MapNodes)
            {
                if (this.focusNodes.TryGetValue(focusMapNode.Name, out FocusNode fragmentFocusNode) == false)
                    throw new Exception($"Internal error. Cant find Focus FocusNode '{focusMapNode.Name}' ");

                foreach (MapLink link in FocusLinks(focusMapNode))
                {
                    MapNode referencedMapNode = ResourceMap.Self.GetMapNode(link.ResourceUrl);
                    fragmentFocusNode.Parents.Add(referencedMapNode);

                    if (this.focusNodes.TryGetValue(referencedMapNode.Name, out FocusNode fragmentParentNode) == false)
                        throw new Exception($"Internal error. Cant find FocusNode '{referencedMapNode.Name}' ");
                    fragmentParentNode.Children.Add(focusMapNode);
                }
            }
        }

        SENode CreateNode(MapNode mapNode, Color color, bool linkFlag)
        {
            SENode node = new SENode(0, color);

            if (this.resourcesMaker.editors.TryGetValue(mapNode.ResourceUrl, out SDefEditor e) == false)
                throw new Exception("Internal error. Editor not found");
            foreach (String titlePart in e.MapName)
            {
                String hRef = null;
                String title = null;
                if (linkFlag)
                {
                    hRef = $"./StructureDefinition-{mapNode.ResourceUrl.LastUriPart()}.html";
                    title = $"'{mapNode.ResourceUrl.LastUriPart()}'";
                }
                String s = titlePart.Trim();
                node.AddTextLine(s, hRef, title);
            }

            return node;
        }

        void GraphNode(FocusNode fragmentNode)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents");
            SENodeGroup focusGroup = new SENodeGroup("focus");
            SENodeGroup childrenGroup = new SENodeGroup("children");
            parentsGroup.Children.Add(focusGroup);
            focusGroup.Children.Add(childrenGroup);

            {
                SENode node = CreateNode(fragmentNode.Focus, Color.LightGreen, false);
                focusGroup.Nodes.Add(node);
            }

            foreach (MapNode childNode in fragmentNode.Children)
            {
                SENode node = CreateNode(childNode, Color.LightBlue, true);
                parentsGroup.Nodes.Add(node);
            }

            foreach (MapNode parentNode in fragmentNode.Parents)
            {
                SENode node = CreateNode(parentNode, Color.LightSalmon, true);
                childrenGroup.Nodes.Add(node);
            }

            e.Render(parentsGroup);
            e.Save(Path.Combine(graphicsDir, FocusMapName(fragmentNode.Focus)));
        }

        void CreateIntroFile(FocusNode fragmentNode)
        {
            String svgFileName = FocusMapName(fragmentNode.Focus);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<div xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd\">");
            sb.AppendLine("<p>");
            sb.AppendLine($"	<object data=\"{svgFileName}\" type=\"image/svg+xml\">");
            sb.AppendLine($"		<img src=\"{svgFileName}\" alt=\"{svgFileName}\" />");
            sb.AppendLine("	</object>");
            sb.AppendLine("</p>");
            sb.AppendLine("</div>");
            File.WriteAllText(Path.Combine(this.contentDir, IntroName(fragmentNode.Focus)),
                sb.ToString());
        }

        void GraphNodes()
        {
            foreach (FocusNode fragmentNode in this.focusNodes.Values)
            {
                if (fragmentNode.Focus.Name.Contains("Fragment") == false)
                {
                    GraphNode(fragmentNode);
                    CreateIntroFile(fragmentNode);
                }
            }
        }

        void CreateNodes()
        {
            foreach (MapNode mapNode in ResourceMap.Self.MapNodes)
            {
                FocusNode fNode = new FocusNode
                {
                    Focus = mapNode
                };
                focusNodes.Add(mapNode.Name, fNode);
            }
        }

        public void Create()
        {
            CreateNodes();
            LinkNodes();
            GraphNodes();
        }
    }
}
