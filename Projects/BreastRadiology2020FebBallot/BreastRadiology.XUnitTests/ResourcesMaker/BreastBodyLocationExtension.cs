using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String BreastBodyLocationExtension()
        {
            SDefEditor e = this.CreateEditor("BreastBodyLocation", 
                "Breast Body Location",
                new string[] {"Breast","Body","Location"}, 
                ExtensionUrl)
                .Description(new Markdown()
                    .Paragraph("Breast Body Location extension")
                    )
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;

            e.AddFragRef(this.headerFragUrl);

            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            e.Select("value[x]")
                .Zero()
                ;

            ElementDefGroup eGroup = e.Find("extension");
            ElementDefinition topExtension = e.Clone("extension");
            topExtension.Path = $"{topExtension.Path}.extension";
            topExtension.ElementId = $"{topExtension.ElementId}.extension";
            topExtension.ConfigureSliceByUrlDiscriminator();
            eGroup.RelatedElements.Add(topExtension);
            {
                ElementDefinition laterality = e.Clone("extension");
                laterality
                    .ElementId($"{topExtension.Path}:laterality")
                    .SliceName("laterality")
                    ;
                ElementDefGroup lateralityGroup = e.InsertAfter(eGroup, laterality);
                ElementDefinition lateralityValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:laterality.value[x]")
                    .Type("CodeableConcept")
                    .Binding("http://hl7.org/fhir/ValueSet/bodysite-laterality", BindingStrength.Required)
                    .Single()
                    ;
                lateralityGroup.RelatedElements.Add(lateralityValue);
            }

            {
                String binding = this.CreateValueSet(
                    "BreastLocationQuadrant",
                    "Breast Location Quadrant",
                    new Markdown()
                        .Paragraph("Breast Location Quadrant"),
                    new String[]
                    {
                    "a. UpperOuter",
                    "b. UpperInner",
                    "c. LowerOuter",
                    "d. LowerInner",
                    "e. Central",
                    "f. RetroaReolar",
                    "g. AxillaryTail"
                    });

                ElementDefinition quadrant = e.Clone("extension");
                quadrant
                    .ElementId($"{topExtension.Path}:quadrant")
                    .SliceName("quadrant")
                    ;
                ElementDefGroup quadrantGroup = e.InsertAfter(eGroup, quadrant);
                ElementDefinition quadrantValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:quadrant.value[x]")
                    .Type("CodeableConcept")
                    .Binding(binding, BindingStrength.Required)
                    .Single()
                    ;
                quadrantGroup.RelatedElements.Add(quadrantValue);
            }

            {
                String binding = this.CreateValueSet(
                    "BreastLocationClock",
                    "Breast Location Clock",
                    new Markdown()
                        .Paragraph("Breast Location Clock"),
                    new String[]
                    {
                    "12-OClock",
                    "1-OClock",
                    "2-OClock",
                    "3-OClock",
                    "4-OClock",
                    "5-OClock",
                    "6-OClock",
                    "7-OClock",
                    "8-OClock",
                    "9-OClock",
                    "10-OClock",
                    "11-OClock"
                    });

                ElementDefinition clock = e.Clone("extension");
                clock
                    .ElementId($"{topExtension.Path}:clock")
                    .SliceName("clock")
                    ;
                ElementDefGroup clockGroup = e.InsertAfter(eGroup, clock);
                ElementDefinition clockValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:clock.value[x]")
                    .Type("CodeableConcept")
                    .Binding(binding, BindingStrength.Required)
                    .Single()
                    ;
                clockGroup.RelatedElements.Add(clockValue);
            }

            {
                String binding = this.CreateValueSet(
                    "BreastLocationDepth",
                    "Breast Location Depth",
                    new Markdown()
                        .Paragraph("Breast Location Depth"),
                    new String[]
                    {
                    "a. Anterion",
                    "b. Middle",
                    "c. Posterior"
                    });

                ElementDefinition depth = e.Clone("extension");
                depth
                    .ElementId($"{topExtension.Path}:depth")
                    .SliceName("depth")
                    ;
                ElementDefGroup depthGroup = e.InsertAfter(eGroup, depth);
                ElementDefinition depthValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:depth.value[x]")
                    .Type("CodeableConcept")
                    .Binding(binding, BindingStrength.Required)
                    .Single()
                    ;
                depthGroup.RelatedElements.Add(depthValue);
            }

            {
                ElementDefinition distanceFromNipple = e.Clone("extension");
                distanceFromNipple
                    .ElementId($"{topExtension.Path}:distanceFromNipple")
                    .SliceName("distanceFromNipple")
                    ;
                ElementDefGroup distanceFromNippleGroup = e.InsertAfter(eGroup, distanceFromNipple);
                ElementDefinition distanceFromNippleValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:distanceFromNipple.value[x]")
                    .Type("Quantity")
                    .Single()
                    ;
                distanceFromNippleGroup.RelatedElements.Add(distanceFromNippleValue);

                ElementDefinition quantitySystem = new ElementDefinition()
                    .Path($"{topExtension.Path}.value[x].system")
                    .ElementId($"{topExtension.Path}:distanceFromNipple.value[x].system")
                    .Type("uri")
                    .Single()
                    .Fixed(new FhirUri("http://unitsofmeasure.org"))
                    ;
                distanceFromNippleGroup.RelatedElements.Add(quantitySystem);

                ElementDefinition quantityCode = new ElementDefinition()
                    .Path($"{topExtension.Path}.value[x].code")
                    .ElementId($"{topExtension.Path}:distanceFromNipple.value[x].code")
                    .Type("uri")
                    .Single()
                    .Binding("http://hl7.org/fhir/us/breast-radiology/ValueSet/UnitsOfLengthVS",
                            BindingStrength.Required)
                    ;
                distanceFromNippleGroup.RelatedElements.Add(quantityCode);
            }

            return e.SDef.Url;
        }
    }
}
