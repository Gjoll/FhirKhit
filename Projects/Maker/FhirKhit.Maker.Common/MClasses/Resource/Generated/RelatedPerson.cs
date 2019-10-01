using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "RelatedPerson",
      "url": "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
      "version": "4.0.0",
      "name": "RelatedPerson",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process.",
      "purpose": "Need to track persons related to the patient or the healthcare process.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "RelatedPerson",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "RelatedPerson",
            "path": "RelatedPerson",
            "short": "A person that is related to a patient, but who is not a direct target of care",
            "definition": "Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "RelatedPerson.identifier",
            "path": "RelatedPerson.identifier",
            "short": "A human identifier for this person",
            "definition": "Identifier for a person within a particular scope.",
            "requirements": "People are known by a variety of ids. Some institutions maintain several, and most collect identifiers for exchange with other organizations concerning the patient. Examples are national person identifier and local identifier.",
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
            "id": "RelatedPerson.active",
            "path": "RelatedPerson.active",
            "short": "Whether this related person's record is in active use",
            "definition": "Whether this related person record is in active use.",
            "comment": "This element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "requirements": "Need to be able to mark a related person record as not to be used, such as if it was created in error.",
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
            "id": "RelatedPerson.patient",
            "path": "RelatedPerson.patient",
            "short": "The patient this person is related to",
            "definition": "The patient this person is related to.",
            "requirements": "We need to know which patient this RelatedPerson is related to.",
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
          },
          {
            "id": "RelatedPerson.relationship",
            "path": "RelatedPerson.relationship",
            "short": "The nature of the relationship",
            "definition": "The nature of the relationship between a patient and the related person.",
            "requirements": "We need to know the relationship with the patient since it influences the interpretation of the information attributed to this person.",
            "min": 0,
            "max": "*",
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
                  "valueString": "PatientRelationshipType"
                }
              ],
              "strength": "preferred",
              "description": "The nature of the relationship between a patient and the related person.",
              "valueSet": "http://hl7.org/fhir/ValueSet/relatedperson-relationshiptype"
            }
          },
          {
            "id": "RelatedPerson.name",
            "path": "RelatedPerson.name",
            "short": "A name associated with the person",
            "definition": "A name associated with the person.",
            "requirements": "Related persons need to be identified by name, but it is uncommon to need details about multiple other names for that person.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "HumanName"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedPerson.telecom",
            "path": "RelatedPerson.telecom",
            "short": "A contact detail for the person",
            "definition": "A contact detail for the person, e.g. a telephone number or an email address.",
            "comment": "Person may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently, and also to help with identification.",
            "requirements": "People have (primary) ways to contact them in some way such as phone, email.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedPerson.gender",
            "path": "RelatedPerson.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.",
            "requirements": "Needed for identification of the person, in combination with (at least) name and birth date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AdministrativeGender"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The gender of a person used for administrative purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/administrative-gender|4.0.0"
            }
          },
          {
            "id": "RelatedPerson.birthDate",
            "path": "RelatedPerson.birthDate",
            "short": "The date on which the related person was born",
            "definition": "The date on which the related person was born.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedPerson.address",
            "path": "RelatedPerson.address",
            "short": "Address where the related person can be contacted or visited",
            "definition": "Address where the related person can be contacted or visited.",
            "requirements": "Need to keep track where the related person can be contacted per postal mail or visited.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Address"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RelatedPerson.photo",
            "path": "RelatedPerson.photo",
            "short": "Image of the person",
            "definition": "Image of the person.",
            "requirements": "Many EHR systems have the capability to capture an image of persons. Fits with newer social media usage too.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "RelatedPerson.period",
            "path": "RelatedPerson.period",
            "short": "Period of time that this relationship is considered valid",
            "definition": "The period of time during which this relationship is or was active. If there are no dates defined, then the interval is unknown.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "RelatedPerson.communication",
            "path": "RelatedPerson.communication",
            "short": "A language which may be used to communicate with about the patient's health",
            "definition": "A language which may be used to communicate with about the patient's health.",
            "comment": "If no language is specified, this *implies* that the default local language is spoken.  If you need to convey proficiency for multiple modes, then you need multiple RelatedPerson.Communication associations.   If the RelatedPerson does not speak the default local language, then the Interpreter Required Standard can be used to explicitly declare that an interpreter is required.",
            "requirements": "If a related person does not speak the local language, interpreters may be required, so languages spoken and proficiency is an important things to keep track of both for patient and other persons of interest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RelatedPerson.communication.language",
            "path": "RelatedPerson.communication.language",
            "short": "The language which can be used to communicate with the patient about his or her health",
            "definition": "The ISO-639-1 alpha 2 code in lower case for the language, optionally followed by a hyphen and the ISO-3166-1 alpha 2 code for the region in upper case; e.g. \"en\" for English, or \"en-US\" for American English versus \"en-EN\" for England English.",
            "comment": "The structure aa-BB with this exact casing is one the most widely used notations for locale. However not all systems actually code this but instead have it as free text. Hence CodeableConcept instead of code as the data type.",
            "requirements": "Most systems in multilingual countries will want to convey language. Not all systems actually need the regional dialect.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Language"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "A human language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/languages"
            }
          },
          {
            "id": "RelatedPerson.communication.preferred",
            "path": "RelatedPerson.communication.preferred",
            "short": "Language preference indicator",
            "definition": "Indicates whether or not the patient prefers this language (over other languages he masters up a certain level).",
            "comment": "This language is specifically identified for communicating healthcare information.",
            "requirements": "People that master multiple languages up to certain level may prefer one or more, i.e. feel more confident in communicating in a particular language making other languages sort of a fall back method.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'RelatedPerson'
    /// </summary>
    // 0. RelatedPerson
    public class RelatedPerson : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class RelatedPerson_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 12. RelatedPerson.communication
            public class Type_Communication : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Communication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 13. RelatedPerson.communication.language
                    public ElementDefinitionInfo Language;                                                                                  // MakerGen.cs:216
                    // 14. RelatedPerson.communication.preferred
                    public ElementDefinitionInfo Preferred;                                                                                 // MakerGen.cs:216
                    public Type_Communication_Elements()                                                                                    // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. RelatedPerson.communication.language
                            this.Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Language",                                                                                          // MakerGen.cs:235
                                Path= "RelatedPerson.communication.language",                                                               // MakerGen.cs:236
                                Id = "RelatedPerson.communication.language",                                                                // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. RelatedPerson.communication.preferred
                            this.Preferred = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Preferred",                                                                                         // MakerGen.cs:235
                                Path= "RelatedPerson.communication.preferred",                                                              // MakerGen.cs:236
                                Id = "RelatedPerson.communication.preferred",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Language.Write(sDef);                                                                                               // MakerGen.cs:220
                        Preferred.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Communication_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Communication()                                                                                                 // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Communication_Elements();                                                                      // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. RelatedPerson.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. RelatedPerson.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:216
            // 3. RelatedPerson.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 4. RelatedPerson.relationship
            public ElementDefinitionInfo Relationship;                                                                                      // MakerGen.cs:216
            // 5. RelatedPerson.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 6. RelatedPerson.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:216
            // 7. RelatedPerson.gender
            public ElementDefinitionInfo Gender;                                                                                            // MakerGen.cs:216
            // 8. RelatedPerson.birthDate
            public ElementDefinitionInfo BirthDate;                                                                                         // MakerGen.cs:216
            // 9. RelatedPerson.address
            public ElementDefinitionInfo Address;                                                                                           // MakerGen.cs:216
            // 10. RelatedPerson.photo
            public ElementDefinitionInfo Photo;                                                                                             // MakerGen.cs:216
            // 11. RelatedPerson.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 12. RelatedPerson.communication
            public ElementDefinitionInfo Communication;                                                                                     // MakerGen.cs:216
            public RelatedPerson_Elements()                                                                                                 // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. RelatedPerson.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "RelatedPerson.identifier",                                                                                   // MakerGen.cs:236
                        Id = "RelatedPerson.identifier",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. RelatedPerson.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Active",                                                                                                    // MakerGen.cs:235
                        Path= "RelatedPerson.active",                                                                                       // MakerGen.cs:236
                        Id = "RelatedPerson.active",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. RelatedPerson.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "RelatedPerson.patient",                                                                                      // MakerGen.cs:236
                        Id = "RelatedPerson.patient",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. RelatedPerson.relationship
                    this.Relationship = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Relationship",                                                                                              // MakerGen.cs:235
                        Path= "RelatedPerson.relationship",                                                                                 // MakerGen.cs:236
                        Id = "RelatedPerson.relationship",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. RelatedPerson.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "RelatedPerson.name",                                                                                         // MakerGen.cs:236
                        Id = "RelatedPerson.name",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. RelatedPerson.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Telecom",                                                                                                   // MakerGen.cs:235
                        Path= "RelatedPerson.telecom",                                                                                      // MakerGen.cs:236
                        Id = "RelatedPerson.telecom",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. RelatedPerson.gender
                    this.Gender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Gender",                                                                                                    // MakerGen.cs:235
                        Path= "RelatedPerson.gender",                                                                                       // MakerGen.cs:236
                        Id = "RelatedPerson.gender",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. RelatedPerson.birthDate
                    this.BirthDate = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BirthDate",                                                                                                 // MakerGen.cs:235
                        Path= "RelatedPerson.birthDate",                                                                                    // MakerGen.cs:236
                        Id = "RelatedPerson.birthDate",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. RelatedPerson.address
                    this.Address = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Address",                                                                                                   // MakerGen.cs:235
                        Path= "RelatedPerson.address",                                                                                      // MakerGen.cs:236
                        Id = "RelatedPerson.address",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. RelatedPerson.photo
                    this.Photo = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Photo",                                                                                                     // MakerGen.cs:235
                        Path= "RelatedPerson.photo",                                                                                        // MakerGen.cs:236
                        Id = "RelatedPerson.photo",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. RelatedPerson.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "RelatedPerson.period",                                                                                       // MakerGen.cs:236
                        Id = "RelatedPerson.period",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. RelatedPerson.communication
                    this.Communication = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Communication",                                                                                             // MakerGen.cs:235
                        Path= "RelatedPerson.communication",                                                                                // MakerGen.cs:236
                        Id = "RelatedPerson.communication",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Communication                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Active.Write(sDef);                                                                                                         // MakerGen.cs:220
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                Relationship.Write(sDef);                                                                                                   // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:220
                Gender.Write(sDef);                                                                                                         // MakerGen.cs:220
                BirthDate.Write(sDef);                                                                                                      // MakerGen.cs:220
                Address.Write(sDef);                                                                                                        // MakerGen.cs:220
                Photo.Write(sDef);                                                                                                          // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                Communication.Write(sDef);                                                                                                  // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public RelatedPerson_Elements Elements { get; }                                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public RelatedPerson()                                                                                                              // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new RelatedPerson_Elements();                                                                                   // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
