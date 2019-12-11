using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourceMap
    {
        public static ResourceMap Self
        {
            get
            {
                if (_self == null)
                    _self = new ResourceMap();
                return _self;
            }
        }
        static ResourceMap _self;

        Dictionary<String, ResourceMap.Node> resources = new Dictionary<string, ResourceMap.Node>();

        private ResourceMap()
        {
        }

        public IEnumerable<ResourceMap.Node> MapNodes => this.resources.Values;

        public bool TryGetNode(String url, out ResourceMap.Node node)
        {
            return resources.TryGetValue(url, out node);
        }

        public ResourceMap.Node GetNode(String url)
        {
            if (resources.TryGetValue(url, out ResourceMap.Node node) == false)
                throw new Exception($"Map node {url} not found");
            return node;
        }

        public ResourceMap.Node CreateMapNode(String url, String[] mapName)
        {
            if (resources.TryGetValue(url, out ResourceMap.Node retVal) == true)
                throw new Exception($"Map node {url} already exists");
            retVal = new Node(url);
            retVal.MapName = mapName;
            return retVal;
        }
    }
}
