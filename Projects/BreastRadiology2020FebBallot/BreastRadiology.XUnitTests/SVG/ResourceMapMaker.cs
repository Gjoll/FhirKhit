using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using StringTask = System.Threading.Tasks.Task<string>;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic of all resources.
    /// </summary>
    class ResourceMapMaker
    {
        class LegendItem
        {
            public String ResourceType;
            public Color Color;
        };

        ResourcesMaker resourcesMaker;
        Dictionary<String, LegendItem> legendItems = new Dictionary<string, LegendItem>();


        public ResourceMapMaker(ResourcesMaker resourcesMaker)
        {
            this.resourcesMaker = resourcesMaker;
        }

        public void AddLegendItem(String resourceType, Color color)
        {
            this.legendItems.Add(resourceType,
                new LegendItem
                {
                    ResourceType = resourceType,
                    Color = color
                });
        }

        SENode CreateNode(ResourceMap.Node mapNode)
        {
            LegendItem legendItem;
            switch (mapNode.StructureName)
            {
                case "StructureDefinition":
                    if (this.legendItems.TryGetValue(mapNode.BaseName, out legendItem) == false)
                        throw new Exception($"No legend item defined for Base {mapNode.BaseName}");
                    break;

                default:
                    throw new Exception($"No legend item defined for Structure {mapNode.StructureName}");
            }

            SENode node = new SENode(0, legendItem.Color);

            String url = mapNode.ResourceUrl;
            foreach (String titlePart in mapNode.MapName)
            {
                String hRef = $"./{mapNode.StructureName}-{url.LastUriPart()}.html";
                String title = $"Click -> '{url.LastUriPart()}'";
                String s = titlePart.Trim();
                node.AddTextLine(s, hRef, title);
            }
            return node;
        }
        bool DifferentChildren(ResourceMap.Link[] links1, ResourceMap.Link[] links2)
        {
            if (links1 == null)
                return true;
            if (links2 == null)
                return true;
            if (links1.Length != links2.Length)
                return true;
            for (Int32 i = 0; i < links1.Length; i++)
            {
                ResourceMap.Link link1 = links1[i];
                ResourceMap.Link link2 = links2[i];
                if (link1.LinkType != link2.LinkType)
                    return true;
                if (link1.ResourceUrl != link2.ResourceUrl)
                    return true;
            }
            return false;
        }

        /*
         * Add children. If two adjacent children have same children, then dont create each in a seperate
         * group. Have the two nodes point to the same group of children.
         */
        void AddChildren(ResourceMap.Node mapNode,
            String linkType,
            SENodeGroup group)
        {
            ResourceMap.Link[] links = mapNode.LinksByName(linkType).ToArray();
            AddChildren(mapNode, linkType, links, group);
        }

        void AddChildren(ResourceMap.Node mapNode,
            String linkType,
            ResourceMap.Link[] links,
            SENodeGroup group)
        {
            ResourceMap.Link[] previousChildLinks = null;
            if (links.Length > 0)
            {
                SENodeGroup groupChild = null;
                foreach (ResourceMap.Link link in links)
                {
                    ResourceMap.Link[] childMapLinks = null;

                    ResourceMap.Node childMapNode = ResourceMap.Self.GetNode(link.ResourceUrl);
                    if (link.ShowChildren)
                    {
                        childMapLinks = childMapNode.LinksByName(linkType).ToArray();
                        if (DifferentChildren(previousChildLinks, childMapLinks))
                            previousChildLinks = null;
                    }
                    else
                        previousChildLinks = null;

                    if (previousChildLinks == null)
                    {
                        groupChild = group.AppendChild("");
                        if (link.ShowChildren)
                        {
                            AddChildren(childMapNode, linkType, childMapLinks, groupChild);
                            previousChildLinks = childMapLinks;
                        }
                    }

                    {
                        if (ResourceMap.Self.TryGetNode(link.ResourceUrl, out ResourceMap.Node linkTargetNode) == false)
                            throw new Exception("ResourceMap.Node '{link.ResourceUrl}' not found");
                        SENode node = CreateNode(linkTargetNode);
                        groupChild.Nodes.Add(node);
                    }
                }
            }
        }

        public void Create(String outputPath)
        {
            SvgEditor svgEditor = new SvgEditor();
            SENodeGroup legendGroup = CreateLegend(svgEditor);
            SENodeGroup rootGroup = CreateNodes(svgEditor);
            svgEditor.Render(legendGroup, false);
            svgEditor.Render(rootGroup, true);
            svgEditor.Save(outputPath);
        }

        SENodeGroup CreateLegend(SvgEditor svgEditor)
        {
            SENodeGroup legendGroup = new SENodeGroup("legend");
            SENodeGroup lastGroup = legendGroup;
            foreach (LegendItem legendItem in this.legendItems.Values)
            {
                SENodeGroup nextGroup = lastGroup.AppendChild("Legend");
                SENode node = new SENode(0, legendItem.Color);
                nextGroup.Nodes.Add(node);
                node.AddTextLine(legendItem.ResourceType);
                lastGroup = nextGroup;
            }
            return legendGroup;
        }

        SENodeGroup CreateNodes(SvgEditor svgEditor)
        {
            StringTask breastRadiologyReport = this.resourcesMaker.BreastRadiologyReport();
            breastRadiologyReport.Wait();
            ResourceMap.Node mapNode = ResourceMap.Self.GetNode(breastRadiologyReport.Result);

            SENodeGroup rootGroup = new SENodeGroup("root");
            SENode rootNode = CreateNode(mapNode);
            rootGroup.Nodes.Add(rootNode);
            AddChildren(mapNode, "valueSet", rootGroup);
            AddChildren(mapNode, "target", rootGroup);
            AddChildren(mapNode, "extension", rootGroup);
            return rootGroup;
        }
    }
}
