using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FhirKhit.ProfGen.PGShared;
using FhirKhit.ProfGen.PGShared.CodeGen.CSApi.Extensions;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support.Model;
using System.Diagnostics;
using Hl7.FhirPath;

namespace FhirKhit.ProfGen.CSApi
{
    public partial class CSClassFormatter
    {
        String AccPrefix(String name) => $"Accessor__{name.ToMachineName()}";

        public CodeBlockNested ClassBlock { get; set; }
        public CodeBlockNested ContainingBlock { get; set; }
        public CodeBlockNested staticMethodsBlock { get; set; }
        public CodeBlockNested ConstructorBlock { get; set; }
        public CodeBlockNested SubClassBlock { get; set; }
        public CodeBlockNested PropertiesBlock { get; set; }
        public CodeBlockNested FieldsBlock { get; set; }
        //CodeBlockNested methodsBlock;

        Type fhirResourceType;
        ProfileGenerator gen;
        CSCodeFormatter codeFormatter;
        String fhirBaseClassName;
        bool topLevelClass;

        /// <summary>
        /// Type of the fhir resource class that the profile is derived from (the resource it profiles)
        /// </summary>
        Type fhirType;

        /// <summary>
        /// Dictionary of Fhir element properties in the current resouce class.
        /// </summary>
        Dictionary<String, PropertyInfo> elements = new Dictionary<string, PropertyInfo>();


        public CSClassFormatter(ProfileGenerator gen,
            CSCodeFormatter codeFormatter,
            CodeBlockNested ContainingBlock,
            bool topLevelClass)
        {
            if (ContainingBlock is null)
                throw new ArgumentNullException(nameof(ContainingBlock));

            this.gen = gen;
            this.codeFormatter = codeFormatter;
            this.ContainingBlock = ContainingBlock;
            this.ClassBlock = this.ContainingBlock.AppendBlock();
            this.topLevelClass = topLevelClass;
        }

        /// <summary>
        /// Populate FhirApiTypes with all the Fhir Api class (resource) types that have the FhirTypeAttribute attribute.
        /// </summary>
        /// <param name="resourceType"></param>
        void PopulateElementDictionary(Type resourceType)
        {
            this.fhirType = resourceType;

            Assembly coreAsm = Assembly.GetAssembly(typeof(Hl7.Fhir.Model.Base));
            foreach (PropertyInfo property in resourceType.GetProperties())
            {
                FhirElementAttribute att = property.GetCustomAttribute<FhirElementAttribute>(false);
                if (att != null)
                    this.elements.Add(att.Name, property);
            }
        }

        /// <summary>
        /// Start creating a class.
        /// </summary>
        public void StartClass(String className, Type fhirType)
        {
            if (fhirType is null)
                throw new ArgumentNullException(nameof(fhirType));

            this.fhirResourceType = fhirType;
            this.PopulateElementDictionary(fhirType);

            this.fhirBaseClassName = fhirType.FriendlyName();
            className = className.FormatClassName();

            if (!this.topLevelClass)
                this.ClassBlock.AppendRaw($"#region Class {className}");

            this.ClassBlock
                .OpenSummary()
                .AppendLine($"/// Class to implement '{className}'")
                .CloseSummary()
                .AppendCode($"public class {className} :")
                .AppendCode($"    ItemBase<{fhirBaseClassName}>")
                .OpenBrace()
                ;

            this.SubClassBlock = this.ClassBlock.AppendBlock();

            this.staticMethodsBlock = this.ClassBlock.AppendBlock();
            this.FieldsBlock = this.ClassBlock.AppendBlock();
            this.PropertiesBlock = this.ClassBlock.AppendBlock();
            this.ConstructorBlock = this.ClassBlock.AppendBlock();

            if (this.topLevelClass)
            {
                this.SubClassBlock.AppendRaw("#region Sub Class Definitions");
                this.FieldsBlock.AppendRaw("#region Field Definitions");
                this.PropertiesBlock.AppendRaw("#region Property Definitions");
            }

            this.staticMethodsBlock
                .WriteStaticCreate(className, this.fhirBaseClassName)
                ;

            this.ConstructorBlock
                .WriteConstructor(className)
                .WriteInitStart(this.fhirBaseClassName)
                ;
        }

        public void EndClass()
        {
            if (this.topLevelClass)
            {
                this.SubClassBlock.AppendRaw("#endregion");
                this.PropertiesBlock.AppendRaw("#endregion");
                this.FieldsBlock.AppendRaw("#endregion");
            }

            this.ConstructorBlock
                .WriteInitEnd()
                ;

            this.ClassBlock
                .CloseBrace()
                ;

            if (!this.topLevelClass)
                this.ClassBlock.AppendRaw("#endregion");
        }

        String ListType(Type list, out Type listType)
        {
            if (list.GenericTypeArguments.Length != 1)
                throw new Exception($"Expected a single generic argument to list property");
            listType = list.GenericTypeArguments[0];
            return listType.FriendlyName();
        }

        void WritePassThroughProperty(ElementNode elementNode,
            String propertyName,
            String propertyType)
        {
            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            String accessorClassName = AccPrefix(propertyName);
            this.SubClassBlock
                .AppendRaw($"#region class {accessorClassName}")
                .OpenSummary()
                .AppendLine($"/// Accessor for property {propertyName}")
                .CloseSummary()
                .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                .OpenBrace()
                .BlankLine()
                .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr) : base(ptr)")
                .OpenBrace()
                .CloseBrace()
                .OpenSummary()
                .AppendLine($"/// Get value")
                .CloseSummary()
                .AppendCode($"public {propertyType} Get() {{ return this.Ptr.{propertyName}; }}")
                .OpenSummary()
                .AppendLine($"/// Set Value")
                .CloseSummary()
                .AppendCode($"public void Set({propertyType} value) {{ this.Ptr.{propertyName} = value; }}")
                .CloseBrace()
                .AppendRaw("#endregion")
                ;


            CreateAccessorProperty(accessorClassName, elementNode);
        }

