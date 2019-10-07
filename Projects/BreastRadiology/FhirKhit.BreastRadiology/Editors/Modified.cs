using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.BreastRadiology
{
    class Modified<T>
        where T : class
    {
        public bool ModifiedFlag { get; set; } = false;
        public T Item { get; set; }

        public Modified(T item)
        {
            this.Item = item;
        }
    }
}
