using Hl7.Fhir.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public class IGMaker : ConverterBase
    {
        protected IGPublisher igPublisher;
        protected const SaveTypes SaveType = SaveTypes.Json;

        protected const String ResourceGroupId = "ResourceGroup";
        protected const String ExtensionGroupId = "ExtensionGroup";
        protected const String ValueSetGroupId = "ValueSetGroup";
        Int32 profileCount = 0;
        Int32 logicalModelCount = 0;
        Int32 extensionCount = 0;
        Int32 valueSetCount = 0;

        protected ImplementationGuide implementationGuide;
        protected String IGPath => Path.Combine(this.templateDir, "ig.json");
        protected String templateDir => this.igPublisher.TemplateDir;
        protected CodeEditor extensionsEditor;
        protected CodeEditor indexEditor;
        protected CodeEditor overviewEditor;
        protected CodeEditor profilesEditor;
        protected CodeEditor logicalModelsEditor;
        protected CodeEditor valueSetsEditor;
        protected IGEditor igEditor;
        protected String abbreviatedName;
        protected String canonicalBase;
        protected string longName;

        protected String implementationGuideDir => Path.Combine(this.templateDir,
            "resources",
            "implementationguide");

        /// <summary>
        /// Constructor
        /// </summary>
        public void Create(String templateDir,
            String baseUrl,
            String abbreviatedName,
            String longName,
            String packageId)
        {
            this.igPublisher = new IGPublisher(templateDir);
            this.ClearDirectory("output");
            this.ClearDirectory("qa");
            this.ClearDirectory("temp");
            this.ClearDirectory(@"resources\implementationguide");
            this.ClearDirectory(@"resources\structuredefinition");
            this.ClearDirectory(@"resources\valueset");
            this.ClearDirectory(@"txCache");

            this.indexEditor = this.CreateEditor("pages", "index.html");
            this.extensionsEditor = this.CreateEditor("pages", "_includes", "extensions.html");
            this.overviewEditor = this.CreateEditor("pages", "_includes", "overview.html");
            this.profilesEditor = this.CreateEditor("pages", "_includes", "profiles.html");
            this.logicalModelsEditor = this.CreateEditor("pages", "_includes", "logicalmodels.html");
            this.valueSetsEditor = this.CreateEditor("pages", "_includes", "value-sets.html");

            this.igEditor = IGEditor.Load(this.IGPath);
            this.igEditor.ReplaceProperty("do-transforms", "true");
        }

        /// <summary>
        /// Save to disc.
        /// </summary>
        public virtual void Save()
        {
            CodeBlockNested tabBlock = this.indexEditor.Blocks.Find("*Tabs", false);
            if (this.logicalModelCount > 0)
                tabBlock.AppendRaw("<li role=\"presentation\"><a href=\"#logical\" aria-controls=\"profile\" role=\"tab\" data-toggle=\"tab\">Logical Models</a></li>");
            if (this.profileCount > 0)
                tabBlock.AppendRaw("<li role=\"presentation\"><a href=\"#profiles\" aria-controls=\"profile\" role=\"tab\" data-toggle=\"tab\">Profiles</a></li>");
            if (this.extensionCount > 0)
                tabBlock.AppendRaw("<li role=\"presentation\"><a href=\"#extensions\" aria-controls=\"profile\" role=\"tab\" data-toggle=\"tab\">Extensions</a></li>");
            if (this.valueSetCount > 0)
                tabBlock.AppendRaw("<li role=\"presentation\"><a href=\"#value-sets\" aria-controls=\"profile\" role=\"tab\" data-toggle=\"tab\">Value Sets</a></li>");

            this.Save(ref this.indexEditor);
            this.Save(ref this.extensionsEditor);
            this.Save(ref this.overviewEditor);
            this.Save(ref this.profilesEditor);
            this.Save(ref this.logicalModelsEditor);
            this.Save(ref this.valueSetsEditor);

            {
                String igFileName = $"{this.implementationGuide.Id.ToMachineName()}ImplementationGuide";
                String igPath = Path.Combine(this.implementationGuideDir, igFileName);
                this.implementationGuide.Save(igPath, SaveType);
                this.igEditor.ReplaceProperty("source", $"implementationguide/{igFileName}{SaveType.ToFileExtension()}");
            }

            this.igEditor.Save(this.IGPath);
        }

        /// <summary>
        /// Set canonical base url.
        /// </summary>
        protected void SetCanonicalBase(String canonicalBase)
        {
            this.canonicalBase = canonicalBase;
            if (canonicalBase.ToUpper().StartsWith("HTTP://") == false)
                canonicalBase = $"http://{canonicalBase}";
            this.igEditor.ReplaceProperty("canonicalBase", canonicalBase);
        }

        /*
            CodeEditor extensionsEditor;
         */
        /// <summary>
        /// Set overview.
        /// Convert markdown to html and store in overview.html.
        /// </summary>
        /// <param name="value">markdown text for overview section</param>
        /// <returns></returns>
        public void SetOverview(String value)
        {
            string htmlValue = CommonMark.CommonMarkConverter.Convert(value);
            CodeBlockNested b = this.overviewEditor.Blocks.Find("*Overview", false);
            b.Clear();
            b.AppendRaw(htmlValue);
        }

        public bool Publish()
        {
            const String fcn = "IGMaker.Publish";

            bool exitCode = this.igPublisher.Publish();
            this.ConversionError(this.GetType().Name, fcn, this.igPublisher.Errors);
            this.ConversionWarn(this.GetType().Name, fcn, this.igPublisher.Warnings);
            this.ConversionInfo(this.GetType().Name, fcn, this.igPublisher.Info);
            return exitCode;
        }

        protected String TemplateRelSubDir(params string[] pathElements) => Path.Combine(pathElements);

        protected String TemplateAbsSubDir(params string[] pathElements)
        {
            String retVal = this.templateDir;
            foreach (String pathElement in pathElements)
                retVal = Path.Combine(retVal, pathElement);
            return retVal;
        }

        protected void ClearDirectory(params string[] pathElements)
        {
            String dir = this.TemplateAbsSubDir(pathElements);
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
                return;
            }

            foreach (String fileName in Directory.GetFiles(dir))
                File.Delete(fileName);

            foreach (String subDirName in Directory.GetDirectories(dir))
                Directory.Delete(subDirName, true);
        }

        protected void Save(ref JObject item, String path) => File.WriteAllText(path, item.ToString());

        protected void Save(ref CodeEditor code)
        {
            if (code == null)
                return;
            code.Save();
            code = null;
        }

        protected CodeEditor CreateEditor(params String[] paths)
        {
            String path = this.TemplateAbsSubDir(paths);
            if (File.Exists(path))
                File.Delete(path);
            File.Copy(path + ".template", path);

            CodeEditor retVal = new CodeEditor();
            retVal.Load(path);
            return retVal;
        }

        protected String GetValue(String value, String errorMsg)
        {
            if (value != null)
                return value;
            Log.Error("IGMaker.GetValue", errorMsg);
            return "??????";
        }

        /// <summary>
        /// Set the url of where the Implementation Guide will be on the net
        /// </summary>
        /// <returns></returns>
        protected void SetImplementationGuideUrl(String url)
        {
            if (url.ToUpper().StartsWith("HTTP://") == false)
                url = $"http://{url}";
            this.implementationGuide.Url = url;
        }

        /// <summary>
        /// Set the abbreviated name. This gets put into various places.
        /// </summary>
        /// <returns></returns>
        protected void SetAbbreviatedName(String value)
        {
            this.abbreviatedName = value.ToMachineName();
            this.implementationGuide.Id = $"{this.abbreviatedName}";
            this.implementationGuide.Name = $"{this.abbreviatedName}";
        }

        /// <summary>
        /// Set the IG Fhir version
        /// </summary>
        /// <returns></returns>
        public void SetIGVersion(String value)
        {
            this.igEditor.ReplaceProperty("version", value);
        }

        /// <summary>
        /// Set the version
        /// </summary>
        /// <returns></returns>
        public void SetVersion(String value)
        {
            this.implementationGuide.Version = value;
        }

        /// <summary>
        /// Set the publisher
        /// </summary>
        /// <returns></returns>
        public void SetPublisher(String value)
        {
            this.implementationGuide.Publisher = value;
        }

        protected void SaveResource(Resource r,
            String resourceFileName,
            String resourceDir)
        {
            String dir = Path.Combine(this.TemplateAbsSubDir("resources", resourceDir));
            if (Directory.Exists(dir) == false)
                Directory.CreateDirectory(dir);
            String path = Path.Combine(dir, Path.GetFileNameWithoutExtension(resourceFileName));
            r.Save(path, SaveType);
        }


        public void FullLogging()
        {
            this.igEditor.FullLogging();
        }

        /// <summary>
        /// Add al the structure definitions as logical models.
        /// </summary>
        /// <param name="modelDefProject"></param>
        /// <returns></returns>
        public void AddLogicalModels(ModelDefProject modelDefProject)
        {
            foreach (StructureDefinition sd in modelDefProject.GetStructureDefinitions())
                this.AddLogicalModel(sd);
        }

        /// <summary>
        /// Add a Fhir profile StructureDefinition to implementation guide.
        /// </summary>
        public void AddProfile(StructureDefinition structDef, String cssClass = "")
        {
            AddStructureDefinition(structDef, this.profilesEditor, cssClass);
            this.profileCount += 1;
        }

        /// <summary>
        /// Add a Fhir logical model StructureDefinition to implementation guide.
        /// We append -model to the id and url to make it unique from the profile
        /// generated from this model.
        /// </summary>
        public void AddLogicalModel(StructureDefinition structDef, String cssClass = "")
        {
            this.logicalModelCount += 1;
            if (structDef.Id.EndsWith("-model") == false)
                structDef.Id = $"{structDef.Id}-model";
            if (structDef.Url.EndsWith("-model") == false)
                structDef.Url = $"{structDef.Url}-model";

#if FHIR_R4 || FHIR_R3
            structDef.Derivation = StructureDefinition.TypeDerivationRule.Constraint;
#endif
            AddStructureDefinition(structDef, this.logicalModelsEditor, cssClass);
        }

        /// <summary>
        /// Add all the items in the IGSource to this IG.
        /// This includes StructureDefinitions, Value Sets, and Extensions.
        /// </summary>
        /// <param name="modelDefProject"></param>
        /// <returns></returns>
        public void AddSourceItems(ModelDefProject modelDefProject)
        {
            foreach (StructureDefinition sd in modelDefProject.GetStructureDefinitions())
                this.AddProfile(sd);
            foreach (ValueSet valueSet in modelDefProject.GetValueSets())
                this.AddValueSet(valueSet);
            foreach (StructureDefinition extension in modelDefProject.GetExtensions())
                this.AddExtension(extension);
        }

        /// <summary>
        /// Set the long name. This gets put into various places.
        /// </summary>
        /// <returns></returns>
        public void SetLongName(String value)
        {
            this.longName = value;
#if FHIR_R4 || FHIR_R3
            this.implementationGuide.Description = new Markdown($"FHIR Implementation Guide for {value}");
#else
            this.implementationGuide.Description = $"FHIR Implementation Guide for {value}";
#endif
            CodeBlockNested b = this.overviewEditor.Blocks.Find("*Header", false);
            b.Clear();
            b.AppendRaw($"{this.longName} Implementation Guide");
        }


        /// <summary>
        /// Add contact
        /// </summary>
        /// <returns></returns>
        public void SetContactUrl(String value)
        {
#if FHIR_R2
            ImplementationGuide.ContactComponent cd = new ImplementationGuide.ContactComponent();
#else
            ContactDetail cd = new ContactDetail();
#endif
            cd.Telecom.Add(new ContactPoint
            {
#if FHIR_R2
                System = ContactPoint.ContactPointSystem.Other,
#else
                System = ContactPoint.ContactPointSystem.Url,
#endif
                Value = value
            });
            this.implementationGuide.Contact.Clear();
            this.implementationGuide.Contact.Add(cd);
        }

        /// <summary>
        /// Add Copyright
        /// </summary>
        /// <returns></returns>
        public void SetCopyright(String value)
        {
#if FHIR_R4 || FHIR_R3
            this.implementationGuide.Copyright = new Markdown(value);
#else
            this.implementationGuide.Copyright = value;
#endif
        }

