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

namespace FhirKhit.SliceGen.Share
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
    public class ProfileGenerator : ConverterBase
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
                if (ProfileGenerator.source == null)
                    ProfileGenerator.source = new ZipSource("specification.zip");
                return ProfileGenerator.source;
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

        /// <summary>
        /// Structure definition of profiles base resource
        /// </summary>
        public StructDefHelper BaseSDef { get; private set; }

        /// <summary>
        /// Structure defininition of profile
        /// </summary>
        public StructDefHelper ProfileSDef { get; private set; }

        Dictionary<Type, String> SubClasses = new Dictionary<Type, string>();

        List<StructureDefinition> profiles = new List<StructureDefinition>();

        /// <summary>
        /// Constructor
        /// </summary>
        public ProfileGenerator(OutputLanguageType outputLanguage,
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
            //String fcn = "ProcessProfile";

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

#if NEVER
        void ProcessProfile(StructureDefinition profile)
        {
            String fcn = "ProcessProfile";

            if (profile.Snapshot == null)
                SnapshotCreator.Create(profile);
            this.ProfileSDef = new StructDefHelper(profile);

            //IEnumerable<string> y = Source.ListArtifactNames();
            //Resource x = Source.ResolveByUri("http://hl7.org/fhir/DataElement/Identifier");
            //x = Source.FindStructureDefinitionForCoreType("identifier");

            switch (this.OutputLanguage)
            {
                case OutputLanguages.CSharp:
                    this.Code = new CSCodeFormatter(this);
                    break;

                default:
                    throw new Exception($"Output language {OutputLanguage} not found");
            }

            if (this.ProfileSDef.SDef.Derivation.Value != StructureDefinition.TypeDerivationRule.Constraint)
            {
                this.ConversionError(this.GetType().Name, fcn, $"{this.ProfileSDef.SDef.Name} is not a profile (constraint == {this.ProfileSDef.SDef.Derivation.Value.ToString()}");
                return;
            }

            ElementManager elements = new ElementManager();
            elements.Load(profile.Snapshot.Element);

            switch (this.ProfileSDef.SDef.Type)
            {
                case "Extension":
                    this.ProcessExtension(this.ProfileSDef.SDef);
                    break;
                default:
                    this.ProcessResourceConstraint(this.ProfileSDef.SDef);
                    break;
            }
        }

        /// <summary>
        /// Process an extension.
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessExtension(StructureDefinition sd) => false;

        /// <summary>
        /// Process a constraint
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessResourceConstraint(StructureDefinition sd)
        {
            Type fhirType = this.GetFhirApiType(sd.BaseDefinition);
            {
                StructureDefinition baseStructDef = ProfileGenerator.Source.FindStructureDefinition(sd.BaseDefinition);
                if (baseStructDef == null)
                    throw new Exception($"Can not find structdef for {sd.BaseDefinition}");
                this.BaseSDef = new StructDefHelper(baseStructDef);
            }

            this.Code.StartNameSpace(this.NameSpace);
            this.Code.StartClass(sd.Name, fhirType);

            if (sd.Snapshot == null)
                throw new Exception($"Profile {sd.Name} is missing snapshot section");
            if (this.BaseSDef.SDef.Snapshot == null)
                throw new Exception($"Fhir base {this.BaseSDef.SDef.Name} is missing snapshot section");

            foreach (ElementDefinition profileElement in sd.Snapshot.Element.Skip(1))
            {
                String[] elementPathItems = profileElement.Path.Split('.');
                switch (elementPathItems.Length)
                {
                    case 0:
                        throw new NotImplementedException();

                    case 1:         // Only first element should be this.
                        break;

                    case 2:         // Property
                        CreateProperty(profileElement);
                        break;

                    default:        // properties is a structure with sub properties.
                        break;
                }
            }

            this.Code.EndClass();
            this.Code.EndNameSpace();

            this.OutputFile = Path.Combine(this.OutputDir, $"{sd.Name}.cs");
            this.Code.Save(this.OutputFile);
            return true;
        }

        void CreateProperty(ElementDefinition profileElement)
        {
            const String fcn = "CreateProperty";
            if (this.BaseSDef.SnapshotElement(profileElement.Path, out ElementDefinition originalElement) == false)
            {
                this.ConversionError(this.GetType().Name, fcn, $"Property {profileElement.Path} not found in base resource");
                return;
            }
            CreateProperty(originalElement, profileElement);
        }

        /// <summary>
        /// Process element that has been modified from parent element.
        /// </summary>
        /// <param name="elementPaths"></param>
        /// <param name="modifiedElement"></param>
        void CreateProperty(ElementDefinition originalElement, ElementDefinition profileElement)
        {
            const String fcn = "CreateProperty";
            if (profileElement.Path.EndsWith(".extension"))
            {
                this.ConversionWarn(this.GetType().Name, fcn, $"TODO: handle extension {profileElement.FullPath()}");
            }
            else
            {
                Code.CreateProperty(originalElement, profileElement);
            }
        }
#endif

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
            const String fcn = "ReadProfile";

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
