using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Observation",
      "url": "http://hl7.org/fhir/StructureDefinition/Observation",
      "version": "4.0.0",
      "name": "Observation",
      "status": "active",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Measurements and simple assertions made about a patient, device or other subject.",
      "purpose": "Observations are a key aspect of healthcare.  This resource is used to capture those that do not require more sophisticated mechanisms.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Observation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Observation",
            "path": "Observation",
            "short": "Measurements and simple assertions",
            "definition": "Measurements and simple assertions made about a patient, device or other subject.",
            "comment": "Used for simple observations such as device measurements, laboratory atomic results, vital signs, height, weight, smoking status, comments, etc.  Other resources are used to provide context for observations such as laboratory reports, etc.",
            "alias": [
              "Vital Signs",
              "Measurement",
              "Results",
              "Tests"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Observation.identifier",
            "path": "Observation.identifier",
            "short": "Business Identifier for observation",
            "definition": "A unique identifier assigned to this observation.",
            "requirements": "Allows observations to be distinguished and referenced.",
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
            "id": "Observation.basedOn",
            "path": "Observation.basedOn",
            "short": "Fulfills plan, proposal or order",
            "definition": "A plan, proposal or order that is fulfilled in whole or in part by this event.  For example, a MedicationRequest may require a patient to have laboratory test performed before  it is dispensed.",
            "requirements": "Allows tracing of authorization for the event and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "Fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.partOf",
            "path": "Observation.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular Observation is a component or step.  For example,  an observation as part of a procedure.",
            "comment": "To link an Observation to an Encounter use `encounter`.  See the  [Notes](observation.html#obsgrouping) below for guidance on referencing another Observation.",
            "alias": [
              "Container"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                  "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
                  "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Immunization",
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.status",
            "path": "Observation.status",
            "short": "registered | preliminary | final | amended +",
            "definition": "The status of the result value.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "requirements": "Need to track the status of individual results. Some results are finalized before the whole report is finalized.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationStatus"
                }
              ],
              "strength": "required",
              "description": "Codes providing the status of an observation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-status|4.0.0"
            }
          },
          {
            "id": "Observation.category",
            "path": "Observation.category",
            "short": "Classification of  type of observation",
            "definition": "A code that classifies the general type of observation being made.",
            "comment": "In addition to the required category valueset, this element allows various categorization schemes based on the owner’s definition of the category and effectively multiple categories can be used at once.  The level of granularity is defined by the category concepts in the value set.",
            "requirements": "Used for filtering what observations are retrieved and displayed.",
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
                  "valueString": "ObservationCategory"
                }
              ],
              "strength": "preferred",
              "description": "Codes for high level observation categories.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-category"
            }
          },
          {
            "id": "Observation.code",
            "path": "Observation.code",
            "short": "Type of observation (code / type)",
            "definition": "Describes what was observed. Sometimes this is called the observation \"name\".",
            "comment": "*All* code-value and, if present, component.code-component.value pairs need to be taken into account to correctly understand the meaning of the observation.",
            "requirements": "Knowing what kind of observation is being made is essential to understanding the observation.",
            "alias": [
              "Name"
            ],
            "min": 1,
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
                  "valueString": "ObservationCode"
                }
              ],
              "strength": "example",
              "description": "Codes identifying names of simple observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "Observation.subject",
            "path": "Observation.subject",
            "short": "Who and/or what the observation is about",
            "definition": "The patient, or group of patients, location, or device this observation is about and into whose record the observation is placed. If the actual focus of the observation is different from the subject (or a sample of, part, or region of the subject), the `focus` element or the `code` itself specifies the actual focus of the observation.",
            "comment": "One would expect this element to be a cardinality of 1..1. The only circumstance in which the subject can be missing is when the observation is made by a device that does not know the patient. In this case, the observation SHALL be matched to a patient through some context/channel matching technique, and at this point, the observation should be updated.",
            "requirements": "Observations have no value if you don't know who or what they're about.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.focus",
            "path": "Observation.focus",
            "short": "What the observation is about, when it is not about the subject of record",
            "definition": "The actual focus of an observation when it is not the patient of record representing something or someone associated with the patient such as a spouse, parent, fetus, or donor. For example, fetus observations in a mother's record.  The focus of an observation could also be an existing condition,  an intervention, the subject's diet,  another observation of the subject,  or a body structure such as tumor or implanted device.   An example use case would be using the Observation resource to capture whether the mother is trained to change her child's tracheostomy tube. In this example, the child is the patient of record and the mother is the focus.",
            "comment": "Typically, an observation is made about the subject - a patient, or group of patients, location, or device - and the distinction between the subject and what is directly measured for an observation is specified in the observation code itself ( e.g., \"Blood Glucose\") and does not need to be represented separately using this element.  Use `specimen` if a reference to a specimen is required.  If a code is required instead of a resource use either  `bodysite` for bodysites or the standard extension [focusCode](extension-observation-focuscode.html).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.encounter",
            "path": "Observation.encounter",
            "short": "Healthcare event during which this observation is made",
            "definition": "The healthcare event  (e.g. a patient and healthcare provider interaction) during which this observation is made.",
            "comment": "This will typically be the encounter the event occurred within, but some events may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter (e.g. pre-admission laboratory tests).",
            "requirements": "For some observations it may be important to know the link between an observation and a particular encounter.",
            "alias": [
              "Context"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.effective[x]",
            "path": "Observation.effective[x]",
            "short": "Clinically relevant time/time-period for observation",
            "definition": "The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the \"physiologically relevant time\". This is usually either the time of the procedure or of specimen collection, but very often the source of the date/time is not known, only the date/time itself.",
            "comment": "At least a date should be present unless this observation is a historical report.  For recording imprecise or \"fuzzy\" times (For example, a blood glucose measurement taken \"after breakfast\") use the [Timing](datatypes.html#timing) datatype which allow the measurement to be tied to regular life events.",
            "requirements": "Knowing when an observation was deemed true is important to its relevance as well as determining trends.",
            "alias": [
              "Occurrence"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Timing"
              },
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.issued",
            "path": "Observation.issued",
            "short": "Date/Time this version was made available",
            "definition": "The date and time this version of the observation was made available to providers, typically after the results have been reviewed and verified.",
            "comment": "For Observations that don’t require review and verification, it may be the same as the [`lastUpdated` ](resource-definitions.html#Meta.lastUpdated) time of the resource itself.  For Observations that do require review and verification for certain updates, it might not be the same as the `lastUpdated` time of the resource itself due to a non-clinically significant update that doesn’t require the new version to be reviewed and verified again.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.performer",
            "path": "Observation.performer",
            "short": "Who is responsible for the observation",
            "definition": "Who was responsible for asserting the observed value as \"true\".",
            "requirements": "May give a degree of confidence in the observation and also indicates where follow-up questions should be directed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.value[x]",
            "path": "Observation.value[x]",
            "short": "Actual result",
            "definition": "The information determined as a result of making the observation, if the information has a simple value.",
            "comment": "An observation may have; 1)  a single value here, 2)  both a value and a set of related or component values,  or 3)  only a set of related or component values. If a value is present, the datatype for this element should be determined by Observation.code.  A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Observation.code defines a coded value.  For additional guidance, see the [Notes section](observation.html#notes) below.",
            "requirements": "An observation exists to have a value, though it might not if it is in error, or if it represents a group of observations.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "string"
              },
              {
                "code": "boolean"
              },
              {
                "code": "integer"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "time"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "condition": [
              "obs-7"
            ],
            "isSummary": true
          },
          {
            "id": "Observation.dataAbsentReason",
            "path": "Observation.dataAbsentReason",
            "short": "Why the result is missing",
            "definition": "Provides a reason why the expected value in the element Observation.value[x] is missing.",
            "comment": "Null or exceptional values can be represented two ways in FHIR Observations.  One way is to simply include them in the value set and represent the exceptions in the value.  For example, measurement values for a serology test could be  \"detected\", \"not detected\", \"inconclusive\", or  \"specimen unsatisfactory\".   \n\nThe alternate way is to use the value element for actual observations and use the explicit dataAbsentReason element to record exceptional values.  For example, the dataAbsentReason code \"error\" could be used when the measurement was not completed. Note that an observation may only be reported if there are values to report. For example differential cell counts values may be reported only when > 0.  Because of these options, use-case agreements are required to interpret general observations for null or exceptional values.",
            "requirements": "For many results it is necessary to handle exceptional values in measurements.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "obs-6"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationValueAbsentReason"
                }
              ],
              "strength": "extensible",
              "description": "Codes specifying why the result (`Observation.value[x]`) is missing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/data-absent-reason"
            }
          },
          {
            "id": "Observation.interpretation",
            "path": "Observation.interpretation",
            "short": "High, low, normal, etc.",
            "definition": "A categorical assessment of an observation value.  For example, high, low, normal.",
            "comment": "Historically used for laboratory results (known as 'abnormal flag' ),  its use extends to other use cases where coded interpretations  are relevant.  Often reported as one or more simple compact codes this element is often placed adjacent to the result value in reports and flow sheets to signal the meaning/normalcy status of the result.",
            "requirements": "For some results, particularly numeric results, an interpretation is necessary to fully understand the significance of a result.",
            "alias": [
              "Abnormal Flag"
            ],
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
                  "valueString": "ObservationInterpretation"
                }
              ],
              "strength": "extensible",
              "description": "Codes identifying interpretations of observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-interpretation"
            }
          },
          {
            "id": "Observation.note",
            "path": "Observation.note",
            "short": "Comments about the observation",
            "definition": "Comments about the observation or the results.",
            "comment": "May include general statements about the observation, or statements about significant, unexpected or unreliable results values, or information about its source when relevant to its interpretation.",
            "requirements": "Need to be able to provide free text additional information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Observation.bodySite",
            "path": "Observation.bodySite",
            "short": "Observed body part",
            "definition": "Indicates the site on the subject's body where the observation was made (i.e. the target site).",
            "comment": "Only used if not implicit in code found in Observation.code.  In many systems, this may be represented as a related observation instead of an inline component.   \n\nIf the use case requires BodySite to be handled as a separate resource (e.g. to identify and track separately) then use the standard extension[ bodySite](extension-bodysite.html).",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "Observation.method",
            "path": "Observation.method",
            "short": "How it was done",
            "definition": "Indicates the mechanism used to perform the observation.",
            "comment": "Only used if not implicit in code for Observation.code.",
            "requirements": "In some cases, method can impact results and is thus used for determining whether results can be compared or determining significance of results.",
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
                  "valueString": "ObservationMethod"
                }
              ],
              "strength": "example",
              "description": "Methods for simple observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-methods"
            }
          },
          {
            "id": "Observation.specimen",
            "path": "Observation.specimen",
            "short": "Specimen used for this observation",
            "definition": "The specimen that was used when this observation was made.",
            "comment": "Should only be used if not implicit in code found in `Observation.code`.  Observations are not made on specimens themselves; they are made on a subject, but in many cases by the means of a specimen. Note that although specimens are often involved, they are not always tracked and reported explicitly. Also note that observation resources may be used in contexts that track the specimen explicitly (e.g. Diagnostic Report).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ]
          },
          {
            "id": "Observation.device",
            "path": "Observation.device",
            "short": "(Measurement) Device",
            "definition": "The device used to generate the observation data.",
            "comment": "Note that this is not meant to represent a device involved in the transmission of the result, e.g., a gateway.  Such devices may be documented using the Provenance resource where relevant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/DeviceMetric"
                ]
              }
            ]
          },
          {
            "id": "Observation.referenceRange",
            "path": "Observation.referenceRange",
            "short": "Provides guide for interpretation",
            "definition": "Guidance on how to interpret the value by comparison to a normal or recommended range.  Multiple reference ranges are interpreted as an \"OR\".   In other words, to represent two distinct target populations, two `referenceRange` elements would be used.",
            "comment": "Most observations only have one generic reference range. Systems MAY choose to restrict to only supplying the relevant reference range based on knowledge about the patient (e.g., specific to the patient's age, gender, weight and other factors), but this might not be possible or appropriate. Whenever more than one reference range is supplied, the differences between them SHOULD be provided in the reference range and/or age properties.",
            "requirements": "Knowing what values are considered \"normal\" can help evaluate the significance of a particular result. Need to be able to provide multiple reference ranges for different contexts.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Observation.referenceRange.low",
            "path": "Observation.referenceRange.low",
            "short": "Low Range, if relevant",
            "definition": "The value of the low bound of the reference range.  The low bound of the reference range endpoint is inclusive of the value (e.g.  reference range is >=5 - <=9). If the low bound is omitted,  it is assumed to be meaningless (e.g. reference range is <=2.3).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "condition": [
              "obs-3"
            ]
          },
          {
            "id": "Observation.referenceRange.high",
            "path": "Observation.referenceRange.high",
            "short": "High Range, if relevant",
            "definition": "The value of the high bound of the reference range.  The high bound of the reference range endpoint is inclusive of the value (e.g.  reference range is >=5 - <=9). If the high bound is omitted,  it is assumed to be meaningless (e.g. reference range is >= 2.3).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ],
            "condition": [
              "obs-3"
            ]
          },
          {
            "id": "Observation.referenceRange.type",
            "path": "Observation.referenceRange.type",
            "short": "Reference range qualifier",
            "definition": "Codes to indicate the what part of the targeted reference population it applies to. For example, the normal or therapeutic range.",
            "comment": "This SHOULD be populated if there is more than one range.  If this element is not present then the normal range is assumed.",
            "requirements": "Need to be able to say what kind of reference range this is - normal, recommended, therapeutic, etc.,  - for proper interpretation.",
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
                  "valueString": "ObservationRangeMeaning"
                }
              ],
              "strength": "preferred",
              "description": "Code for the meaning of a reference range.",
              "valueSet": "http://hl7.org/fhir/ValueSet/referencerange-meaning"
            }
          },
          {
            "id": "Observation.referenceRange.appliesTo",
            "path": "Observation.referenceRange.appliesTo",
            "short": "Reference range population",
            "definition": "Codes to indicate the target population this reference range applies to.  For example, a reference range may be based on the normal population or a particular sex or race.  Multiple `appliesTo`  are interpreted as an \"AND\" of the target populations.  For example, to represent a target population of African American females, both a code of female and a code for African American would be used.",
            "comment": "This SHOULD be populated if there is more than one range.  If this element is not present then the normal population is assumed.",
            "requirements": "Need to be able to identify the target population for proper interpretation.",
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
                  "valueString": "ObservationRangeType"
                }
              ],
              "strength": "example",
              "description": "Codes identifying the population the reference range applies to.",
              "valueSet": "http://hl7.org/fhir/ValueSet/referencerange-appliesto"
            }
          },
          {
            "id": "Observation.referenceRange.age",
            "path": "Observation.referenceRange.age",
            "short": "Applicable age range, if relevant",
            "definition": "The age at which this reference range is applicable. This is a neonatal age (e.g. number of weeks at term) if the meaning says so.",
            "requirements": "Some analytes vary greatly over age.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "Observation.referenceRange.text",
            "path": "Observation.referenceRange.text",
            "short": "Text based reference range in an observation",
            "definition": "Text based reference range in an observation which may be used when a quantitative range is not appropriate for an observation.  An example would be a reference value of \"Negative\" or a list or table of \"normals\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Observation.hasMember",
            "path": "Observation.hasMember",
            "short": "Related resource that belongs to the Observation group",
            "definition": "This observation is a group observation (e.g. a battery, a panel of tests, a set of vital sign measurements) that includes the target as a member of the group.",
            "comment": "When using this element, an observation will typically have either a value or a set of related resources, although both may be present in some cases.  For a discussion on the ways Observations can assembled in groups together, see [Notes](observation.html#obsgrouping) below.  Note that a system may calculate results from [QuestionnaireResponse](questionnaireresponse.html)  into a final score and represent the score as an Observation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.derivedFrom",
            "path": "Observation.derivedFrom",
            "short": "Related measurements the observation is made from",
            "definition": "The target resource that represents a measurement from which this observation value is derived. For example, a calculated anion gap or a fetal measurement based on an ultrasound image.",
            "comment": "All the reference choices that are listed in this element can represent clinical observations and other measurements that may be the source for a derived value.  The most common reference will be another Observation.  For a discussion on the ways Observations can assembled in groups together, see [Notes](observation.html#obsgrouping) below.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                  "http://hl7.org/fhir/StructureDefinition/Media",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.component",
            "path": "Observation.component",
            "short": "Component results",
            "definition": "Some observations have multiple component observations.  These component observations are expressed as separate code value pairs that share the same attributes.  Examples include systolic and diastolic component observations for blood pressure measurement and multiple component observations for genetics observations.",
            "comment": "For a discussion on the ways Observations can be assembled in groups together see [Notes](observation.html#notes) below.",
            "requirements": "Component observations share the same attributes in the Observation resource as the primary observation and are always treated a part of a single observation (they are not separable).   However, the reference range for the primary observation value is not inherited by the component values and is required when appropriate for each component observation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.component.code",
            "path": "Observation.component.code",
            "short": "Type of component observation (code / type)",
            "definition": "Describes what was observed. Sometimes this is called the observation \"code\".",
            "comment": "*All* code-value and  component.code-component.value pairs need to be taken into account to correctly understand the meaning of the observation.",
            "requirements": "Knowing what kind of observation is being made is essential to understanding the observation.",
            "min": 1,
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
                  "valueString": "ObservationCode"
                }
              ],
              "strength": "example",
              "description": "Codes identifying names of simple observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "Observation.component.value[x]",
            "path": "Observation.component.value[x]",
            "short": "Actual component result",
            "definition": "The information determined as a result of making the observation, if the information has a simple value.",
            "comment": "Used when observation has a set of component observations. An observation may have both a value (e.g. an  Apgar score)  and component observations (the observations from which the Apgar score was derived). If a value is present, the datatype for this element should be determined by Observation.code. A CodeableConcept with just a text would be used instead of a string if the field was usually coded, or if the type associated with the Observation.code defines a coded value.  For additional guidance, see the [Notes section](observation.html#notes) below.",
            "requirements": "An observation exists to have a value, though it might not if it is in error, or if it represents a group of observations.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "string"
              },
              {
                "code": "boolean"
              },
              {
                "code": "integer"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "time"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Observation.component.dataAbsentReason",
            "path": "Observation.component.dataAbsentReason",
            "short": "Why the component result is missing",
            "definition": "Provides a reason why the expected value in the element Observation.component.value[x] is missing.",
            "comment": "\"Null\" or exceptional values can be represented two ways in FHIR Observations.  One way is to simply include them in the value set and represent the exceptions in the value.  For example, measurement values for a serology test could be  \"detected\", \"not detected\", \"inconclusive\", or  \"test not done\". \n\nThe alternate way is to use the value element for actual observations and use the explicit dataAbsentReason element to record exceptional values.  For example, the dataAbsentReason code \"error\" could be used when the measurement was not completed.  Because of these options, use-case agreements are required to interpret general observations for exceptional values.",
            "requirements": "For many results it is necessary to handle exceptional values in measurements.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "obs-6"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationValueAbsentReason"
                }
              ],
              "strength": "extensible",
              "description": "Codes specifying why the result (`Observation.value[x]`) is missing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/data-absent-reason"
            }
          },
          {
            "id": "Observation.component.interpretation",
            "path": "Observation.component.interpretation",
            "short": "High, low, normal, etc.",
            "definition": "A categorical assessment of an observation value.  For example, high, low, normal.",
            "comment": "Historically used for laboratory results (known as 'abnormal flag' ),  its use extends to other use cases where coded interpretations  are relevant.  Often reported as one or more simple compact codes this element is often placed adjacent to the result value in reports and flow sheets to signal the meaning/normalcy status of the result.",
            "requirements": "For some results, particularly numeric results, an interpretation is necessary to fully understand the significance of a result.",
            "alias": [
              "Abnormal Flag"
            ],
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
                  "valueString": "ObservationInterpretation"
                }
              ],
              "strength": "extensible",
              "description": "Codes identifying interpretations of observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-interpretation"
            }
          },
          {
            "id": "Observation.component.referenceRange",
            "path": "Observation.component.referenceRange",
            "short": "Provides guide for interpretation of component result",
            "definition": "Guidance on how to interpret the value by comparison to a normal or recommended range.",
            "comment": "Most observations only have one generic reference range. Systems MAY choose to restrict to only supplying the relevant reference range based on knowledge about the patient (e.g., specific to the patient's age, gender, weight and other factors), but this might not be possible or appropriate. Whenever more than one reference range is supplied, the differences between them SHOULD be provided in the reference range and/or age properties.",
            "requirements": "Knowing what values are considered \"normal\" can help evaluate the significance of a particular result. Need to be able to provide multiple reference ranges for different contexts.",
            "min": 0,
            "max": "*",
            "contentReference": "#Observation.referenceRange"
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Observation'
    /// </summary>
    // 0. Observation
    public partial class Resource_Observation : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 21. Observation.referenceRange
        public partial class Type_ReferenceRange : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. Observation.referenceRange.low
            public ElementDefinitionInfo Element_Low;
            // 23. Observation.referenceRange.high
            public ElementDefinitionInfo Element_High;
            // 24. Observation.referenceRange.type
            public ElementDefinitionInfo Element_Type;
            // 25. Observation.referenceRange.appliesTo
            public ElementDefinitionInfo Element_AppliesTo;
            // 26. Observation.referenceRange.age
            public ElementDefinitionInfo Element_Age;
            // 27. Observation.referenceRange.text
            public ElementDefinitionInfo Element_Text;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Observation.referenceRange",
                    ElementId = "Observation.referenceRange"
                });
                Element_Low.Write(sDef);
                Element_High.Write(sDef);
                Element_Type.Write(sDef);
                Element_AppliesTo.Write(sDef);
                Element_Age.Write(sDef);
                Element_Text.Write(sDef);
            }
            
            public Type_ReferenceRange()
            {
                {
                    // 22. Observation.referenceRange.low
                    this.Element_Low = new ElementDefinitionInfo
                    {
                        Name = "Element_Low",
                        Path= "Observation.referenceRange.low",
                        Id = "Observation.referenceRange.low",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 23. Observation.referenceRange.high
                    this.Element_High = new ElementDefinitionInfo
                    {
                        Name = "Element_High",
                        Path= "Observation.referenceRange.high",
                        Id = "Observation.referenceRange.high",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 24. Observation.referenceRange.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Observation.referenceRange.type",
                        Id = "Observation.referenceRange.type",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 25. Observation.referenceRange.appliesTo
                    this.Element_AppliesTo = new ElementDefinitionInfo
                    {
                        Name = "Element_AppliesTo",
                        Path= "Observation.referenceRange.appliesTo",
                        Id = "Observation.referenceRange.appliesTo",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 26. Observation.referenceRange.age
                    this.Element_Age = new ElementDefinitionInfo
                    {
                        Name = "Element_Age",
                        Path= "Observation.referenceRange.age",
                        Id = "Observation.referenceRange.age",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 27. Observation.referenceRange.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "Observation.referenceRange.text",
                        Id = "Observation.referenceRange.text",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
            }
        }
        // 30. Observation.component
        public partial class Type_Component : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 31. Observation.component.code
            public ElementDefinitionInfo Element_Code;
            // 32. Observation.component.value[x]
            public ElementDefinitionInfo Element_Value;
            // 33. Observation.component.dataAbsentReason
            public ElementDefinitionInfo Element_DataAbsentReason;
            // 34. Observation.component.interpretation
            public ElementDefinitionInfo Element_Interpretation;
            // 35. Observation.component.referenceRange
            public ElementDefinitionInfo Element_ReferenceRange;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Observation.component",
                    ElementId = "Observation.component"
                });
                Element_Code.Write(sDef);
                Element_Value.Write(sDef);
                Element_DataAbsentReason.Write(sDef);
                Element_Interpretation.Write(sDef);
                Element_ReferenceRange.Write(sDef);
            }
            
            public Type_Component()
            {
                {
                    // 31. Observation.component.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Observation.component.code",
                        Id = "Observation.component.code",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 32. Observation.component.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Observation.component.value[x]",
                        Id = "Observation.component.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_SampledData
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
                {
                    // 33. Observation.component.dataAbsentReason
                    this.Element_DataAbsentReason = new ElementDefinitionInfo
                    {
                        Name = "Element_DataAbsentReason",
                        Path= "Observation.component.dataAbsentReason",
                        Id = "Observation.component.dataAbsentReason",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 34. Observation.component.interpretation
                    this.Element_Interpretation = new ElementDefinitionInfo
                    {
                        Name = "Element_Interpretation",
                        Path= "Observation.component.interpretation",
                        Id = "Observation.component.interpretation",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 35. Observation.component.referenceRange
                    this.Element_ReferenceRange = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferenceRange",
                        Path= "Observation.component.referenceRange",
                        Id = "Observation.component.referenceRange",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. Observation.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Observation.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. Observation.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 4. Observation.status
        public ElementDefinitionInfo Element_Status;
        // 5. Observation.category
        public ElementDefinitionInfo Element_Category;
        // 6. Observation.code
        public ElementDefinitionInfo Element_Code;
        // 7. Observation.subject
        public ElementDefinitionInfo Element_Subject;
        // 8. Observation.focus
        public ElementDefinitionInfo Element_Focus;
        // 9. Observation.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 10. Observation.effective[x]
        public ElementDefinitionInfo Element_Effective;
        // 11. Observation.issued
        public ElementDefinitionInfo Element_Issued;
        // 12. Observation.performer
        public ElementDefinitionInfo Element_Performer;
        // 13. Observation.value[x]
        public ElementDefinitionInfo Element_Value;
        // 14. Observation.dataAbsentReason
        public ElementDefinitionInfo Element_DataAbsentReason;
        // 15. Observation.interpretation
        public ElementDefinitionInfo Element_Interpretation;
        // 16. Observation.note
        public ElementDefinitionInfo Element_Note;
        // 17. Observation.bodySite
        public ElementDefinitionInfo Element_BodySite;
        // 18. Observation.method
        public ElementDefinitionInfo Element_Method;
        // 19. Observation.specimen
        public ElementDefinitionInfo Element_Specimen;
        // 20. Observation.device
        public ElementDefinitionInfo Element_Device;
        // 21. Observation.referenceRange
        public ElementDefinitionInfo Element_ReferenceRange;
        // 28. Observation.hasMember
        public ElementDefinitionInfo Element_HasMember;
        // 29. Observation.derivedFrom
        public ElementDefinitionInfo Element_DerivedFrom;
        // 30. Observation.component
        public ElementDefinitionInfo Element_Component;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Observation",
                ElementId = "Observation"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_Category.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Focus.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Effective.Write(sDef);
            Element_Issued.Write(sDef);
            Element_Performer.Write(sDef);
            Element_Value.Write(sDef);
            Element_DataAbsentReason.Write(sDef);
            Element_Interpretation.Write(sDef);
            Element_Note.Write(sDef);
            Element_BodySite.Write(sDef);
            Element_Method.Write(sDef);
            Element_Specimen.Write(sDef);
            Element_Device.Write(sDef);
            Element_ReferenceRange.Write(sDef);
            Element_HasMember.Write(sDef);
            Element_DerivedFrom.Write(sDef);
            Element_Component.Write(sDef);
        }
        
        public Resource_Observation()
        {
            {
                // 1. Observation.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Observation.identifier",
                    Id = "Observation.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. Observation.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "Observation.basedOn",
                    Id = "Observation.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",
                                "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                                "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                                "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 3. Observation.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Observation.partOf",
                    Id = "Observation.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                                "http://hl7.org/fhir/StructureDefinition/MedicationDispense",
                                "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                                "http://hl7.org/fhir/StructureDefinition/Procedure",
                                "http://hl7.org/fhir/StructureDefinition/Immunization",
                                "http://hl7.org/fhir/StructureDefinition/ImagingStudy"
                            }
                        }
                    }
                };
            }
            {
                // 4. Observation.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Observation.status",
                    Id = "Observation.status",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 5. Observation.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "Observation.category",
                    Id = "Observation.category",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 6. Observation.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Observation.code",
                    Id = "Observation.code",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 7. Observation.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Observation.subject",
                    Id = "Observation.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 8. Observation.focus
                this.Element_Focus = new ElementDefinitionInfo
                {
                    Name = "Element_Focus",
                    Path= "Observation.focus",
                    Id = "Observation.focus",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 9. Observation.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Observation.encounter",
                    Id = "Observation.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 10. Observation.effective[x]
                this.Element_Effective = new ElementDefinitionInfo
                {
                    Name = "Element_Effective",
                    Path= "Observation.effective[x]",
                    Id = "Observation.effective[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        }
                    }
                };
            }
            {
                // 11. Observation.issued
                this.Element_Issued = new ElementDefinitionInfo
                {
                    Name = "Element_Issued",
                    Path= "Observation.issued",
                    Id = "Observation.issued",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        }
                    }
                };
            }
            {
                // 12. Observation.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "Observation.performer",
                    Id = "Observation.performer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 13. Observation.value[x]
                this.Element_Value = new ElementDefinitionInfo
                {
                    Name = "Element_Value",
                    Path= "Observation.value[x]",
                    Id = "Observation.value[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Ratio
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_SampledData
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Time
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 14. Observation.dataAbsentReason
                this.Element_DataAbsentReason = new ElementDefinitionInfo
                {
                    Name = "Element_DataAbsentReason",
                    Path= "Observation.dataAbsentReason",
                    Id = "Observation.dataAbsentReason",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 15. Observation.interpretation
                this.Element_Interpretation = new ElementDefinitionInfo
                {
                    Name = "Element_Interpretation",
                    Path= "Observation.interpretation",
                    Id = "Observation.interpretation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 16. Observation.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Observation.note",
                    Id = "Observation.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 17. Observation.bodySite
                this.Element_BodySite = new ElementDefinitionInfo
                {
                    Name = "Element_BodySite",
                    Path= "Observation.bodySite",
                    Id = "Observation.bodySite",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 18. Observation.method
                this.Element_Method = new ElementDefinitionInfo
                {
                    Name = "Element_Method",
                    Path= "Observation.method",
                    Id = "Observation.method",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 19. Observation.specimen
                this.Element_Specimen = new ElementDefinitionInfo
                {
                    Name = "Element_Specimen",
                    Path= "Observation.specimen",
                    Id = "Observation.specimen",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Specimen"
                            }
                        }
                    }
                };
            }
            {
                // 20. Observation.device
                this.Element_Device = new ElementDefinitionInfo
                {
                    Name = "Element_Device",
                    Path= "Observation.device",
                    Id = "Observation.device",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/DeviceMetric"
                            }
                        }
                    }
                };
            }
            {
                // 21. Observation.referenceRange
                this.Element_ReferenceRange = new ElementDefinitionInfo
                {
                    Name = "Element_ReferenceRange",
                    Path= "Observation.referenceRange",
                    Id = "Observation.referenceRange",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ReferenceRange
                        {
                        }
                    }
                };
            }
            {
                // 28. Observation.hasMember
                this.Element_HasMember = new ElementDefinitionInfo
                {
                    Name = "Element_HasMember",
                    Path= "Observation.hasMember",
                    Id = "Observation.hasMember",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                            }
                        }
                    }
                };
            }
            {
                // 29. Observation.derivedFrom
                this.Element_DerivedFrom = new ElementDefinitionInfo
                {
                    Name = "Element_DerivedFrom",
                    Path= "Observation.derivedFrom",
                    Id = "Observation.derivedFrom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
                                "http://hl7.org/fhir/StructureDefinition/Media",
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                            }
                        }
                    }
                };
            }
            {
                // 30. Observation.component
                this.Element_Component = new ElementDefinitionInfo
                {
                    Name = "Element_Component",
                    Path= "Observation.component",
                    Id = "Observation.component",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Component
                        {
                        }
                    }
                };
            }
            this.Name = "Observation";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Observation";
        }
    }
}
