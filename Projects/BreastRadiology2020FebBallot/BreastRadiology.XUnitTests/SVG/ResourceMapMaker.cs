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
    /// Create graphic of all resources.
    /// </summary>
    class ResourceMapMaker
    {
        ResourcesMaker resourcesMaker;

        public ResourceMapMaker(ResourcesMaker resourcesMaker)
        {
            this.resourcesMaker = resourcesMaker;
        }

        IEnumerable<MapLink> TargetLinks(MapNode n)
        {
            foreach (MapLink link in n.Links)
            {
                switch (link.LinkType)
                {
                    case "target":
                    case "extension":
                        yield return link;
                        break;
                }
            }
        }


        SENode CreateNode(String url)
        {
            SENode node = new SENode(0, Color.LightGreen);

            if (this.resourcesMaker.editors.TryGetValue(url, out SDefEditor e) == false)
                throw new Exception("Internal error. Editor not found");
            foreach (String titlePart in e.MapName)
            {
                String hRef = $"./StructureDefinition-{url.LastUriPart()}.html";
                String title = $"Click -> '{url.LastUriPart()}'";
                String s = titlePart.Trim();
                node.AddTextLine(s, hRef, title);
            }
            return node;
        }
        bool DifferentChildren(MapLink[] links1, MapLink[] links2)
        {
            if (links1 == null)
                return true;
            if (links2 == null)
                return true;
            if (links1.Length != links2.Length)
                return true;
            for (Int32 i = 0; i < links1.Length; i++)
            {
                MapLink link1 = links1[i];
                MapLink link2 = links2[i];
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
        void AddChildren(MapNode mapNode,
            MapLink[] links,
            SENodeGroup group)
        {
            MapLink[] previousChildLinks = null;
            if (links.Length > 0)
            {
                SENodeGroup groupChild = null;
                foreach (MapLink link in links)
                {
                    MapLink[] childMapLinks = null;

                    MapNode childMapNode = ResourceMap.Self.GetMapNode(link.ResourceUrl);
                    if (link.ShowChildren)
                    {
                        childMapLinks = TargetLinks(childMapNode).ToArray();
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
                            AddChildren(childMapNode, childMapLinks, groupChild);
                            previousChildLinks = childMapLinks;
                        }
                    }

                    SENode node = CreateNode(link.ResourceUrl);
                    groupChild.Nodes.Add(node);
                }
            }
        }

        public void Create(String outputPath)
        {
            SvgEditor e = new SvgEditor();
            SENodeGroup rootGroup = new SENodeGroup("root");
            SENode rootNode = CreateNode(this.resourcesMaker.BreastRadiologyReport);
            rootGroup.Nodes.Add(rootNode);
            MapNode mapNode = ResourceMap.Self.GetMapNode(this.resourcesMaker.BreastRadiologyReport);
            MapLink[] links = TargetLinks(mapNode).ToArray();
            AddChildren(mapNode, links, rootGroup);
            e.Render(rootGroup);
            e.Save(outputPath);
        }
    }
}
