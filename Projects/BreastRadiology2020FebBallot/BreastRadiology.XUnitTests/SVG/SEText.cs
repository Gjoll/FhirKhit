using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class SEText
    {
        public String Text {get; set; }
        public Uri HRef {get; set; }

        public SEText(String text, Uri hRef = null)
        {
            this.Text = text;
            this.HRef = hRef;
        }

        public SEText()
        {
        }
    }
}
