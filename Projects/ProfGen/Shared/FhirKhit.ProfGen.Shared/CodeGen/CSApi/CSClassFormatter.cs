﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FhirKhit.ProfGen.Shared;
using FhirKhit.ProfGen.Shared.CodeGen.CSApi.Extensions;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support.Model;
using System.Diagnostics;

namespace FhirKhit.ProfGen.CSApi
{
    public class CSClassFormatter
    {
        const String AccPrefix = "Accessor__";

        public CodeBlockNested ClassBlock;
        CodeBlockNested containingBlock;
        CodeBlockNested constructorBlock;
        CodeBlockNested subClassBlock;
        CodeBlockNested propertiesBlock;
        //CodeBlockNested methodsBlock;
        Type fhirResourceType;
        ProfileGenerator gen;
        CSCodeFormatter codeFormatter;
        String fhirBaseClassName;

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
            CodeBlockNested containingBlock)
        {
            this.gen = gen;
            this.codeFormatter = codeFormatter;
            this.containingBlock = containingBlock;
            this.ClassBlock = this.containingBlock.AppendBlock();
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
            this.fhirResourceType = fhirType;
            this.PopulateElementDictionary(fhirType);

            this.fhirBaseClassName = fhirType.FriendlyName();
            className = className.FormatClassName();

            this.ClassBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Class to implement '{className}'")
                .AppendCode($"/// </summary>")
                .AppendCode($"public class {className} :")
                .AppendCode($"    ProfileBase<{fhirBaseClassName}>")
                .OpenBrace()
                ;

            this.subClassBlock = this.ClassBlock.AppendBlock();
            this.subClassBlock.AppendRaw("#region Sub Class Definitions");

            this.propertiesBlock = this.ClassBlock.AppendBlock();
            this.propertiesBlock.AppendRaw("#region Property Definitions");

            this.constructorBlock = this.ClassBlock.AppendBlock();

            this.constructorBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Constructor")
                .AppendCode($"/// </summary>")
                .AppendCode($"public {className}({this.fhirBaseClassName} ptr) : base(ptr)")
                .OpenBrace()
                ;
        }

        public void EndClass()
        {
            this.subClassBlock.AppendRaw("#endregion");
            this.propertiesBlock.AppendRaw("#endregion");

            this.constructorBlock
                .CloseBrace()
                ;

            this.ClassBlock
                .CloseBrace()
                ;
        }

        String ListType(Type list, out Type listType)
        {
            if (list.GenericTypeArguments.Length != 1)
                throw new Exception($"Expected a single generic argument to list property");
            listType = list.GenericTypeArguments[0];
            return listType.FriendlyName();
        }

        public void ModifiedElement(ElementDefinition elementNode)
        {
            throw new NotImplementedException();
        }

        void WritePassThroughProperty(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
            PropertyInfo propertyInfo)
        {
            String typeFriendlyName = propertyInfo.PropertyType.FriendlyName();

            WritePassThroughProperty(elementNode, elementSlice, propertyInfo.Name, typeFriendlyName);
        }