#if FHIR_R4 || FHIR_R3

        /// <summary>
        /// Set the publication status
        /// </summary>
        /// <returns></returns>
        public void SetStatus(PublicationStatus? value)
        {
            this.implementationGuide.Status = value;
        }
#else
        /// <summary>
        /// Set the publication status
        /// </summary>
        /// <returns></returns>
        public void SetStatus(ConformanceResourceStatus? value)
        {
            this.implementationGuide.Status = value;
        }
#endif

#if FHIR_R3 || FHIR_R2
        protected ImplementationGuide.PackageComponent resourcePackage;
#endif

        /// <summary>
        /// Constructor
        /// </summary>
        public IGMaker(String templateDir,
            String baseUrl,
            String abbreviatedName,
            String longName,
            String packageId)
        {
            Create(templateDir, baseUrl, abbreviatedName, longName, packageId);
            this.implementationGuide = new ImplementationGuide
            {
                DateElement = new FhirDateTime(DateTimeOffset.Now),
#if FHIR_R4
                FhirVersion = new FHIRVersion?[] { FhirKhitVersion.FhirVersionEnum },
                Definition = new ImplementationGuide.DefinitionComponent(),
                Manifest = new ImplementationGuide.ManifestComponent(),
                PackageId = packageId
#elif FHIR_R3
                FhirVersion = FhirKhitVersion.FhirVersion,
#elif FHIR_R2
                FhirVersion = FhirKhitVersion.FhirVersion,
#endif
            };

#if FHIR_R3
            this.resourcePackage = new ImplementationGuide.PackageComponent
            {
                Name = $"{longName} Resources",
                Description = $"{longName} Resources"
            };
            this.implementationGuide.Package.Add(this.resourcePackage);
            // Is this generated by publisher?????
            //this.implementationGuide.Page = new ImplementationGuide.PageComponent
            //{
            //    Source = "",
            //    Name = "",
            //    Kind = ImplementationGuide.GuidePageKind.Page
            //};
#endif

            this.igEditor.ReplaceProperty("npm-name", packageId);
            this.SetCanonicalBase(baseUrl);
            this.SetImplementationGuideUrl($"{baseUrl}/ImplementationGuide/{abbreviatedName}");
            this.SetAbbreviatedName(abbreviatedName);
            this.SetLongName(longName);

#if FHIR_R4
            this.AddGroup("Resources", "Resource StructureDefinitions defined for this implementation guide.", ResourceGroupId);
            this.AddGroup("Extensions", "Extension StructureDefinitions defined for this implementation guide.", ExtensionGroupId);
            this.AddGroup("ValueSets", "ValueSets defined for this implementation guide.", ValueSetGroupId);
#endif
        }



        /// <summary>
        /// Add a Fhir ValueSet to implementation guide.
        /// </summary>
        public void AddValueSet(ValueSet valueSet, String cssClass = "")
        {
            this.valueSetCount += 1;
            String resourceFileName = $"{valueSet.Name}.json";
            String resourcePath = $"ValueSet/{valueSet.Name}";

            this.SaveResource(valueSet, resourceFileName, "valueset");
            String anchor = $"ValueSet-{valueSet.Name}";
            String href = $"{anchor}.html";

#if FHIR_R4 || FHIR_R3
            String valueSetDescription = this.GetValue(valueSet?.Description?.Value, $"ValueSet {valueSet.Name} is missing description field");
#else
            String valueSetDescription = this.GetValue(valueSet?.Description, $"ValueSet {valueSet.Name} is missing description field");
#endif
            String valueSetName = this.GetValue(valueSet?.Name, $"ValueSet {valueSet.Id} is missing name field");
            String valueSetUrl = this.GetValue(valueSet?.Url, $"ValueSet {valueSet.Name} is missing url field");

            CodeBlockNested block = this.valueSetsEditor.Blocks.Find("*Resources", false);
            block.AppendTableRow(cssClass,
                $"<a href=\"{href}\">{valueSetName}</a>",
                valueSetDescription,
                valueSetUrl);
            this.igEditor.AddResource(resourcePath, href);

#if FHIR_R4
            String valueSetTitle = this.GetValue(valueSet?.Title, $"ValueSet {valueSet.Name} is missing title field");
            this.implementationGuide.Definition.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
                    Name = valueSetTitle,
                    Description = valueSetDescription,
                    GroupingId = ValueSetGroupId,
                    Reference = new ResourceReference(resourcePath)
                }
            );

            this.implementationGuide.Manifest.Resource.Add(
                new ImplementationGuide.ManifestResourceComponent
                {
                    Reference = new ResourceReference(resourcePath),
                    RelativePath = $"{href}#{anchor}"
                }
            );

            this.implementationGuide.Manifest.Page.Add(
                new ImplementationGuide.ManifestPageComponent
                {
                    Name = href,
                    Title = $"{valueSet.Title}",
                    Anchor = new String[] { anchor, "tx", "uml" }
                }
            );
