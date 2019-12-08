using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Helper class for making xxx-intro.xml files.
    /// These files provide the html verbage for the introduction of a fhir class
    /// html page in the IG.
    /// </summary>
    class IntroDoc
    {
        StringBuilder sb = new StringBuilder();

        public IntroDoc()
        {
            sb
                .AppendLine("<div xmlns=\"http://www.w3.org/1999/xhtml\"")
                .AppendLine("    xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"")
                .AppendLine("    xsi:schemaLocation=\"http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd\">")
                ;
        }

        public IntroDoc AddSvgImage(String svgFileName)
        {
            sb
                .AppendLine($"    <object data=\"{svgFileName}\" type=\"image/svg+xml\">")
                .AppendLine($"        <img src=\"{svgFileName}\" alt=\"image/svg+xml\" />")
                .AppendLine($"    </object>")
                ;

            return this;
        }

        public IntroDoc Paragraph(params String[] lines)
        {
            sb.AppendLine("    <p>");
            foreach (String line in lines)
            {
                sb.AppendLine($"{line}");
            }
            sb.AppendLine("    </p>");
            return this;
        }


        public IntroDoc List(ValueSet binding)
        {
            sb.AppendLine("    <ul>");
            foreach (var include in binding.Compose.Include)
            {
                switch (include)
                {
                    case ValueSet.ConceptSetComponent compose:
                        foreach (ValueSet.ConceptReferenceComponent concept in include.Concept)
                            sb.AppendLine($"        <li>{concept.Code} - {concept.Display}</li>");
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            sb.AppendLine("    </ul>");
            return this;
        }

        public void CodedObservation(SDefEditor e,
            String observable,
            ValueSet binding)
        {
            this
                .AddSvgImage(FocusMapMaker.FocusMapName(e.MapNode))
                .Paragraph(
                    $"This resource is a simple observation of {observable}.",
                    $"value[x] is a single codeableConcept, and is bound to one of the following values"
                )
                .List(binding)
                ;
        }

        public String Render()
        {
            sb.AppendLine("</div>");
            return sb.ToString();
        }
    }
}
