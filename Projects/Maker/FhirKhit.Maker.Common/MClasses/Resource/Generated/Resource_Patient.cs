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
      "id": "Patient",
      "url": "http://hl7.org/fhir/StructureDefinition/Patient",
      "version": "4.0.0",
      "name": "Patient",
      "status": "active",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Demographics and other administrative information about an individual or animal receiving care or other health-related services.",
      "purpose": "Tracking patient is the center of the healthcare process.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Patient",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Patient",
            "path": "Patient",
            "short": "Information about an individual or animal receiving health care services",
            "definition": "Demographics and other administrative information about an individual or animal receiving care or other health-related services.",
            "alias": [
              "SubjectOfCare Client Resident"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Patient.identifier",
            "path": "Patient.identifier",
            "short": "An identifier for this patient",
            "definition": "An identifier for this patient.",
            "requirements": "Patients are almost always assigned specific numerical identifiers.",
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
            "id": "Patient.active",
            "path": "Patient.active",
            "short": "Whether this patient's record is in active use",
            "definition": "Whether this patient record is in active use. \nMany systems use this property to mark as non-current patients, such as those that have not been seen for a period of time based on an organization's business rules.\n\nIt is often used to filter patient lists to exclude inactive patients\n\nDeceased patients may also be marked as inactive for the same reasons, but may be active for some time after death.",
            "comment": "If a record is inactive, and linked to an active record, then future patient/record updates should occur on the other patient.",
            "requirements": "Need to be able to mark a patient record as not to be used because it was created in error.",
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
            "id": "Patient.name",
            "path": "Patient.name",
            "short": "A name associated with the patient",
            "definition": "A name associated with the individual.",
            "comment": "A patient may have multiple names with different uses or applicable periods. For animals, the name is a \"HumanName\" in the sense that is assigned and used by humans and has the same patterns.",
            "requirements": "Need to be able to track the patient by multiple names. Examples are your official name and a partner name.",
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
            "id": "Patient.telecom",
            "path": "Patient.telecom",
            "short": "A contact detail for the individual",
            "definition": "A contact detail (e.g. a telephone number or an email address) by which the individual may be contacted.",
            "comment": "A Patient may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently and also to help with identification. The address might not go directly to the individual, but may reach another party that is able to proxy for the patient (i.e. home phone, or pet owner's phone).",
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
            "id": "Patient.gender",
            "path": "Patient.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender - the gender that the patient is considered to have for administration and record keeping purposes.",
            "comment": "The gender might not match the biological sex as determined by genetics or the individual's preferred identification. Note that for both humans and particularly animals, there are other legitimate possibilities than male and female, though the vast majority of systems and contexts only support male and female.  Systems providing decision support or enforcing business rules should ideally do this on the basis of Observations dealing with the specific sex or gender aspect of interest (anatomical, chromosomal, social, etc.)  However, because these observations are infrequently recorded, defaulting to the administrative gender is common practice.  Where such defaulting occurs, rule enforcement should allow for the variation between administrative and biological, chromosomal and other gender aspects.  For example, an alert about a hysterectomy on a male should be handled as a warning or overridable error, not a \"hard\" error.  See the Patient Gender and Sex section for additional information about communicating patient gender and sex.",
            "requirements": "Needed for identification of the individual, in combination with (at least) name and birth date.",
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
            "id": "Patient.birthDate",
            "path": "Patient.birthDate",
            "short": "The date of birth for the individual",
            "definition": "The date of birth for the individual.",
            "comment": "At least an estimated year should be provided as a guess if the real DOB is unknown  There is a standard extension \"patient-birthTime\" available that should be used where Time is required (such as in maternity/infant care systems).",
            "requirements": "Age of the individual drives many clinical processes.",
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
            "id": "Patient.deceased[x]",
            "path": "Patient.deceased[x]",
            "short": "Indicates if the individual is deceased or not",
            "definition": "Indicates if the individual is deceased or not.",
            "comment": "If there's no value in the instance, it means there is no statement on whether or not the individual is deceased. Most systems will interpret the absence of a value as a sign of the person being alive.",
            "requirements": "The fact that a patient is deceased influences the clinical process. Also, in human communication and relation management it is necessary to know whether the person is alive.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "dateTime"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because once a patient is marked as deceased, the actions that are appropriate to perform on the patient may be significantly different.",
            "isSummary": true
          },
          {
            "id": "Patient.address",
            "path": "Patient.address",
            "short": "An address for the individual",
            "definition": "An address for the individual.",
            "comment": "Patient may have multiple addresses with different uses or applicable periods.",
            "requirements": "May need to keep track of patient addresses for contacting, billing or reporting requirements and also to help with identification.",
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
            "id": "Patient.maritalStatus",
            "path": "Patient.maritalStatus",
            "short": "Marital (civil) status of a patient",
            "definition": "This field contains a patient's most recent marital (civil) status.",
            "requirements": "Most, if not all systems capture it.",
            "min": 0,
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
                  "valueString": "MaritalStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "The domestic partnership status of a person.",
              "valueSet": "http://hl7.org/fhir/ValueSet/marital-status"
            }
          },
          {
            "id": "Patient.multipleBirth[x]",
            "path": "Patient.multipleBirth[x]",
            "short": "Whether patient is part of a multiple birth",
            "definition": "Indicates whether the patient is part of a multiple (boolean) or indicates the actual birth order (integer).",
            "comment": "Where the valueInteger is provided, the number is the birth number in the sequence. E.g. The middle birth in triplets would be valueInteger=2 and the third born would have valueInteger=3 If a boolean value was provided for this triplets example, then all 3 patient records would have valueBoolean=true (the ordering is not indicated).",
            "requirements": "For disambiguation of multiple-birth children, especially relevant where the care provider doesn't meet the patient, such as labs.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "Patient.photo",
            "path": "Patient.photo",
            "short": "Image of the patient",
            "definition": "Image of the patient.",
            "comment": "Guidelines:\n* Use id photos, not clinical photos.\n* Limit dimensions to thumbnail.\n* Keep byte count low to ease resource updates.",
            "requirements": "Many EHR systems have the capability to capture an image of the patient. Fits with newer social media usage too.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "Patient.contact",
            "path": "Patient.contact",
            "short": "A contact party (e.g. guardian, partner, friend) for the patient",
            "definition": "A contact party (e.g. guardian, partner, friend) for the patient.",
            "comment": "Contact covers all kinds of contact parties: family members, business contacts, guardians, caregivers. Not applicable to register pedigree and family ties beyond use of having contact.",
            "requirements": "Need to track people you can contact about the patient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Patient.contact.relationship",
            "path": "Patient.contact.relationship",
            "short": "The kind of relationship",
            "definition": "The nature of the relationship between the patient and the contact person.",
            "requirements": "Used to determine which contact person is the most relevant to approach, depending on circumstances.",
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
                  "valueString": "ContactRelationship"
                }
              ],
              "strength": "extensible",
              "description": "The nature of the relationship between a patient and a contact person for that patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/patient-contactrelationship"
            }
          },
          {
            "id": "Patient.contact.name",
            "path": "Patient.contact.name",
            "short": "A name associated with the contact person",
            "definition": "A name associated with the contact person.",
            "requirements": "Contact persons need to be identified by name, but it is uncommon to need details about multiple other names for that contact person.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "HumanName"
              }
            ]
          },
          {
            "id": "Patient.contact.telecom",
            "path": "Patient.contact.telecom",
            "short": "A contact detail for the person",
            "definition": "A contact detail for the person, e.g. a telephone number or an email address.",
            "comment": "Contact may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently, and also to help with identification.",
            "requirements": "People have (primary) ways to contact them in some way such as phone, email.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "Patient.contact.address",
            "path": "Patient.contact.address",
            "short": "Address for the contact person",
            "definition": "Address for the contact person.",
            "requirements": "Need to keep track where the contact person can be contacted per postal mail or visited.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Address"
              }
            ]
          },
          {
            "id": "Patient.contact.gender",
            "path": "Patient.contact.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender - the gender that the contact person is considered to have for administration and record keeping purposes.",
            "requirements": "Needed to address the person correctly.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
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
            "id": "Patient.contact.organization",
            "path": "Patient.contact.organization",
            "short": "Organization that is associated with the contact",
            "definition": "Organization on behalf of which the contact is acting or for which the contact is working.",
            "requirements": "For guardians or business related contacts, the organization is relevant.",
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
            "condition": [
              "pat-1"
            ]
          },
          {
            "id": "Patient.contact.period",
            "path": "Patient.contact.period",
            "short": "The period during which this contact person or organization is valid to be contacted relating to this patient",
            "definition": "The period during which this contact person or organization is valid to be contacted relating to this patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Patient.communication",
            "path": "Patient.communication",
            "short": "A language which may be used to communicate with the patient about his or her health",
            "definition": "A language which may be used to communicate with the patient about his or her health.",
            "comment": "If no language is specified, this *implies* that the default local language is spoken.  If you need to convey proficiency for multiple modes, then you need multiple Patient.Communication associations.   For animals, language is not a relevant field, and should be absent from the instance. If the Patient does not speak the default local language, then the Interpreter Required Standard can be used to explicitly declare that an interpreter is required.",
            "requirements": "If a patient does not speak the local language, interpreters may be required, so languages spoken and proficiency are important things to keep track of both for patient and other persons of interest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Patient.communication.language",
            "path": "Patient.communication.language",
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
            "id": "Patient.communication.preferred",
            "path": "Patient.communication.preferred",
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
          },
          {
            "id": "Patient.generalPractitioner",
            "path": "Patient.generalPractitioner",
            "short": "Patient's nominated primary care provider",
            "definition": "Patient's nominated care provider.",
            "comment": "This may be the primary care provider (in a GP context), or it may be a patient nominated care manager in a community/disability setting, or even organization that will provide people to perform the care provider roles.  It is not to be used to record Care Teams, these should be in a CareTeam resource that may be linked to the CarePlan or EpisodeOfCare resources.\nMultiple GPs may be recorded against the patient for various reasons, such as a student that has his home GP listed along with the GP at university during the school semesters, or a \"fly-in/fly-out\" worker that has the onsite GP also included with his home GP to remain aware of medical issues.\n\nJurisdictions may decide that they can profile this down to 1 if desired, or 1 per type.",
            "alias": [
              "careProvider"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "Patient.managingOrganization",
            "path": "Patient.managingOrganization",
            "short": "Organization that is the custodian of the patient record",
            "definition": "Organization that is the custodian of the patient record.",
            "comment": "There is only one managing organization for a specific patient record. Other organizations will have their own Patient record, and may use the Link property to join the records together (or a Person resource which can include confidence ratings for the association).",
            "requirements": "Need to know who recognizes this patient record, manages and updates it.",
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
          },
          {
            "id": "Patient.link",
            "path": "Patient.link",
            "short": "Link to another patient resource that concerns the same actual person",
            "definition": "Link to another patient resource that concerns the same actual patient.",
            "comment": "There is no assumption that linked patient records have mutual links.",
            "requirements": "There are multiple use cases:   \n\n* Duplicate patient records due to the clerical errors associated with the difficulties of identifying humans consistently, and \n* Distribution of patient information across multiple servers.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it might not be the main Patient resource, and the referenced patient should be used instead of this Patient record. This is when the link.type value is 'replaced-by'",
            "isSummary": true
          },
          {
            "id": "Patient.link.other",
            "path": "Patient.link.other",
            "short": "The other patient or related person resource that the link refers to",
            "definition": "The other patient resource that the link refers to.",
            "comment": "Referencing a RelatedPerson here removes the need to use a Person record to associate a Patient and RelatedPerson as the same individual.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": false
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Patient.link.type",
            "path": "Patient.link.type",
            "short": "replaced-by | replaces | refer | seealso",
            "definition": "The type of link between this patient resource and another patient resource.",
            "min": 1,
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
                  "valueString": "LinkType"
                }
              ],
              "strength": "required",
              "description": "The type of link between this patient resource and another patient resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/link-type|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Patient'
    /// </summary>
    // 0. Patient
    public class Resource_Patient : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                  // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 12. Patient.contact
        public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. Patient.contact.relationship
            public ElementDefinitionInfo Element_Relationship;                                                                              // MakerGen.cs:219
            // 14. Patient.contact.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
            // 15. Patient.contact.telecom
            public ElementDefinitionInfo Element_Telecom;                                                                                   // MakerGen.cs:219
            // 16. Patient.contact.address
            public ElementDefinitionInfo Element_Address;                                                                                   // MakerGen.cs:219
            // 17. Patient.contact.gender
            public ElementDefinitionInfo Element_Gender;                                                                                    // MakerGen.cs:219
            // 18. Patient.contact.organization
            public ElementDefinitionInfo Element_Organization;                                                                              // MakerGen.cs:219
            // 19. Patient.contact.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Patient.contact",                                                                                               // MakerGen.cs:395
                    ElementId = "Patient.contact"                                                                                           // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Relationship.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Telecom.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Address.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_Gender.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Organization.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Contact()                                                                                                           // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. Patient.contact.relationship
                    this.Element_Relationship = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Relationship",                                                                                      // MakerGen.cs:238
                        Path= "Patient.contact.relationship",                                                                               // MakerGen.cs:239
                        Id = "Patient.contact.relationship",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. Patient.contact.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "Patient.contact.name",                                                                                       // MakerGen.cs:239
                        Id = "Patient.contact.name",                                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. Patient.contact.telecom
                    this.Element_Telecom = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Telecom",                                                                                           // MakerGen.cs:238
                        Path= "Patient.contact.telecom",                                                                                    // MakerGen.cs:239
                        Id = "Patient.contact.telecom",                                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                             // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. Patient.contact.address
                    this.Element_Address = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Address",                                                                                           // MakerGen.cs:238
                        Path= "Patient.contact.address",                                                                                    // MakerGen.cs:239
                        Id = "Patient.contact.address",                                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Address                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. Patient.contact.gender
                    this.Element_Gender = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Gender",                                                                                            // MakerGen.cs:238
                        Path= "Patient.contact.gender",                                                                                     // MakerGen.cs:239
                        Id = "Patient.contact.gender",                                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 18. Patient.contact.organization
                    this.Element_Organization = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Organization",                                                                                      // MakerGen.cs:238
                        Path= "Patient.contact.organization",                                                                               // MakerGen.cs:239
                        Id = "Patient.contact.organization",                                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 19. Patient.contact.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Period",                                                                                            // MakerGen.cs:238
                        Path= "Patient.contact.period",                                                                                     // MakerGen.cs:239
                        Id = "Patient.contact.period",                                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 20. Patient.communication
        public class Type_Communication : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 21. Patient.communication.language
            public ElementDefinitionInfo Element_Language;                                                                                  // MakerGen.cs:219
            // 22. Patient.communication.preferred
            public ElementDefinitionInfo Element_Preferred;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Patient.communication",                                                                                         // MakerGen.cs:395
                    ElementId = "Patient.communication"                                                                                     // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Language.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Preferred.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Communication()                                                                                                     // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 21. Patient.communication.language
                    this.Element_Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Language",                                                                                          // MakerGen.cs:238
                        Path= "Patient.communication.language",                                                                             // MakerGen.cs:239
                        Id = "Patient.communication.language",                                                                              // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. Patient.communication.preferred
                    this.Element_Preferred = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Preferred",                                                                                         // MakerGen.cs:238
                        Path= "Patient.communication.preferred",                                                                            // MakerGen.cs:239
                        Id = "Patient.communication.preferred",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 25. Patient.link
        public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 26. Patient.link.other
            public ElementDefinitionInfo Element_Other;                                                                                     // MakerGen.cs:219
            // 27. Patient.link.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Patient.link",                                                                                                  // MakerGen.cs:395
                    ElementId = "Patient.link"                                                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Other.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Link()                                                                                                              // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 26. Patient.link.other
                    this.Element_Other = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Other",                                                                                             // MakerGen.cs:238
                        Path= "Patient.link.other",                                                                                         // MakerGen.cs:239
                        Id = "Patient.link.other",                                                                                          // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 27. Patient.link.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "Patient.link.type",                                                                                          // MakerGen.cs:239
                        Id = "Patient.link.type",                                                                                           // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Patient.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Patient.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:219
        // 3. Patient.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 4. Patient.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:219
        // 5. Patient.gender
        public ElementDefinitionInfo Element_Gender;                                                                                        // MakerGen.cs:219
        // 6. Patient.birthDate
        public ElementDefinitionInfo Element_BirthDate;                                                                                     // MakerGen.cs:219
        // 7. Patient.deceased[x]
        public ElementDefinitionInfo Element_Deceased;                                                                                      // MakerGen.cs:219
        // 8. Patient.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:219
        // 9. Patient.maritalStatus
        public ElementDefinitionInfo Element_MaritalStatus;                                                                                 // MakerGen.cs:219
        // 10. Patient.multipleBirth[x]
        public ElementDefinitionInfo Element_MultipleBirth;                                                                                 // MakerGen.cs:219
        // 11. Patient.photo
        public ElementDefinitionInfo Element_Photo;                                                                                         // MakerGen.cs:219
        // 12. Patient.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:219
        // 20. Patient.communication
        public ElementDefinitionInfo Element_Communication;                                                                                 // MakerGen.cs:219
        // 23. Patient.generalPractitioner
        public ElementDefinitionInfo Element_GeneralPractitioner;                                                                           // MakerGen.cs:219
        // 24. Patient.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:219
        // 25. Patient.link
        public ElementDefinitionInfo Element_Link;                                                                                          // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Patient",                                                                                                           // MakerGen.cs:395
                ElementId = "Patient"                                                                                                       // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Gender.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_BirthDate.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Deceased.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_MaritalStatus.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_MultipleBirth.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_Photo.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Communication.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_GeneralPractitioner.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_Link.Write(sDef);                                                                                                       // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Patient()                                                                                                           // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Patient.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Patient.identifier",                                                                                             // MakerGen.cs:239
                    Id = "Patient.identifier",                                                                                              // MakerGen.cs:240
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
                // 2. Patient.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Active",                                                                                                // MakerGen.cs:238
                    Path= "Patient.active",                                                                                                 // MakerGen.cs:239
                    Id = "Patient.active",                                                                                                  // MakerGen.cs:240
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
                // 3. Patient.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "Patient.name",                                                                                                   // MakerGen.cs:239
                    Id = "Patient.name",                                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                    // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Patient.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:238
                    Path= "Patient.telecom",                                                                                                // MakerGen.cs:239
                    Id = "Patient.telecom",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Patient.gender
                this.Element_Gender = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Gender",                                                                                                // MakerGen.cs:238
                    Path= "Patient.gender",                                                                                                 // MakerGen.cs:239
                    Id = "Patient.gender",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Patient.birthDate
                this.Element_BirthDate = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_BirthDate",                                                                                             // MakerGen.cs:238
                    Path= "Patient.birthDate",                                                                                              // MakerGen.cs:239
                    Id = "Patient.birthDate",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Patient.deceased[x]
                this.Element_Deceased = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Deceased",                                                                                              // MakerGen.cs:238
                    Path= "Patient.deceased[x]",                                                                                            // MakerGen.cs:239
                    Id = "Patient.deceased[x]",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Patient.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Address",                                                                                               // MakerGen.cs:238
                    Path= "Patient.address",                                                                                                // MakerGen.cs:239
                    Id = "Patient.address",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Address                                                                      // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. Patient.maritalStatus
                this.Element_MaritalStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MaritalStatus",                                                                                         // MakerGen.cs:238
                    Path= "Patient.maritalStatus",                                                                                          // MakerGen.cs:239
                    Id = "Patient.maritalStatus",                                                                                           // MakerGen.cs:240
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
                // 10. Patient.multipleBirth[x]
                this.Element_MultipleBirth = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MultipleBirth",                                                                                         // MakerGen.cs:238
                    Path= "Patient.multipleBirth[x]",                                                                                       // MakerGen.cs:239
                    Id = "Patient.multipleBirth[x]",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        },                                                                                                                  // MakerGen.cs:307
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. Patient.photo
                this.Element_Photo = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Photo",                                                                                                 // MakerGen.cs:238
                    Path= "Patient.photo",                                                                                                  // MakerGen.cs:239
                    Id = "Patient.photo",                                                                                                   // MakerGen.cs:240
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
                // 12. Patient.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:238
                    Path= "Patient.contact",                                                                                                // MakerGen.cs:239
                    Id = "Patient.contact",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Contact                                                                                                    // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 20. Patient.communication
                this.Element_Communication = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Communication",                                                                                         // MakerGen.cs:238
                    Path= "Patient.communication",                                                                                          // MakerGen.cs:239
                    Id = "Patient.communication",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Communication                                                                                              // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. Patient.generalPractitioner
                this.Element_GeneralPractitioner = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_GeneralPractitioner",                                                                                   // MakerGen.cs:238
                    Path= "Patient.generalPractitioner",                                                                                    // MakerGen.cs:239
                    Id = "Patient.generalPractitioner",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 24. Patient.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:238
                    Path= "Patient.managingOrganization",                                                                                   // MakerGen.cs:239
                    Id = "Patient.managingOrganization",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. Patient.link
                this.Element_Link = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Link",                                                                                                  // MakerGen.cs:238
                    Path= "Patient.link",                                                                                                   // MakerGen.cs:239
                    Id = "Patient.link",                                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Link                                                                                                       // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Patient";                                                                                                          // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Patient";                                                                   // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
