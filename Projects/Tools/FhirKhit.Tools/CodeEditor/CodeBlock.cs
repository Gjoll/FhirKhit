using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Tools
{
    public abstract class CodeBlock
    {
        public String Name;

        public CodeBlock(String name)
        {
            this.Name = name.Trim();
        }

        /// <summary>
        /// Clear all content.
        /// </summary>
        public abstract void Clear();

        /// <summary>
        /// Return array of all lines
        /// </summary>
        public abstract String[] Lines();

        /// <summary>
        /// Return array of all lines including header and footer lines
        /// </summary>
        public abstract String[] AllLines();

        /// <summary>
        /// Return string of all lines
        /// </summary>
        public abstract String Text();

        /// <summary>
        /// Return string of all lines including header and footer lines
        /// </summary>
        public abstract String AllText();
    }
}
