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
    class FragmentMapMaker
    {
        class FragmentNode
        {
            public MapNode Focus;
            public List<MapNode> Parents = new List<MapNode>();
            public List<MapNode> Children = new List<MapNode>();
        }

        Dictionary<String, FragmentNode> fragmentNodes = new Dictionary<string, FragmentNode>();
        String outputDir;

        ResourcesMaker resourcesMaker;

        public FragmentMapMaker(ResourcesMaker resourcesMaker,
            String outputDir)
        {
            this.resourcesMaker = resourcesMaker;
            this.outputDir = outputDir;
        }

        String FragmentMapName(MapNode mapNode) => $"FragmentMap_{mapNode.Name}.svg";

        IEnumerable<MapLink> FragmentLinks(MapNode n)
        {
            foreach (MapLink link in n.Links)
            {
                switch (link.LinkType)
                {
                    case "fragment":
                        yield return link;
                        break;
                }
            }
        }

        void LinkNodes()
        {
            foreach (MapNode focusMapNode in ResourceMap.Self.MapNodes)
            {
                if (this.fragmentNodes.TryGetValue(focusMapNode.Name, out FragmentNode fragmentFocusNode) == false)
                    throw new Exception($"Internal error. Cant find Focus FragmentNode '{focusMapNode.Name}' ");

                foreach (MapLink link in FragmentLinks(focusMapNode))
                {
                    MapNode referencedMapNode = ResourceMap.Self.GetMapNode(link.ResourceUrl);
                    fragmentFocusNode.Parents.Add(referencedMapNode);

                    if (this.fragmentNodes.TryGetValue(referencedMapNode.Name, out FragmentNode fragmentParentNode) == false)
                        throw new Exception($"Internal error. Cant find FragmentNode '{referencedMapNode.Name}' ");
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
                    String fragMapName = FragmentMapName(mapNode);
                    hRef = $"./{fragMapName}";
                    title = $"'{fragMapName}'";
                }
                String s = titlePart.Trim();
                node.AddTextLine(s, hRef, title);
            }

            {
                String hRef = $"../Guide/Output/StructureDefinition-{mapNode.ResourceUrl.LastUriPart()}.html";
                String title = $"'{mapNode.ResourceUrl.LastUriPart()}'";
                node.AddTextLine("[Resource]", hRef, title);
            }
            return node;
        }

        void GraphNode(FragmentNode fragmentNode)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup parentsGroup = new SENodeGroup("parents");
            SENodeGroup focusGroup = new SENodeGroup("focus");
            SENodeGroup childrenGroup = new SENodeGroup("children");
            parentsGroup.Children.Add(focusGroup);
            focusGroup.Children.Add(childrenGroup);

            {
                SENode node = CreateNode(fragmentNode.Focus, Color.Green, false);
                focusGroup.Nodes.Add(node);
            }

            foreach (MapNode childNode in fragmentNode.Children)
            {
                SENode node = CreateNode(childNode, Color.LightBlue, true);
                childrenGroup.Nodes.Add(node);
            }

            foreach (MapNode parentNode in fragmentNode.Parents)
            {
                SENode node = CreateNode(parentNode, Color.LightCyan, true);
                parentsGroup.Nodes.Add(node);
            }

            e.Render(parentsGroup);
            e.Save(Path.Combine(outputDir, FragmentMapName(fragmentNode.Focus)));
        }

        void GraphNodes()
        {
            foreach (FragmentNode fragmentNode in this.fragmentNodes.Values)
                GraphNode(fragmentNode);
        }

        void CreateNodes()
        {
            foreach (MapNode mapNode in ResourceMap.Self.MapNodes)
            {
                FragmentNode fNode = new FragmentNode
                {
                    Focus = mapNode
                };
                fragmentNodes.Add(mapNode.Name, fNode);
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
