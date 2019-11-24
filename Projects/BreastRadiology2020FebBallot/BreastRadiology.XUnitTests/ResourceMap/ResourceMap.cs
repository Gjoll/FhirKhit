using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class ResourceMap
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

        Dictionary<String, MapNode> resources = new Dictionary<string, MapNode>();

        private ResourceMap()
        {
        }

        public MapNode GetMapNode(String url)
        {
            if (resources.TryGetValue(url, out MapNode retVal) == false)
            {
                retVal = new MapNode(url);
                resources.Add(url, retVal);
            }
            return retVal;
        }
    }
}
