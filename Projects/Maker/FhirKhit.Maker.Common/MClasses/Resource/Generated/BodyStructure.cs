using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'BodyStructure'
    /// </summary>
    // 0. BodyStructure
    public class BodyStructure : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class BodyStructure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. BodyStructure.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. BodyStructure.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:211
            // 3. BodyStructure.morphology
            public ElementDefinitionInfo Morphology;                                                                                        // MakerGen.cs:211
            // 4. BodyStructure.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:211
            // 5. BodyStructure.locationQualifier
            public ElementDefinitionInfo LocationQualifier;                                                                                 // MakerGen.cs:211
            // 6. BodyStructure.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 7. BodyStructure.image
            public ElementDefinitionInfo Image;                                                                                             // MakerGen.cs:211
            // 8. BodyStructure.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public BodyStructure_Elements()                                                                                                 // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. BodyStructure.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "BodyStructure.identifier",                                                                                   // MakerGen.cs:231
                        Id = "BodyStructure.identifier",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. BodyStructure.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Active",                                                                                                    // MakerGen.cs:230
                        Path= "BodyStructure.active",                                                                                       // MakerGen.cs:231
                        Id = "BodyStructure.active",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. BodyStructure.morphology
                    this.Morphology = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Morphology",                                                                                                // MakerGen.cs:230
                        Path= "BodyStructure.morphology",                                                                                   // MakerGen.cs:231
                        Id = "BodyStructure.morphology",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. BodyStructure.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Location",                                                                                                  // MakerGen.cs:230
                        Path= "BodyStructure.location",                                                                                     // MakerGen.cs:231
                        Id = "BodyStructure.location",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. BodyStructure.locationQualifier
                    this.LocationQualifier = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LocationQualifier",                                                                                         // MakerGen.cs:230
                        Path= "BodyStructure.locationQualifier",                                                                            // MakerGen.cs:231
                        Id = "BodyStructure.locationQualifier",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. BodyStructure.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "BodyStructure.description",                                                                                  // MakerGen.cs:231
                        Id = "BodyStructure.description",                                                                                   // MakerGen.cs:232
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
                    // 7. BodyStructure.image
                    this.Image = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Image",                                                                                                     // MakerGen.cs:230
                        Path= "BodyStructure.image",                                                                                        // MakerGen.cs:231
                        Id = "BodyStructure.image",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. BodyStructure.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Patient",                                                                                                   // MakerGen.cs:230
                        Path= "BodyStructure.patient",                                                                                      // MakerGen.cs:231
                        Id = "BodyStructure.patient",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Active.Write(sDef);                                                                                                         // MakerGen.cs:215
                Morphology.Write(sDef);                                                                                                     // MakerGen.cs:215
                Location.Write(sDef);                                                                                                       // MakerGen.cs:215
                LocationQualifier.Write(sDef);                                                                                              // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                Image.Write(sDef);                                                                                                          // MakerGen.cs:215
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public BodyStructure_Elements Elements                                                                                              // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new BodyStructure_Elements();                                                                           // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        BodyStructure_Elements elements;                                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public BodyStructure()                                                                                                              // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "BodyStructure";                                                                                                    // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BodyStructure";                                                             // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "BodyStructure",                                                                                                     // MakerGen.cs:423
                ElementId = "BodyStructure"                                                                                                 // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
