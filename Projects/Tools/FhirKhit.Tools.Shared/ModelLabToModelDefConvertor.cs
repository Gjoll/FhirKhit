using FhirKhit.Tools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// Convert model lab files to modeldef files.
    /// 
    /// Todo:
    /// </summary>
    public class ModelLabToModelDefConvertor : ModelLabVisitor<ModelSectionData>, IDisposable
{
    public ModelDefProject OutputCache = new ModelDefProject();
    public ModelDefProject.ProjectDataClass ProjectData => this.OutputCache.ProjectData;

    public ModelLabProject Project;

    public FhirDateTime Date
    {
        get
        {
            if (this.date != null)
                return this.date;
            return new FhirDateTime(DateTimeOffset.Now);
        }
        set { this.date = value; }
    }
    FhirDateTime date = null;
    IModelLabReader modelLabReader;

    /// <summary>
    /// Constructor.
    /// </summary>
    public ModelLabToModelDefConvertor(IModelLabReader modelLabReader)
    {
        this.modelLabReader = modelLabReader;
    }

    public void Dispose()
    {
    }

    public bool Convert()
    {
        const String fcn = "ModelLabToModelDefConvertor.Convert";

        Log.Info("ModelLabToModelDefConvertor.Convert", $"Conversion start");
        /*
        public List<ReferenceItem> ReferenceItems = new List<ReferenceItem>();
        public List<AuthorItem> AuthorItems = new List<AuthorItem>();
         */
        {
            ConfigData configData = this.Project.ConfigData;
            {
                this.ProjectData.PublicationStatus =
                    configData.GetModelProperty("fhirStructuredDefs", "publicationStatus");
                if (this.ProjectData.PublicationStatus == null)
                {
                    this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing PublicationStatus. Using unknown");
                    this.ProjectData.PublicationStatus = "unknown";
                }
            }

            {
                this.ProjectData.ProjectCopyrightText =
                    configData.GetModelProperty("fhirStructuredDefs", "copyright");
                if (this.ProjectData.ProjectCopyrightText == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing ProjectCopyrightText");
            }

            this.ProjectData.BaseUrl = this.Project.BaseUrl;
            {
                this.ProjectData.ProjectContactUrl =
                    configData.GetModelProperty("fhirStructuredDefs", "contactUrl");
                if (this.ProjectData.ProjectContactUrl == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing ProjectContactUrl");
            }

            {
                this.ProjectData.NameOfPublishingEntity =
                    configData.GetModelProperty("fhirStructuredDefs", "nameOfPublishingEntity");
                if (this.ProjectData.NameOfPublishingEntity == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing NameOfPublishingEntity");
            }

            {
                this.ProjectData.ProjectVersion =
                    configData.GetModelProperty("fhirStructuredDefs", "projectVersion");
                if (this.ProjectData.ProjectVersion == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing ProjectVersion");
            }

            {
                this.ProjectData.AbbreviatedProjectName =
                    configData.GetModelProperty("fhirStructuredDefs", "abbreviatedProjectName");
                if (this.ProjectData.AbbreviatedProjectName == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing AbbreviatedProjectName");
            }

            {
                this.ProjectData.LongProjectName =
                    configData.GetModelProperty("fhirStructuredDefs", "longProjectName");
                if (this.ProjectData.LongProjectName == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing LongProjectName");
            }

            {
                this.ProjectData.NameSpace = configData.Project_NameSpace;
                if (this.ProjectData.NameSpace == null)
                    this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing NameSpace");
            }

            {
                this.ProjectData.ImplementationGuideUrl =
                    configData.GetModelProperty("fhirStructuredDefs", "implementationGuideUrl");
                if (this.ProjectData.ImplementationGuideUrl == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing ImplementationGuideUrl");
            }
            {
                this.ProjectData.IGOverviewMarkdown =
                    configData.GetModelProperty("fhirStructuredDefs", "igOverview");
                if (this.ProjectData.IGOverviewMarkdown == null)
                    this.ConversionError(this.GetType().Name, fcn, $"Project {this.Project.ConfigData.Title} is missing IGOverviewMarkdown");
            }
        }

        if (this.Errors.Any() == false)
        {
            this.Visit(this.ProcessSections());
        }
        Log.Info("ModelLabToModelDefConvertor.Convert", $"Conversion complete");

        return this.Errors.Any() == false;
    }

    public void Save(String outputDir, SaveTypes saveType = SaveTypes.Json)
    {
        this.OutputCache.Save(outputDir, saveType);
    }

    protected override bool Visit_Stage1Start(ModelSectionData model)
    {
        //const String fcn = "ModelLabToModelDefConvertor.Stage1";

        StructureDefinition modelDef = new StructureDefinition()
            .Init(model.TypeName, model.ConfigData.Title)
            .InitDifferential()
            ;
#if FHIR_R4
            modelDef.FhirVersion = FhirKhitVersion.FhirVersionEnum;
#else
        modelDef.FhirVersion = FhirKhitVersion.FhirVersion;
#endif
        {
            CIMPLMap map = this.ReadCIMPLMap(model.ConfigData.CIMPLTemplate);
            if (map != null)
                modelDef.Differential.Element[0].SetCIMPLMap(map);
        }
        model.StructureDefinition = modelDef;
        return true;
    }

    CIMPLMap ReadCIMPLMap(String cimplMapText)
    {
        const String fcn = "ReadCIMPLMap";

        if (String.IsNullOrEmpty(cimplMapText))
            return null;

        try
        {
            CIMPLMapProcessor p = new CIMPLMapProcessor();
            return p.ParseCIMPLMap(cimplMapText);
        }
        catch (Exception e)
        {
            this.ConversionError(this.GetType().Name, fcn, $"Error '{e.Message}' parsing CIMPLMap text\n    '{cimplMapText}'");
            return null;
        }
    }

    protected override bool Visit_Stage1_ComposeTarget(ModelSectionData model)
    {
        model.StructureDefinition.SetSectionPurpose(FhirExtendableExtensions.SectionPurporseEnums.CompositionTarget);
        return true;
    }

    protected override bool Visit_Stage1_Profile(ModelSectionData model)
    {
        const String fcn = "Visit_Stage1Profile";

        StructureDefinition modelDef = model.StructureDefinition;

        String baseDefinition = model.ConfigData.Section_BaseDefinition;

        if (String.IsNullOrEmpty(baseDefinition))
        {
            this.ConversionError(this.GetType().Name, fcn, $"Model {model.ConfigData.Title} has invalid BaseDefinition");
            return true;
        }
        StructureDefinitionMap map = new StructureDefinitionMap(baseDefinition);
        modelDef
            .SetSectionPurpose(FhirExtendableExtensions.SectionPurporseEnums.Profile)
            .SetModelDefToProfileMap(map)
            ;
        return true;
    }

    protected override bool Visit_Stage1Complete(ModelSectionData model)
    {
        const String fcn = "Visit_Stage1_Complete";

        StructureDefinition modelDef = model.StructureDefinition;
        modelDef
            .SetBaseDefinition("http://hl7.org/fhir/StructureDefinition/DomainResource")
#if FHIR_R3 || FHIR_R4
                        .SetType(model.TypeName)
#endif
                        ;
        model
            .SetUrl(this, this.Project.BaseUrl)
            .SetTitle(this, this.Project)
            .SetStatus(this, this.Project)
            .SetPublisher(this, this.Project)
        ;

        {
            String nameSpace = this.OutputCache.ProjectData.NameSpace;
            if (String.IsNullOrEmpty(nameSpace))
                this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.Title} has empty namespace");
            else
                modelDef.SetNamespace($"{nameSpace}");
        }
        modelDef.DateElement = this.Date;
        //# Add more description....
        String description = model.ConfigData.Description;
        if (String.IsNullOrWhiteSpace(description))
        {
            this.ConversionWarn(this.GetType().Name, fcn, $"SelectElement {this.Project.Title}.{model.ConfigData.Title} is missing Description field");
            description = model.ConfigData.Title;
        }
        if (String.IsNullOrWhiteSpace(description))
            description = "??????";
#if FHIR_R3 || FHIR_R4
            modelDef.Description = this.ConvertToMarkdown(description);
#else
        modelDef.Description = description;
#endif
        //modelDef.Text = new Narrative
        //{
        //    Status = Narrative.NarrativeStatus.Generated,
        //    Div = ConverterBase.ToDiv(description)
        //};
        modelDef.Abstract = false;

        this.OutputCache.AddModelDef(modelDef);
        return true;
    }

    protected override bool Visit_Stage2_ModelSection(ModelSectionData model)
    {
        return true;
    }

    protected override bool Visit_Stage2_NumericProperty(ModelSectionData model, ConfigData item)
    {
#if FHIR_R2
            ElementDefinition elementDefinition = this.AddProperty(model, item, FHIRDefinedType.Integer);
#else
        ElementDefinition elementDefinition = this.AddProperty(model, item, "integer");
#endif
        return true;
    }

    protected override bool Visit_Stage2_StringProperty(ModelSectionData model, ConfigData item)
    {
#if FHIR_R2
            ElementDefinition elementDefinition = this.AddProperty(model, item, FHIRDefinedType.String);
#else
        ElementDefinition elementDefinition = this.AddProperty(model, item, "string");
#endif
        return true;
    }

    protected override bool Visit_Stage2_BooleanProperty(ModelSectionData model, ConfigData item)
    {
#if FHIR_R2
            ElementDefinition elementDefinition = this.AddProperty(model, item, FHIRDefinedType .Boolean);
#else
        ElementDefinition elementDefinition = this.AddProperty(model, item, "boolean");
#endif
        return true;
    }

    protected override bool Visit_Stage2_DateTimeProperty(ModelSectionData model, ConfigData item)
    {
#if FHIR_R2
            ElementDefinition elementDefinition = this.AddProperty(model, item, FHIRDefinedType.DateTime);
#else
        ElementDefinition elementDefinition = this.AddProperty(model, item, "dateTime");
#endif
        return true;
    }

    protected override bool Visit_Stage2_CompositionReference(ModelSectionData model, ConfigData item)
    {
        if (this.TryFindSection(item.TargetGuid, out ModelSectionData modelRef) == false)
        {
            Guid targetGuid = item.TargetGuid;
            modelRef = this.modelLabReader.PullModelSectionByGuid(targetGuid);

            modelRef.DefaultMap = item.ProfileMap;
            modelRef.DefaultMatch = item.ProfileMatch;
            this.Stage1(modelRef);
        }

        ElementDefinition elementDefinition = AddContentReference(model, modelRef, item);
        elementDefinition.SetComposable(FhirExtendableExtensions.ComposableEnums.Flatten);
        this.AddCIMPLMap(item, elementDefinition);
        return true;
    }


    protected override bool Visit_Stage2_SelectElement(ModelSectionData model, ConfigData item)
    {
        //const String fcn = "Stage2SelectElement";
        ValueSetData valueSetData = this.GetValueSet(model, item);
#if FHIR_R2
            ElementDefinition elementDefinition = this.AddProperty(model, item, FHIRDefinedType.Code);
            elementDefinition.Binding = new ElementDefinition.BindingComponent
            {
                Strength = BindingStrength.Required,
                Description = valueSetData.ValueSet.Description,
            };

            // add extension that sets name for enum code generator.
            elementDefinition.Binding.Extension.Add(
                new Extension
                {
                    Url = "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                    //$ the following uri is probably wrong....
                    Value = new FhirString(valueSetData.ValueSet.Name.ToMachineName())
                });
#elif FHIR_R3
            ElementDefinition elementDefinition = this.AddProperty(model, item, "code");
            elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
            {
                Strength = BindingStrength.Required,
                Description = valueSetData.ValueSet.Description?.Value,
                ValueSet = new FhirUri(valueSetData.ValueSet.Url)
            };
#else
        ElementDefinition elementDefinition = this.AddProperty(model, item, "code");
        elementDefinition.Binding = new ElementDefinition.ElementDefinitionBindingComponent
        {
            Strength = BindingStrength.Required,
            Description = valueSetData.ValueSet.Description?.Value,
            ValueSet = new Canonical(valueSetData.ValueSet.Url)
        };
#endif
        return true;
    }

    ElementDefinition AddContentReference(ModelSectionData model,
        ModelSectionData modelRef,
        ConfigData item)
    {
        //const String fcn = "ModelLabToModelDefConvertor.AddContentReference";

        String pPath = $"{model.TypeName}.{item.Id.ToLocalName()}";
        ElementDefinition elementDefinition = model.StructureDefinition.AddDiffElement(pPath, pPath);
        elementDefinition.Short = item.Title;

        String description = item.Description;
        if (String.IsNullOrWhiteSpace(description))
            description = item.Title;
        if (String.IsNullOrWhiteSpace(description) == false)
        {
#if FHIR_R4
                elementDefinition.Definition = new Markdown(description);
#else
            elementDefinition.Definition = description;
#endif
        }

        elementDefinition.Type = new List<ElementDefinition.TypeRefComponent>();
        ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
        {
#if FHIR_R2
                Code = FHIRDefinedType.Reference,
                Profile = new String[] {modelRef.ToUrl(this, this.Project.BaseUrl)}
#elif FHIR_R3
                Code = "Reference",
                Profile = modelRef.ToUrl(this, this.Project.BaseUrl)
#elif FHIR_R4
                Code = "Reference",
                Profile = new String[] { modelRef.ToUrl(this, this.Project.BaseUrl) }
#endif
        };
        elementDefinition.Type.Add(typeRef);
        return elementDefinition;
    }

    String CleanText(String s)
    {
        return s
            .Replace("%", "%%")
            .Replace("“", "'")
            .Replace("”", "'")
            .Replace("\"", "'")
            ;
        }

    ElementDefinition AddProperty(ModelSectionData model,
        ConfigData item,
#if FHIR_R3 || FHIR_R4
            String propertyType,
#else
            FHIRDefinedType propertyType,
#endif
            Int32 min = 0,
        Int32 max = 1)
    {
        const String fcn = "ModelLabToModelDefConvertor.AddProperty";

        List<ElementDefinition.TypeRefComponent> type = new List<ElementDefinition.TypeRefComponent>();
        ElementDefinition.TypeRefComponent typeRef = new ElementDefinition.TypeRefComponent
        {
            Code = propertyType
        };
        type.Add(typeRef);

        String pPath = $"{model.TypeName}.{item.Id.ToLocalName()}";
        ElementDefinition elementDefinition = model.StructureDefinition.AddDiffElement(pPath, pPath);
        elementDefinition.Min = min;
        elementDefinition.Max = (max == -1) ? "*" : max.ToString();
        elementDefinition.Short = item.Title;
        elementDefinition.Type = type;

        String description = item.Description;
        if (String.IsNullOrEmpty(description))
            this.ConversionWarn(this.GetType().Name, fcn, $"Element {pPath} is missing description");
        if (String.IsNullOrWhiteSpace(description))
            description = item.Title;
        if (String.IsNullOrWhiteSpace(description))
            description = "??????";
#if FHIR_R4
            elementDefinition.Definition = new Markdown(description);
#else
        elementDefinition.Definition = description;
#endif

        String map = item.ProfileMap;
        if (String.IsNullOrEmpty(map) == true)
            map = model.DefaultMap;
        if (String.IsNullOrEmpty(map) == true)
            map = model.ConfigData.ProfileMap;
        //$if (String.IsNullOrEmpty(map) == true)
        //$    this.ConversionError(this.GetType().Name, fcn, $"Element {pPath} is missing element map");

        String match = item.ProfileMatch;
        if (String.IsNullOrEmpty(match) == true)
            match = model.DefaultMatch;
        if (String.IsNullOrEmpty(match) == true)
            match = model.ConfigData.ProfileMatch;
        //$if (String.IsNullOrEmpty(match) == true)
        //$    this.ConversionError(this.GetType().Name, fcn, $"Element {pPath} is missing element match");

        if ((String.IsNullOrEmpty(map) == false) && ((String.IsNullOrEmpty(match) == false)))
        {
            String fieldTerminologySource = item.GetModelProperty("common", "terminologySource");
            String fieldTerminologyId = item.GetModelProperty("common", "terminologyId");
            if (String.IsNullOrEmpty(fieldTerminologySource) == true)
            {
                fieldTerminologySource = "LOINC";
                fieldTerminologyId = "87553-4";
                //$$$$ Fix when richard fixes...
                this.ConversionWarn(this.GetType().Name, fcn, $"Element {pPath} is missing field terminology source...");
            }

            fieldTerminologySource.ProcessSystem(fieldTerminologyId,
                this.CleanText(item.Description),
                out String fhirSystem,
                out String fhirCode,
                out String fhirDisplay);

            ElementDefinitionMatch eMatch = new ElementDefinitionMatch(match);
            ElementDefinitionMap eMap = new ElementDefinitionMap(eMatch,
                map,
                fhirSystem,
                fhirCode,
                fhirDisplay);
            elementDefinition.SetMap(eMap);
        }
        AddCIMPLMap(item, elementDefinition);
        return elementDefinition;
    }

    void AddCIMPLMap(ConfigData item, ElementDefinition elementDefinition)
    {
        CIMPLMap cimplMap = this.ReadCIMPLMap(item.CIMPLMap);
        if (cimplMap != null)
            elementDefinition.SetCIMPLMap(cimplMap);
    }


    ValueSetData GetValueSet(ModelSectionData model,
        ConfigData item)
    {
        const String fcn = "GetValueSet";

        ValueSetData valueSetData;
        if (this.Project.ValueSets.TryGetValue(item.Guid, out valueSetData) == true)
            return valueSetData;
        valueSetData = new ValueSetData(item, FhirKhitVersion.FhirVersion);
        this.Project.ValueSets.Add(valueSetData.Guid, valueSetData);
        valueSetData
            .SetId(this, this.Project)
            .SetTitle(this, this.Project)
            .SetDescription(this, this.Project)
            .SetUrl(this, this.Project)
            .SetStatus(this, this.Project)
            .SetPublisher(this, this.Project)
            ;

        String nameSpace = this.OutputCache.ProjectData.NameSpace;
        if (String.IsNullOrEmpty(nameSpace))
            this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.Title} has empty namespace");
        else
            valueSetData.ValueSet.SetNamespace($"{nameSpace}");
        valueSetData.ValueSet.DateElement = this.Date;

        this.OutputCache.AddValueSet(valueSetData.ValueSet);

        List<ConfigData> optionElements = new List<ConfigData>();

        foreach (ConfigData child in item.Children)
        {
            switch (child.Type)
            {
                case "OptionElement":
                    optionElements.Add(child);
                    break;

                default:
                    throw new Exception($"{fcn}. Unexpected type {child.Type} found");
            }
        }
        this.ProcessOptionElements(model, valueSetData, optionElements);
        return valueSetData;
    }


    void ProcessOptionElements(ModelSectionData model,
        ValueSetData valueSetData,
        List<ConfigData> optionElements)
    {
        const string fcn = "ModelLabToModelDefConvertor.ProcessOptionElements";

        String fieldTerminologySource = model.ConfigData.SelectElement_FieldTerminologySource;
        valueSetData.ValueSet.Compose = new ValueSet.ComposeComponent();
        optionElements.Sort(
            (ConfigData x, ConfigData y) =>
            {
                String xConceptSystem = x.OptionElement_TerminologySource.ValueOrDef(fieldTerminologySource);
                String yConceptSystem = y.OptionElement_TerminologySource.ValueOrDef(fieldTerminologySource);
                Int32 compareValue = String.Compare(xConceptSystem, yConceptSystem);
                if (compareValue != 0)
                    return compareValue;

                    //$compareValue = String.Compare(x.ModelProperty("modelDef", "conceptVersion").ValueOrDef(""),
                    //$    y.ModelProperty("modelDef", "conceptVersion").ValueOrDef(""));
                    //$if (compareValue != 0)
                    //$    return compareValue;

                    String xConceptCode = x.OptionElement_ConceptId.ValueOrDef("");
                String yConceptCode = y.OptionElement_ConceptId.ValueOrDef("");
                compareValue = String.Compare(xConceptCode, yConceptCode);
                if (compareValue != 0)
                    return compareValue;

                return 0;
            });

        ValueSet.ConceptSetComponent currentComponent = null;

        foreach (ConfigData optionElement in optionElements)
        {
            bool errFlag = false;

            String modelLabCode = optionElement.OptionElement_ConceptId;
            String modelLabSystem = optionElement.OptionElement_TerminologySource.ValueOrDef(fieldTerminologySource);
            String version = "";

            if (String.IsNullOrEmpty(modelLabCode) == true)
            {
                modelLabCode = optionElement.Title.ToMachineName();
                this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.Title} OptionElement {optionElement.Title} is missing conceptId, Using '{modelLabCode}'");
            }

            if (modelLabSystem == null)
            {
                this.ConversionWarn(this.GetType().Name, fcn, $"Project {this.Project.Title} OptionElement {optionElement.Title} is missing fieldTerminologySource");
            }

            modelLabSystem.ProcessSystem(modelLabCode,
                this.CleanText(optionElement.Description),
                out String fhirSystem,
                out String fhirCode,
                out String fhirDisplay);

            //$String version = optionElement.ModelProperty("modelDef", "conceptVersion");
            //$if (version == null)
            //${
            //$    ConversionError(this.GetType().Name, fcn, $"Project {project.Title} OptionElement {optionElement.Title} is missing conceptVersion");
            //$    errFlag = true;
            //$    version = "1";
            //$}

            if (errFlag == false)
            {
                if (
                    (currentComponent == null) ||
                    (currentComponent.System.NullCompareTo(fhirSystem) != 0) ||
                    (currentComponent.Version.NullCompareTo(version) != 0)
                )
                {
                    currentComponent = new ValueSet.ConceptSetComponent
                    {
                        System = fhirSystem
                    };
                    if (String.IsNullOrEmpty(version) == false)
                        currentComponent.Version = version;
                    valueSetData.ValueSet.Compose.Include.Add(currentComponent);
                }
                currentComponent.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = fhirCode,
                    Display = fhirDisplay
                });
            }
        }
    }

    public void LoadProjectByName(String name)
    {
        this.Project = this.modelLabReader.PullModelLabProjectByName(name, out String dummy);
    }

    public void LoadProjectByGuid(Guid guid)
    {
        this.Project = this.modelLabReader.PullModelLabProjectByGuid(guid);
    }

    protected IEnumerable<ModelSectionData> ProcessSections()
    {
        //const String fcn = "ModelLabToModelDefConvertorBase.ProcessSections";

        foreach (ModelSectionData model in this.Project.ModelSections.Values)
        {
            switch (model.ConfigData.Section_Purpose)
            {
                case ConfigData.PurposeEnums.ComposeTarget:
                    Log.Info("ModelLabToModelDefConvertor.Convert", $"Processing {model.ConfigData.Title} as a Compose Target");
                    break;

                case ConfigData.PurposeEnums.Profile:
                    Log.Info("ModelLabToModelDefConvertor.Convert", $"Processing {model.ConfigData.Title} as a Profile");
                    yield return model;
                    break;

                case ConfigData.PurposeEnums.None:
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }

    protected String TypeUri(String fullClassName)
    {
        String[] path = fullClassName.Split('.');
        StringBuilder typeName = new StringBuilder();
        typeName.Append($"http://www.ModelLabs.com/ModelLab/Model");
        for (Int32 i = 0; i < path.Length; i++)
            typeName.Append($"/{path[i]}");
        return typeName.ToString();
    }

    protected Markdown ConvertToMarkdown(params String[] description)
    {
        Markdown retVal = new Markdown();
        StringBuilder sb = new StringBuilder();
        foreach (String s in description)
            sb.AppendLine(s);

        retVal.Value = sb.ToString();
        return retVal;
    }
}
}
