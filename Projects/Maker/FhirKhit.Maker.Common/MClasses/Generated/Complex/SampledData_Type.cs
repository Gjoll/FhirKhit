using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common
{
    /// <summary>
    /// Fhir primitive 'SampledData'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "SampledData",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/SampledData",
    ///   "version": "4.0.0",
    ///   "name": "SampledData",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for SampledData Type: A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.",
    ///   "purpose": "There is a need for a concise way to handle the data produced by devices that sample a physical state at a high frequency.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "SampledData",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "SampledData",
    ///         "extension": [
    ///           {
    ///             "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status",
    ///             "valueCode": "trial-use"
    ///           }
    ///         ],
    ///         "path": "SampledData",
    ///         "short": "A series of measurements taken by a device",
    ///         "definition": "A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.",
    ///         "comment": "The data is not interpretable without at least origin, period, and dimensions, but these are optional to allow a separation between the template of measurement and the actual measurement, such as between DeviceCapabilities and DeviceLog.  When providing a summary view (for example with Observation.value[x]) SampledData should be represented with a brief display text such as \"Sampled Data\".",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "SampledData.origin",
    ///         "path": "SampledData.origin",
    ///         "short": "Zero value and units",
    ///         "definition": "The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Quantity",
    ///             "profile": [
    ///               "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.period",
    ///         "path": "SampledData.period",
    ///         "short": "Number of milliseconds between samples",
    ///         "definition": "The length of time between sampling times, measured in milliseconds.",
    ///         "comment": "This is usually a whole number.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "decimal"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.factor",
    ///         "path": "SampledData.factor",
    ///         "short": "Multiply data by this before adding to origin",
    ///         "definition": "A correction factor that is applied to the sampled data points before they are added to the origin.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "decimal"
    ///           }
    ///         ],
    ///         "meaningWhenMissing": "If no factor is assigned, the data is not adjusted before adding to the origin",
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.lowerLimit",
    ///         "path": "SampledData.lowerLimit",
    ///         "short": "Lower limit of detection",
    ///         "definition": "The lower limit of detection of the measured points. This is needed if any of the data points have the value \"L\" (lower than detection limit).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "decimal"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.upperLimit",
    ///         "path": "SampledData.upperLimit",
    ///         "short": "Upper limit of detection",
    ///         "definition": "The upper limit of detection of the measured points. This is needed if any of the data points have the value \"U\" (higher than detection limit).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "decimal"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.dimensions",
    ///         "path": "SampledData.dimensions",
    ///         "short": "Number of sample points at each time point",
    ///         "definition": "The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once.",
    ///         "comment": "If there is more than one dimension, the code for the type of data will define the meaning of the dimensions (typically ECG data).",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "positiveInt"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "SampledData.data",
    ///         "path": "SampledData.data",
    ///         "short": "Decimal values with spaces, or \"E\" | \"U\" | \"L\"",
    ///         "definition": "A series of data points which are decimal values separated by a single space (character u20). The special values \"E\" (error), \"L\" (below detection limit) and \"U\" (above detection limit) can also be used in place of a decimal value.",
    ///         "comment": "Data may be missing if it is omitted for summarization purposes. In general, data is required for any actual use of a SampledData.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ]
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    public class SampledData_Type : Complex_Type
    {
    }
}
