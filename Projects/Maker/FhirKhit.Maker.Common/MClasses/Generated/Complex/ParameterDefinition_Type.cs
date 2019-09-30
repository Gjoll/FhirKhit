using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'ParameterDefinition'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "ParameterDefinition",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/ParameterDefinition",
    ///   "version": "4.0.0",
    ///   "name": "ParameterDefinition",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for ParameterDefinition Type: The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "ParameterDefinition",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "ParameterDefinition",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "ParameterDefinition",
    ///         "short": "Definition of a parameter to a module",
    ///         "definition": "The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.name",
    ///         "path": "ParameterDefinition.name",
    ///         "short": "Name used to access the parameter value",
    ///         "definition": "The name of the parameter used to allow access to the value of the parameter in evaluation contexts.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.use",
    ///         "path": "ParameterDefinition.use",
    ///         "short": "in | out",
    ///         "definition": "Whether the parameter is input or output for the module.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "ParameterUse"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "Whether the parameter is input or output.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/operation-parameter-use|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.min",
    ///         "path": "ParameterDefinition.min",
    ///         "short": "Minimum cardinality",
    ///         "definition": "The minimum number of times this parameter SHALL appear in the request or response.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "integer"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.max",
    ///         "path": "ParameterDefinition.max",
    ///         "short": "Maximum cardinality (a number of *)",
    ///         "definition": "The maximum number of times this element is permitted to appear in the request or response.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.documentation",
    ///         "path": "ParameterDefinition.documentation",
    ///         "short": "A brief description of the parameter",
    ///         "definition": "A brief discussion of what the parameter is for and how it is used by the module.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.type",
    ///         "path": "ParameterDefinition.type",
    ///         "short": "What type of value",
    ///         "definition": "The type of the parameter.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "FHIRAllTypes"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "A list of all the concrete types defined in this version of the FHIR specification - Abstract Types, Data Types and Resource Types.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/all-types|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "ParameterDefinition.profile",
    ///         "path": "ParameterDefinition.profile",
    ///         "short": "What profile the value is expected to be",
    ///         "definition": "If specified, this indicates a profile that the input data must conform to, or that the output data will conform to.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "canonical",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class ParameterDefinition_Type : Complex_Type
    {
    }
}
