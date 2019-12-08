using FhirKhit.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class MapNode
    {
        public String Name => this.ResourceUrl.LastUriPart();

        /// <summary>
        /// Url of the resource this represents.
        /// </summary>
        public String ResourceUrl;

        /// <summary>
        /// Links from this resource to an other resource.
        /// </summary>
        public IEnumerable<MapLink> Links => links.Values;

        Dictionary<String, MapLink> links = new Dictionary<String, MapLink>();

        public MapNode(String resourceUrl)
        {
            this.ResourceUrl = resourceUrl;
        }

        public void AddFragmentLink(String url, bool showChildren = true)
        {
            this.AddLink("fragment", url, showChildren);
        }

        public void AddTargetLink(String url, bool showChildren = true)
        {
            this.AddLink("target", url, showChildren);
        }

        public void AddExtensionLink(String url, bool showChildren = true)
        {
            this.AddLink("extension", url, showChildren);
        }

        public void AddProfileTargets(params ProfileTargetSlice[] targets)
        {
            foreach (ProfileTargetSlice target in targets)
                this.AddLink("target", target.Profile, target.ShowChildren);
        }

        public void AddLink(String linkType,
            String url,
            bool showChildren)
        {
            if (String.IsNullOrEmpty(url))
                throw new Exception("Url can not be empty");
            if (this.links.TryGetValue(url, out MapLink link) == true)
                return;
            this.links.Add(url, new MapLink(linkType, url, showChildren));
        }
    }
}