        void EmptyProfileCheck(ElementDefinition.TypeRefComponent type)
        {
            String fcn = "EmptyProfileCheck";

#if FHIR_R2 || FHIR_R3
            //# Tested
            if (type.Profile != null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Profile not implemented [{type.Code}]");
                return;
            }
            if (type.TargetProfile != null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TargetProfile not implemented [{type.Code}]");
                return;
            }
#elif FHIR_R4
            //# Tested
            if (type.Profile.Any())
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Profile not implemented [{type.Code}]");
                return;
            }
            if (type.TargetProfile.Any())
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TargetProfile not implemented [{type.Code}]");
                return;
            }
#endif
        }

        String FhirTypeProfileCheck(ElementDefinition.TypeRefComponent type)
        {
            String fcn = "EmptyProfileCheck";

#if FHIR_R2 || FHIR_R3
            //# Tested
            if (type.TargetProfile != null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TargetProfile not implemented [{type.Code}]");
                return null;
            }

            if (type.Profile != null)
                return type.Profile.LastPathPart();
            
            return type.Code;
#elif FHIR_R4
            //# Tested
            if (type.TargetProfile.Any())
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TargetProfile not implemented [{type.Code}]");
                return null;
            }

            switch (type.Profile.Count())
            {
                case 0: return type.Code;
                case 1: return type.Profile.First().LastUriPart();
                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Multiple Profile on frir type not implemented [{type.Code}]");
                    return null;
            }
