using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public enum ReviewStatus
    {
        NotReviewed,
        Preliminary,
        Completed
    };

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

        public IntroDoc AddSvgImage(SDefEditor e)
        {
            AddSvgImage(FocusMapMaker.FocusMapName(e.MapNode));
            return this;
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

        public IntroDoc ObservationSection(String name)
        {
            this.Paragraph(
                $"This resource is an '{name}' section.",
                $"Information about the finding is contained in this observation and observations",
                $"referenced by this resource's hasMember field."
                );
            return this;
        }

        public IntroDoc ObservationLeafNode(String leafNode)
        {
            this.Paragraph(
                $"This resource is an leaf-node observation of a {leafNode}.",
                $"It is referenced by an parent Observation section that references other information about this specific abnormality."
                );
            return this;
        }


        public IntroDoc ReviewedStatus(ReviewStatus reviewStatus)
        {
            this.Paragraph($"---",
                           $"** ReviewStatus: {reviewStatus} **",
                           $"---");
            return this;
        }


        public IntroDoc Fragment(String purpose)
        {
            this.Paragraph($"{purpose}.");
            return this;
        }

        public IntroDoc Extension(String name, String purpose)
        {
            this.Paragraph($"{name} Extension Resource used to {purpose}.");
            return this;
        }

        public IntroDoc CodedObservationLeafNode(SDefEditor e,
            String leafNode,
            ValueSet binding)
        {
            this
                .Paragraph(
                    $"This resource is an leaf-node observation of a {leafNode}.",
                    $"It is referenced by an parent Observation section that references other information about this specific abnormality",
                    $"Observation.value[x] is a single codeableConcept, and is bound to one of the following values"
                )
                .List(binding)
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

        public String Render()
        {
            sb.AppendLine("</div>");
            return sb.ToString();
        }
    }
}
