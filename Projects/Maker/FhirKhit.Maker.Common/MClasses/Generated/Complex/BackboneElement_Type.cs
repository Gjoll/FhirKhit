using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'BackboneElement'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "BackboneElement",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
    ///   "version": "4.0.0",
    ///   "name": "BackboneElement",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for BackboneElement Type: Base definition for all elements that are defined inside a resource - but not those in a data type.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": true,
    ///   "type": "BackboneElement",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "BackboneElement",
    ///         "path": "BackboneElement",
    ///         "short": "Base for elements defined inside a resource",
    ///         "definition": "Base definition for all elements that are defined inside a resource - but not those in a data type.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "BackboneElement.modifierExtension",
    ///         "path": "BackboneElement.modifierExtension",
    ///         "short": "Extensions that cannot be ignored even if unrecognized",
    ///         "definition": "May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.\n\nModifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).",
    ///         "comment": "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.",
    ///         "requirements": "Modifier extensions allow for extensions that *cannot* be safely ignored to be clearly distinguished from the vast majority of extensions which can be safely ignored.  This promotes interoperability by eliminating the need for implementers to prohibit the presence of extensions. For further information, see the [definition of modifier extensions](extensibility.html#modifierExtension).",
    ///         "alias": [
    ///           "extensions",
    ///           "user content",
    ///           "modifiers"
    ///         ],
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Extension"
    ///           }
    ///         ],
    ///         "isModifier": true,
    ///         "isModifierReason": "Modifier extensions are expected to modify the meaning or interpretation of the element that contains them",
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. BackboneElement
    public class BackboneElement_Type : MakerComplex_Type                                                                                   // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. BackboneElement.modifierExtension
        public MakerElementInstance ModifierExtension;                                                                                      // MakerGen.cs:217
        public BackboneElement_Type()                                                                                                       // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. BackboneElement.modifierExtension
                this.ModifierExtension = new MakerElementInstance                                                                           // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "ModifierExtension",                                                                                             // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
