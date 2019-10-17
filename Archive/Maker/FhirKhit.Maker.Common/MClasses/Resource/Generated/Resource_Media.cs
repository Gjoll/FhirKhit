using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "Media",
      "url": "http://hl7.org/fhir/StructureDefinition/Media",
      "version": "4.0.0",
      "name": "Media",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Media",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Media",
            "path": "Media",
            "short": "A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference",
            "definition": "A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Media.identifier",
            "path": "Media.identifier",
            "short": "Identifier(s) for the image",
            "definition": "Identifiers associated with the image - these may include identifiers for the image itself, identifiers for the context of its collection (e.g. series ids) and context ids such as accession numbers or other workflow identifiers.",
            "comment": "The identifier label and use can be used to determine what kind of identifier it is.",
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
            "id": "Media.basedOn",
            "path": "Media.basedOn",
            "short": "Procedure that caused this media to be created",
            "definition": "A procedure that is fulfilled in whole or in part by the creation of this media.",
            "requirements": "Allows tracing of authorization for the event and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/CarePlan"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.partOf",
            "path": "Media.partOf",
            "short": "Part of referenced event",
            "definition": "A larger event of which this particular event is a component or step.",
            "comment": "Not to be used to link an event to an Encounter - use Media.encounter for that.\r\r[The allowed reference resources may be adjusted as appropriate for the event resource].",
            "requirements": "E.g. Drug administration as part of a procedure, procedure as part of observation, etc.",
            "alias": [
              "container"
            ],
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
            "id": "Media.status",
            "path": "Media.status",
            "short": "preparation | in-progress | not-done | suspended | aborted | completed | entered-in-error | unknown",
            "definition": "The current state of the {{title}}.",
            "comment": "A nominal state-transition diagram can be found in the [[event.html#statemachine | Event pattern]] documentation\r\rUnknown does not represent \"other\" - one of the defined statuses must apply.  Unknown is used when the authoring system is not sure what the current status is.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MediaStatus"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the lifecycle stage of an event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/event-status|4.0.0"
            }
          },
          {
            "id": "Media.type",
            "path": "Media.type",
            "short": "Classification of media as image, video, or audio",
            "definition": "A code that classifies whether the media is an image, video or audio recording or some other media category.",
            "requirements": "Used for filtering what observations are retrieved and displayed.",
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
                  "valueString": "MediaType"
                }
              ],
              "strength": "extensible",
              "description": "Codes for high level media categories.",
              "valueSet": "http://hl7.org/fhir/ValueSet/media-type"
            }
          },
          {
            "id": "Media.modality",
            "path": "Media.modality",
            "short": "The type of acquisition equipment/process",
            "definition": "Details of the type of the media - usually, how it was acquired (what type of device). If images sourced from a DICOM system, are wrapped in a Media resource, then this is the modality.",
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
                  "valueString": "MediaModality"
                }
              ],
              "strength": "example",
              "description": "Detailed information about the type of the image - its kind, purpose, or the kind of equipment used to generate it.",
              "valueSet": "http://hl7.org/fhir/ValueSet/media-modality"
            }
          },
          {
            "id": "Media.view",
            "path": "Media.view",
            "short": "Imaging view, e.g. Lateral or Antero-posterior",
            "definition": "The name of the imaging view e.g. Lateral or Antero-posterior (AP).",
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
                  "valueString": "MediaView"
                }
              ],
              "strength": "example",
              "description": "Imaging view (projection) used when collecting an image.",
              "valueSet": "http://hl7.org/fhir/ValueSet/media-view"
            }
          },
          {
            "id": "Media.subject",
            "path": "Media.subject",
            "short": "Who/What this Media is a record of",
            "definition": "Who/What this Media is a record of.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Specimen",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.encounter",
            "path": "Media.encounter",
            "short": "Encounter associated with media",
            "definition": "The encounter that establishes the context for this media.",
            "comment": "This will typically be the encounter the media occurred within.",
            "requirements": "Links the Media to the Encounter context.",
            "alias": [
              "context"
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
            "id": "Media.created[x]",
            "path": "Media.created[x]",
            "short": "When Media was collected",
            "definition": "The date and time(s) at which the media was collected.",
            "alias": [
              "timing"
            ],
            "min": 0,
            "max": "1",
            "type": [
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
            "id": "Media.issued",
            "path": "Media.issued",
            "short": "Date/Time this version was made available",
            "definition": "The date and time this version of the media was made available to providers, typically after having been reviewed.",
            "comment": "It may be the same as the [`lastUpdated` ](resource-definitions.html#Meta.lastUpdated) time of the resource itself.  For Observations that do require review and verification for certain updates, it might not be the same as the `lastUpdated` time of the resource itself due to a non-clinically significant update that does not require the new version to be reviewed and verified again.",
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
            "id": "Media.operator",
            "path": "Media.operator",
            "short": "The person who generated the image",
            "definition": "The person who administered the collection of the image.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.reasonCode",
            "path": "Media.reasonCode",
            "short": "Why was event performed?",
            "definition": "Describes why the event occurred in coded or textual form.",
            "comment": "Textual reasons can be captured using reasonCode.text.",
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
                  "valueString": "MediaReason"
                }
              ],
              "strength": "example",
              "description": "The reason for the media.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-reason"
            }
          },
          {
            "id": "Media.bodySite",
            "path": "Media.bodySite",
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
            "id": "Media.deviceName",
            "path": "Media.deviceName",
            "short": "Name of the device/manufacturer",
            "definition": "The name of the device / manufacturer of the device  that was used to make the recording.",
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
            "id": "Media.device",
            "path": "Media.device",
            "short": "Observing Device",
            "definition": "The device used to collect the media.",
            "comment": "An extension should be used if further typing of the device is needed.  Secondary devices used to support collecting a media can be represented using either extension or through the Observation.related element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/DeviceMetric",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.height",
            "path": "Media.height",
            "short": "Height of the image in pixels (photo/video)",
            "definition": "Height of the image in pixels (photo/video).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.width",
            "path": "Media.width",
            "short": "Width of the image in pixels (photo/video)",
            "definition": "Width of the image in pixels (photo/video).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.frames",
            "path": "Media.frames",
            "short": "Number of frames if > 1 (photo)",
            "definition": "The number of frames in a photo. This is used with a multi-page fax, or an imaging acquisition context that takes multiple slices in a single image, or an animated gif. If there is more than one frame, this SHALL have a value in order to alert interface software that a multi-frame capable rendering widget is required.",
            "comment": "if the number of frames is not supplied, the value may be unknown. Applications should not assume that there is only one frame unless it is explicitly stated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.duration",
            "path": "Media.duration",
            "short": "Length in seconds (audio / video)",
            "definition": "The duration of the recording in seconds - for audio and video.",
            "comment": "The duration might differ from occurrencePeriod if recording was paused.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.content",
            "path": "Media.content",
            "short": "Actual Media - reference or data",
            "definition": "The actual content of the media - inline or by direct reference to the media source file.",
            "comment": "Recommended content types: image/jpeg, image/png, image/tiff, video/mpeg, audio/mp4, application/dicom. Application/dicom can contain the transfer syntax as a parameter.  For media that covers a period of time (video/sound), the content.creationTime is the end time. Creation time is used for tracking, organizing versions and searching.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Media.note",
            "path": "Media.note",
            "short": "Comments made about the media",
            "definition": "Comments made about the media by the performer, subject or other participants.",
            "comment": "Not to be used for observations, conclusions, etc. Instead use an [Observation](observation.html) based on the Media/ImagingStudy resource.",
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'Media'
    /// </summary>
    // 0. Media
    public partial class Resource_Media : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Media.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. Media.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:217
        // 3. Media.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:217
        // 4. Media.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 5. Media.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 6. Media.modality
        public ElementDefinitionInfo Element_Modality;                                                                                      // MakerGen.cs:217
        // 7. Media.view
        public ElementDefinitionInfo Element_View;                                                                                          // MakerGen.cs:217
        // 8. Media.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 9. Media.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:217
        // 10. Media.created[x]
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:217
        // 11. Media.issued
        public ElementDefinitionInfo Element_Issued;                                                                                        // MakerGen.cs:217
        // 12. Media.operator
        public ElementDefinitionInfo Element_Operator;                                                                                      // MakerGen.cs:217
        // 13. Media.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:217
        // 14. Media.bodySite
        public ElementDefinitionInfo Element_BodySite;                                                                                      // MakerGen.cs:217
        // 15. Media.deviceName
        public ElementDefinitionInfo Element_DeviceName;                                                                                    // MakerGen.cs:217
        // 16. Media.device
        public ElementDefinitionInfo Element_Device;                                                                                        // MakerGen.cs:217
        // 17. Media.height
        public ElementDefinitionInfo Element_Height;                                                                                        // MakerGen.cs:217
        // 18. Media.width
        public ElementDefinitionInfo Element_Width;                                                                                         // MakerGen.cs:217
        // 19. Media.frames
        public ElementDefinitionInfo Element_Frames;                                                                                        // MakerGen.cs:217
        // 20. Media.duration
        public ElementDefinitionInfo Element_Duration;                                                                                      // MakerGen.cs:217
        // 21. Media.content
        public ElementDefinitionInfo Element_Content;                                                                                       // MakerGen.cs:217
        // 22. Media.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Media",                                                                                                             // MakerGen.cs:393
                ElementId = "Media"                                                                                                         // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Modality.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_View.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Issued.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Operator.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_BodySite.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_DeviceName.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Device.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Height.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Width.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Frames.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Duration.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Content.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_Media()                                                                                                             // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Media.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "Media.identifier",                                                                                               // MakerGen.cs:237
                    Id = "Media.identifier",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Media.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:236
                    Path= "Media.basedOn",                                                                                                  // MakerGen.cs:237
                    Id = "Media.basedOn",                                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                                   // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/CarePlan"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. Media.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:236
                    Path= "Media.partOf",                                                                                                   // MakerGen.cs:237
                    Id = "Media.partOf",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. Media.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "Media.status",                                                                                                   // MakerGen.cs:237
                    Id = "Media.status",                                                                                                    // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. Media.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "Media.type",                                                                                                     // MakerGen.cs:237
                    Id = "Media.type",                                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. Media.modality
                this.Element_Modality = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Modality",                                                                                              // MakerGen.cs:236
                    Path= "Media.modality",                                                                                                 // MakerGen.cs:237
                    Id = "Media.modality",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. Media.view
                this.Element_View = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_View",                                                                                                  // MakerGen.cs:236
                    Path= "Media.view",                                                                                                     // MakerGen.cs:237
                    Id = "Media.view",                                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. Media.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "Media.subject",                                                                                                  // MakerGen.cs:237
                    Id = "Media.subject",                                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Specimen",                                                         // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. Media.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:236
                    Path= "Media.encounter",                                                                                                // MakerGen.cs:237
                    Id = "Media.encounter",                                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. Media.created[x]
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Created",                                                                                               // MakerGen.cs:236
                    Path= "Media.created[x]",                                                                                               // MakerGen.cs:237
                    Id = "Media.created[x]",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. Media.issued
                this.Element_Issued = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Issued",                                                                                                // MakerGen.cs:236
                    Path= "Media.issued",                                                                                                   // MakerGen.cs:237
                    Id = "Media.issued",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. Media.operator
                this.Element_Operator = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Operator",                                                                                              // MakerGen.cs:236
                    Path= "Media.operator",                                                                                                 // MakerGen.cs:237
                    Id = "Media.operator",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/CareTeam",                                                         // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. Media.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:236
                    Path= "Media.reasonCode",                                                                                               // MakerGen.cs:237
                    Id = "Media.reasonCode",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. Media.bodySite
                this.Element_BodySite = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_BodySite",                                                                                              // MakerGen.cs:236
                    Path= "Media.bodySite",                                                                                                 // MakerGen.cs:237
                    Id = "Media.bodySite",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. Media.deviceName
                this.Element_DeviceName = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DeviceName",                                                                                            // MakerGen.cs:236
                    Path= "Media.deviceName",                                                                                               // MakerGen.cs:237
                    Id = "Media.deviceName",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 16. Media.device
                this.Element_Device = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Device",                                                                                                // MakerGen.cs:236
                    Path= "Media.device",                                                                                                   // MakerGen.cs:237
                    Id = "Media.device",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/DeviceMetric",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 17. Media.height
                this.Element_Height = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Height",                                                                                                // MakerGen.cs:236
                    Path= "Media.height",                                                                                                   // MakerGen.cs:237
                    Id = "Media.height",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. Media.width
                this.Element_Width = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Width",                                                                                                 // MakerGen.cs:236
                    Path= "Media.width",                                                                                                    // MakerGen.cs:237
                    Id = "Media.width",                                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 19. Media.frames
                this.Element_Frames = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Frames",                                                                                                // MakerGen.cs:236
                    Path= "Media.frames",                                                                                                   // MakerGen.cs:237
                    Id = "Media.frames",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 20. Media.duration
                this.Element_Duration = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Duration",                                                                                              // MakerGen.cs:236
                    Path= "Media.duration",                                                                                                 // MakerGen.cs:237
                    Id = "Media.duration",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 21. Media.content
                this.Element_Content = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Content",                                                                                               // MakerGen.cs:236
                    Path= "Media.content",                                                                                                  // MakerGen.cs:237
                    Id = "Media.content",                                                                                                   // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Attachment                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 22. Media.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:236
                    Path= "Media.note",                                                                                                     // MakerGen.cs:237
                    Id = "Media.note",                                                                                                      // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "Media";                                                                                                            // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Media";                                                                     // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
