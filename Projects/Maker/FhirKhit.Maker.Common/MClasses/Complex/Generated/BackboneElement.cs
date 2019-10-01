using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "BackboneElement",
      "url": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "version": "4.0.0",
      "name": "BackboneElement",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for BackboneElement Type: Base definition for all elements that are defined inside a resource - but not those in a data type.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": true,
      "type": "BackboneElement",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "BackboneElement",
            "path": "BackboneElement",
            "short": "Base for elements defined inside a resource",
            "definition": "Base definition for all elements that are defined inside a resource - but not those in a data type.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "BackboneElement.modifierExtension",
            "path": "BackboneElement.modifierExtension",
            "short": "Extensions that cannot be ignored even if unrecognized",
            "definition": "May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.\n\nModifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).",
            "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
            "requirements": "Modifier extensions allow for extensions that *cannot* be safely ignored to be clearly distinguished from the vast majority of extensions which can be safely ignored.  This promotes interoperability by eliminating the need for implementers to prohibit the presence of extensions. For further information, see the [definition of modifier extensions](extensibility.html#modifierExtension).",
            "alias": [
              "extensions",
              "user content",
              "modifiers"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Extension"
              }
            ],
            "isModifier": true,
            "isModifierReason": "Modifier extensions are expected to modify the meaning or interpretation of the element that contains them",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'BackboneElement'
    /// </summary>
    // 0. BackboneElement
    public class BackboneElement : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class BackboneElement_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. BackboneElement.modifierExtension
            public ElementDefinitionInfo ModifierExtension;                                                                                 // MakerGen.cs:216
            public BackboneElement_Elements()                                                                                               // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. BackboneElement.modifierExtension
                    this.ModifierExtension = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ModifierExtension",                                                                                         // MakerGen.cs:235
                        Path= "BackboneElement.modifierExtension",                                                                          // MakerGen.cs:236
                        Id = "BackboneElement.modifierExtension",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                ModifierExtension.Write(sDef);                                                                                              // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public BackboneElement_Elements Elements { get; }                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public BackboneElement()                                                                                                            // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new BackboneElement_Elements();                                                                                 // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
