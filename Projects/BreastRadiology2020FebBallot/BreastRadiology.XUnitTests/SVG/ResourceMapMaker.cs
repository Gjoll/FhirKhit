using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Create graphic of all resources.
    /// </summary>
    class ResourceMapMaker
    {
        ResourcesMaker resourcesMaker;

        public ResourceMapMaker(ResourcesMaker resourcesMaker)
        {
            this.resourcesMaker = resourcesMaker;
        }

        SENode CreateNode(ResourceMap.Node mapNode, Color color)
        {
            SENode node = new SENode(0, color);

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
                        SENode node = CreateNode(linkTargetNode, Color.Green);
                        groupChild.Nodes.Add(node);
                    }
                }
            }
        }

        public void Create(String outputPath)
        {
            ResourceMap.Node mapNode = ResourceMap.Self.GetNode(this.resourcesMaker.BreastRadiologyReport);

            SvgEditor svgEditor = new SvgEditor();
            SENodeGroup rootGroup = new SENodeGroup("root");
            SENode rootNode = CreateNode(mapNode, Color.LightGreen);
            rootGroup.Nodes.Add(rootNode);
            AddChildren(mapNode, "valueSet", rootGroup);
            AddChildren(mapNode, "target", rootGroup);
            AddChildren(mapNode, "extension", rootGroup);
            svgEditor.Render(rootGroup);
            svgEditor.Save(outputPath);
        }
    }
}
