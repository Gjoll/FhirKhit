using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Identifier",
      "url": "http://hl7.org/fhir/StructureDefinition/Identifier",
      "version": "4.0.0",
      "name": "Identifier",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Identifier Type: An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.",
      "purpose": "Need to be able to identify things with confidence and be sure that the identification is not subject to misinterpretation.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Identifier",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Identifier",
            "path": "Identifier",
            "short": "An identifier intended for computation",
            "definition": "An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Identifier.use",
            "path": "Identifier.use",
            "short": "usual | official | temp | secondary | old (If known)",
            "definition": "The purpose of this identifier.",
            "comment": "Applications can assume that an identifier is permanent unless it explicitly says that it is temporary.",
            "requirements": "Allows the appropriate identifier for a particular context of use to be selected from among a set of identifiers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary id for a permanent one.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "IdentifierUse"
                }
              ],
              "strength": "required",
              "description": "Identifies the purpose for this identifier, if known .",
              "valueSet": "http://hl7.org/fhir/ValueSet/identifier-use|4.0.0"
            }
          },
          {
            "id": "Identifier.type",
            "path": "Identifier.type",
            "short": "Description of identifier",
            "definition": "A coded type for the identifier that can be used to determine which identifier to use for a specific purpose.",
            "comment": "This element deals only with general categories of identifiers.  It SHOULD not be used for codes that correspond 1..1 with the Identifier.system. Some identifiers may fall into multiple categories due to common usage.   Where the system is known, a type is unnecessary because the type is always part of the system definition. However systems often need to handle identifiers where the system is not known. There is not a 1:1 relationship between type and system, since many different systems have the same type.",
            "requirements": "Allows users to make use of identifiers when the identifier system is not known.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "IdentifierType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "A coded type for an identifier that can be used to determine which identifier to use for a specific purpose.",
              "valueSet": "http://hl7.org/fhir/ValueSet/identifier-type"
            }
          },
          {
            "id": "Identifier.system",
            "path": "Identifier.system",
            "short": "The namespace for the identifier value",
            "definition": "Establishes the namespace for the value - that is, a URL that describes a set values that are unique.",
            "comment": "Identifier.system is always case sensitive.",
            "requirements": "There are many sets  of identifiers.  To perform matching of two identifiers, we need to know what set we're dealing with. The system identifies a particular set of unique identifiers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueUri": "http://www.acme.com/identifiers/patient"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Identifier.value",
            "path": "Identifier.value",
            "short": "The value that is unique",
            "definition": "The portion of the identifier typically relevant to the user and which is unique within the context of the system.",
            "comment": "If the value is a full URI, then the system SHALL be urn:ietf:rfc:3986.  The value's primary purpose is computational mapping.  As a result, it may be normalized for comparison purposes (e.g. removing non-significant whitespace, dashes, etc.)  A value formatted for human display can be conveyed using the [Rendered Value extension](extension-rendered-value.html). Identifier.value is to be treated as case sensitive unless knowledge of the Identifier.system allows the processer to be confident that non-case-sensitive processing is safe.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "123456"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Identifier.period",
            "path": "Identifier.period",
            "short": "Time period when id is/was valid for use",
            "definition": "Time period during which identifier is/was valid for use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Identifier.assigner",
            "path": "Identifier.assigner",
            "short": "Organization that issued id (may be just text)",
            "definition": "Organization that issued/manages the identifier.",
            "comment": "The Identifier.assigner may omit the .reference element and only contain a .display element reflecting the name or other textual information about the assigning organization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'Identifier'
    /// </summary>
    // 0. Identifier
    public class Type_Identifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Identifier_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. Identifier.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 2. Identifier.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 3. Identifier.system
            public ElementDefinitionInfo Element_System;                                                                                    // MakerGen.cs:211
            // 4. Identifier.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:211
            // 5. Identifier.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
            // 6. Identifier.assigner
            public ElementDefinitionInfo Element_Assigner;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Identifier_Elements()                                                                                               // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Identifier.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "Identifier.use",                                                                                             // MakerGen.cs:231
                        Id = "Identifier.use",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Identifier.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "Identifier.type",                                                                                            // MakerGen.cs:231
                        Id = "Identifier.type",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Identifier.system
                    this.Element_System = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_System",                                                                                            // MakerGen.cs:230
                        Path= "Identifier.system",                                                                                          // MakerGen.cs:231
                        Id = "Identifier.system",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Identifier.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Value",                                                                                             // MakerGen.cs:230
                        Path= "Identifier.value",                                                                                           // MakerGen.cs:231
                        Id = "Identifier.value",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Identifier.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "Identifier.period",                                                                                          // MakerGen.cs:231
                        Id = "Identifier.period",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Identifier.assigner
                    this.Element_Assigner = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Assigner",                                                                                          // MakerGen.cs:230
                        Path= "Identifier.assigner",                                                                                        // MakerGen.cs:231
                        Id = "Identifier.assigner",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Use.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_System.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Assigner.Write(sDef);                                                                                               // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Identifier_Elements Elements                                                                                            // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Identifier_Elements();                                                                         // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Identifier_Elements elements;                                                                                                  // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Identifier()                                                                                                            // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Identifier",                                                                                                        // MakerGen.cs:420
                ElementId = "Identifier"                                                                                                    // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
