using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Antlr4.Runtime.Misc;
using FhirKhit.Tools.AntlrSupport;
using Hl7.Fhir.Model;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    /// <summary>
    /// ANTLR Visitor class.
    /// </summary>
    public class MapVisitorLocal : map_parserBaseVisitor<Object>
    {
        /// <summary>
        /// Point in differential.Element where to insert new extension elements.
        /// </summary>
        public const Int32 ExtensionInsertPointOffsetFromEnd = 2;

        private const String ExtensionBaseUrl = "http://hl7.org/fhir/StructureDefinition/Extension";
        private Stack<Element> fhirElementStack = new Stack<Element>();

        /// <summary>
        /// element definition from source model def
        /// </summary>
        private readonly ElementDefinition sourceElement;

        /// <summary>
        /// element definition from target profile
        /// This is the element in the resource that we are profiling.
        /// </summary>
        private readonly ElementDefinition targetElement;

        /// <summary>
        /// output StructureDefinition
        /// </summary>
        private readonly StructureDefinition outputProfile;

        /// <summary>
        /// output StructureDefinition
        /// </summary>
        private readonly ModelDefProject modelDefCache;

        private readonly StructureDefinition sourceStructureDefinition;
        private readonly StructureDefinition targetStructureDefinition;
        private readonly FhirDateTime date;
        private ElementDefinitionMap map;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MapVisitorLocal(ModelDefProject modelDefCache,
            StructureDefinition sourceStructureDefinition,
            StructureDefinition targetStructureDefinition,
            StructureDefinition outputProfile,
            ElementDefinition sourceElement,
            ElementDefinition targetElement,
            ElementDefinitionMap map,
            FhirDateTime date)
        {
            this.sourceStructureDefinition = sourceStructureDefinition;
            this.targetStructureDefinition = targetStructureDefinition;
            this.outputProfile = outputProfile;
            this.modelDefCache = modelDefCache;
            this.sourceElement = sourceElement;
            this.targetElement = targetElement;
            this.map = map;
            this.date = date;
        }

        void LTrace(String caller, String msg)
        {
            //Trace.WriteLine($"{caller}: {msg}");
            //Log.Trace(caller, msg);
        }

        String UnQuote(String s) => s.Substring(1, s.Length - 2);

        void AddElement(ElementDefinition newDef)
        {
            if (this.outputProfile.Differential == null)
                this.outputProfile.Differential = new StructureDefinition.DifferentialComponent();

            newDef.DeleteMap(); // delete explicit ModeDef map commands from element.
            this.outputProfile.Differential.Element.Add(newDef);
        }

        public override Object VisitMessageCommand(map_parserParser.MessageCommandContext context)
        {
            //# Tested
            String message = this.VisitOrDefault<String>(context.stringValue());

            return null;
        }

        void Check(bool condition, String exceptionMessage)
        {
            if (condition == false)
                throw new Exception(exceptionMessage);
        }

        void ValidateSliceBase(String fieldName, ElementDefinition targetBaseElement)
        {
#if FHIR_R2
                throw new NotImplementedException();
#else
            Check(targetBaseElement.Path == this.targetElement.Path, "Invalid existing slice path");
            Check(targetBaseElement.SliceName == "sliceComponent", "Invalid existing slice name");
            Check(targetBaseElement.Slicing.Rules == ElementDefinition.SlicingRules.Open, "Invalid existing slice rule");
            Check(targetBaseElement.Slicing.Discriminator.Count == 1, "Invalid existing slice discriminator count");
            Check(targetBaseElement.Slicing.Discriminator[0].Type == ElementDefinition.DiscriminatorType.Value, "Invalid existing slice discriminator type");
            Check(targetBaseElement.Slicing.Discriminator[0].Path == fieldName, "Invalid existing slice discriminator path");
#endif
        }

        ElementDefinition CreateSliceBase(String fieldName)
        {
#if FHIR_R2
                throw new NotImplementedException();
#else
            ElementDefinition targetBaseElement = new ElementDefinition
            {
                Path = this.targetElement.Path,
                ElementId = this.targetElement.Path,
                SliceName = "sliceComponent",
                Slicing = new ElementDefinition.SlicingComponent
                {
                    Rules = ElementDefinition.SlicingRules.Open
                }
            };
            targetBaseElement.Slicing.Discriminator.Add(
                    new ElementDefinition.DiscriminatorComponent
                    {
                        Type = ElementDefinition.DiscriminatorType.Value,
                        Path = fieldName
                    }
                );
            return targetBaseElement;
#endif
        }

        public override Object VisitSliceCommand(map_parserParser.SliceCommandContext context)
        {
            //# Tested
            LTrace("MapVisitorLocal.VisitSlice", $"Map Slice '{this.sourceElement.Path}' -> '{this.targetElement.Path}'");

            if (String.IsNullOrEmpty(this.sourceElement.Short))
                throw new Exception($"Source element lacks required short description.");

            String fieldName = this.VisitOrDefault<String>(context.stringValue());
            if (String.IsNullOrEmpty(fieldName))
                fieldName = "code";

            Element fhirElement = this.VisitOrDefault<Element>(context.fhirElement());
            if (fhirElement == null)
            {
                switch (fieldName)
                {
                    case "code":
                        fhirElement = new Coding
                        {
                            System = this.map.FieldTerminologySource,
                            Code = this.map.FieldTerminologyId
                        };
                        break;

                    default:
                        throw new Exception("Invalid field name for default fhir element");
                }
            }

            //$ Verify that field is a valid field name in component.
            ElementDefinition outputSliceBaseElement = this.outputProfile.Differential.Element.FindByPath(this.targetElement.Path);
            if (outputSliceBaseElement == null)
            {
                outputSliceBaseElement = this.CreateSliceBase(fieldName);
                this.outputProfile.Differential.Element.Add(outputSliceBaseElement);
            }
            else
            {
                ValidateSliceBase(fieldName, outputSliceBaseElement);
            }

            ElementDefinition newDef = new ElementDefinition
            {
                ElementId = $"{this.targetElement.ElementId}:{this.sourceElement.Short.ToMachineName()}",
                Path = this.targetElement.Path,
                Label = this.sourceElement.Short,
                Short = this.sourceElement.Short,
                Definition = this.sourceElement.Definition,
                Min = this.sourceElement.Min,
                Max = this.sourceElement.Max,
                Binding = this.sourceElement.Binding,
                Type = this.sourceElement.Type,
                MustSupport = true,
#if FHIR_R2
#else
                SliceName = $"{this.sourceElement.Short.ToMachineName()}"
#endif
            };

            newDef.Code.Add((Coding) fhirElement);

            return newDef;
        }

        public override Object VisitUpdateCommand(map_parserParser.UpdateCommandContext context)
        {
            //# Tested
            LTrace("MapVisitorLocal.VisitUpdate", $"Map Update '{this.sourceElement.Path}' -> '{this.targetElement.Path}'");

            ElementDefinition newDef = new ElementDefinition();
            this.targetElement.CopyTo(newDef);
            this.sourceElement.CopyTo(newDef);
            return newDef;
        }

        public override Object VisitIgnoreCommand(map_parserParser.IgnoreCommandContext context)
        {
            //# Tested
            LTrace("MapVisitorLocal.VisitNoOp", $"Map Ignore '{this.sourceElement.Path}' -> '{this.targetElement.Path}'");
            return null;
        }

        public override Object VisitMapNewElementCommand(map_parserParser.MapNewElementCommandContext context)
        {
            //# Tested
            LTrace("MapVisitorLocal.VisitMapNewElementCommand", $"");

            ElementDefinition newDef = (ElementDefinition)this.VisitChildren(context);
            this.AddElement(newDef);
            return null;
        }

        public override Object VisitMapNewElement(map_parserParser.MapNewElementContext context)
        {
            return (ElementDefinition)this.VisitChildren(context);
        }

        public override Object VisitOverwrite(map_parserParser.OverwriteContext context)
        {
            //# Tested

            LTrace("MapVisitorLocal.VisitOverwrite", $"Map Overwrite '{this.sourceElement.Path}' ->  '{this.targetElement.Path}'");
            ElementDefinition newDef = new ElementDefinition();
            this.sourceElement.CopyTo(newDef);
            return newDef;
        }

        public override Object VisitAbortCommand(map_parserParser.AbortCommandContext context)
        {
            //# Tested
            LTrace("MapVisitorLocal.VisitAbortCommand", $"");
            String message = this.VisitOrDefault<String>(context.stringValue());
            throw new Exception(message);
        }

        /// <summary>
        /// Create an extension. The name and type are implicitly defined by the source name and type.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitExtensionImplicitCommand(map_parserParser.ExtensionImplicitCommandContext context)
        {
            //if (this.sourceElement.Type.Count != 1)

            String mapName = this.sourceElement.Path.LastPathPart();
            LTrace("MapVisitorLocal.VisitExtensionImplicit", $"Map Extension({mapName}, {this.sourceElement.Type})");
#if FHIR_R2 || FHIR_R3
            this.Extension(mapName);
#elif FHIR_R4
            this.Extension(mapName, this.sourceElement.Type);
#endif
            return null;
        }

        /// <summary>
        /// Create an extension. The name and type are exlicitly defined.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Object VisitExtensionExplicitCommand(map_parserParser.ExtensionExplicitCommandContext context)
        {
            //# Tested
            String[] strings = this.VisitMultiple<String>(context.stringValue());
            String mapName = strings[0];
            String mapType = strings[1];
            LTrace("MapVisitorLocal.VisitExtensionExplicit", $"Map Extension({mapName}, {mapType})");
#if FHIR_R2 || FHIR_R3
            this.Extension(mapName);
#elif FHIR_R4
            this.Extension(mapName,
                new ElementDefinition.TypeRefComponent[] { new ElementDefinition.TypeRefComponent { Code = mapType } });
#endif
            return null;
        }

#if FHIR_R4
        void Extension(String mapName, IEnumerable<ElementDefinition.TypeRefComponent> type)
#else
        void Extension(string mapName)
#endif
        {
            {
                String extensionName = $"{mapName.ToMachineName()}Extension";
                String extensionUrl = $"{this.modelDefCache.ProjectData.BaseUrl}/StructureDefinition/{extensionName}";

                if (this.modelDefCache.FindExtension(extensionUrl, out StructureDefinition retVal) == true)
                    throw new Exception("Extension {extensionUrl} already exists");
                {
                    String description = $"{mapName} Extension Fields";
                    StructureDefinition extension = new StructureDefinition
                    {
                        Abstract = false,
                        DateElement = this.date,
                        Differential = new StructureDefinition.DifferentialComponent(),
                        Experimental = true,
                        Id = extensionName,
                        Name = extensionName,
                        Status = this.modelDefCache.ProjectData.PublicationStatus.ToPublicationStatus(),
                        //Text = new Narrative
                        //{
                        //    Status = Narrative.NarrativeStatus.Generated,
                        //    Div = ConverterBase.ToDiv(description)
                        //},
                        Url = extensionUrl,

#if FHIR_R2
                        Base = ExtensionBaseUrl,
                        ConstrainedType = FHIRDefinedType.Extension,
                        Context = new String[] { this.outputProfile.Url },
                        ContextType = StructureDefinition.ExtensionContext.Extension,
                        Description = description,
                        FhirVersion  = FhirKhitVersion.FhirVersion,
                        Kind = StructureDefinition.StructureDefinitionKind.Resource
#elif FHIR_R3
                        BaseDefinition = ExtensionBaseUrl,
                        Context = new String[] { this.outputProfile.Url },
                        ContextType = StructureDefinition.ExtensionContext.Extension,
                        Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                        Description = new Markdown(description),
                        FhirVersion  = FhirKhitVersion.FhirVersion,
                        Kind = StructureDefinition.StructureDefinitionKind.ComplexType,
                        Title = $"{mapName} Extension Fields",
                        Type = "Extension"
#elif FHIR_R4
                        BaseDefinition = ExtensionBaseUrl,
                        //Context = new StructureDefinition.ContextComponent
                        //{
                        //    new String[] { this.outputProfile.Url }
                        //},
                        Derivation = StructureDefinition.TypeDerivationRule.Constraint,
                        Description = new Markdown(description),
                        FhirVersion = FhirKhitVersion.FhirVersionEnum,
                        Kind = StructureDefinition.StructureDefinitionKind.ComplexType,
                        Title = $"{mapName} Extension Fields",
                        Type = "Extension"
#endif
                    };

                    {
                        ElementDefinition e = new ElementDefinition
                        {
                            ElementId = $"Extension",
                            Path = "Extension",
                            MustSupport = false,
                            IsModifier = false,
                            Short = this.sourceElement.Short,
                            Definition = this.sourceElement.Definition,
                            Min = 0,
                            Max = "1"
                        };
                        extension.Differential.Element.Add(e);
                    }
                    {
                        ElementDefinition e = new ElementDefinition
                        {
                            ElementId = $"Extension.url",
                            Path = "Extension.url",
                            Fixed = new FhirUri(extensionUrl)
                        };
                        extension.Differential.Element.Add(e);
                    }
                    {
                        ElementDefinition e = new ElementDefinition
                        {
                            ElementId = $"Extension.value",
                            Path = "Extension.value",
                            Short = this.sourceElement.Short,
                            Definition = this.sourceElement.Definition,
                            Min = 1,
                            Max = "1",
                            Type = this.sourceElement.Type,
                            Binding = this.sourceElement.Binding
                        };
                        extension.Differential.Element.Add(e);
                    }
                    this.modelDefCache.AddExtension(extension);
                }

                // Add extension reference to output profile
                {
                    String path = $"{this.outputProfile.Differential.Element[0].ElementId}.extension";
                    String id = $"{path}.{extensionName}";
                    ElementDefinition e = new ElementDefinition
                    {
                        ElementId = id,
                        Path = path,
#if FHIR_R4 || FHIR_R3
                        SliceName = extensionName,
#endif
                        Short = this.sourceElement.Short,
                        Definition = this.sourceElement.Definition,
                        Min = this.sourceElement.Min,
                        Max = this.sourceElement.Max,
                        MustSupport = true
                    };
                    ElementDefinition.TypeRefComponent eType = new ElementDefinition.TypeRefComponent
                    {
#if FHIR_R2
                        Code = FHIRDefinedType.Extension
#else
                        Code = "Extension"
#endif
                    };
#if FHIR_R4
                    eType.ProfileElement.Add(new Canonical(extensionUrl));
#elif FHIR_R3
                    eType.ProfileElement = new FhirUri(extensionUrl);
#else
                    eType.ProfileElement.Add(new FhirUri(extensionUrl));
#endif
                    e.Type.Add(eType);
                    this.outputProfile.Differential.Element.Add(e);
                }
            }
        }

        private void PushFhirElement(Element fhirElement)
        {
            this.fhirElementStack.Push(fhirElement);
        }

        private T GetCurrentFhirElement<T>()
            where T : Element
        {
            return (T)this.fhirElementStack.Peek();
        }

        private Element PopFhirElement()
        {
            return this.fhirElementStack.Pop();
        }

        public override Object VisitFhirElementCoding(map_parserParser.FhirElementCodingContext context)
        {
            LTrace("MapVisitorLocal.VisitFhirElementCoding", $"");

            Coding retVal = new Coding();
            String[] strings = this.VisitMultiple<String>(context.stringValue());
            retVal.System = strings[0];
            retVal.Code = strings[1];
            if (strings.Length >= 3)
                retVal.Version = strings[2];
            return retVal;
        }

        public override Object VisitStringValueFieldTermSource(map_parserParser.StringValueFieldTermSourceContext context)
        {
            if (this.map == null)
                throw new Exception("VisitStringValueFieldTermSource: map is null, can not lookup field terminology source");
            return this.map.FieldTerminologySource;
        }

        public override Object VisitStringValueFieldTermId(map_parserParser.StringValueFieldTermIdContext context)
        {
            if (this.map == null)
                throw new Exception("VisitStringValueFieldTermId: map is null, can not lookup field terminology Id");
            return this.map.FieldTerminologyId;
        }

        public override Object VisitStringValueQString(map_parserParser.StringValueQStringContext context)
        {
            return this.UnQuote(context.GetText());
        }
    }
}