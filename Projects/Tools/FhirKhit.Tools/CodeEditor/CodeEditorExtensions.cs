using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace FhirKhit.Tools
{
    public static class CodeEditorExtensions
    {
        public static CodeBlockNested AppendTableRow(this CodeBlockNested block,
            String cssClass,
            params String[] fields)
        {
            block.AppendRaw(string.IsNullOrEmpty(cssClass) ? "<tr>" : $"<tr class=\"{cssClass}\">");
            foreach (String field in fields)
                block.AppendRaw($"<td>{field}</td>");
            block.AppendRaw("</tr>");
            return block;
        }
    }
}
