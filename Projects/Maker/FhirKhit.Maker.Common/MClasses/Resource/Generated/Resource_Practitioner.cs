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
      "id": "Practitioner",
      "url": "http://hl7.org/fhir/StructureDefinition/Practitioner",
      "version": "4.0.0",
      "name": "Practitioner",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A person who is directly or indirectly involved in the provisioning of healthcare.",
      "purpose": "Need to track doctors, staff, locums etc. for both healthcare practitioners, funders, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Practitioner",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Practitioner",
            "path": "Practitioner",
            "short": "A person with a  formal responsibility in the provisioning of healthcare or related services",
            "definition": "A person who is directly or indirectly involved in the provisioning of healthcare.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Practitioner.identifier",
            "path": "Practitioner.identifier",
            "short": "An identifier for the person as this agent",
            "definition": "An identifier that applies to this person in this role.",
            "requirements": "Often, specific identities are assigned for the agent.",
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
            "id": "Practitioner.active",
            "path": "Practitioner.active",
            "short": "Whether this practitioner's record is in active use",
            "definition": "Whether this practitioner's record is in active use.",
            "comment": "If the practitioner is not in use by one organization, then it should mark the period on the PractitonerRole with an end date (even if they are active) as they may be active in another role.",
            "requirements": "Need to be able to mark a practitioner record as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isSummary": true
          },
          {
            "id": "Practitioner.name",
            "path": "Practitioner.name",
            "short": "The name(s) associated with the practitioner",
            "definition": "The name(s) associated with the practitioner.",
            "comment": "The selection of the use property should ensure that there is a single usual name specified, and others use the nickname (alias), old, or other values as appropriate.  \r\rIn general, select the value to be used in the ResourceReference.display based on this:\r\r1. There is more than 1 name\r2. Use = usual\r3. Period is current to the date of the usage\r4. Use = official\r5. Other order as decided by internal business rules.",
            "requirements": "The name(s) that a Practitioner is known by. Where there are multiple, the name that the practitioner is usually known as should be used in the display.",
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
            "id": "Practitioner.telecom",
            "path": "Practitioner.telecom",
            "short": "A contact detail for the practitioner (that apply to all roles)",
            "definition": "A contact detail for the practitioner, e.g. a telephone number or an email address.",
            "comment": "Person may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently and to help with identification.  These typically will have home numbers, or mobile numbers that are not role specific.",
            "requirements": "Need to know how to reach a practitioner independent to any roles the practitioner may have.",
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
            "id": "Practitioner.address",
            "path": "Practitioner.address",
            "short": "Address(es) of the practitioner that are not role specific (typically home address)",
            "definition": "Address(es) of the practitioner that are not role specific (typically home address). \rWork addresses are not typically entered in this property as they are usually role dependent.",
            "comment": "The PractitionerRole does not have an address value on it, as it is expected that the location property be used for this purpose (which has an address).",
            "requirements": "The home/mailing address of the practitioner is often required for employee administration purposes, and also for some rostering services where the start point (practitioners home) can be used in calculations.",
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
            "id": "Practitioner.gender",
            "path": "Practitioner.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.",
            "requirements": "Needed to address the person correctly.",
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
            "id": "Practitioner.birthDate",
            "path": "Practitioner.birthDate",
            "short": "The date  on which the practitioner was born",
            "definition": "The date of birth for the practitioner.",
            "requirements": "Needed for identification.",
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
            "id": "Practitioner.photo",
            "path": "Practitioner.photo",
            "short": "Image of the person",
            "definition": "Image of the person.",
            "requirements": "Many EHR systems have the capability to capture an image of patients and personnel. Fits with newer social media usage too.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "Practitioner.qualification",
            "path": "Practitioner.qualification",
            "short": "Certification, licenses, or training pertaining to the provision of care",
            "definition": "The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.  For example, a medical license issued by a medical board authorizing the practitioner to practice medicine within a certian locality.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.identifier",
            "path": "Practitioner.qualification.identifier",
            "short": "An identifier for this qualification for the practitioner",
            "definition": "An identifier that applies to this person's qualification in this role.",
            "requirements": "Often, specific identities are assigned for the qualification.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.code",
            "path": "Practitioner.qualification.code",
            "short": "Coded representation of the qualification",
            "definition": "Coded representation of the qualification.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Qualification"
                }
              ],
              "strength": "example",
              "description": "Specific qualification the practitioner has to provide a service.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-2.7-0360"
            }
          },
          {
            "id": "Practitioner.qualification.period",
            "path": "Practitioner.qualification.period",
            "short": "Period during which the qualification is valid",
            "definition": "Period during which the qualification is valid.",
            "requirements": "Qualifications are often for a limited period of time, and can be revoked.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.issuer",
            "path": "Practitioner.qualification.issuer",
            "short": "Organization that regulates and issues the qualification",
            "definition": "Organization that regulates and issues the qualification.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Practitioner.communication",
            "path": "Practitioner.communication",
            "short": "A language the practitioner can use in patient communication",
            "definition": "A language the practitioner can use in patient communication.",
            "comment": "The structure aa-BB with this exact casing is one the most widely used notations for locale. However not all systems code this but instead have it as free text. Hence CodeableConcept instead of code as the data type.",
            "requirements": "Knowing which language a practitioner speaks can help in facilitating communication with patients.",
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
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Practitioner'
    /// </summary>
    // 0. Practitioner
    public class Resource_Practitioner : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 9. Practitioner.qualification
        public class Type_Qualification : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 10. Practitioner.qualification.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 11. Practitioner.qualification.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 12. Practitioner.qualification.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:212
            // 13. Practitioner.qualification.issuer
            public ElementDefinitionInfo Element_Issuer;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Practitioner.qualification",                                                                                    // MakerGen.cs:388
                    ElementId = "Practitioner.qualification"                                                                                // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Issuer.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Qualification()                                                                                                     // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 10. Practitioner.qualification.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "Practitioner.qualification.identifier",                                                                      // MakerGen.cs:232
                        Id = "Practitioner.qualification.identifier",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. Practitioner.qualification.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "Practitioner.qualification.code",                                                                            // MakerGen.cs:232
                        Id = "Practitioner.qualification.code",                                                                             // MakerGen.cs:233
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
                    // 12. Practitioner.qualification.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Period",                                                                                            // MakerGen.cs:231
                        Path= "Practitioner.qualification.period",                                                                          // MakerGen.cs:232
                        Id = "Practitioner.qualification.period",                                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. Practitioner.qualification.issuer
                    this.Element_Issuer = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Issuer",                                                                                            // MakerGen.cs:231
                        Path= "Practitioner.qualification.issuer",                                                                          // MakerGen.cs:232
                        Id = "Practitioner.qualification.issuer",                                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Practitioner.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Practitioner.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:212
        // 3. Practitioner.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 4. Practitioner.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:212
        // 5. Practitioner.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:212
        // 6. Practitioner.gender
        public ElementDefinitionInfo Element_Gender;                                                                                        // MakerGen.cs:212
        // 7. Practitioner.birthDate
        public ElementDefinitionInfo Element_BirthDate;                                                                                     // MakerGen.cs:212
        // 8. Practitioner.photo
        public ElementDefinitionInfo Element_Photo;                                                                                         // MakerGen.cs:212
        // 9. Practitioner.qualification
        public ElementDefinitionInfo Element_Qualification;                                                                                 // MakerGen.cs:212
        // 14. Practitioner.communication
        public ElementDefinitionInfo Element_Communication;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Practitioner",                                                                                                      // MakerGen.cs:388
                ElementId = "Practitioner"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Gender.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_BirthDate.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Photo.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Qualification.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_Communication.Write(sDef);                                                                                              // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Practitioner()                                                                                                      // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Practitioner.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Practitioner.identifier",                                                                                        // MakerGen.cs:232
                    Id = "Practitioner.identifier",                                                                                         // MakerGen.cs:233
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
                // 2. Practitioner.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Active",                                                                                                // MakerGen.cs:231
                    Path= "Practitioner.active",                                                                                            // MakerGen.cs:232
                    Id = "Practitioner.active",                                                                                             // MakerGen.cs:233
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
                // 3. Practitioner.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "Practitioner.name",                                                                                              // MakerGen.cs:232
                    Id = "Practitioner.name",                                                                                               // MakerGen.cs:233
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
                // 4. Practitioner.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:231
                    Path= "Practitioner.telecom",                                                                                           // MakerGen.cs:232
                    Id = "Practitioner.telecom",                                                                                            // MakerGen.cs:233
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
                // 5. Practitioner.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Address",                                                                                               // MakerGen.cs:231
                    Path= "Practitioner.address",                                                                                           // MakerGen.cs:232
                    Id = "Practitioner.address",                                                                                            // MakerGen.cs:233
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
                // 6. Practitioner.gender
                this.Element_Gender = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Gender",                                                                                                // MakerGen.cs:231
                    Path= "Practitioner.gender",                                                                                            // MakerGen.cs:232
                    Id = "Practitioner.gender",                                                                                             // MakerGen.cs:233
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
                // 7. Practitioner.birthDate
                this.Element_BirthDate = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_BirthDate",                                                                                             // MakerGen.cs:231
                    Path= "Practitioner.birthDate",                                                                                         // MakerGen.cs:232
                    Id = "Practitioner.birthDate",                                                                                          // MakerGen.cs:233
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
                // 8. Practitioner.photo
                this.Element_Photo = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Photo",                                                                                                 // MakerGen.cs:231
                    Path= "Practitioner.photo",                                                                                             // MakerGen.cs:232
                    Id = "Practitioner.photo",                                                                                              // MakerGen.cs:233
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
                // 9. Practitioner.qualification
                this.Element_Qualification = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Qualification",                                                                                         // MakerGen.cs:231
                    Path= "Practitioner.qualification",                                                                                     // MakerGen.cs:232
                    Id = "Practitioner.qualification",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Qualification                                                                                              // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. Practitioner.communication
                this.Element_Communication = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Communication",                                                                                         // MakerGen.cs:231
                    Path= "Practitioner.communication",                                                                                     // MakerGen.cs:232
                    Id = "Practitioner.communication",                                                                                      // MakerGen.cs:233
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
            this.Name = "Practitioner";                                                                                                     // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Practitioner";                                                              // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
