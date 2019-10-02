using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
    {
      "resourceType": "StructureDefinition",
      "id": "BodyStructure",
      "url": "http://hl7.org/fhir/StructureDefinition/BodyStructure",
      "version": "4.0.0",
      "name": "BodyStructure",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "BodyStructure",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "BodyStructure",
            "path": "BodyStructure",
            "short": "Specific and identified anatomical structure",
            "definition": "Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.",
            "alias": [
              "anatomical location"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "BodyStructure.identifier",
            "path": "BodyStructure.identifier",
            "short": "Bodystructure identifier",
            "definition": "Identifier for this instance of the anatomical structure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "BodyStructure.active",
            "path": "BodyStructure.active",
            "short": "Whether this record is in active use",
            "definition": "Whether this body site is in active use.",
            "comment": "This element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "requirements": "Need to be able to mark a body site entry as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that can indicate that a record should not be treated as valid",
            "isSummary": true
          },
          {
            "id": "BodyStructure.morphology",
            "path": "BodyStructure.morphology",
            "short": "Kind of Structure",
            "definition": "The kind of structure being represented by the body structure at `BodyStructure.location`.  This can define both normal and abnormal morphologies.",
            "comment": "The minimum cardinality of 0 supports the use case of specifying a location without defining a morphology.",
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
                  "valueString": "BodyStructureCode"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomic morphology.",
              "valueSet": "http://hl7.org/fhir/ValueSet/bodystructure-code"
            }
          },
          {
            "id": "BodyStructure.location",
            "path": "BodyStructure.location",
            "short": "Body site",
            "definition": "The anatomical location or region of the specimen, lesion, or body structure.",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "BodyStructure.locationQualifier",
            "path": "BodyStructure.locationQualifier",
            "short": "Body site modifier",
            "definition": "Qualifier to refine the anatomical location.  These include qualifiers for laterality, relative location, directionality, number, and plane.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BodyStructureQualifier"
                }
              ],
              "strength": "example",
              "description": "Concepts modifying the anatomic location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/bodystructure-relative-location"
            }
          },
          {
            "id": "BodyStructure.description",
            "path": "BodyStructure.description",
            "short": "Text description",
            "definition": "A summary, characterization or explanation of the body structure.",
            "comment": "This description could include any visual markings used to orientate the viewer e.g. external reference points, special sutures, ink markings.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "BodyStructure.image",
            "path": "BodyStructure.image",
            "short": "Attached images",
            "definition": "Image or images used to identify a location.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "BodyStructure.patient",
            "path": "BodyStructure.patient",
            "short": "Who this is about",
            "definition": "The person to which the body site belongs.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'BodyStructure'
    /// </summary>
    // 0. BodyStructure
    public class Resource_BodyStructure : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. BodyStructure.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. BodyStructure.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:219
        // 3. BodyStructure.morphology
        public ElementDefinitionInfo Element_Morphology;                                                                                    // MakerGen.cs:219
        // 4. BodyStructure.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:219
        // 5. BodyStructure.locationQualifier
        public ElementDefinitionInfo Element_LocationQualifier;                                                                             // MakerGen.cs:219
        // 6. BodyStructure.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:219
        // 7. BodyStructure.image
        public ElementDefinitionInfo Element_Image;                                                                                         // MakerGen.cs:219
        // 8. BodyStructure.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "BodyStructure",                                                                                                     // MakerGen.cs:395
                ElementId = "BodyStructure"                                                                                                 // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Morphology.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_LocationQualifier.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Image.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_BodyStructure()                                                                                                     // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. BodyStructure.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "BodyStructure.identifier",                                                                                       // MakerGen.cs:239
                    Id = "BodyStructure.identifier",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. BodyStructure.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Active",                                                                                                // MakerGen.cs:238
                    Path= "BodyStructure.active",                                                                                           // MakerGen.cs:239
                    Id = "BodyStructure.active",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. BodyStructure.morphology
                this.Element_Morphology = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Morphology",                                                                                            // MakerGen.cs:238
                    Path= "BodyStructure.morphology",                                                                                       // MakerGen.cs:239
                    Id = "BodyStructure.morphology",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. BodyStructure.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Location",                                                                                              // MakerGen.cs:238
                    Path= "BodyStructure.location",                                                                                         // MakerGen.cs:239
                    Id = "BodyStructure.location",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. BodyStructure.locationQualifier
                this.Element_LocationQualifier = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_LocationQualifier",                                                                                     // MakerGen.cs:238
                    Path= "BodyStructure.locationQualifier",                                                                                // MakerGen.cs:239
                    Id = "BodyStructure.locationQualifier",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. BodyStructure.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Description",                                                                                           // MakerGen.cs:238
                    Path= "BodyStructure.description",                                                                                      // MakerGen.cs:239
                    Id = "BodyStructure.description",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. BodyStructure.image
                this.Element_Image = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Image",                                                                                                 // MakerGen.cs:238
                    Path= "BodyStructure.image",                                                                                            // MakerGen.cs:239
                    Id = "BodyStructure.image",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. BodyStructure.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "BodyStructure.patient",                                                                                          // MakerGen.cs:239
                    Id = "BodyStructure.patient",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "BodyStructure";                                                                                                    // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BodyStructure";                                                             // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
