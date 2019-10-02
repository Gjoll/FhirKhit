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
    #endregion
    /// <summary>
    /// Fhir resource 'Media'
    /// </summary>
    // 0. Media
    public partial class Resource_Media : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. Media.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Media.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. Media.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 4. Media.status
        public ElementDefinitionInfo Element_Status;
        // 5. Media.type
        public ElementDefinitionInfo Element_Type;
        // 6. Media.modality
        public ElementDefinitionInfo Element_Modality;
        // 7. Media.view
        public ElementDefinitionInfo Element_View;
        // 8. Media.subject
        public ElementDefinitionInfo Element_Subject;
        // 9. Media.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 10. Media.created[x]
        public ElementDefinitionInfo Element_Created;
        // 11. Media.issued
        public ElementDefinitionInfo Element_Issued;
        // 12. Media.operator
        public ElementDefinitionInfo Element_Operator;
        // 13. Media.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 14. Media.bodySite
        public ElementDefinitionInfo Element_BodySite;
        // 15. Media.deviceName
        public ElementDefinitionInfo Element_DeviceName;
        // 16. Media.device
        public ElementDefinitionInfo Element_Device;
        // 17. Media.height
        public ElementDefinitionInfo Element_Height;
        // 18. Media.width
        public ElementDefinitionInfo Element_Width;
        // 19. Media.frames
        public ElementDefinitionInfo Element_Frames;
        // 20. Media.duration
        public ElementDefinitionInfo Element_Duration;
        // 21. Media.content
        public ElementDefinitionInfo Element_Content;
        // 22. Media.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Media",
                ElementId = "Media"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Modality.Write(sDef);
            Element_View.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Created.Write(sDef);
            Element_Issued.Write(sDef);
            Element_Operator.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_BodySite.Write(sDef);
            Element_DeviceName.Write(sDef);
            Element_Device.Write(sDef);
            Element_Height.Write(sDef);
            Element_Width.Write(sDef);
            Element_Frames.Write(sDef);
            Element_Duration.Write(sDef);
            Element_Content.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_Media()
        {
            {
                // 1. Media.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Media.identifier",
                    Id = "Media.identifier",
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
                // 2. Media.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "Media.basedOn",
                    Id = "Media.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                                "http://hl7.org/fhir/StructureDefinition/CarePlan"
                            }
                        }
                    }
                };
            }
            {
                // 3. Media.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Media.partOf",
                    Id = "Media.partOf",
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
                // 4. Media.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Media.status",
                    Id = "Media.status",
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
                // 5. Media.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Media.type",
                    Id = "Media.type",
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
                // 6. Media.modality
                this.Element_Modality = new ElementDefinitionInfo
                {
                    Name = "Element_Modality",
                    Path= "Media.modality",
                    Id = "Media.modality",
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
                // 7. Media.view
                this.Element_View = new ElementDefinitionInfo
                {
                    Name = "Element_View",
                    Path= "Media.view",
                    Id = "Media.view",
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
                // 8. Media.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Media.subject",
                    Id = "Media.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Specimen",
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 9. Media.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Media.encounter",
                    Id = "Media.encounter",
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
                // 10. Media.created[x]
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "Media.created[x]",
                    Id = "Media.created[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
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
                // 11. Media.issued
                this.Element_Issued = new ElementDefinitionInfo
                {
                    Name = "Element_Issued",
                    Path= "Media.issued",
                    Id = "Media.issued",
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
                // 12. Media.operator
                this.Element_Operator = new ElementDefinitionInfo
                {
                    Name = "Element_Operator",
                    Path= "Media.operator",
                    Id = "Media.operator",
                    Min = 0,
                    Max = 1,
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
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 13. Media.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "Media.reasonCode",
                    Id = "Media.reasonCode",
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
                // 14. Media.bodySite
                this.Element_BodySite = new ElementDefinitionInfo
                {
                    Name = "Element_BodySite",
                    Path= "Media.bodySite",
                    Id = "Media.bodySite",
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
                // 15. Media.deviceName
                this.Element_DeviceName = new ElementDefinitionInfo
                {
                    Name = "Element_DeviceName",
                    Path= "Media.deviceName",
                    Id = "Media.deviceName",
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
            {
                // 16. Media.device
                this.Element_Device = new ElementDefinitionInfo
                {
                    Name = "Element_Device",
                    Path= "Media.device",
                    Id = "Media.device",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/DeviceMetric",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 17. Media.height
                this.Element_Height = new ElementDefinitionInfo
                {
                    Name = "Element_Height",
                    Path= "Media.height",
                    Id = "Media.height",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        }
                    }
                };
            }
            {
                // 18. Media.width
                this.Element_Width = new ElementDefinitionInfo
                {
                    Name = "Element_Width",
                    Path= "Media.width",
                    Id = "Media.width",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        }
                    }
                };
            }
            {
                // 19. Media.frames
                this.Element_Frames = new ElementDefinitionInfo
                {
                    Name = "Element_Frames",
                    Path= "Media.frames",
                    Id = "Media.frames",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        }
                    }
                };
            }
            {
                // 20. Media.duration
                this.Element_Duration = new ElementDefinitionInfo
                {
                    Name = "Element_Duration",
                    Path= "Media.duration",
                    Id = "Media.duration",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        }
                    }
                };
            }
            {
                // 21. Media.content
                this.Element_Content = new ElementDefinitionInfo
                {
                    Name = "Element_Content",
                    Path= "Media.content",
                    Id = "Media.content",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        }
                    }
                };
            }
            {
                // 22. Media.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Media.note",
                    Id = "Media.note",
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
            this.Name = "Media";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Media";
        }
    }
}
