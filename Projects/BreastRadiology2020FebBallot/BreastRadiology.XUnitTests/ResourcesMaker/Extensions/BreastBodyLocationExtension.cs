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

    partial class ResourcesMaker : ConverterBase
    {
        String BreastBodyLocationExtension
        {
            get
            {
                if (breastBodyLocationExtension == null)
                    CreateBreastBodyLocationExtension();
                return breastBodyLocationExtension;
            }
        }
        String breastBodyLocationExtension = null;


        void CreateBreastBodyLocationExtension()
        {
            SDefEditor e;
            ElementDefGroup eGroup;
            ElementDefinition topExtension;

            void SliceAndBind(String sliceName,
                String bindName)
            {
                ElementDefinition extensionElement = e.Clone("extension");
                extensionElement
                    .ElementId($"{topExtension.Path}:{sliceName}")
                    .SliceName(sliceName)
                    ;
                ElementDefGroup extensionGroup = e.InsertAfter(eGroup, extensionElement);

                ElementDefinition sealExtension = e.Clone("extension");
                sealExtension
                    .ElementId($"{topExtension.Path}:{sliceName}.extension")
                    .Zero()
                    ;
                extensionGroup.RelatedElements.Add(sealExtension);

                ElementDefinition lateralityValue = e.Clone("value[x]")
                    .Path($"{topExtension.Path}.value[x]")
                    .ElementId($"{topExtension.Path}:{sliceName}.value[x]")
                    .Type("CodeableConcept")
                    .Binding(bindName, BindingStrength.Required)
                    .Single()
                    ;
                extensionGroup.RelatedElements.Add(lateralityValue);
            }

            e = this.CreateEditor("BreastBodyLocation",
                "Breast Body Location",
                new string[] { "Breast", "Body", "Location" },
                ExtensionUrl,
                "Extension/BreastBodyLocation",
                out breastBodyLocationExtension)
                .Description("Breast Body Location extension",
                    new Markdown()
                        .Paragraph("this extension defines the fields that are used to describe the" +
                                   "location of an observed item in a breat radiology report")
                        .Paragraph("Breast radiology exams have specific ways of defining a location that are unique to this field.")
                        .Todo(
                        )
                )
                .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                .Context()
                ;

            e.AddFragRef(this.HeaderFragment);

            e.Select("url")
                .Type("uri")
                .Fixed(new FhirUri(e.SDef.Url));

            e.Select("value[x]")
                .Zero()
                ;

            eGroup = e.Find("extension");
            topExtension = eGroup.ElementDefinition;
            topExtension.ConfigureSliceByUrlDiscriminator();


            SliceAndBind("laterality", "http://hl7.org/fhir/ValueSet/bodysite-laterality");

            {
                ValueSet binding = this.CreateValueSet(
                    "BreastLocationQuadrant",
                    "Breast Location Quadrant",
                    new Markdown()
                        .Paragraph("Breast Location Quadrant"),
                    new ConceptDef[]
                    {
                        new ConceptDef("UpperOuter",
                            "Upper Outer Quadrant",
                            new Definition()
                                .Line("Upper outer quadrant of the breast")
                            ),

                        new ConceptDef("UpperInner",
                            "Upper Inner Quadrant",
                            new Definition()
                                .Line("Upper inner quadrant of the breast")
                            ),

                        new ConceptDef("LowerOuter",
                            "Lower Outer Quadrant",
                            new Definition()
                                .Line("Lower outer quadrant of the breast")
                            ),

                        new ConceptDef("LowerInner",
                            "Lower Inner Quadrant",
                            new Definition()
                                .Line("Lower inner quadrant of the breast")
                            ),

                        new ConceptDef("Central",
                            "Central Quadrant",
                            new Definition()
                                .Line("Central quadrant of the breast (behind nipple)")
                            ),

                        new ConceptDef("Upper Central",
                            "Upper Central Quadrant",
                            new Definition()
                                .Line("Upper Central quadrant of the breast (12 oclock central)")
                            ),

                        new ConceptDef("Lower Central",
                            "Lower Central Quadrant",
                            new Definition()
                                .Line("Lower Central quadrant of the breast (6 oclock central)")
                            ),

                        new ConceptDef("Outer Central",
                            "Outer Central Quadrant",
                            new Definition()
                                .Line("Outer Central quadrant of the breast (3 or 9 oclock depending on laterality)")
                            ),

                        new ConceptDef("Inner Central",
                            "Inner Central Quadrant",
                            new Definition()
                                .Line("Inner Central quadrant of the breast (3 or 9 oclock depending on laterality)")
                            ),

                        new ConceptDef("RetroaReolar",
                            "RetroaReolar Quadrant",
                            new Definition()
                                .Line("Central location in the anterior third of the breast close to the nipple")
                            ),

                        new ConceptDef("AxillaryTail",
                            "AxillaryTail Quadrant",
                            new Definition()
                                .Line("Upper outer quadrant location adjacent to the axilla but within the breast mound")
                            )
                    });

                SliceAndBind("quadrant", binding.Url);
            }

            {
                ValueSet binding = this.CreateValueSet(
                    "BreastLocationClock",
                    "Breast Location Clock",
                    new Markdown()
                        .Paragraph("Breast Location Clock"),
                    new ConceptDef[]
                    {
                        new ConceptDef("12-OClock",
                            "12-OClock",
                            new Definition()
                                .Line("12-OClock")
                            ),
                        new ConceptDef("12:30-OClock",
                            "12:30-OClock",
                            new Definition()
                                .Line("12:30-OClock")
                            ),
                        new ConceptDef("1:00-OClock",
                            "1:00-OClock",
                            new Definition()
                                .Line("1:00-OClock")
                            ),
                        new ConceptDef("1:30-OClock",
                            "1:30-OClock",
                            new Definition()
                                .Line("1:30-OClock")
                            ),
                        new ConceptDef("2:00-OClock",
                            "2:00-OClock",
                            new Definition()
                                .Line("2:00-OClock")
                            ),
                        new ConceptDef("2:30-OClock",
                            "2:30-OClock",
                            new Definition()
                                .Line("2:30-OClock")
                            ),
                        new ConceptDef("3:00-OClock",
                            "3:00-OClock",
                            new Definition()
                                .Line("3:00-OClock")
                            ),
                        new ConceptDef("3:30-OClock",
                            "3:30-OClock",
                            new Definition()
                                .Line("3:30-OClock")
                            ),
                        new ConceptDef("4:00-OClock",
                            "4:00-OClock",
                            new Definition()
                                .Line("4:00-OClock")
                            ),
                        new ConceptDef("4:30-OClock",
                            "4:30-OClock",
                            new Definition()
                                .Line("4:30-OClock")
                            ),
                        new ConceptDef("5:00-OClock",
                            "5:00-OClock",
                            new Definition()
                                .Line("5:00-OClock")
                            ),
                        new ConceptDef("5:30-OClock",
                            "5:30-OClock",
                            new Definition()
                                .Line("5:30-OClock")
                            ),
                        new ConceptDef("6:00-OClock",
                            "6:00-OClock",
                            new Definition()
                                .Line("6:00-OClock")
                            ),
                        new ConceptDef("6:30-OClock",
                            "6:30-OClock",
                            new Definition()
                                .Line("6:30-OClock")
                            ),
                        new ConceptDef("7:00-OClock",
                            "7:00-OClock",
                            new Definition()
                                .Line("7:00-OClock")
                            ),
                        new ConceptDef("7:30-OClock",
                            "7:30-OClock",
                            new Definition()
                                .Line("7:30-OClock")
                            ),
                        new ConceptDef("8:00-OClock",
                            "8:00-OClock",
                            new Definition()
                                .Line("8:00-OClock")
                            ),
                        new ConceptDef("8:30-OClock",
                            "8:30-OClock",
                            new Definition()
                                .Line("8:30-OClock")
                            ),
                        new ConceptDef("9:00-OClock",
                            "9:00-OClock",
                            new Definition()
                                .Line("9:00-OClock")
                            ),
                        new ConceptDef("9:30-OClock",
                            "9:30-OClock",
                            new Definition()
                                .Line("9:30-OClock")
                            ),
                        new ConceptDef("10:00-OClock",
                            "10:00-OClock",
                            new Definition()
                                .Line("10:00-OClock")
                            ),
                        new ConceptDef("10:30-OClock",
                            "10:30-OClock",
                            new Definition()
                                .Line("10:30-OClock")
                            ),
                        new ConceptDef("11:00-OClock",
                            "11:00-OClock",
                            new Definition()
                                .Line("11:00-OClock")
                            ),
                        new ConceptDef("11:30-OClock",
                            "11:30-OClock",
                            new Definition()
                                .Line("11:30-OClock")
                            )
                    });

                SliceAndBind("clockDirection", binding.Url);
            }

            {
                ValueSet binding = this.CreateValueSet(
                    "BreastLocationDepth",
                    "Breast Location Depth",
                    new Markdown()
                        .Paragraph("Breast Location Depth"),
                    new ConceptDef[]
                    {
                        new ConceptDef("Anterior",
                            "Anterior depth",
                            new Definition()
                                .Line("Anterior depth")
                            ),
                        new ConceptDef("Middle",
                            "Middle depth",
                            new Definition()
                                .Line("Middle depth")
                            ),
                        new ConceptDef("Posterior",
                            "Posterior depth",
                            new Definition()
                                .Line("Posterior depth")
                            )
                    });

                SliceAndBind("depth", binding.Url);
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

                e.IntroDoc.ReviewedStatus(ReviewStatus.NotReviewed).Extension("Breast Body Location", "define a location in the breast");
            }
        }
    }
}
