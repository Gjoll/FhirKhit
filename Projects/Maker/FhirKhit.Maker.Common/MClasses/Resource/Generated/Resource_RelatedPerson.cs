using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'RelatedPerson'
    /// </summary>
    // 0. RelatedPerson
    public class Resource_RelatedPerson : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 12. RelatedPerson.communication
        public class Type_Communication : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 13. RelatedPerson.communication.language
            public ElementDefinitionInfo Element_Language;                                                                                  // MakerGen.cs:212
            // 14. RelatedPerson.communication.preferred
            public ElementDefinitionInfo Element_Preferred;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "RelatedPerson.communication",                                                                                   // MakerGen.cs:388
                    ElementId = "RelatedPerson.communication"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Language.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Preferred.Write(sDef);                                                                                              // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Communication()                                                                                                     // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 13. RelatedPerson.communication.language
                    this.Element_Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Language",                                                                                          // MakerGen.cs:231
                        Path= "RelatedPerson.communication.language",                                                                       // MakerGen.cs:232
                        Id = "RelatedPerson.communication.language",                                                                        // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. RelatedPerson.communication.preferred
                    this.Element_Preferred = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Preferred",                                                                                         // MakerGen.cs:231
                        Path= "RelatedPerson.communication.preferred",                                                                      // MakerGen.cs:232
                        Id = "RelatedPerson.communication.preferred",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. RelatedPerson.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. RelatedPerson.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:212
        // 3. RelatedPerson.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 4. RelatedPerson.relationship
        public ElementDefinitionInfo Element_Relationship;                                                                                  // MakerGen.cs:212
        // 5. RelatedPerson.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 6. RelatedPerson.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:212
        // 7. RelatedPerson.gender
        public ElementDefinitionInfo Element_Gender;                                                                                        // MakerGen.cs:212
        // 8. RelatedPerson.birthDate
        public ElementDefinitionInfo Element_BirthDate;                                                                                     // MakerGen.cs:212
        // 9. RelatedPerson.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:212
        // 10. RelatedPerson.photo
        public ElementDefinitionInfo Element_Photo;                                                                                         // MakerGen.cs:212
        // 11. RelatedPerson.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 12. RelatedPerson.communication
        public ElementDefinitionInfo Element_Communication;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "RelatedPerson",                                                                                                     // MakerGen.cs:388
                ElementId = "RelatedPerson"                                                                                                 // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Relationship.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Gender.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_BirthDate.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Photo.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Communication.Write(sDef);                                                                                              // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_RelatedPerson()                                                                                                     // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. RelatedPerson.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "RelatedPerson.identifier",                                                                                       // MakerGen.cs:232
                    Id = "RelatedPerson.identifier",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. RelatedPerson.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Active",                                                                                                // MakerGen.cs:231
                    Path= "RelatedPerson.active",                                                                                           // MakerGen.cs:232
                    Id = "RelatedPerson.active",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. RelatedPerson.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "RelatedPerson.patient",                                                                                          // MakerGen.cs:232
                    Id = "RelatedPerson.patient",                                                                                           // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. RelatedPerson.relationship
                this.Element_Relationship = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Relationship",                                                                                          // MakerGen.cs:231
                    Path= "RelatedPerson.relationship",                                                                                     // MakerGen.cs:232
                    Id = "RelatedPerson.relationship",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. RelatedPerson.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "RelatedPerson.name",                                                                                             // MakerGen.cs:232
                    Id = "RelatedPerson.name",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                    // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. RelatedPerson.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:231
                    Path= "RelatedPerson.telecom",                                                                                          // MakerGen.cs:232
                    Id = "RelatedPerson.telecom",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. RelatedPerson.gender
                this.Element_Gender = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Gender",                                                                                                // MakerGen.cs:231
                    Path= "RelatedPerson.gender",                                                                                           // MakerGen.cs:232
                    Id = "RelatedPerson.gender",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. RelatedPerson.birthDate
                this.Element_BirthDate = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_BirthDate",                                                                                             // MakerGen.cs:231
                    Path= "RelatedPerson.birthDate",                                                                                        // MakerGen.cs:232
                    Id = "RelatedPerson.birthDate",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. RelatedPerson.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Address",                                                                                               // MakerGen.cs:231
                    Path= "RelatedPerson.address",                                                                                          // MakerGen.cs:232
                    Id = "RelatedPerson.address",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Address                                                                      // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. RelatedPerson.photo
                this.Element_Photo = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Photo",                                                                                                 // MakerGen.cs:231
                    Path= "RelatedPerson.photo",                                                                                            // MakerGen.cs:232
                    Id = "RelatedPerson.photo",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. RelatedPerson.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "RelatedPerson.period",                                                                                           // MakerGen.cs:232
                    Id = "RelatedPerson.period",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. RelatedPerson.communication
                this.Element_Communication = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Communication",                                                                                         // MakerGen.cs:231
                    Path= "RelatedPerson.communication",                                                                                    // MakerGen.cs:232
                    Id = "RelatedPerson.communication",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Communication                                                                                              // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "RelatedPerson";                                                                                                    // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RelatedPerson";                                                             // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
