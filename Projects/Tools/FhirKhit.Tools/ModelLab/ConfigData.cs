using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FhirKhit.Tools
{
    /// <summary>
    /// Base class for Model Lab data files.
    /// </summary>
    [DebuggerDisplay("Title {this.Title}:{this.Guid}")]
    public class ConfigData
    {
        public enum PurposeEnums
        {
            /// <summary>
            /// Ignore section
            /// </summary>
            None,

            /// <summary>
            /// Profile section
            /// </summary>
            Profile,

            /// <summary>
            /// Section is <see langword="abstract"/> composition item referenced by other sections.
            /// </summary>
            ComposeTarget
        }

        public const String Type_ComposeTarget = "ComposeTarget";
        public const String Type_BooleanElement = "BooleanElement";
        public const String Type_CompositionReference = "CompositionReference";
        public const String Type_DateTimeElement = "DateTimeElement";
        public const String Type_ModelPropertyElement = "ModelPropertyElement";
        public const String Type_NumericElement = "NumericElement";
        public const String Type_SelectElement = "SelectElement";
        public const String Type_StringElement = "StringElement";
        public const String Type_StructureElement = "StructureElement";
        public const String Type_ModelSection = "ModelSection";

        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("title")] public string Title { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("guid")] public Guid Guid { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("modelProperties")] public JObject ModelProperties { get; set; }
        [JsonProperty("children")] public List<ConfigData> Children { get; set; } = new List<ConfigData>();

        [JsonProperty("targetPath")] public string TargetPath { get; set; }
        [JsonProperty("targetGuid")] public Guid TargetGuid { get; set; }

        /// <summary>
        /// Valid only on Sections's
        /// </summary>
        public PurposeEnums Section_Purpose
        {
            get
            {
                String purpose = this.GetModelProperty("fhirStructuredDefs", "purpose")?.Trim();
                switch (purpose?.ToUpper())
                {
                    case "COMPOSETARGET":
                        return PurposeEnums.ComposeTarget;

                    case "PROFILE":
                        return PurposeEnums.Profile;

                    case "NONE":
                    case "":
                    case null:
                        return PurposeEnums.None;

                    default:
                        throw new Exception($"Purpose {purpose} not understood");
                }
            }
        }

        /// <summary>
        /// Valid only on projects
        /// </summary>
        public string Project_BaseUrl => this.GetModelProperty("fhirStructuredDefs", "baseurl");

        public string Project_NameSpace => this.GetModelProperty("fhirStructuredDefs", "namespace");

        /// <summary>
        /// Valid only on Sections's
        /// </summary>
        public string Section_BaseDefinition => this.GetModelProperty("fhirStructuredDefs", "basedefinition");

        /// <summary>
        /// Valid only on SelectElement's
        /// </summary>
        public string SelectElement_FieldTerminologySource => this.GetModelProperty("common", "fieldTerminologySource");

        /// <summary>
        /// Valid only on SelectElement's
        /// </summary>
        public string SelectElement_FieldTerminologyId => this.GetModelProperty("common", "fieldTerminologyId");

        public string CIMPLTemplate => this.GetModelProperty("fhirStructuredDefs", "cimplTemplate");
        public string CIMPLMap => this.GetModelProperty("fhirStructuredDefs", "cimplMap");
        public string ProfileMap => this.GetModelProperty("fhirStructuredDefs", "profileMap");
        public string ProfileMatch => this.GetModelProperty("fhirStructuredDefs", "profileMatch");

        /// <summary>
        /// Valid only on OptionElement's
        /// </summary>
        public string OptionElement_TerminologySource => this.GetModelProperty("common", "terminologySource");

        /// <summary>
        /// Valid only on OptionElement's
        /// </summary>
        public string OptionElement_ConceptId => this.GetModelProperty("common", "conceptId");


        public static ConfigData Load(String modelText) => JsonConvert.DeserializeObject<ConfigData>(modelText);
        public static ConfigData Load(JObject section)
        {
            String json = section.ToString();
            return ConfigData.Load(json);
        }

        public void Save(String path)
        {
            String json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Set model property.
        /// </summary>
        public void SetModelProperty(String value, params String[] path)
        {
            JObject item = (JObject)this.ModelProperties;
            if (item == null)
                throw new Exception($"ModelProperties is null");

            for (Int32 i = 0; i < path.Length - 1; i++)
            {
                String pathItem = path[i];
                item = (JObject)item.GetValue(pathItem);
                if (item == null)
                {
                    JObject newItem = new JObject();
                    item.Add(pathItem, newItem);
                    item = newItem;
                }
            }

            JValue itemValue = (JValue)item[path[path.Length - 1]];
            if (itemValue != null)
                item.Remove(path[path.Length - 1]);
            itemValue = new JValue(value);
            item.Add(itemValue);
        }

        /// <summary>
        /// Return model property, or null if not found.
        /// </summary>
        public bool GetModelProperty(out bool value, params String[] path)
        {
            const String fcn = "GetModelProperty";

            value = false;
            String s = GetModelProperty(path);
            switch (s?.ToLower())
            {
                case null:
                    return false;

                case "true":
                    value = true;
                    return true;

                case "false":
                    return true;

                default:
                    throw new Exception($"{fcn}. Invalid boolean value {s}");
            }
        }

        /// <summary>
        /// Return model property, or null if not found.
        /// </summary>
        public String GetModelProperty(params String[] path)
        {
            JObject item = (JObject)this.ModelProperties;
            if (item == null)
                return null;

            for (Int32 i = 0; i < path.Length - 1; i++)
            {
                String pathItem = path[i];
                item = (JObject)item.GetValue(pathItem);
                if (item == null)
                    return null;
            }

            JValue itemValue = (JValue)item[path[path.Length - 1]];
            if (itemValue == null)
                return null;
            return (String)itemValue.Value<String>();
        }
    }
}
