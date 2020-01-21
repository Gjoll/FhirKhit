using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public class ElementTreeSorter
    {
        public ElementTreeSorter()
        {
        }

        /// <summary>
        /// Sort items according to the order in the template.
        /// </summary>
        /// <param name="orderTemplate">
        /// Defines the order in which elements should be in 'items'.
        /// If elements are in orderTemplate but not in items that is ok.
        /// If elements are in items but not in orderTemplate that is not ok.
        /// </param>
        /// <param name="items">
        /// The items to reorder.
        /// </param>
        public void Sort(ElementTreeNode orderTemplate,
            ElementTreeNode items)
        {
            SortElements(orderTemplate, items);
        }

        void SortElements(ElementTreeNode orderTemplateNode,
            ElementTreeNode itemsNode)
        {
            foreach (ElementTreeSlice itemsSlice in itemsNode.Slices)
            {
                SortSlice(orderTemplateNode.DefaultSlice, itemsSlice);
            }
        }

        void SortSlice(ElementTreeSlice orderTemplateSlice,
            ElementTreeSlice itemsSlice)
        {
            Dictionary<String, Int32> order = new Dictionary<string, int>();
            ElementTreeNode[] orderNodes = orderTemplateSlice.Nodes.ToArray();
            for (Int32 i = 0; i < orderTemplateSlice.Nodes.Count; i++)
                order.Add(orderNodes[i].Name, i);

            SortNodes(itemsSlice.Nodes.Items, order);

            foreach (ElementTreeNode node in itemsSlice.Nodes)
            {
                if (orderTemplateSlice.Nodes.TryGetItem(node.Name, out ElementTreeNode orderTemplateNode) == false)
                    throw new Exception($"{node.Path} not found in order template. Is node named incorrectly?");
                SortElements(orderTemplateNode, node);
            }
        }

        /// <summary>
        /// Bubble sort of nodes in list.
        /// Nodes are sorted according to the position values stored in
        /// order, which si usually created from the snapshot of the base resource.
        /// If tow items with the same name are found in the list, then the relative order of the items
        /// will be kept, so that the item that was first will still be first. This si done to keep Slice elements 
        /// in the same order as they were defined.
        /// </summary>
        void SortNodes(List<ElementTreeNode> nodes,
            Dictionary<String, Int32> order)
        {
            if (nodes.Count == 0)
                return;

            int length = nodes.Count;
            ElementTreeNode temp = nodes[0];

            for (int i = 0; i < length; i++)
            {
                if (order.TryGetValue(nodes[i].Name, out Int32 iVal) == false)
                    throw new Exception($"Sort error. Can not find index of {nodes[i].Name}");

                for (int j = i + 1; j < length; j++)
                {
                    if (order.TryGetValue(nodes[j].Name, out Int32 jVal) == false)
                        throw new Exception($"Sort error. Can not find index of {nodes[j].Name}");
                    if (iVal > jVal)
                    {
                        temp = nodes[i];
                        nodes[i] = nodes[j];
                        nodes[j] = temp;
                    }
                }
            }
        }
    }
}
