using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class MapNode
    {
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

        public void AddFragmentLink(String url)
        {
            this.AddLinks("fragment", url);
        }

        public void AddObservationTargets(params ObservationTarget[] targets)
        {
            foreach (ObservationTarget target in targets)
                this.AddLinks("target", target.Profile);
        }

        public void AddLinks(String linkType,
            params String[] urls)
        {
            foreach (String url in urls)
            {
                if (String.IsNullOrEmpty(url))
                    throw new Exception("Url can not be empty");
                if (this.links.TryGetValue(url, out MapLink link) == true)
                    return;
                this.links.Add(url, new MapLink(linkType, url));
            }
        }
    }
}
