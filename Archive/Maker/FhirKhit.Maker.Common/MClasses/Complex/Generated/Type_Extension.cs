using System;                                                                                                                               // MakerGen.cs:490
using System.Diagnostics;                                                                                                                   // MakerGen.cs:491
using System.IO;                                                                                                                            // MakerGen.cs:492
using System.Linq;                                                                                                                          // MakerGen.cs:493
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:494
                                                                                                                                            // MakerGen.cs:495
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:496
{                                                                                                                                           // MakerGen.cs:497
    #region Json                                                                                                                            // MakerGen.cs:498
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Extension",
      "url": "http://hl7.org/fhir/StructureDefinition/Extension",
      "version": "4.0.0",
      "name": "Extension",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Extension Type: Optional Extension Element - found in all resources.",
      "purpose": "The ability to add extensions in a structured way is what keeps FHIR resources simple.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Extension",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Extension",
            "path": "Extension",
            "short": "Optional Extensions Element",
            "definition": "Optional Extension Element - found in all resources.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Extension.url",
            "path": "Extension.url",
            "representation": [
              "xmlAttr"
            ],
            "short": "identifies the meaning of the extension",
            "definition": "Source of the definition for the extension code - a logical name or a URL.",
            "comment": "The definition may point directly to a computable or human-readable definition of the extensibility codes, or it may be a logical URI as declared in some other specification. The definition SHALL be a URI for the Structure Definition defining the extension.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "_code": {
                  "extension": [
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-json-type",
                      "valueString": "string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-xml-type",
                      "valueString": "xsd:string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-rdf-type",
                      "valueString": "xsd:string"
                    },
                    {
                      "url": "http://hl7.org/fhir/StructureDefinition/regex",
                      "valueString": "((http|https)://([A-Za-z0-9\\\\\\.\\:\\%\\$]*\\/)*)?(Account|ActivityDefinition|AdverseEvent|AllergyIntolerance|Appointment|AppointmentResponse|AuditEvent|Basic|Binary|BiologicallyDerivedProduct|BodyStructure|Bundle|CapabilityStatement|CarePlan|CareTeam|CatalogEntry|ChargeItem|ChargeItemDefinition|Claim|ClaimResponse|ClinicalImpression|CodeSystem|Communication|CommunicationRequest|CompartmentDefinition|Composition|ConceptMap|Condition|Consent|Contract|Coverage|CoverageEligibilityRequest|CoverageEligibilityResponse|DetectedIssue|Device|DeviceDefinition|DeviceMetric|DeviceRequest|DeviceUseStatement|DiagnosticReport|DocumentManifest|DocumentReference|EffectEvidenceSynthesis|Encounter|Endpoint|EnrollmentRequest|EnrollmentResponse|EpisodeOfCare|EventDefinition|Evidence|EvidenceVariable|ExampleScenario|ExplanationOfBenefit|FamilyMemberHistory|Flag|Goal|GraphDefinition|Group|GuidanceResponse|HealthcareService|ImagingStudy|Immunization|ImmunizationEvaluation|ImmunizationRecommendation|ImplementationGuide|InsurancePlan|Invoice|Library|Linkage|List|Location|Measure|MeasureReport|Media|Medication|MedicationAdministration|MedicationDispense|MedicationKnowledge|MedicationRequest|MedicationStatement|MedicinalProduct|MedicinalProductAuthorization|MedicinalProductContraindication|MedicinalProductIndication|MedicinalProductIngredient|MedicinalProductInteraction|MedicinalProductManufactured|MedicinalProductPackaged|MedicinalProductPharmaceutical|MedicinalProductUndesirableEffect|MessageDefinition|MessageHeader|MolecularSequence|NamingSystem|NutritionOrder|Observation|ObservationDefinition|OperationDefinition|OperationOutcome|Organization|OrganizationAffiliation|Patient|PaymentNotice|PaymentReconciliation|Person|PlanDefinition|Practitioner|PractitionerRole|Procedure|Provenance|Questionnaire|QuestionnaireResponse|RelatedPerson|RequestGroup|ResearchDefinition|ResearchElementDefinition|ResearchStudy|ResearchSubject|RiskAssessment|RiskEvidenceSynthesis|Schedule|SearchParameter|ServiceRequest|Slot|Specimen|SpecimenDefinition|StructureDefinition|StructureMap|Subscription|Substance|SubstanceNucleicAcid|SubstancePolymer|SubstanceProtein|SubstanceReferenceInformation|SubstanceSourceMaterial|SubstanceSpecification|SupplyDelivery|SupplyRequest|Task|TerminologyCapabilities|TestReport|TestScript|ValueSet|VerificationResult|VisionPrescription)\\/[A-Za-z0-9\\-\\.]{1,64}(\\/_history\\/[A-Za-z0-9\\-\\.]{1,64})?"
                    }
                  ]
                }
              }
            ]
          },
          {
            "id": "Extension.value[x]",
            "path": "Extension.value[x]",
            "short": "Value of extension",
            "definition": "Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'Extension'
    /// </summary>
    // 0. Extension
    public partial class Type_Extension : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Extension.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 2. Extension.value[x]
        public ElementDefinitionInfo Element_Value;                                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Extension",                                                                                                         // MakerGen.cs:393
                ElementId = "Extension"                                                                                                     // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_Value.Write(sDef);                                                                                                      // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_Extension()                                                                                                             // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Extension.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "Extension.url",                                                                                                  // MakerGen.cs:237
                    Id = "Extension.url",                                                                                                   // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Extension.value[x]
                this.Element_Value = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Value",                                                                                                 // MakerGen.cs:236
                    Path= "Extension.value[x]",                                                                                             // MakerGen.cs:237
                    Id = "Extension.value[x]",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary                                                          // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id                                                                    // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Oid                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uuid                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_Address                                                                      // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Age                                                                          // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        },                                                                                                                  // MakerGen.cs:320
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        },                                                                                                                  // MakerGen.cs:320
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Count                                                                        // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Distance                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Duration                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                    // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Money                                                                        // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Range                                                                        // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                        // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                        },                                                                                                                  // MakerGen.cs:348
                        new FhirKhit.Maker.Common.Complex.Type_SampledData                                                                  // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Signature                                                                    // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Timing                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Contributor                                                                  // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_DataRequirement                                                              // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Expression                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_ParameterDefinition                                                          // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact                                                              // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition                                                            // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        },                                                                                                                  // MakerGen.cs:358
                        new FhirKhit.Maker.Common.Complex.Type_Dosage                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
