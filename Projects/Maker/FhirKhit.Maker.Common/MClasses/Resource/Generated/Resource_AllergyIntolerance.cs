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
      "id": "AllergyIntolerance",
      "url": "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",
      "version": "4.0.0",
      "name": "AllergyIntolerance",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Risk of harmful or undesirable, physiological response which is unique to an individual and associated with exposure to a substance.",
      "purpose": "To record a clinical assessment of a propensity, or potential risk to an individual, of an adverse reaction upon future exposure to the specified substance, or class of substance.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "AllergyIntolerance",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "AllergyIntolerance",
            "path": "AllergyIntolerance",
            "short": "Allergy or Intolerance (generally: Risk of adverse reaction to a substance)",
            "definition": "Risk of harmful or undesirable, physiological response which is unique to an individual and associated with exposure to a substance.",
            "comment": "Substances include, but are not limited to: a therapeutic substance administered correctly at an appropriate dosage for the individual; food; material derived from plants or animals; or venom from insect stings.",
            "alias": [
              "Allergy",
              "Intolerance",
              "Adverse Reaction"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "AllergyIntolerance.identifier",
            "path": "AllergyIntolerance.identifier",
            "short": "External ids for this item",
            "definition": "Business identifiers assigned to this AllergyIntolerance by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the AllergyIntolerance as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "AllergyIntolerance.clinicalStatus",
            "path": "AllergyIntolerance.clinicalStatus",
            "short": "active | inactive | resolved",
            "definition": "The clinical status of the allergy or intolerance.",
            "comment": "Refer to [discussion](extensibility.html#Special-Case) if clincalStatus is missing data.\nThe data type is CodeableConcept because clinicalStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "ait-1",
              "ait-2"
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the status contains the codes inactive and resolved that mark the AllergyIntolerance as no longer active.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AllergyIntoleranceClinicalStatus"
                }
              ],
              "strength": "required",
              "description": "The clinical status of the allergy or intolerance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergyintolerance-clinical|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.verificationStatus",
            "path": "AllergyIntolerance.verificationStatus",
            "short": "unconfirmed | confirmed | refuted | entered-in-error",
            "definition": "Assertion about certainty associated with the propensity, or potential risk, of a reaction to the identified substance (including pharmaceutical product).",
            "comment": "The data type is CodeableConcept because verificationStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "ait-1",
              "ait-2"
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the status contains the codes refuted and entered-in-error that mark the AllergyIntolerance as not currently valid.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AllergyIntoleranceVerificationStatus"
                }
              ],
              "strength": "required",
              "description": "Assertion about certainty associated with a propensity, or potential risk, of a reaction to the identified substance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergyintolerance-verification|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.type",
            "path": "AllergyIntolerance.type",
            "short": "allergy | intolerance - Underlying mechanism (if known)",
            "definition": "Identification of the underlying physiological mechanism for the reaction risk.",
            "comment": "Allergic (typically immune-mediated) reactions have been traditionally regarded as an indicator for potential escalation to significant future risk. Contemporary knowledge suggests that some reactions previously thought to be immune-mediated are, in fact, non-immune, but in some cases can still pose a life threatening risk. It is acknowledged that many clinicians might not be in a position to distinguish the mechanism of a particular reaction. Often the term \"allergy\" is used rather generically and may overlap with the use of \"intolerance\" - in practice the boundaries between these two concepts might not be well-defined or understood. This data element is included nevertheless, because many legacy systems have captured this attribute. Immunologic testing may provide supporting evidence for the basis of the reaction and the causative substance, but no tests are 100% sensitive or specific for sensitivity to a particular substance. If, as is commonly the case, it is unclear whether the reaction is due to an allergy or an intolerance, then the type element should be omitted from the resource.",
            "alias": [
              "Category",
              "Class"
            ],
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
                  "valueString": "AllergyIntoleranceType"
                }
              ],
              "strength": "required",
              "description": "Identification of the underlying physiological mechanism for a Reaction Risk.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergy-intolerance-type|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.category",
            "path": "AllergyIntolerance.category",
            "short": "food | medication | environment | biologic",
            "definition": "Category of the identified substance.",
            "comment": "This data element has been included because it is currently being captured in some clinical systems. This data can be derived from the substance where coding systems are used, and is effectively redundant in that situation.  When searching on category, consider the implications of AllergyIntolerance resources without a category.  For example, when searching on category = medication, medication allergies that don't have a category valued will not be returned.  Refer to [search](search.html) for more information on how to search category with a :missing modifier to get allergies that don't have a category.  Additionally, category should be used with caution because category can be subjective based on the sender.",
            "alias": [
              "Category",
              "Type",
              "Reaction Type",
              "Class"
            ],
            "min": 0,
            "max": "*",
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
                  "valueString": "AllergyIntoleranceCategory"
                }
              ],
              "strength": "required",
              "description": "Category of an identified substance associated with allergies or intolerances.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergy-intolerance-category|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.criticality",
            "path": "AllergyIntolerance.criticality",
            "short": "low | high | unable-to-assess",
            "definition": "Estimate of the potential clinical harm, or seriousness, of the reaction to the identified substance.",
            "comment": "The default criticality value for any propensity to an adverse reaction should be 'Low Risk', indicating at the very least a relative contraindication to deliberate or voluntary exposure to the substance. 'High Risk' is flagged if the clinician has identified a propensity for a more serious or potentially life-threatening reaction, such as anaphylaxis, and implies an absolute contraindication to deliberate or voluntary exposure to the substance. If this element is missing, the criticality is unknown (though it may be known elsewhere).  Systems that capture a severity at the condition level are actually representing the concept of criticality whereas the severity documented at the reaction level is representing the true reaction severity.  Existing systems that are capturing both condition criticality and reaction severity may use the term \"severity\" to represent both.  Criticality is the worst it could be in the future (i.e. situation-agnostic) whereas severity is situation-dependent.",
            "alias": [
              "Severity",
              "Seriousness",
              "Contra-indication",
              "Risk"
            ],
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
                  "valueString": "AllergyIntoleranceCriticality"
                }
              ],
              "strength": "required",
              "description": "Estimate of the potential clinical harm, or seriousness, of a reaction to an identified substance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.code",
            "path": "AllergyIntolerance.code",
            "short": "Code that identifies the allergy or intolerance",
            "definition": "Code for an allergy or intolerance statement (either a positive or a negated/excluded statement).  This may be a code for a substance or pharmaceutical product that is considered to be responsible for the adverse reaction risk (e.g., \"Latex\"), an allergy or intolerance condition (e.g., \"Latex allergy\"), or a negated/excluded code for a specific substance or class (e.g., \"No latex allergy\") or a general or categorical negated statement (e.g.,  \"No known allergy\", \"No known drug allergies\").  Note: the substance for a specific reaction may be different from the substance identified as the cause of the risk, but it must be consistent with it. For instance, it may be a more specific substance (e.g. a brand medication) or a composite product that includes the identified substance. It must be clinically safe to only process the 'code' and ignore the 'reaction.substance'.  If a receiving system is unable to confirm that AllergyIntolerance.reaction.substance falls within the semantic scope of AllergyIntolerance.code, then the receiving system should ignore AllergyIntolerance.reaction.substance.",
            "comment": "It is strongly recommended that this element be populated using a terminology, where possible. For example, some terminologies used include RxNorm, SNOMED CT, DM+D, NDFRT, ICD-9, IDC-10, UNII, and ATC. Plain text should only be used if there is no appropriate terminology available. Additional details can be specified in the text.\r\rWhen a substance or product code is specified for the 'code' element, the \"default\" semantic context is that this is a positive statement of an allergy or intolerance (depending on the value of the 'type' element, if present) condition to the specified substance/product.  In the corresponding SNOMED CT allergy model, the specified substance/product is the target (destination) of the \"Causative agent\" relationship.\r\rThe 'substanceExposureRisk' extension is available as a structured and more flexible alternative to the 'code' element for making positive or negative allergy or intolerance statements.  This extension provides the capability to make \"no known allergy\" (or \"no risk of adverse reaction\") statements regarding any coded substance/product (including cases when a pre-coordinated \"no allergy to x\" concept for that substance/product does not exist).  If the 'substanceExposureRisk' extension is present, the AllergyIntolerance.code element SHALL be omitted.",
            "alias": [
              "Code"
            ],
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
                  "valueString": "AllergyIntoleranceCode"
                }
              ],
              "strength": "example",
              "description": "Type of the substance/product, allergy or intolerance condition, or negation/exclusion codes for reporting no known allergies.",
              "valueSet": "http://hl7.org/fhir/ValueSet/allergyintolerance-code"
            }
          },
          {
            "id": "AllergyIntolerance.patient",
            "path": "AllergyIntolerance.patient",
            "short": "Who the sensitivity is for",
            "definition": "The patient who has the allergy or intolerance.",
            "alias": [
              "Patient"
            ],
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
            "id": "AllergyIntolerance.encounter",
            "path": "AllergyIntolerance.encounter",
            "short": "Encounter when the allergy or intolerance was asserted",
            "definition": "The encounter when the allergy or intolerance was asserted.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "AllergyIntolerance.onset[x]",
            "path": "AllergyIntolerance.onset[x]",
            "short": "When allergy or intolerance was identified",
            "definition": "Estimated or actual date,  date-time, or age when allergy or intolerance was identified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Age"
              },
              {
                "code": "Period"
              },
              {
                "code": "Range"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.recordedDate",
            "path": "AllergyIntolerance.recordedDate",
            "short": "Date first version of the resource instance was recorded",
            "definition": "The recordedDate represents when this particular AllergyIntolerance record was created in the system, which is often a system-generated date.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.recorder",
            "path": "AllergyIntolerance.recorder",
            "short": "Who recorded the sensitivity",
            "definition": "Individual who recorded the record and takes responsibility for its content.",
            "alias": [
              "Author"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ]
          },
          {
            "id": "AllergyIntolerance.asserter",
            "path": "AllergyIntolerance.asserter",
            "short": "Source of the information about the allergy",
            "definition": "The source of the information about the allergy that is recorded.",
            "comment": "The recorder takes responsibility for the content, but can reference the source from where they got it.",
            "alias": [
              "Source",
              "Informant"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AllergyIntolerance.lastOccurrence",
            "path": "AllergyIntolerance.lastOccurrence",
            "short": "Date(/time) of last known occurrence of a reaction",
            "definition": "Represents the date and/or time of the last known occurrence of a reaction event.",
            "comment": "This date may be replicated by one of the Onset of Reaction dates. Where a textual representation of the date of last occurrence is required e.g. 'In Childhood, '10 years ago' the Comment element should be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.note",
            "path": "AllergyIntolerance.note",
            "short": "Additional text not captured in other fields",
            "definition": "Additional narrative about the propensity for the Adverse Reaction, not captured in other fields.",
            "comment": "For example: including reason for flagging a seriousness of 'High Risk'; and instructions related to future exposure or administration of the substance, such as administration within an Intensive Care Unit or under corticosteroid cover. The notes should be related to an allergy or intolerance as a condition in general and not related to any particular episode of it. For episode notes and descriptions, use AllergyIntolerance.event.description and  AllergyIntolerance.event.notes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.reaction",
            "path": "AllergyIntolerance.reaction",
            "short": "Adverse Reaction Events linked to exposure to substance",
            "definition": "Details about each adverse reaction event linked to exposure to the identified substance.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.reaction.substance",
            "path": "AllergyIntolerance.reaction.substance",
            "short": "Specific substance or pharmaceutical product considered to be responsible for event",
            "definition": "Identification of the specific substance (or pharmaceutical product) considered to be responsible for the Adverse Reaction event. Note: the substance for a specific reaction may be different from the substance identified as the cause of the risk, but it must be consistent with it. For instance, it may be a more specific substance (e.g. a brand medication) or a composite product that includes the identified substance. It must be clinically safe to only process the 'code' and ignore the 'reaction.substance'.  If a receiving system is unable to confirm that AllergyIntolerance.reaction.substance falls within the semantic scope of AllergyIntolerance.code, then the receiving system should ignore AllergyIntolerance.reaction.substance.",
            "comment": "Coding of the specific substance (or pharmaceutical product) with a terminology capable of triggering decision support should be used wherever possible.  The 'code' element allows for the use of a specific substance or pharmaceutical product, or a group or class of substances. In the case of an allergy or intolerance to a class of substances, (for example, \"penicillins\"), the 'reaction.substance' element could be used to code the specific substance that was identified as having caused the reaction (for example, \"amoxycillin\"). Duplication of the value in the 'code' and 'reaction.substance' elements is acceptable when a specific substance has been recorded in 'code'.",
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
                  "valueString": "SubstanceCode"
                }
              ],
              "strength": "example",
              "description": "Codes defining the type of the substance (including pharmaceutical products).",
              "valueSet": "http://hl7.org/fhir/ValueSet/substance-code"
            }
          },
          {
            "id": "AllergyIntolerance.reaction.manifestation",
            "path": "AllergyIntolerance.reaction.manifestation",
            "short": "Clinical symptoms/signs associated with the Event",
            "definition": "Clinical symptoms and/or signs that are observed or associated with the adverse reaction event.",
            "comment": "Manifestation can be expressed as a single word, phrase or brief description. For example: nausea, rash or no reaction. It is preferable that manifestation should be coded with a terminology, where possible. The values entered here may be used to display on an application screen as part of a list of adverse reactions, as recommended in the UK NHS CUI guidelines.  Terminologies commonly used include, but are not limited to, SNOMED CT or ICD10.",
            "alias": [
              "Symptoms",
              "Signs"
            ],
            "min": 1,
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
                  "valueString": "Manifestation"
                }
              ],
              "strength": "example",
              "description": "Clinical symptoms and/or signs that are observed or associated with an Adverse Reaction Event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "AllergyIntolerance.reaction.description",
            "path": "AllergyIntolerance.reaction.description",
            "short": "Description of the event as a whole",
            "definition": "Text description about the reaction as a whole, including details of the manifestation if required.",
            "comment": "Use the description to provide any details of a particular event of the occurred reaction such as circumstances, reaction specifics, what happened before/after. Information, related to the event, but not describing a particular care should be captured in the comment field. For example: at the age of four, the patient was given penicillin for strep throat and subsequently developed severe hives.",
            "alias": [
              "Narrative",
              "Text"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.reaction.onset",
            "path": "AllergyIntolerance.reaction.onset",
            "short": "Date(/time) when manifestations showed",
            "definition": "Record of the date and/or time of the onset of the Reaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "AllergyIntolerance.reaction.severity",
            "path": "AllergyIntolerance.reaction.severity",
            "short": "mild | moderate | severe (of event as a whole)",
            "definition": "Clinical assessment of the severity of the reaction event as a whole, potentially considering multiple different manifestations.",
            "comment": "It is acknowledged that this assessment is very subjective. There may be some specific practice domains where objective scales have been applied. Objective scales can be included in this model as extensions.",
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
                  "valueString": "AllergyIntoleranceSeverity"
                }
              ],
              "strength": "required",
              "description": "Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reaction-event-severity|4.0.0"
            }
          },
          {
            "id": "AllergyIntolerance.reaction.exposureRoute",
            "path": "AllergyIntolerance.reaction.exposureRoute",
            "short": "How the subject was exposed to the substance",
            "definition": "Identification of the route by which the subject was exposed to the substance.",
            "comment": "Coding of the route of exposure with a terminology should be used wherever possible.",
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
                  "valueString": "RouteOfAdministration"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the route or physiological path of administration of a therapeutic agent into or onto the body of a subject.",
              "valueSet": "http://hl7.org/fhir/ValueSet/route-codes"
            }
          },
          {
            "id": "AllergyIntolerance.reaction.note",
            "path": "AllergyIntolerance.reaction.note",
            "short": "Text about event not captured in other fields",
            "definition": "Additional text about the adverse reaction event not captured in other fields.",
            "comment": "Use this field to record information indirectly related to a particular event and not captured in the description. For example: Clinical records are no longer available, recorded based on information provided to the patient by her mother and her mother is deceased.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'AllergyIntolerance'
    /// </summary>
    // 0. AllergyIntolerance
    public class Resource_AllergyIntolerance : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 16. AllergyIntolerance.reaction
        public class Type_Reaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 17. AllergyIntolerance.reaction.substance
            public ElementDefinitionInfo Element_Substance;                                                                                 // MakerGen.cs:212
            // 18. AllergyIntolerance.reaction.manifestation
            public ElementDefinitionInfo Element_Manifestation;                                                                             // MakerGen.cs:212
            // 19. AllergyIntolerance.reaction.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 20. AllergyIntolerance.reaction.onset
            public ElementDefinitionInfo Element_Onset;                                                                                     // MakerGen.cs:212
            // 21. AllergyIntolerance.reaction.severity
            public ElementDefinitionInfo Element_Severity;                                                                                  // MakerGen.cs:212
            // 22. AllergyIntolerance.reaction.exposureRoute
            public ElementDefinitionInfo Element_ExposureRoute;                                                                             // MakerGen.cs:212
            // 23. AllergyIntolerance.reaction.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "AllergyIntolerance.reaction",                                                                                   // MakerGen.cs:388
                    ElementId = "AllergyIntolerance.reaction"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Substance.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Manifestation.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Onset.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Severity.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_ExposureRoute.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Reaction()                                                                                                          // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 17. AllergyIntolerance.reaction.substance
                    this.Element_Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Substance",                                                                                         // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.substance",                                                                      // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.substance",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
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
                    // 18. AllergyIntolerance.reaction.manifestation
                    this.Element_Manifestation = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Manifestation",                                                                                     // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.manifestation",                                                                  // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.manifestation",                                                                   // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. AllergyIntolerance.reaction.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.description",                                                                    // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.description",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. AllergyIntolerance.reaction.onset
                    this.Element_Onset = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Onset",                                                                                             // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.onset",                                                                          // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.onset",                                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. AllergyIntolerance.reaction.severity
                    this.Element_Severity = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Severity",                                                                                          // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.severity",                                                                       // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.severity",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 22. AllergyIntolerance.reaction.exposureRoute
                    this.Element_ExposureRoute = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ExposureRoute",                                                                                     // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.exposureRoute",                                                                  // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.exposureRoute",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
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
                    // 23. AllergyIntolerance.reaction.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Note",                                                                                              // MakerGen.cs:231
                        Path= "AllergyIntolerance.reaction.note",                                                                           // MakerGen.cs:232
                        Id = "AllergyIntolerance.reaction.note",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. AllergyIntolerance.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. AllergyIntolerance.clinicalStatus
        public ElementDefinitionInfo Element_ClinicalStatus;                                                                                // MakerGen.cs:212
        // 3. AllergyIntolerance.verificationStatus
        public ElementDefinitionInfo Element_VerificationStatus;                                                                            // MakerGen.cs:212
        // 4. AllergyIntolerance.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 5. AllergyIntolerance.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 6. AllergyIntolerance.criticality
        public ElementDefinitionInfo Element_Criticality;                                                                                   // MakerGen.cs:212
        // 7. AllergyIntolerance.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 8. AllergyIntolerance.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 9. AllergyIntolerance.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 10. AllergyIntolerance.onset[x]
        public ElementDefinitionInfo Element_Onset;                                                                                         // MakerGen.cs:212
        // 11. AllergyIntolerance.recordedDate
        public ElementDefinitionInfo Element_RecordedDate;                                                                                  // MakerGen.cs:212
        // 12. AllergyIntolerance.recorder
        public ElementDefinitionInfo Element_Recorder;                                                                                      // MakerGen.cs:212
        // 13. AllergyIntolerance.asserter
        public ElementDefinitionInfo Element_Asserter;                                                                                      // MakerGen.cs:212
        // 14. AllergyIntolerance.lastOccurrence
        public ElementDefinitionInfo Element_LastOccurrence;                                                                                // MakerGen.cs:212
        // 15. AllergyIntolerance.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 16. AllergyIntolerance.reaction
        public ElementDefinitionInfo Element_Reaction;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "AllergyIntolerance",                                                                                                // MakerGen.cs:388
                ElementId = "AllergyIntolerance"                                                                                            // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ClinicalStatus.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_VerificationStatus.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Criticality.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Onset.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_RecordedDate.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Recorder.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Asserter.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_LastOccurrence.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Reaction.Write(sDef);                                                                                                   // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_AllergyIntolerance()                                                                                                // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. AllergyIntolerance.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "AllergyIntolerance.identifier",                                                                                  // MakerGen.cs:232
                    Id = "AllergyIntolerance.identifier",                                                                                   // MakerGen.cs:233
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
                // 2. AllergyIntolerance.clinicalStatus
                this.Element_ClinicalStatus = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ClinicalStatus",                                                                                        // MakerGen.cs:231
                    Path= "AllergyIntolerance.clinicalStatus",                                                                              // MakerGen.cs:232
                    Id = "AllergyIntolerance.clinicalStatus",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. AllergyIntolerance.verificationStatus
                this.Element_VerificationStatus = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_VerificationStatus",                                                                                    // MakerGen.cs:231
                    Path= "AllergyIntolerance.verificationStatus",                                                                          // MakerGen.cs:232
                    Id = "AllergyIntolerance.verificationStatus",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. AllergyIntolerance.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "AllergyIntolerance.type",                                                                                        // MakerGen.cs:232
                    Id = "AllergyIntolerance.type",                                                                                         // MakerGen.cs:233
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
                // 5. AllergyIntolerance.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "AllergyIntolerance.category",                                                                                    // MakerGen.cs:232
                    Id = "AllergyIntolerance.category",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. AllergyIntolerance.criticality
                this.Element_Criticality = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Criticality",                                                                                           // MakerGen.cs:231
                    Path= "AllergyIntolerance.criticality",                                                                                 // MakerGen.cs:232
                    Id = "AllergyIntolerance.criticality",                                                                                  // MakerGen.cs:233
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
                // 7. AllergyIntolerance.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "AllergyIntolerance.code",                                                                                        // MakerGen.cs:232
                    Id = "AllergyIntolerance.code",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. AllergyIntolerance.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "AllergyIntolerance.patient",                                                                                     // MakerGen.cs:232
                    Id = "AllergyIntolerance.patient",                                                                                      // MakerGen.cs:233
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
                // 9. AllergyIntolerance.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "AllergyIntolerance.encounter",                                                                                   // MakerGen.cs:232
                    Id = "AllergyIntolerance.encounter",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. AllergyIntolerance.onset[x]
                this.Element_Onset = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Onset",                                                                                                 // MakerGen.cs:231
                    Path= "AllergyIntolerance.onset[x]",                                                                                    // MakerGen.cs:232
                    Id = "AllergyIntolerance.onset[x]",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        },                                                                                                                  // MakerGen.cs:300
                        new FhirKhit.Maker.Common.Complex.Type_Age                                                                          // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        },                                                                                                                  // MakerGen.cs:353
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. AllergyIntolerance.recordedDate
                this.Element_RecordedDate = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_RecordedDate",                                                                                          // MakerGen.cs:231
                    Path= "AllergyIntolerance.recordedDate",                                                                                // MakerGen.cs:232
                    Id = "AllergyIntolerance.recordedDate",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. AllergyIntolerance.recorder
                this.Element_Recorder = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recorder",                                                                                              // MakerGen.cs:231
                    Path= "AllergyIntolerance.recorder",                                                                                    // MakerGen.cs:232
                    Id = "AllergyIntolerance.recorder",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. AllergyIntolerance.asserter
                this.Element_Asserter = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Asserter",                                                                                              // MakerGen.cs:231
                    Path= "AllergyIntolerance.asserter",                                                                                    // MakerGen.cs:232
                    Id = "AllergyIntolerance.asserter",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. AllergyIntolerance.lastOccurrence
                this.Element_LastOccurrence = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LastOccurrence",                                                                                        // MakerGen.cs:231
                    Path= "AllergyIntolerance.lastOccurrence",                                                                              // MakerGen.cs:232
                    Id = "AllergyIntolerance.lastOccurrence",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. AllergyIntolerance.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "AllergyIntolerance.note",                                                                                        // MakerGen.cs:232
                    Id = "AllergyIntolerance.note",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. AllergyIntolerance.reaction
                this.Element_Reaction = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Reaction",                                                                                              // MakerGen.cs:231
                    Path= "AllergyIntolerance.reaction",                                                                                    // MakerGen.cs:232
                    Id = "AllergyIntolerance.reaction",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Reaction                                                                                                   // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "AllergyIntolerance";                                                                                               // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance";                                                        // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