#else
            this.resourcePackage.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
#if FHIR_R3
                    Example = false,
#endif
                    Source = new ResourceReference(resourcePath, valueSet.Name)
                }
            );
#endif
        }





        /// <summary>
        /// Add a Fhir Extension Definition (StructureDefinition) to implementation guide.
        /// </summary>
        public void AddExtension(StructureDefinition extension, String cssClass = "")
        {
            this.extensionCount += 1;
            String extensionName = this.GetValue(extension.Name, $"Extension {extension.Id} is missing name field");
#if FHIR_R2
            String extensionDescription = this.GetValue(extension.Description, $"Extension {extension.Id} is missing Description field");
#else
            String extensionDescription = this.GetValue(extension.Description.Value, $"Extension {extension.Id} is missing Description field");
#endif
            String extensionUrl = this.GetValue(extension.Url, $"Extension {extension.Id} is missing url field");

            String resourceFileName = $"{extensionName}.json";
            this.SaveResource(extension, resourceFileName, "extension");
            String anchor = $"StructureDefinition-{extensionName}";
            String href = $"{anchor}.html";
            String resourcePath = $"Extension/{extensionName}";

            CodeBlockNested block = this.extensionsEditor.Blocks.Find("*Extensions", false);

            block.AppendTableRow(cssClass,
                $"<a href=\"{href}\">{extensionName}</a>",
                extensionDescription,
                extensionUrl);

            this.igEditor.AddResource(resourcePath, href);

#if FHIR_R4
            String extensionTitle = this.GetValue(extension.Title, $"Extension {extension.Id} is missing title field");

            this.implementationGuide.Definition.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
                    Name = extensionTitle,
                    Description = extensionDescription,
                    GroupingId = ExtensionGroupId,
                    Reference = new ResourceReference(resourcePath),
                }
            );

            this.implementationGuide.Manifest.Resource.Add(
                new ImplementationGuide.ManifestResourceComponent
                {
                    Reference = new ResourceReference(resourcePath),
                    RelativePath = $"{href}#{anchor}"
                }
            );

            this.implementationGuide.Manifest.Page.Add(
                new ImplementationGuide.ManifestPageComponent
                {
                    Name = href,
                    Title = $"{extension.Title}",
                    Anchor = new String[] { anchor, "tx", "uml" }
                }
            );
