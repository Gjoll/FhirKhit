using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PreFhir
{
    public class ElementTreeItemList<T> : IEnumerable<T>
        where T : class, IElementTreeItem
    {
        public T this[String name]
        {
            get
            {
                if (this.dict.TryGetValue(name, out T item) == false)
                    throw new Exception($"Item {name} not found in ElementTreeItemList ");
                return item;
            }
        }

        public Int32 Count
        {
            get { return this.items.Count; }
        }

        /// <summary>
        /// Ordered list of T.
        /// </summary>
        List<T> items = new List<T>();

        /// <summary>
        /// Dictionary view of items.
        /// </summary>
        Dictionary<String, T> dict = new Dictionary<string, T>();

        /// <summary>
        /// Add alias to an existing item
        /// </summary>
        /// <param name="item"></param>
        public void AddAlias(String alias, T item)
        {
            this.dict.Add(alias, item);
        }

        /// <summary>
        /// Append item onto end of list.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            this.dict.Add(item.Name, item);
            this.items.Add(item);
        }

        public void Clear()
        {
            this.items.Clear();
            this.dict.Clear();
        }

        /// <summary>
        /// Remove item from list
        /// </summary>
        public void Remove(T item)
        {
            this.dict.Remove(item.Name);
            this.items.Remove(item);
        }

        /// <summary>
        /// insert item into list.
        /// </summary>
        public void InsertAt(Int32 index, T item)
        {
            this.dict.Add(item.Name, item);
            this.items.Insert(index, item);
        }

        /// <summary>
        /// Try to get item.
        /// </summary>
        public bool TryGetItem(String name, out T item)
        {
            return this.dict.TryGetValue(name, out item);
        }

        public List<T> Items => this.items;

        public T GetItemAt(Int32 i)
        {
            return this.items[i];
        }

        /// <summary>
        /// Return index of item in list.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Int32 Index(T item)
        {
            return this.items.IndexOf(item);
        }

        /// <summary>
        /// Sort the <list type="using the indicated comparison function."
        /// </summary>
        /// <param name="comparison"></param>
        public void SortList(Comparison<T> comparison)
        {
            this.items.Sort(comparison);
        }

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)this.items).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<T>)this.items).GetEnumerator();
    }
}