#endif
        }

        PropertyInfo GetProperty(String name)
        {
            if (name.EndsWith("[x]"))
                name = name.Substring(0, name.Length - 3);
            if (this.elements.TryGetValue(name, out PropertyInfo propertyInfo) == false)
                throw new Exception();
            return propertyInfo;
        }

        bool FhirSimpleConstruct(CodeBlockNested block,
            String varName,
            String value,
            bool singleton,
            String propertyType)
        {
            block
                .OpenBrace()
                .AppendCode($"{propertyType} temp = new {propertyType}({value});")
                ;
            if (singleton)
                block.AppendCode($"{varName} = temp;");
            else
            {
                block.AppendCode($"{varName}.Clear();");
                block.AppendCode($"{varName}.Add(temp);");
            }
            block.CloseBrace();
            return true;
        }

        String GetBindingValuesetName(ElementNode elementSlice)
        {
#if FHIR_R4
            return elementSlice.Element.Binding.ValueSet.ToValueSetEnumName();
#elif FHIR_R3
            const String fcn = "GetBindingValuesetName";

            switch (elementSlice.Binding.ValueSet)
            {
            case FhirUri uri:
                return uri.Value.ToValueSetEnumName();
            default:
                this.gen.ConversionError(this.GetType().Name, fcn, $"Value set binding of unknown type '{elementSlice.Binding.ValueSet.TypeName}");
                return null;
            }
#else
            Unimplemented.
#endif
        }

        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        /// <param name="fix"></param>
        /// <returns></returns>
        bool FhirConstruct(ElementNode elementNode,
            CodeBlockNested block,
            Element fix,
            String varName,
            bool singleton,
            out String propertyType)
        {
            const String fcn = "FhirConstruct";

            propertyType = null;
            switch (fix.TypeName)
            {
                case "code":
                    {
                        //# Tested
                        var v = (Code)fix;
                        String valueName = "??";
                        if (UsesEnum(elementNode))
                        {
                            //# Tested
                            String enumName = GetBindingValuesetName(elementNode);
                            if (enumName != null)
                            {
                                propertyType = $"Code<{enumName}>";
                                valueName = $"{enumName}.{v.Value.ToValueSetEnumName()}";
                            }
                        }
                        else
                        {
                            //# Not Tested
                            propertyType = "Code";
                            valueName = v.Value.ToCode();
                        }

                        if (singleton)
                        {
                            block.AppendCode($"{varName} = new {propertyType}({valueName});");
                        }
                        else
                        {
                            block.AppendCode($"{varName}.Clear();");
                            block.AppendCode($"{varName}.Add(new {propertyType}({valueName}));");
                        }
                        return true;
                    }
                case "instant":
                    //# Not Tested
                    propertyType = "Instant";
                    return FhirSimpleConstruct(block, varName, ((Instant)fix).Value.ToCode(), singleton, propertyType);

                case "time":
                    //# Not Tested
                    propertyType = "Time";
                    return FhirSimpleConstruct(block, varName, ((Time)fix).Value.ToCode(), singleton, propertyType);

                case "date":
                    //# Not Tested
                    propertyType = "Date";
                    return FhirSimpleConstruct(block, varName, ((Date)fix).Value.ToCode(), singleton, propertyType);

                case "dateTime":
                    //# Not Tested
                    propertyType = "FhirDateTime";
                    return FhirSimpleConstruct(block, varName, ((FhirDateTime)fix).Value.ToCode(), singleton, propertyType);

                case "decimal":
                    //# Not Tested
                    propertyType = "FhirDecimal";
                    return FhirSimpleConstruct(block, varName, ((FhirDecimal)fix).Value.ToCode(), singleton, propertyType);

                case "boolean":
                    //# Tested
                    propertyType = "FhirBoolean";
                    return FhirSimpleConstruct(block, varName, ((FhirBoolean)fix).Value.ToCode(), singleton, propertyType);

#if FHIR_R4
                case "url":
                    //# Not Tested
                    propertyType = "FhirUrl";
                    return FhirSimpleConstruct(block, varName, ((FhirUrl)fix).Value.ToCode(), singleton, propertyType);
#endif

                case "string":
                    //# Not Tested
                    propertyType = "FhirString";
                    return FhirSimpleConstruct(block, varName, ((FhirString)fix).Value.ToCode(), singleton, propertyType);

                case "uri":
                    //# Not Tested
                    propertyType = "FhirUri";
                    return FhirSimpleConstruct(block, varName, ((FhirUri)fix).Value.ToCode(), singleton, propertyType);


#if FHIR_R4
                case "canonical":
                    //# Not Tested
                    propertyType = "Canonical";
                    return FhirSimpleConstruct(block, varName, ((Canonical)fix).Value.ToCode(), singleton, propertyType);
#endif

                case "markdown":
                    //# Not Tested
                    propertyType = "Markdown";
                    return FhirSimpleConstruct(block, varName, ((Markdown)fix).Value.ToCode(), singleton, propertyType);

                case "id":
                    //# Not Tested
                    propertyType = "Id";
                    return FhirSimpleConstruct(block, varName, ((Id)fix).Value.ToCode(), singleton, propertyType);

                case "oid":
                    //# Not Tested
                    propertyType = "Oid";
                    return FhirSimpleConstruct(block, varName, ((Oid)fix).Value.ToCode(), singleton, propertyType);

                case "uuid":
                    //# Not Tested
                    propertyType = "Uuid";
                    return FhirSimpleConstruct(block, varName, ((Uuid)fix).Value.ToCode(), singleton, propertyType);

                case "base64Binary":
                    //# Not Tested
                    propertyType = "Base64Binary";
                    return FhirSimpleConstruct(block, varName, ((Base64Binary)fix).Value.ToCode(), singleton, propertyType);

                case "integer":
                    //# Not Tested
                    propertyType = "Integer";
                    return FhirSimpleConstruct(block, varName, ((Integer)fix).Value.ToCode(), singleton, propertyType);

                case "unsignedInt":
                    //# Not Tested
                    propertyType = "UnsignedInt";
                    return FhirSimpleConstruct(block, varName, ((UnsignedInt)fix).Value.ToCode(), singleton, propertyType);

                case "positiveInt":
                    //# Not Tested
                    propertyType = "PositiveInt";
                    return FhirSimpleConstruct(block, varName, ((PositiveInt)fix).Value.ToCode(), singleton, propertyType);

                case "Ratio":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Period":
                    {
                        //# Tested
                        propertyType = "Period";
                        Period p = (Period)fix;
                        block.OpenBrace();
                        block.AppendCode($"FhirDateTime start = {p.StartElement.ToCode()};");
                        block.AppendCode($"FhirDateTime end = {p.EndElement.ToCode()};");
                        block.AppendCode($"{propertyType} temp = new {propertyType}(start, end);");
                        if (singleton)
                            block.AppendCode($"{varName} = temp;");
                        else
                        {
                            block.AppendCode($"{varName}.Clear();");
                            block.AppendCode($"{varName}.Add(temp);");
                        }
                        block.CloseBrace();
                        return true;
                    }
                case "Range":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Attachment":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Identifier":
                    {
                        //# Tested
                        var v = (Identifier)fix;
                        if (v == null)
                            return true;

                        propertyType = "Identifier";
                        block
                            .OpenBrace()
                            .AppendCode($"var temp = new {propertyType}({v.System.ToCode()}, {v.Value.ToCode()});")
                            ;
                        if (singleton)
                            block.AppendCode($"{varName} = temp;");
                        else
                        {
                            block
                                .AppendCode($"{varName}.Clear();")
                                .AppendCode($"{varName}.Add(temp);")
                                .CloseBrace()
                                ;
                        }
                        return true;
                    }
                case "Annotation":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "HumanName":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "CodeableConcept":
                    {
                        //# Tested
                        CodeableConcept v = (CodeableConcept)fix;
                        if (v == null)
                            return true;
                        propertyType = "CodeableConcept";
                        block
                            .OpenBrace()
                            .AppendCode($"CodeableConcept temp = new {propertyType}();")
                            ;
                        if (v.Text != null)
                            block.AppendCode($"temp.Text = {v.Text.ToCode()};");
                        foreach (Coding c in v.Coding)
                            block.AppendCode($"temp.Coding.Add({c.ToCode()}));");

                        if (singleton)
                            block.AppendCode($"{varName} = temp;");
                        else
                        {
                            block.AppendCode($"{varName}.Clear();");
                            block.AppendCode($"{varName}.Add(temp);");
                        }
                        block.CloseBrace();
                        return true;
                    }
                case "ContactPoint":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Coding":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Money":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Address":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Timing":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Quantity":
                    {
                        //# Tested
                        propertyType = "Quantity";
                        var v = (Quantity)fix;
                        return FhirSimpleConstruct(block, varName, $"{v.Value.ToCode()}, {v.Code.ToCode()}, {v.System.ToCode()}", singleton, propertyType);
                    }
                case "SampledData":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Signature":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Age":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Distance":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Duration":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Count":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "MoneyQuantity":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "SimpleQuantity":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "Narrative":
                    {
                        //# Not Tested
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }
                case "identifier":
                    //# Not Tested
                    {
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Implement {fix.GetType().FriendlyName()}");
                        return false;
                    }

                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Unimplemented element type {fix.GetType().FriendlyName()}");
                    return false;
            }
        }

        /// <summary>
        /// Create a singleton property with a fixed value.
        /// </summary>
        void CreatePropertyFixed(ElementNode elementNode,
            String elementName,
            PropertyInfo propertyInfo,
            bool singleton)
        {
            if (singleton == false)
                this.ConstructorBlock.AppendCode($"this.Ptr.{propertyInfo.Name}.Clear();");
            if (this.FhirConstruct(elementNode, this.ConstructorBlock, elementNode.Element.Fixed, $"this.Ptr.{ propertyInfo.Name}", singleton, out string elementType) == false)
                return;

            String elementPName = elementName.FormatPropertyName();

            String accessorClassName = AccPrefix(elementPName);
            this.SubClassBlock
                .OpenSummary()
                .AppendLine($"/// Accessor for property {elementPName}")
                .CloseSummary()
                .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                .OpenBrace()

                .WriteStaticCreate(accessorClassName, this.fhirBaseClassName)
                .WriteConstructor(accessorClassName)
                .WriteInit(this.fhirBaseClassName)

                .OpenSummary()
                .AppendLine($"/// Property for accessing fixed property {elementNode.Path}.")
                .CloseSummary()
                .AppendCode($"public bool Get(out {elementType} value)")
                .OpenBrace()
                ;
            switch (singleton)
            {
                case true: this.SubClassBlock.AppendCode($"value = ({elementType}) this.Ptr.{propertyInfo.Name};"); break;
                case false: this.SubClassBlock.AppendCode($"value = this.Ptr.{propertyInfo.Name}.First();"); break;
            }

            this.SubClassBlock
                .AppendCode($"return value != null;")
                .CloseBrace()
                .CloseBrace()
                ;

            CreateAccessorProperty(accessorClassName, elementNode);
        }

        void CreateAccessorProperty(String accessorClassName,
            ElementNode elementNode)
        {
            String elementName = elementNode.Path.LastPathPart().Trim();
            String elementPName = elementName.FormatPropertyName();
            // Create property that instantiates the single tone class created above.

            this.PropertiesBlock
                .OpenSummary()
                .AppendLine($"/// Property for accessing {elementNode.Path}.")
                .AppendLine($"/// An accessor instance is created each time this property is called.")
                .CloseSummary()
                .AppendCode($"public {accessorClassName} {elementPName} => {accessorClassName}.Create(this.Ptr);")
                ;
        }

        bool UsesEnum(ElementNode elementNode)
        {
            if (
                (elementNode.Element.Binding != null) &&
                (elementNode.Element.Binding.Strength == BindingStrength.Required)
                )
                return true;
            return false;
        }

        /// <summary>
        /// Create a singleton property.
        /// </summary>
        void CreatePropertySingleton(ElementNode elementNode,
            PropertyInfo propertyInfo)
        {
            const String fcn = "CreateSingletonProperty";

            void WriteBackboneAccessor(String backboneClass,
                String propertyName,
                String propertyType)
            {
                this.SubClassBlock
                    .OpenSummary()
                    .AppendLine($"/// Get '{propertyType}' value")
                    .AppendLine($"/// return true if successfull, false if value is null or can not be converted to '{propertyType}'")
                    .CloseSummary()
                    .AppendCode($"public bool Get(out {backboneClass} value)")
                    .OpenBrace()
                    .AppendCode($"value == null;")
                    .AppendCode($"if (this.Ptr.{propertyName} == null) return false;")
                    .AppendCode($"value = new {backboneClass}(this.Ptr.{propertyName});")
                    .AppendCode($"return true;")
                    .CloseBrace()
                    .OpenSummary()
                    .AppendLine($"/// Set '{propertyType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Set({propertyType} value) => this.Ptr.{propertyInfo.Name} = value;")
                    .OpenBrace()
                    .AppendCode($"if (value == null) this.Ptr.{propertyInfo.Name} = null;")
                    .OpenBrace()
                    .AppendCode($"this.Ptr.{propertyInfo.Name} = null;")
                    .AppendCode($"return;")
                    .CloseBrace()
                    .AppendCode($"this.Ptr.{propertyInfo.Name} = value.Ptr;")
                    .CloseBrace()
                    ;
            }

            void WriteAccessor(String pType)
            {
                this.SubClassBlock
                    .OpenSummary()
                    .AppendLine($"/// Get '{pType}' value")
                    .AppendLine($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .CloseSummary()
                    .AppendCode($"public bool Get(out {pType} value)")
                    .OpenBrace()
                    .AppendCode($"value = this.Ptr.{propertyInfo.Name} as {pType};")
                    .AppendCode($"return value != null;")
                    .CloseBrace()
                    .OpenSummary()
                    .AppendLine($"/// Set '{pType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Set({pType} value) => this.Ptr.{propertyInfo.Name} = value;")
                    ;
            }

            /// <summary>
            /// Original and profile elements have cardinality = 1.
            /// </summary>
            void WriteAccessors(ElementDefinition.TypeRefComponent type)
            {
                switch (type.Code)
                {
                    case "BackboneElement":
                        {
                            //# Not Tested
                            String pTypeName = propertyInfo.PropertyType.FriendlyName();
                            String backboneClassName = this.CreateBackBoneClass(elementNode, propertyInfo.PropertyType);
                            WriteBackboneAccessor(backboneClassName, pTypeName, propertyInfo.Name);
                        }
                        break;

                    case "Extension":
                        {
                            //# Not Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Extension Unsupported.");
                        }
                        break;

                    case "Resource":
                        {
                            //# Not Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Resource Unsupported.");
                        }
                        break;

                    case "Reference":
                        {
                            //# Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Reference Unsupported.");
                        }
                        break;

                    case "code":
                        {
                            this.EmptyProfileCheck(type);

                            // Write out property to bind to coded enum if possible.
                            if (UsesEnum(elementNode))
                            {
                                // the c# only creates a enum if the value set is required, so we cant link against it if it is only preferred.
                                // TODO: Create our own valueset enums?

                                String enumName = GetBindingValuesetName(elementNode);
                                if (enumName != null)
                                    WriteAccessor($"Code<{enumName}>");
                            }
                            else
                            {
                                WriteAccessor($"Code");
                            }
                        }
                        break;

                    case "instant":                        // Primitive types.
                    case "time":
                    case "date":
                    case "dateTime":
                    case "decimal":
                    case "boolean":
                    case "url":
                    case "string":
                    case "uri":
                    case "canonical":
                    case "markdown":
                    case "id":
                    case "oid":
                    case "uuid":
                    case "base64Binary":
                    case "integer":
                    case "unsignedInt":
                    case "positiveInt":                         // Primitive types.
                    case "Ratio":                               // General purpose data types (minus backbone element).
                    case "Period":
                    case "Range":
                    case "Attachment":
                    case "Identifier":
                    case "Annotation":
                    case "HumanName":
                    case "CodeableConcept":
                    case "ContactPoint":
                    case "Coding":
                    case "Money":
                    case "Address":
                    case "Timing":
                    case "Quantity":
                    case "SampledData":
                    case "Signature":
                    case "Age":
                    case "Distance":
                    case "Duration":
                    case "Count":
                    case "MoneyQuantity":
                    case "SimpleQuantity":                      // General purpose data types (minus backbone element).

                    case "Meta":
                    case "Narrative":

                        if (propertyInfo.Name == "ElementId")
                        {
                            this.EmptyProfileCheck(type);
                            WriteAccessor("String");
                        }
                        else
                        {
                            String fhirType = this.FhirTypeProfileCheck(type);
                            if (ModelInfo.FhirTypeToCsType.TryGetValue(fhirType, out Type csType) == false)
                            {
                                this.gen.ConversionError(this.GetType().Name, fcn, $"Property type {type.Code} {propertyInfo.Name} not found");
                                return;
                            }
                            WriteAccessor(csType.FriendlyName());
                        }
                        break;

                    default:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                        break;
                }
            }
            {
                String propertyName = propertyInfo.Name;

                String accessorClassName = AccPrefix(propertyName);
                this.SubClassBlock
                    .AppendRaw($"#region class {accessorClassName}")
                    .OpenSummary()
                    .AppendLine($"/// Accessor for property {propertyName}")
                    .CloseSummary()
                    .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                    .OpenBrace()

                    .WriteStaticCreate(accessorClassName, this.fhirBaseClassName)
                    .WriteConstructor(accessorClassName)
                    .WriteInit(this.fhirBaseClassName)
                    ;

                foreach (ElementDefinition.TypeRefComponent type in elementNode.Element.Type)
                    WriteAccessors(type);

                // complete sub class.
                this.SubClassBlock
                    .CloseBrace()
                    .AppendRaw("#endregion")
                    ;

                CreateAccessorProperty(accessorClassName, elementNode);
            }
        }

        String CreateComplexClass(ElementNode elementNode,
            Type propertyType,
            String accessorClassName)
        {
            const String fcn = "CreateComplexClass";

            if (propertyType.DeclaringType == null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"#Todo: Definition not in declaring type not implemented.");
                return null;
            }
            if (propertyType.DeclaringType != fhirResourceType)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"#Todo: Definition not in declaring type not implemented.");
                return null;
            }

            this.codeFormatter.StartClass(accessorClassName, propertyType, false);

            foreach (ElementNode child in elementNode.Children)
                this.codeFormatter.CreateProperty(child);

            this.codeFormatter.EndClass();

            return accessorClassName;
        }

        /// <summary>
        /// Create a backbone class.
        /// This recrusively calls the whole class creation process.
        /// </summary>
        String CreateBackBoneClass(ElementNode elementNode,
            Type propertyType)
        {
            if (this.codeFormatter.TryGetBackboneElement(propertyType, out String accessorClassName) == true)
                return accessorClassName;

            String fullClassName = propertyType.FriendlyName();
            String shortClassName = fullClassName.LastPathPart();
            accessorClassName = AccPrefix(shortClassName);

            return CreateComplexClass(elementNode, propertyType, accessorClassName);
        }

        /// <summary>
        /// Create a slice class.
        /// This recrusively calls the whole class creation process.
        /// </summary>
        String WriteSliceClass(ElementNode elementSlice,
            String propertyName,
            Type propertyType)
        {
            const String fcn = "WriteSliceClass";

            String sliceName = elementSlice.Element.SliceName;
            if (String.IsNullOrEmpty(sliceName) == true)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Slice element {elementSlice.Element.ElementId} lacks SliceName");
                return String.Empty;
            }

            String fullClassName = propertyType.FriendlyName();
            String shortClassName = fullClassName.LastPathPart();
            String className = $"Slice_{sliceName}";
            return CreateComplexClass(elementSlice, propertyType, className);
        }

        /// <summary>
        /// Create properties for elements whose original and profile cardinality is greater than 1.
        /// </summary>
        void CreatePropertyMultiple(ElementNode elementNode,
            PropertyInfo propertyInfo)
        {
            const String fcn = "CreateMultipleProperty";

            String propertyName = propertyInfo.Name;
            String listTypeName = ListType(propertyInfo.PropertyType, out Type listType);
            CodeBlockNested subClassBlock = null;
            CodeBlockNested staticMethodsBlock = null;
            CodeBlockNested fieldsBlock = null;
            CodeBlockNested propertiesBlock = null;
            CodeBlockNested constructorBlock = null;
            CodeBlockNested methodsBlock = null;

            void WriteAccessorMultiComplex(String backboneType,
                String pType,
                String pName)
            {
                propertiesBlock
                    .OpenSummary()
                    .AppendLine($"/// Count of items")
                    .CloseSummary()
                    .AppendCode($"public Int32 Count => this.Ptr.{pName}.Count;")
                    ;

                methodsBlock
                    .OpenSummary()
                    .AppendLine($"/// Get '{pType}' value")
                    .AppendLine($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .CloseSummary()
                    .AppendCode($"public bool Get(Int32 index, out {backboneType} value)")
                    .OpenBrace()
                    .AppendCode($"value = null;")
                    .AppendCode($"{pType} temp = this.Ptr.{pName}[index];")
                    .AppendCode($"if (temp == null) return false;")
                    .AppendCode($"value = {backboneType}.Create(temp);")
                    .AppendCode($"return true;")
                    .CloseBrace()

                    .OpenSummary()
                    .AppendLine($"/// Set '{pType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Set(Int32 index, {backboneType} value)")
                    .OpenBrace()
                    .AppendCode($"if (value is null)")
                    .AppendCode($"    throw new ArgumentNullException(nameof(value));")
                    .AppendCode($"this.Ptr.{pName}[index] = value.Ptr;")
                    .CloseBrace()

                    .OpenSummary()
                    .AppendLine($"/// Add '{pType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Add({backboneType} value)")
                    .OpenBrace()
                    .AppendCode($"if (value is null)")
                    .AppendCode($"    throw new ArgumentNullException(nameof(value));")
                    .AppendCode($"this.Ptr.{pName}.Add(value.Ptr);")
                    .CloseBrace()
                    ;
            }

            void WriteAccessorMultiSimple(String pType,
                String pName)
            {
                propertiesBlock
                    .OpenSummary()
                    .AppendLine($"/// Count of items")
                    .CloseSummary()
                    .AppendCode($"public Int32 Count => this.Ptr.{pName}.Count;")
                    ;
                methodsBlock
                    .OpenSummary()
                    .AppendLine($"/// Get '{pType}' value")
                    .AppendLine($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .CloseSummary()
                    .AppendCode($"public bool Get(Int32 index, out {pType} value)")
                    .OpenBrace()
                    .AppendCode($"value = this.Ptr.{pName}[index] as {pType};")
                    .AppendCode($"return value != null;")
                    .CloseBrace()

                    .OpenSummary()
                    .AppendLine($"/// Set '{pType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Set(Int32 index, {pType} value)")
                    .OpenBrace()
                    .AppendCode($"if (value is null)")
                    .AppendCode($"    throw new ArgumentNullException(nameof(value));")
                    .AppendCode($"this.Ptr.{pName}[index] = value;")
                    .CloseBrace()

                    .OpenSummary()
                    .AppendLine($"/// Add '{pType}' Value")
                    .CloseSummary()
                    .AppendCode($"public void Add({pType} value)")
                    .OpenBrace()
                    .AppendCode($"if (value is null)")
                    .AppendCode($"    throw new ArgumentNullException(nameof(value));")
                    .AppendCode($"this.Ptr.{pName}.Add(value.Ptr);")
                    .CloseBrace()
                    ;
            }

            // ItemArray<Accessor__ReferenceRangeComponent, Observation.ReferenceRangeComponent>  xxyyz;

            void WriteSliceAccessorClass(ElementNode elementSlice)
            {
                String sliceName = elementSlice.Element.SliceName;
                if (String.IsNullOrEmpty(sliceName) == true)
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Slice element {elementSlice.Element.ElementId} lacks SliceName");
                    return;
                }

                String sliceClassName = AccPrefix(sliceName);
                subClassBlock
                    .AppendRaw($"#region class {sliceClassName}")
                    .OpenSummary()
                    .AppendLine($"/// Accessor class for slice {elementSlice.Element.SliceName}")
                    .CloseSummary()
                    .AppendCode($"public class {sliceClassName} : ItemBase<{this.fhirBaseClassName}>")
                    .OpenBrace()

                    .WriteStaticCreate(sliceClassName, this.fhirBaseClassName)
                    .WriteConstructor(sliceClassName)
                    .WriteInit(this.fhirBaseClassName)

                    .BlankLine()
                    .AppendCode($"public {listTypeName} Members()")
                    .OpenBrace()
                    .AppendCode($"throw new NotImplementedException();  // TODO")
                    .CloseBrace()
                    .AppendCode($"public void Add({listTypeName} item)")
                    .OpenBrace()
                    .AppendCode($"throw new NotImplementedException();  // TODO")
                    .CloseBrace()
                    .AppendCode($"public void DeleteAt(Int32 index)")
                    .OpenBrace()
                    .AppendCode($"throw new NotImplementedException();  // TODO")
                    .CloseBrace()
                    .AppendCode($"public void InsertAt(Int32 index, {listTypeName} item)")
                    .OpenBrace()
                    .AppendCode($"throw new NotImplementedException();  // TODO")
                    .CloseBrace()
                    .AppendCode($"public bool GetAt(Int32 index, out {listTypeName} item)")
                    .OpenBrace()
                    .AppendCode($"throw new NotImplementedException();  // TODO")
                    .CloseBrace()
                    .CloseBrace()
                    .AppendRaw("#endregion")
                    ;


                // Create property that instantiates the alice class created above.

                propertiesBlock
                    .OpenSummary()
                    .AppendLine($"/// Property for accessing slice {elementSlice.Element.SliceName}.")
                    .AppendLine($"/// An accessor instance is created each time this property is called.")
                    .CloseSummary()
                    .AppendCode($"public {sliceClassName} {elementSlice.Element.SliceName} => {sliceClassName}.Create(this.Ptr);")
                    ;
            }

            /// <summary>
            /// Write the common, non type specific acessors.
            /// </summary>
            void WriteCommonAccessors()
            {
                methodsBlock
                    .OpenSummary()
                    .AppendLine($"/// Remove item at indicated index")
                    .CloseSummary()
                    .AppendCode($"public void RemoveAt(Int32 index) => this.Ptr.{propertyInfo.Name}.RemoveAt(index);")

                    .OpenSummary()
                    .AppendLine($"/// Get list of all items")
                    .CloseSummary()
                    .AppendCode($"public IEnumerable<{listTypeName}> Get() => this.Ptr.{propertyInfo.Name};")
                    ;
            }

            /// <summary>
            /// Original and profile elements have cardinality = 1.
            /// </summary>
            void WriteAccessors(ElementDefinition.TypeRefComponent type)
            {
                switch (type.Code)
                {
                    case "BackboneElement":
                        {
                            //# Tested
                            String backboneClassName = this.CreateBackBoneClass(elementNode, listType);
                            WriteAccessorMultiComplex(backboneClassName, listTypeName, propertyInfo.Name);
                        }
                        break;

                    case "Extension":
                        {
                            //# Not Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Extension Unsupported.");
                        }
                        break;

                    case "Resource":
                        {
                            //# Not Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Resource Unsupported.");
                        }
                        break;

                    case "Reference":
                        {
                            //# Tested
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Reference Unsupported.");
                        }
                        break;

                    case "code":
                        {
                            this.EmptyProfileCheck(type);

                            // Write out property to bind to coded enum if possible.
                            if (UsesEnum(elementNode))
                            {
                                // the c# only creates a enum if the value set is required, so we cant link against it if it is only preferred.
                                // TODO: Create our own valueset enums?

                                String enumName = this.GetBindingValuesetName(elementNode);
                                if (enumName != null)
                                    WriteAccessorMultiSimple($"Code<{enumName}>", propertyInfo.Name);
                            }
                            else
                            {
                                WriteAccessorMultiSimple($"Code", propertyInfo.Name);
                            }
                        }
                        break;

                    case "instant":                        // Primitive types.
                    case "time":
                    case "date":
                    case "dateTime":
                    case "decimal":
                    case "boolean":
                    case "url":
                    case "string":
                    case "uri":
                    case "canonical":
                    case "markdown":
                    case "id":
                    case "oid":
                    case "uuid":
                    case "base64Binary":
                    case "integer":
                    case "unsignedInt":
                    case "positiveInt":                         // Primitive types.
                    case "Ratio":                               // General purpose data types (minus backbone element).
                    case "Period":
                    case "Range":
                    case "Attachment":
                    case "Identifier":
                    case "Annotation":
                    case "HumanName":
                    case "CodeableConcept":
                    case "ContactPoint":
                    case "Coding":
                    case "Money":
                    case "Address":
                    case "Timing":
                    case "Quantity":
                    case "SampledData":
                    case "Signature":
                    case "Age":
                    case "Distance":
                    case "Duration":
                    case "Count":
                    case "MoneyQuantity":
                    case "SimpleQuantity":                      // General purpose data types (minus backbone element).

                    case "Meta":
                    case "Narrative":
                        {
                            String fhirType = this.FhirTypeProfileCheck(type);
                            if (ModelInfo.FhirTypeToCsType.TryGetValue(fhirType, out Type csType) == false)
                            {
                                this.gen.ConversionError(this.GetType().Name, fcn, $"Property type {type.Code} {propertyInfo.Name} not found");
                                return;
                            }
                            WriteAccessorMultiSimple(csType.FriendlyName(), propertyInfo.Name);
                        }
                        break;

                    default:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                        break;
                }
            }

            String accessorClassName = AccPrefix(propertyName);

            {
                CodeBlockNested classBlock = this.SubClassBlock.AppendBlock();
                classBlock
                    .BlankLine()
                    .AppendRaw($"#region class {accessorClassName}")
                    .OpenSummary()
                    .AppendLine($"/// Accessor class for property {propertyName}")
                    .CloseSummary()
                    .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                    .OpenBrace()
                    ;
                subClassBlock = classBlock.AppendBlock();
                staticMethodsBlock = classBlock.AppendBlock();
                fieldsBlock = classBlock.AppendBlock();
                propertiesBlock = classBlock.AppendBlock();
                constructorBlock = classBlock.AppendBlock();
                methodsBlock = classBlock.AppendBlock();

                // complete sub class.
                classBlock
                    .CloseBrace()
                    .AppendRaw("#endregion")
                ;
            }

            staticMethodsBlock
                .WriteStaticCreate(accessorClassName, this.fhirBaseClassName)
                ;

            constructorBlock
                .WriteConstructor(accessorClassName)
                .WriteInitStart(this.fhirBaseClassName)
                ;
            ;

            ElementNode[] slices = elementNode.Slices.ToArray();
            if (slices.Length > 0)
            {
                if (elementNode.Element.Slicing == null)
                {
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Missing slicing discriminator in {elementNode.Path} when multiple slices defined");
                    return;
                }

                CreateSliceDisciminator(elementNode, constructorBlock, fieldsBlock);
                foreach (ElementNode slice in slices)
                {
                    String sliceClass = WriteSliceClass(slice, propertyName, listType);
                    WriteSliceAccessorClass(slice);
                }
            }

            WriteCommonAccessors();
            foreach (ElementDefinition.TypeRefComponent type in elementNode.Element.Type)
                WriteAccessors(type);

            constructorBlock
                .WriteInitEnd()
                ;

            CreateAccessorProperty(accessorClassName, elementNode);
        }

        /// <summary>
        /// Original max cardinality > 1 and profile max cardinality constrained to 1.
        /// </summary>
        void CreatePropertySingletonFromMultiple(ElementNode elementNode,
            PropertyInfo propertyInfo)
        {
            String fcn = "CreatePropertySingletonFromMultiple";
            String listTypeName = ListType(propertyInfo.PropertyType, out Type listType);

            void WriteAccessor(String propertyName,
                String propertyType)
            {
                String accessorClassName = AccPrefix(propertyName);
                this.SubClassBlock
                    .BlankLine()
                    .AppendRaw($"#region class {accessorClassName}")
                    .OpenSummary()
                    .AppendLine($"/// Accessor for property {propertyName}")
                    .CloseSummary()
                    .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                    .OpenBrace()

                    .WriteStaticCreate(accessorClassName, this.fhirBaseClassName)
                    .WriteConstructor(accessorClassName)
                    .WriteInit(this.fhirBaseClassName)

                    .OpenSummary()
                    .AppendLine($"/// Get value")
                    .CloseSummary()
                    .AppendCode($"public {propertyType} Get()")
                    .OpenBrace()
                    .AppendCode($"return this.Ptr.{propertyName}.FirstOrDefault();")
                    .CloseBrace()
                    .OpenSummary()
                    .AppendLine($"/// Set Value")
                    .CloseSummary()
                    .AppendCode($"public void Set({propertyType} value)")
                    .OpenBrace()
                    .AppendCode($"if (this.Ptr.{propertyName}.Count == 0)")
                    .OpenBrace()
                    .AppendCode($"this.Ptr.{propertyName}.Add(value);")
                    .CloseBrace()
                    .AppendCode($"else")
                    .OpenBrace()
                    .AppendCode($"this.Ptr.{propertyName}[0] = value;")
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    .AppendRaw("#endregion")
                    ;

                CreateAccessorProperty(accessorClassName, elementNode);
            }

            void WriteBackboneAccessor(String backboneClass,
                String propertyName,
                String propertyType)
            {
                String accessorClassName = AccPrefix(propertyName);
                this.SubClassBlock
                    .AppendRaw($"#region class {accessorClassName}")
                    .OpenSummary()
                    .AppendLine($"/// Accessor for property {propertyName}")
                    .CloseSummary()
                    .AppendCode($"public class {accessorClassName} : ItemBase<{this.fhirBaseClassName}>")
                    .OpenBrace()
                    .AppendCode($"{this.fhirBaseClassName} ptr;")
                    .BlankLine()
                    .AppendCode($"public {accessorClassName}({backboneClass} ptr) : base(ptr)")
                    .OpenBrace()
                    .CloseBrace()
                    .OpenSummary()
                    .AppendLine($"/// Get value")
                    .CloseSummary()
                    .AppendCode($"public {accessorClassName} Get()")
                    .OpenBrace()
                    .AppendCode($"{propertyType} retVal = this.Ptr.{propertyName}.FirstOrDefault();")
                    .AppendCode($"if (retVal == null) return null;")
                    .AppendCode($"return new {accessorClassName}(retVal);")
                    .CloseBrace()
                    .OpenSummary()
                    .AppendLine($"/// Set Value")
                    .CloseSummary()
                    .AppendCode($"public void Set({accessorClassName} value)")
                    .OpenBrace()
                    .AppendCode($"if (value is null)")
                    .AppendCode($"    throw new ArgumentNullException(nameof(value));")
                    .AppendCode($"if (this.Ptr.{propertyName}.Count == 0)")
                    .OpenBrace()
                    .AppendCode($"this.Ptr.{propertyName}.Add(value.Ptr);")
                    .CloseBrace()
                    .AppendCode($"else")
                    .OpenBrace()
                    .AppendCode($"this.Ptr.{propertyName}[0] = value.Ptr;")
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    .AppendRaw("#endregion")
                    ;

                CreateAccessorProperty(accessorClassName, elementNode);
            }

            if (elementNode.Element.Type.Count > 1)
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported multiple types. Using first type only.");
            ElementDefinition.TypeRefComponent type = elementNode.Element.Type[0];

            switch (type.Code)
            {
                case "BackboneElement":
                    {
                        //# Not Tested
                        String backboneClassName = this.CreateBackBoneClass(elementNode, listType);
                        WriteBackboneAccessor(backboneClassName, listTypeName, propertyInfo.Name);
                    }
                    break;

                case "Extension":
                    {
                        //# Not Tested
                        this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Extension Unsupported.");
                    }
                    break;

                case "Resource":
                    {
                        //# Not Tested
                        if (elementNode.Children.Any())
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported contained resources.");
                    }
                    break;

                case "Reference":
                    WriteAccessor(propertyInfo.Name, listTypeName);
                    break;

                case "instant":
                case "time":
                case "date":
                case "dateTime":
                case "base64Binary":
                case "decimal":
                case "boolean":
                case "url":
                case "code":
                case "string":
                case "integer":
                case "uri":
                case "canonical":
                case "markdown":
                case "id":
                case "oid":
                case "uuid":
                case "unsignedInt":
                case "positiveInt":
                // Primitive type.

                case "Ratio":
                case "Period":
                case "Range":
                case "Attachment":
                case "Identifier":
                case "Annotation":
                case "HumanName":
                case "CodeableConcept":
                case "ContactPoint":
                case "Coding":
                case "Money":
                case "Address":
                case "Timing":
                case "Quantity":
                case "SampledData":
                case "Signature":
                case "Age":
                case "Distance":
                case "Duration":
                case "Count":
                case "MoneyQuantity":
                case "SimpleQuantity":

                case "Meta":
                case "Narrative":
                    // General purpose data types (minus backbone element).
                    {
                        //# Not Tested
                        this.EmptyProfileCheck(type);

                        String pName = propertyInfo.Name;
                        if (pName.EndsWith("Element"))
                            pName = propertyInfo.Name.RemoveSuffix("Element");
                        WriteAccessor(pName, listTypeName);
                    }
                    break;

                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                    break;
            }
        }


        void CreateSliceDisciminator(ElementNode elementNode,
            CodeBlockNested constructorBlock,
            CodeBlockNested fieldsBlock)
        {
            String fcn = "CreateSliceDisciminator";

            void DefineDiscriminator(ElementDefinition.DiscriminatorComponent discriminator)
            {
                switch (discriminator.Type)
                {
                    case ElementDefinition.DiscriminatorType.Value:
                        {
                            constructorBlock
                                .AppendCode($"discriminators.Add(new SliceOnValue(\"{discriminator.Path}\"));");
                            ;
                        }
                        break;
                    default:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: discriminator.Type {discriminator.Type} currently implemented. '{elementNode.Path}'");
                        break;
                }
            }

            ElementDefinition.SlicingComponent sliceComponent = elementNode.Element.Slicing;
            if (sliceComponent.Ordered == true)
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Ordered == true not currently implemented. '{elementNode.Path}'");
            if (sliceComponent.Rules != ElementDefinition.SlicingRules.Open)
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Rules != Open not currently implemented. '{elementNode.Path}'");

            fieldsBlock
                .OpenSummary()
                .AppendLine($"/// Field to define slicing on '{elementNode.Path}'")
                ;
            if (String.IsNullOrWhiteSpace(sliceComponent.Description) == false)
                fieldsBlock.AppendLine($"/// '{sliceComponent.Description}'");
            String fieldName = $"ISliceDiscriminator_{sliceComponent.ElementId}_{elementNode.Element.SliceName}";
            fieldsBlock
                .CloseSummary()
                .AppendCode($"Slicing {fieldName};")
                ;

            constructorBlock
                .OpenBrace()
                .AppendCode($"List<ISliceDiscriminator> discriminators = new List<ISliceDiscriminator>();")
                ;

            foreach (ElementDefinition.DiscriminatorComponent discriminator in sliceComponent.Discriminator)
                DefineDiscriminator(discriminator);

            constructorBlock
                .AppendCode($"this.{fieldName} = new Slicing(discriminators.ToArray());")
                .CloseBrace()
                ;
        }

        public void CreateProperty(ElementNode elementNode)
        {
            const String fcn = "CreateProperty";
            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            String elementName = elementNode.Path.LastPathPart().Trim();
            PropertyInfo propertyInfo = this.GetProperty(elementName);

            Int32 originalMax = elementNode.Element.Base.Max.ToMax();
            Int32 profileMax = elementNode.Element.Max.ToMax();
            if (profileMax == 0)
                return;

            if ((originalMax == 1) && (profileMax == 1))
            {
                //# Tested
                if (elementNode.IsFixed == true)
                {
                    CreatePropertyFixed(elementNode, elementName, propertyInfo, true);
                    if (elementNode.Slices.Count() > 1)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unexpected multiple slices. {elementNode.Path} (Max = 1,1");
                }
                else
                {
                    CreatePropertySingleton(elementNode, propertyInfo);
                    if (elementNode.Slices.Count() > 1)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unexpected multiple slices. {elementNode.Path} (Max = 1,1");
                }
            }
            else if ((originalMax > 1) && (profileMax > 1))
            {
                //# Tested
                if (elementNode.Element.Fixed != null)
                {
                    CreatePropertyFixed(elementNode, elementName, propertyInfo, false);
                    if (elementNode.Slices.Count() > 1)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unexpected multiple slices. {elementNode.Path} (Max = >1,>1");
                }
                else
                {
                    CreatePropertyMultiple(elementNode, propertyInfo);
                }
            }
            else if ((originalMax > 1) && (profileMax == 1))
            {
                //# Tested
                if (elementNode.Element.Fixed != null)
                {
                    CreatePropertyFixed(elementNode, elementName, propertyInfo, false);
                    if (elementNode.Slices.Count() > 1)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unexpected multiple slices. {elementNode.Path} (Max = >1,1");
                }
                else
                {
                    CreatePropertySingletonFromMultiple(elementNode, propertyInfo);
                    if (elementNode.Slices.Count() > 1)
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unexpected multiple slices. {elementNode.Path} (Max = >1,1");
                }
            }
            else
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Invalid Max Values. Original {elementNode.Element.Base.Max}, Profile {elementNode.Element.Max}");
                return;
            }
        }
    }
}