#elif FHIR_R3 || FHIR_R2
            this.resourcePackage.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
#if FHIR_R3
                    Example = false,
#endif
                    Source = new ResourceReference(resourcePath, extension.Name)
                }
            );
#endif
        }


        /// <summary>
        /// Add a Fhir StructureDefinition to implementation guide.
        /// </summary>
        public void AddStructureDefinition(StructureDefinition structDef, CodeEditor codeEditor, String cssClass = "")
        {
            String structDefName = this.GetValue(structDef.Id, $"StructureDefinition is missing id field");
#if FHIR_R4 || FHIR_R3
            String structDefDescription = this.GetValue(structDef.Description?.Value, $"StructureDefinition {structDef.Id} is missing Description field");
#else
            String structDefDescription = this.GetValue(structDef.Description, $"StructureDefinition {structDef.Id} is missing Description field");
#endif
            String structDefUrl = this.GetValue(structDef.Url, $"StructureDefinition {structDef.Id} is missing url field");

            String resourceFileName = $"{structDefName}.json";
            this.SaveResource(structDef, resourceFileName, "structuredefinition");
            String anchor = $"StructureDefinition-{structDefName}";
            String href = $"{anchor}.html";
            String resourcePath = $"StructureDefinition/{structDefName}";

            CodeBlockNested block = codeEditor.Blocks.Find("*Resources", false);

            block.AppendTableRow(cssClass,
                $"<a href=\"{anchor}-definitions.html\">{structDefName}</a>",
                structDefDescription,
                structDefUrl);

            this.igEditor.AddResource(resourcePath, href);
#if FHIR_R4
            String structDefTitle = this.GetValue(structDef.Title, $"StructureDefinition {structDef.Id} is missing title field");

            this.implementationGuide.Definition.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
                    Name = structDefTitle,
                    Description = structDefDescription,
                    GroupingId = ResourceGroupId,
                    Reference = new ResourceReference(resourcePath)
                }
            );
            this.implementationGuide.Manifest.Resource.Add(
                new ImplementationGuide.ManifestResourceComponent
                {
                    Reference = new ResourceReference(resourcePath),
                    RelativePath = $"{href}#{anchor}"
                }
            );

            this.implementationGuide.Manifest.Page.Add(
                new ImplementationGuide.ManifestPageComponent
                {
                    Name = href,
                    Title = $"{structDef.Title}",
                    Anchor = new String[] { anchor, "tx", "uml" }
                }
            );
#else
            this.resourcePackage.Resource.Add(
                new ImplementationGuide.ResourceComponent
                {
#if FHIR_R3
                    Example = false,
#endif
                    Source = new ResourceReference(resourcePath, structDef.Name)
                }
            );
#endif
        }


#if FHIR_R4
        void AddGroup(String type, String description, String id)
        {
            ImplementationGuide.GroupingComponent g = new ImplementationGuide.GroupingComponent
            {
                ElementId = id,
                Name = $"{this.longName} {type}",
                Description = description
            };
            this.implementationGuide.Definition.Grouping.Add(g);
        }
#endif
    }
}
