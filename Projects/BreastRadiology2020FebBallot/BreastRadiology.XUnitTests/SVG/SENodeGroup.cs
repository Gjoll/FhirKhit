using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class SENodeGroup
    {
        public List<SENode> Nodes = new List<SENode>();
        public List<SENodeGroup> Children = new List<SENodeGroup>();
    }
}
