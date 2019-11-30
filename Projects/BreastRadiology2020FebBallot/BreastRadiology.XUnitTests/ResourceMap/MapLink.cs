using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class MapLink
    {
        /// <summary>
        /// What type of link this.
        /// </summary>
        public string LinkType;

        /// <summary>
        /// Url of MapNode that this links to.
        /// </summary>
        public String ResourceUrl;

        public bool ShowChildren;

        public MapLink(String linkType,
            String resourceUrl,
            bool showChildren)
        {
            this.LinkType = linkType;
            this.ResourceUrl = resourceUrl;
            this.ShowChildren = showChildren;
        }
    }
}