        void WritePassThroughProperty(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
            String propertyName,
            String propertyType)
        {
            String accessorClassName = $"{AccPrefix}{propertyName.ToMachineName()}";
            this.subClassBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Accessor for property {propertyName}")
                .AppendCode($"/// </summary>")
                .AppendCode($"public class {accessorClassName}")
                .OpenBrace()
                .AppendCode($"{this.fhirBaseClassName} ptr;")
                .AppendCode("")
                .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr)")
                .OpenBrace()
                .AppendCode($"this.ptr = ptr;")
                .CloseBrace()
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Get value")
                .AppendCode($"/// </summary>")
                .AppendCode($"public {propertyType} Get() {{ return this.ptr.{propertyName}; }}")
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Set Value")
                .AppendCode($"/// </summary>")
                .AppendCode($"public void Set({propertyType} value) {{ this.ptr.{propertyName} = value; }}")
                .CloseBrace()
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
            if (type.Profile.Count() > 0)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Profile not implemented [{type.Code}]");
                return;
            }
            if (type.TargetProfile.Count() > 0)
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
            if (type.TargetProfile.Count() > 0)
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

        void CreatePassThroughProperty(ElementTreeNode elementNode,
        ElementTreeSlice elementSlice,
        PropertyInfo propertyInfo)
        {
            String fcn = "CreatePassThroughProperty";

            if (elementSlice.Types.Count > 1)
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported multiple types. Using first type only.");
            ElementDefinition.TypeRefComponent type = elementSlice.Types[0];

            switch (type.Code)
            {
                case "BackboneElement":
                    {
                        //# Not Tested
                        this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: BackboneElement Unsupported.");
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
                        if (elementNode.ChildItems().Any())
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported contained resources.");
                    }
                    break;

                case "Reference":
                    {
                        //# Tested
                        WritePassThroughProperty(elementNode, elementSlice, propertyInfo);
                    }
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
                        String fhirType = this.FhirTypeProfileCheck(type);
                        WritePassThroughProperty(elementNode, elementSlice, propertyInfo.Name, fhirType);
                        //if (propertyInfo.Name.EndsWith("Element"))
                        //{
                        //    //# Tested
                        //    String name = propertyInfo.Name.RemoveSuffix("Element");
                        //    PropertyInfo p2 = this.fhirResourceType.GetProperty(name);
                        //    if (p2 == null)
                        //    {
                        //        this.gen.ConversionWarn(this.GetType().Name, fcn, $"Property {name} not found");
                        //        return;
                        //    }
                        //    WritePassThroughProperty(elementNode, elementSlice, p2);
                        //}
                    }
                    break;

                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                    break;
            }
        }

        /// <summary>
        /// Create a wrapper for sub type. Sub type can be a subtype of current resoruce, or a globally defined sub type.
        /// </summary>
        String DeclareSubtype(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
            Type propertyType,
            ElementDefinition.TypeRefComponent type)
        {
            String fcn = "DeclareSubtype";

            if (this.gen.TryGetSubClass(propertyType, out String profileClassName) == true)
                return profileClassName;

            String typeName = $"__{propertyType.FriendlyName()}";

            this.gen.ConversionWarn(this.GetType().Name, fcn, $"Singleton type not implemented [{type.Code}]");
            // If class is declared in this class, then add it a a sub calss to profile class, otherwise create new global class for it.
            if (propertyType.DeclaringType == null)
            {
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported DeclareSubtype in declaring type.");
            }
            else
            {
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported DeclareSubtype not in declaring type.");
            }

            return String.Empty;
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
                .AppendLine($"{propertyType} temp = new {propertyType}({value});")
                ;
            if (singleton)
                block.AppendLine($"{varName} = temp;");
            else
            {
                block.AppendLine($"{varName}.Clear();");
                block.AppendLine($"{varName}.Add(temp);");
            }
            block.CloseBrace();
            return true;
        }

        String GetBindingValuesetName(ElementTreeSlice elementSlice)
        {
#if FHIR_R4
            return elementSlice.Binding.ValueSet.ToValueSetEnumName();
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
        bool FhirConstruct(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
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
                        if (UsesEnum(elementNode, elementSlice))
                        {
                            //# Tested
                            String enumName = GetBindingValuesetName(elementSlice);
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
                            block.AppendLine($"{varName} = new {propertyType}({valueName});");
                        else
                        {
                            block.AppendLine($"{varName}.Clear();");
                            block.AppendLine($"{varName}.Add(new {propertyType}({valueName}));");
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
                            .AppendLine($"var temp = new {propertyType}({v.System.ToCode()}, {v.Value.ToCode()});")
                            ;
                        if (singleton)
                            block.AppendLine($"{varName} = temp;");
                        else
                        {
                            block
                                .AppendLine($"{varName}.Clear();")
                                .AppendLine($"{varName}.Add(temp);")
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
                            .AppendLine($"CodeableConcept temp = new {propertyType}();")
                            ;
                        if (v.Text != null)
                            block.AppendLine($"temp.Text = {v.Text.ToCode()};");
                        foreach (Coding c in v.Coding)
                            block.AppendLine($"temp.Coding.Add({c.ToCode()}));");

                        if (singleton)
                            block.AppendLine($"{varName} = temp;");
                        else
                        {
                            block.AppendLine($"{varName}.Clear();");
                            block.AppendLine($"{varName}.Add(temp);");
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
        void CreateFixedProperty(ElementTreeNode elementNode,
            String elementName,
            ElementTreeSlice elementSlice,
            PropertyInfo propertyInfo,
            bool singleton)
        {
            if (singleton == false)
                this.constructorBlock.AppendLine($"this.ptr.{propertyInfo.Name}.Clear();");
            if (this.FhirConstruct(elementNode, elementSlice, this.constructorBlock, elementSlice.Fixed, $"this.ptr.{ propertyInfo.Name}", singleton, out string elementType) == false)
                return;

            String elementPName = elementName.FormatPropertyName();

            String accessorClassName = $"{AccPrefix}{elementPName}";
            this.subClassBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Accessor for property {elementPName}")
                .AppendCode($"/// </summary>")
                .AppendCode($"public class {accessorClassName}")
                .OpenBrace()
                .AppendCode($"{this.fhirBaseClassName} ptr;")
                .AppendCode("")
                .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr)")
                .OpenBrace()
                .AppendCode($"this.ptr = ptr;")
                .CloseBrace()
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Property for accessing fixed property {elementNode.Path}.")
                .AppendCode($"/// </summary>")
                .AppendCode($"public bool Get(out {elementType} value)")
                .OpenBrace()
                ;
            switch (singleton)
            {
                case true: this.subClassBlock.AppendCode($"value = ({elementType}) this.ptr.{propertyInfo.Name};"); break;
                case false: this.subClassBlock.AppendCode($"value = this.ptr.{propertyInfo.Name}.First();"); break;
            }

            this.subClassBlock
                .AppendCode($"return value != null;")
                .CloseBrace()
                .CloseBrace()
                ;

            CreateAccessorProperty(accessorClassName, elementNode);
        }

        void CreateAccessorProperty(String accessorClassName,
            ElementTreeNode elementNode)
        {
            String elementName = elementNode.Path.LastPathPart().Trim();
            String elementPName = elementName.FormatPropertyName();
            // Create property that instantiates the single tone class created above.
            String fieldName = $"__{elementPName}";

            this.propertiesBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Property for accessing {elementNode.Path}.")
                .AppendCode($"/// Lazy constructed.")
                .AppendCode($"/// </summary>")
                .AppendCode($"public {accessorClassName} {elementPName}")
                .OpenBrace()
                .AppendCode($"get")
                .OpenBrace()
                .AppendCode($"if (this.{fieldName} == null)")
                .AppendCode($"    this.{fieldName} = new {accessorClassName}(this.ptr);")
                .AppendCode($"return this.{fieldName};")
                .CloseBrace()
                .CloseBrace()
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Backing field for property {elementPName}.")
                .AppendCode($"/// </summary>")
                .AppendCode($"{accessorClassName} {fieldName};")
                ;
        }

        bool UsesEnum(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice)
        {
            if (
                (elementSlice.Binding != null) &&
                (elementSlice.Binding.Strength == BindingStrength.Required)
                )
                return true;
            return false;
        }

        /// <summary>
        /// Create a singleton property.
        /// </summary>
        void CreateSingletonProperty(ElementTreeNode elementNode,
            String elementName,
            ElementTreeSlice elementSlice,
            PropertyInfo propertyInfo)
        {
            const String fcn = "CreateSingletonProperty";

            void WriteAccessor(String pType)
            {
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get '{pType}' value")
                    .AppendCode($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public bool Get(out {pType} value)")
                    .OpenBrace()
                    .AppendCode($"value = this.ptr.{propertyInfo.Name} as {pType};")
                    .AppendCode($"return value != null;")
                    .CloseBrace()
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Set '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Set({pType} value) => this.ptr.{propertyInfo.Name} = value;")
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
                            this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: BackboneElement Unsupported.");
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
                            if (UsesEnum(elementNode, elementSlice))
                            {
                                // the c# only creates a enum if the value set is required, so we cant link against it if it is only preferred.
                                // TODO: Create our own valueset enums?

                                String enumName = GetBindingValuesetName(elementSlice);
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

            String propertyName = propertyInfo.Name;

            String accessorClassName = $"{AccPrefix}{propertyName.ToMachineName()}";
            this.subClassBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Accessor for property {propertyName}")
                .AppendCode($"/// </summary>")
                .AppendCode($"public class {accessorClassName}")
                .OpenBrace()
                .AppendCode($"{this.fhirBaseClassName} ptr;")
                .AppendCode("")
                .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr)")
                .OpenBrace()
                .AppendCode($"this.ptr = ptr;")
                .CloseBrace()
                ;


            foreach (ElementDefinition.TypeRefComponent type in elementSlice.Types)
                WriteAccessors(type);

            // complete sub class.
            this.subClassBlock
                .CloseBrace()
                ;

            CreateAccessorProperty(accessorClassName, elementNode);
        }

        String CreateBackBoneClass(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
            Type propertyType,
            ElementDefinition.TypeRefComponent type)
        {
            const String fcn = "CreateBackBoneClass";

            String WriteBackboneClass(CSCodeFormatter codeFormatter, String propertyName, CodeBlockNested classBlock)
            {
                if (this.codeFormatter.TryGetBackboneElement(propertyType, out String accessorClassName) == true)
                    return accessorClassName;

                String fullClassName = propertyType.FriendlyName();
                String shortClassName = fullClassName.LastPathPart();
                accessorClassName = $"{AccPrefix}{shortClassName}";
                this.codeFormatter.StartClass(accessorClassName, propertyType);

                foreach (ElementTreeNode child in elementSlice.ChildNodes)
                    this.codeFormatter.CreateProperty(child);

                this.codeFormatter.EndClass();

                codeFormatter.AddBackboneElement(propertyType, accessorClassName);
                return accessorClassName;
            }

            if (propertyType.DeclaringType == null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"#Todo: BackboneElement definition not in declaring type not implemented.");
                return null;
            }
            if (propertyType.DeclaringType != fhirResourceType)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"#Todo: BackboneElement definition not in declaring type not implemented.");
                return null;
            }

            {
                CodeBlockNested classBlock = this.subClassBlock.AppendBlock();
                return WriteBackboneClass(this.codeFormatter, propertyType.Name, classBlock);
            }
        }

        /// <summary>
        /// Create properties for elements whose original and profile cardinality is greater than 1.
        /// </summary>
        void CreateMultipleProperty(ElementTreeNode elementNode,
            String elementName,
            ElementTreeSlice elementSlice,
            PropertyInfo propertyInfo)
        {
            const String fcn = "CreateMultipleProperty";

            String propertyName = propertyInfo.Name;
            String listTypeName = ListType(propertyInfo.PropertyType, out Type listType);

            void WriteBackboneAccessor(String backboneType,
                String pType,
                String pName)
            {
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Count of items")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public Int32 Count => this.ptr.{pName}.Count;")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get '{pType}' value")
                    .AppendCode($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public bool Get(Int32 index, out {backboneType} value)")
                    .OpenBrace()
                    .AppendCode($"value = null;")
                    .AppendCode($"{pType} temp = this.ptr.{pName}[index];")
                    .AppendCode($"if (temp == null) return false;")
                    .AppendCode($"value = new {backboneType}(temp);")
                    .AppendCode($"return true;")
                    .CloseBrace()

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Set '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Set(Int32 index, {backboneType} value) => this.ptr.{pName}[index] = value.Ptr;")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Add '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Add({backboneType} value) => this.ptr.{pName}.Add(value.Ptr);")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// AddRange '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void AddRange(IEnumerable<{backboneType}> values)")
                    .OpenBrace()
                    .AppendCode($"foreach ({backboneType} value in values)")
                    .OpenBrace()
                    .AppendCode($"this.Add(value);")
                    .CloseBrace()
                    .CloseBrace()
                    ;
            }

            void WriteAccessor(String pType,
                String pName)
            {
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Count of items")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public Int32 Count => this.ptr.{pName}.Count;")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get '{pType}' value")
                    .AppendCode($"/// return true if successfull, false if value is null or con not be converted to '{pType}'")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public bool Get(Int32 index, out {pType} value)")
                    .OpenBrace()
                    .AppendCode($"value = this.ptr.{pName}[index] as {pType};")
                    .AppendCode($"return value != null;")
                    .CloseBrace()

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Set '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Set(Int32 index, {pType} value) => this.ptr.{pName}[index] = value;")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Add '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Add({pType} value) => this.ptr.{pName}.Add(value);")

                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// AddRange '{pType}' Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void AddRange(IEnumerable<{pType}> values) => this.ptr.{pName}.AddRange(values);")
                    ;
            }

            /// <summary>
            /// Original and profile elements have cardinality = 1.
            /// </summary>
            void WriteAccessors(ElementDefinition.TypeRefComponent type)
            {
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Remove item at indicated index")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void RemoveAt(Int32 index) => this.ptr.{propertyInfo.Name}.RemoveAt(index);")
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get list of all items")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public IEnumerable<{listTypeName}> Get() => this.ptr.{propertyInfo.Name};")
                    ;

                switch (type.Code)
                {
                    case "BackboneElement":
                        {
                            //# Tested
                            String backboneClassName = this.CreateBackBoneClass(elementNode, elementSlice, listType, type);
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
                            if (UsesEnum(elementNode, elementSlice))
                            {
                                // the c# only creates a enum if the value set is required, so we cant link against it if it is only preferred.
                                // TODO: Create our own valueset enums?

                                String enumName = this.GetBindingValuesetName(elementSlice);
                                if (enumName != null)
                                    WriteAccessor($"Code<{enumName}>", propertyInfo.Name);
                            }
                            else
                            {
                                WriteAccessor($"Code", propertyInfo.Name);
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
                            WriteAccessor(csType.FriendlyName(), propertyInfo.Name);
                        }
                        break;

                    default:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                        break;
                }
            }

            String accessorClassName = $"{AccPrefix}{propertyName.ToMachineName()}";
            this.subClassBlock
                .AppendCode($"")
                .AppendCode($"/// <summary>")
                .AppendCode($"/// Accessor for property {propertyName}")
                .AppendCode($"/// </summary>")
                .AppendCode($"public class {accessorClassName}")
                .OpenBrace()
                .AppendCode($"{this.fhirBaseClassName} ptr;")
                .AppendCode("")
                .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr)")
                .OpenBrace()
                .AppendCode($"this.ptr = ptr;")
                .CloseBrace()
                ;


            foreach (ElementDefinition.TypeRefComponent type in elementSlice.Types)
                WriteAccessors(type);

            // complete sub class.
            this.subClassBlock
                .CloseBrace()
                ;

            CreateAccessorProperty(accessorClassName, elementNode);
        }

        /// <summary>
        /// Original max cardinality > 1 and profile max cardinality constrained to 1.
        /// </summary>
        void CreateSingletonFromMultipleProperty(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice,
            PropertyInfo propertyInfo)
        {
            String fcn = "CreateSingletonFromMultipleProperty";
            String listTypeName = ListType(propertyInfo.PropertyType, out Type listType);

            void WriteAccessor(String propertyName,
                String propertyType)
            {
                String accessorClassName = $"{AccPrefix}{propertyName.ToMachineName()}";
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Accessor for property {propertyName}")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public class {accessorClassName}")
                    .OpenBrace()
                    .AppendCode($"{this.fhirBaseClassName} ptr;")
                    .AppendCode("")
                    .AppendCode($"public {accessorClassName}({this.fhirBaseClassName} ptr)")
                    .OpenBrace()
                    .AppendCode($"this.ptr = ptr;")
                    .CloseBrace()
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public {propertyType} Get()")
                    .OpenBrace()
                    .AppendCode($"return this.ptr.{propertyName}.FirstOrDefault();")
                    .CloseBrace()
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Set Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Set({propertyType} value)")
                    .OpenBrace()
                    .AppendCode($"if (this.ptr.{propertyName}.Count == 0)")
                    .OpenBrace()
                    .AppendCode($"this.ptr.{propertyName}.Add(value);")
                    .CloseBrace()
                    .AppendCode($"else")
                    .OpenBrace()
                    .AppendCode($"this.ptr.{propertyName}[0] = value;")
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    ;

                CreateAccessorProperty(accessorClassName, elementNode);
            }

            void WriteBackboneAccessor(String backboneClass,
                String propertyName,
                String propertyType)
            {
                String accessorClassName = $"{AccPrefix}{propertyName.ToMachineName()}";
                this.subClassBlock
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Accessor for property {propertyName}")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public class {accessorClassName}")
                    .OpenBrace()
                    .AppendCode($"{this.fhirBaseClassName} ptr;")
                    .AppendCode("")
                    .AppendCode($"public {accessorClassName}({backboneClass} ptr)")
                    .OpenBrace()
                    .AppendCode($"this.ptr = ptr;")
                    .CloseBrace()
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Get value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public {accessorClassName} Get()")
                    .OpenBrace()
                    .AppendCode($"{propertyType} retVal = this.ptr.{propertyName}.FirstOrDefault();")
                    .AppendCode($"if (retVal == null) return null;")
                    .AppendCode($"return new {accessorClassName}(retVal);")
                    .CloseBrace()
                    .AppendCode($"")
                    .AppendCode($"/// <summary>")
                    .AppendCode($"/// Set Value")
                    .AppendCode($"/// </summary>")
                    .AppendCode($"public void Set({accessorClassName} value)")
                    .OpenBrace()
                    .AppendCode($"if (this.ptr.{propertyName}.Count == 0)")
                    .OpenBrace()
                    .AppendCode($"this.ptr.{propertyName}.Add(value.Ptr);")
                    .CloseBrace()
                    .AppendCode($"else")
                    .OpenBrace()
                    .AppendCode($"this.ptr.{propertyName}[0] = value.Ptr;")
                    .CloseBrace()
                    .CloseBrace()
                    .CloseBrace()
                    ;

                CreateAccessorProperty(accessorClassName, elementNode);
            }

            if (elementSlice.Types.Count > 1)
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#Todo: Unsupported multiple types. Using first type only.");
            ElementDefinition.TypeRefComponent type = elementSlice.Types[0];

            switch (type.Code)
            {
                case "BackboneElement":
                    {
                        //# Not Tested
                        String backboneClassName = this.CreateBackBoneClass(elementNode, elementSlice, listType, type);
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
                        if (elementNode.ChildItems().Any())
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

                        WriteAccessor(propertyInfo.Name, listTypeName);

                        //if (propertyInfo.Name.EndsWith("Element"))
                        //{
                        //    //# Not Tested
                        //    String name = propertyInfo.Name.RemoveSuffix("Element");
                        //    PropertyInfo p2 = this.fhirResourceType.GetProperty(name);
                        //    if (p2 == null)
                        //    {
                        //        this.gen.ConversionWarn(this.GetType().Name, fcn, $"Property {name} not found");
                        //        return;
                        //    }
                        //    WriteAccessor(elementNode, p2);
                        //}
                    }
                    break;

                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"Unsupported type '{type.Code}'");
                    break;
            }
        }

        public void CreateProperty(ElementTreeNode elementNode)
        {
            String fcn = "CreateProperty";

            if (elementNode.Slices.Count() > 1)
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"#TODO: Handle multiple slices");
            this.CreateProperty(elementNode, elementNode.Slices.First());

        }

        void CreateProperty(ElementTreeNode elementNode,
            ElementTreeSlice elementSlice)
        {
            String fcn = "CreateProperty";

            String elementName = elementNode.Path.LastPathPart().Trim();
            PropertyInfo propertyInfo = this.GetProperty(elementName);

            Int32 originalMax = elementSlice.BaseInfo.Max;
            Int32 profileMax = elementSlice.Max;
            if (profileMax == 0)
                return;

            if ((originalMax == 1) && (profileMax == 1))
            {
                //# Tested
                if (elementSlice.Fixed != null)
                    CreateFixedProperty(elementNode, elementName, elementSlice, propertyInfo, true);
                else
                    CreateSingletonProperty(elementNode, elementName, elementSlice, propertyInfo);
            }
            else if ((originalMax > 1) && (profileMax > 1))
            {
                //# Tested
                if (elementSlice.Fixed != null)
                    CreateFixedProperty(elementNode, elementName, elementSlice, propertyInfo, false);
                else
                    CreateMultipleProperty(elementNode, elementName, elementSlice, propertyInfo);
            }
            else if ((originalMax > 1) && (profileMax == 1))
            {
                //# Tested
                if (elementSlice.Fixed != null)
                    CreateFixedProperty(elementNode, elementName, elementSlice, propertyInfo, false);
                else
                    CreateSingletonFromMultipleProperty(elementNode, elementSlice, propertyInfo);
            }
            else
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Invalid Max Values. Original {elementSlice.BaseInfo.Max}, Profile {elementSlice.Max}");
                return;
            }
        }
    }
}
