using FhirKhit.SliceGen.CSApi;
using FhirKhit.Tools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

#if FHIR_R2
using FhirKhit.Tools.R2;
#elif FHIR_R3
using FhirKhit.Tools.R3;
#elif FHIR_R4
using FhirKhit.Tools.R4;
#endif

namespace FhirKhit.SliceGen.R4
{
    /// <summary>
    /// Entry point to profile generator.
    /// The profile generator creates an outpout class (c#, java, etc) that will implement the 
    /// methods of the indicated profile. 
    /// The output class wraps a class instance of the base resource (c#, jave, etc) and
    /// operates on the wrapped items instance data but maintains the profiles interface.
    /// ToDo:
    ///     - Currently nested items (i.e. Observation.ReferenceRange) are treatd like fhir primitives. Need to create profiles on these
    ///       nested classes, both for simgletones and for lists, including adders and such.
    /// </summary>
    public class SliceGenerator : ConverterBase
    {
        public enum OutputLanguageType
        {
            Unset,
            CSharp
        };

        public static ZipSource Source
        {
            get
            {
                if (SliceGenerator.source == null)
                    SliceGenerator.source = new ZipSource("specification.zip");
                return SliceGenerator.source;
            }
        }
        static ZipSource source = null;

        /// <summary>
        /// Output language
        /// </summary>
        public OutputLanguageType OutputLanguage { get; private set; }

        /// <summary>
        /// Output namespace
        /// </summary>
        public String NameSpace { get; private set; }

        /// <summary>
        /// Output directory
        /// </summary>
        public String OutputDir { get; private set; }

        Dictionary<Type, String> SubClasses = new Dictionary<Type, string>();

        List<StructureDefinition> profiles = new List<StructureDefinition>();

        /// <summary>
        /// Constructor
        /// </summary>
        public SliceGenerator(OutputLanguageType outputLanguage,
            String nameSpace,
            String outputDir)
        {
            CodeEditor.DebugFlag = true;
            this.OutputLanguage = outputLanguage;
            this.NameSpace = nameSpace;
            this.OutputDir = outputDir;
        }

        public bool TryGetSubClass(Type type, out String name)
        {
            return this.SubClasses.TryGetValue(type, out name);
        }

        public void AddSubClass(Type type, String name)
        {
            this.SubClasses.Add(type, name);
        }

        /// <summary>
        /// Process profile into output class
        /// </summary>
        /// <param name="newStructDef"></param>
        /// <param name="outputLanguage"></param>
        /// <returns></returns>
        public void AddProfile(String profilePath)
        {
            this.AddProfile(ReadProfile(profilePath));
        }

        /// <summary>
        /// Process profile into output class
        /// </summary>
        /// <param name="newStructDef"></param>
        /// <param name="outputLanguage"></param>
        /// <returns></returns>
        public void AddProfile(StructureDefinition profile)
        {
            this.profiles.Add(profile);
        }

        public bool Process()
        {
            for (Int32 i = 0; i < this.profiles.Count; i++)
                ProcessProfile(this.profiles[i]);
            return this.HasErrors == false;
        }

        void ProcessProfile(StructureDefinition profile)
        {
            //String fcn = nameof(ProcessProfile);

            if (profile.Snapshot == null)
                SnapshotCreator.Create(profile);
            ElementNode profileItems = ElementNode.Create(profile.Snapshot.Element);

            Type fhirType = this.GetFhirApiType(profile.BaseDefinition);

            GenerateItem gi = new GenerateItem(this,
                this.NameSpace,
                profile.Name,
                profile.Type,
                fhirType,
                this.OutputLanguage,
                profileItems);

            gi.Process();

            String outputFile = Path.Combine(this.OutputDir, $"{profile.Name}.cs");
            File.WriteAllText(outputFile, gi.GetCode());
        }

        /// <summary>
        /// Get type for FHIR api class of indicated fhir uri (resource uri)
        /// </summary>
        /// <param name="baseClassUri"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1054:Uri parameters should not be strings", Justification = "<Pending>")]
        public Type GetFhirApiType(String baseClassUri)
        {
            const String uriPrefix = "HTTP://HL7.ORG/FHIR/STRUCTUREDEFINITION/";

            if (baseClassUri is null)
                throw new ArgumentNullException(nameof(baseClassUri));

            if (baseClassUri.ToUpper().StartsWith(uriPrefix) == false)
                throw new Exception($"Expected Fhir Base Uri to start with '{uriPrefix}'");
            String baseClassName = baseClassUri.Substring(uriPrefix.Length);

            Type fhirType = ModelInfo.GetTypeForFhirType(baseClassName);
            if (fhirType == null)
                throw new Exception($"Can not find Fhir Resource Class for '{baseClassName}'");
            return fhirType;
        }

        /// <summary>
        /// Read profile from disk
        /// </summary>
        /// <returns></returns>
        StructureDefinition ReadProfile(String profilePath)
        {
            const String fcn = nameof(ReadProfile);

            if (File.Exists(profilePath) == false)
                throw new NotImplementedException($"Profile file {profilePath} not found");

            String fhirText = File.ReadAllText(profilePath);
            String ext = Path.GetExtension(profilePath).ToLower();
            Base resource;
            switch (ext)
            {
                case ".xml":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        resource = parser.Parse<Base>(fhirText);
                    }
                    break;

                case ".json":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        resource = parser.Parse(fhirText, typeof(Resource));
                    }
                    break;

                default:
                    throw new NotImplementedException($"Can not handle files of type ");
            }

            if (resource.TypeName != "StructureDefinition")
            {
                this.ConversionError(this.GetType().Name, fcn, $"File {profilePath} is {resource.TypeName}, not StructuredDefinition");
                return null;
            }

            return (StructureDefinition)resource;
        }
    }
}
