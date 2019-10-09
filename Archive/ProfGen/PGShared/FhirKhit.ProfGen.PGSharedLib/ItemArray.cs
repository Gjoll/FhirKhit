using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.ProfGen.PGSharedLib
{
    public class ItemArray<TProfileItemClass, TFhirItemClass>
        where TProfileItemClass : ItemBase<TFhirItemClass>, new()
        where TFhirItemClass : Base
    {
        List<TFhirItemClass> items;

        public ItemArray()
        {
        }

        public virtual void Init(List<TFhirItemClass> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Remove item at indicated index
        /// </summary>
        public void RemoveAt(Int32 index) => items.RemoveAt(index);

        /// <summary>
        /// Get list of all items
        /// </summary>
        public IEnumerable<TFhirItemClass> GetRaw() => items;

        /// <summary>
        /// Count of items
        /// </summary>
        public Int32 Count => items.Count;

        /// <summary>
        /// Get value
        /// return true if successfull
        /// </summary>
        public void Get(Int32 index, out TProfileItemClass value)
        {
            TFhirItemClass temp = items[index];
            value = new TProfileItemClass
            {
                Ptr = temp
            };
        }

        /// <summary>
        /// Set Value
        /// </summary>
        public void Set(Int32 index, TProfileItemClass value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            items[index] = value.Ptr;
        }

        /// <summary>
        /// Add Value
        /// </summary>
        public void Add(TProfileItemClass value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            items.Add(value.Ptr);
        }

        /// <summary>
        /// AddRange Value
        /// </summary>
        public void AddRange(IEnumerable<TProfileItemClass> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));

            foreach (TProfileItemClass value in values)
                this.Add(value);
        }
    }
}
