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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Practitioner'
    /// </summary>
    // 0. Practitioner
    public class Practitioner : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Practitioner_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 9. Practitioner.qualification
            public class Type_Qualification : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Qualification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 10. Practitioner.qualification.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:211
                    // 11. Practitioner.qualification.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 12. Practitioner.qualification.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:211
                    // 13. Practitioner.qualification.issuer
                    public ElementDefinitionInfo Issuer;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Qualification_Elements()                                                                                    // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. Practitioner.qualification.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Identifier",                                                                                        // MakerGen.cs:230
                                Path= "Practitioner.qualification.identifier",                                                              // MakerGen.cs:231
                                Id = "Practitioner.qualification.identifier",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. Practitioner.qualification.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "Practitioner.qualification.code",                                                                    // MakerGen.cs:231
                                Id = "Practitioner.qualification.code",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Practitioner.qualification.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Period",                                                                                            // MakerGen.cs:230
                                Path= "Practitioner.qualification.period",                                                                  // MakerGen.cs:231
                                Id = "Practitioner.qualification.period",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. Practitioner.qualification.issuer
                            this.Issuer = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Issuer",                                                                                            // MakerGen.cs:230
                                Path= "Practitioner.qualification.issuer",                                                                  // MakerGen.cs:231
                                Id = "Practitioner.qualification.issuer",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Issuer.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Qualification_Elements Elements                                                                                 // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Qualification_Elements();                                                              // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Qualification_Elements elements;                                                                                       // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Qualification()                                                                                                 // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Practitioner.qualification",                                                                                // MakerGen.cs:423
                        ElementId = "Practitioner.qualification"                                                                            // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. Practitioner.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. Practitioner.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:211
            // 3. Practitioner.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 4. Practitioner.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:211
            // 5. Practitioner.address
            public ElementDefinitionInfo Address;                                                                                           // MakerGen.cs:211
            // 6. Practitioner.gender
            public ElementDefinitionInfo Gender;                                                                                            // MakerGen.cs:211
            // 7. Practitioner.birthDate
            public ElementDefinitionInfo BirthDate;                                                                                         // MakerGen.cs:211
            // 8. Practitioner.photo
            public ElementDefinitionInfo Photo;                                                                                             // MakerGen.cs:211
            // 9. Practitioner.qualification
            public ElementDefinitionInfo Qualification;                                                                                     // MakerGen.cs:211
            // 14. Practitioner.communication
            public ElementDefinitionInfo Communication;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Practitioner_Elements()                                                                                                  // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Practitioner.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Practitioner.identifier",                                                                                    // MakerGen.cs:231
                        Id = "Practitioner.identifier",                                                                                     // MakerGen.cs:232
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
                    // 2. Practitioner.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Active",                                                                                                    // MakerGen.cs:230
                        Path= "Practitioner.active",                                                                                        // MakerGen.cs:231
                        Id = "Practitioner.active",                                                                                         // MakerGen.cs:232
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
                    // 3. Practitioner.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "Practitioner.name",                                                                                          // MakerGen.cs:231
                        Id = "Practitioner.name",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Practitioner.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Telecom",                                                                                                   // MakerGen.cs:230
                        Path= "Practitioner.telecom",                                                                                       // MakerGen.cs:231
                        Id = "Practitioner.telecom",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Practitioner.address
                    this.Address = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Address",                                                                                                   // MakerGen.cs:230
                        Path= "Practitioner.address",                                                                                       // MakerGen.cs:231
                        Id = "Practitioner.address",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Practitioner.gender
                    this.Gender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Gender",                                                                                                    // MakerGen.cs:230
                        Path= "Practitioner.gender",                                                                                        // MakerGen.cs:231
                        Id = "Practitioner.gender",                                                                                         // MakerGen.cs:232
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
                    // 7. Practitioner.birthDate
                    this.BirthDate = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "BirthDate",                                                                                                 // MakerGen.cs:230
                        Path= "Practitioner.birthDate",                                                                                     // MakerGen.cs:231
                        Id = "Practitioner.birthDate",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Practitioner.photo
                    this.Photo = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Photo",                                                                                                     // MakerGen.cs:230
                        Path= "Practitioner.photo",                                                                                         // MakerGen.cs:231
                        Id = "Practitioner.photo",                                                                                          // MakerGen.cs:232
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
                    // 9. Practitioner.qualification
                    this.Qualification = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Qualification",                                                                                             // MakerGen.cs:230
                        Path= "Practitioner.qualification",                                                                                 // MakerGen.cs:231
                        Id = "Practitioner.qualification",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Qualification                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Practitioner.communication
                    this.Communication = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Communication",                                                                                             // MakerGen.cs:230
                        Path= "Practitioner.communication",                                                                                 // MakerGen.cs:231
                        Id = "Practitioner.communication",                                                                                  // MakerGen.cs:232
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
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Active.Write(sDef);                                                                                                         // MakerGen.cs:215
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:215
                Address.Write(sDef);                                                                                                        // MakerGen.cs:215
                Gender.Write(sDef);                                                                                                         // MakerGen.cs:215
                BirthDate.Write(sDef);                                                                                                      // MakerGen.cs:215
                Photo.Write(sDef);                                                                                                          // MakerGen.cs:215
                Qualification.Write(sDef);                                                                                                  // MakerGen.cs:215
                Communication.Write(sDef);                                                                                                  // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Practitioner_Elements Elements                                                                                               // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Practitioner_Elements();                                                                            // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Practitioner_Elements elements;                                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Practitioner()                                                                                                               // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Practitioner";                                                                                                     // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Practitioner";                                                              // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Practitioner",                                                                                                      // MakerGen.cs:423
                ElementId = "Practitioner"                                                                                                  // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
