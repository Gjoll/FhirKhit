using FhirKhit.SliceGen.CodeGen;
using FhirKhit.SliceGen.R4;
using FhirKhit.SliceGen.SharedLib;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FhirKhit.SliceGen.CSApi
{
    /// <summary>
    /// Created slice class and accessor.
    /// Called only from CSCodeGen.CreateSlice().
    /// </summary>
    public class CSSliceCreator
    {
        String className;
        ElementNode elementNode;
        CodeBlockNested methodsBlock;
        CodeBlockNested subClassBlock;

        /// <summary>
        /// Type of the fhir resource class that the profile is derived from (the resource it profiles)
        /// </summary>
        Type fhirBaseClassType;

        CodeBlockNested sliceClassFields;
        CodeBlockNested sliceClassMethods;
        CodeBlockNested sliceStaticConstructor;
        CodeBlockNested sliceStaticFields;
        ElementDefinition.DiscriminatorComponent[] discriminators = null;
        bool retVal = true;
        String accessorType = String.Empty;
        String baseTypeName;
        String baseItemTypeName;
        CSCodeFormatter csCode;
        SliceGenerator gen => csCode.Gen;

        public CSSliceCreator(String className,
            CSCodeFormatter csCode,
            CodeBlockNested subClassBlock,
            CodeBlockNested methodsBlock,
            ElementNode elementNode,
            Type fhirBaseClassType)
        {
            if (subClassBlock is null)
                throw new ArgumentNullException(nameof(subClassBlock));
            if (methodsBlock is null)
                throw new ArgumentNullException(nameof(methodsBlock));
            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            this.csCode = csCode;
            if (elementNode is null)
                throw new ArgumentNullException(nameof(elementNode));

            this.className = className;
            this.subClassBlock = subClassBlock.AppendBlock();
            this.methodsBlock = methodsBlock.AppendBlock();
            this.elementNode = elementNode;
            this.fhirBaseClassType = fhirBaseClassType;
        }

        bool DefineSliceOnValueDiscriminator(Int32 index,
            CodeBlockNested sliceDiscriminators,
            ElementNode sliceNode,
            String varName,
            ElementDefinition.DiscriminatorComponent discriminator,
            String valueFilterMethod,
            String leafType)
        {
            const String fcn = nameof(DefineSliceOnValueDiscriminator);

            var selectedNodes = sliceNode.Select(discriminator.Path).ToArray();
            var fixedNodes = selectedNodes.FixedValues().ToArray();
            Element fixedValue = fixedNodes.SingleOrDefault();
            if (fixedValue == null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node lacks fixed element {discriminator.Path}");
                return false;
            }

            String sliceName = sliceNode.Element.SliceName;

            CodeBlockNested valueMethodBlock = sliceClassMethods.AppendBlock();

            valueFilterMethod = CSMisc.ValueFilterName(CSMisc.MakePath(sliceNode.SlicePath(), discriminator.Path));
            // Note: We are defining method here, after we know the return value type.
            valueMethodBlock
                .BlankLine()
                .SummaryOpen()
                .AppendCode($"/// Return all elements for discriminator # {index+1}'")
                .SummaryLines(discriminator.ToFormatedJson())
                .SummaryClose()
                ;

            {
                GenerateFhirPathSearch g = new GenerateFhirPathSearch(this.gen);
                if (g.Generate(valueMethodBlock, "static", valueFilterMethod, elementNode, discriminator.Path, out Type leaf) == false)
                    return false;
                leafType = leaf.FriendlyName();
            }


            String tempVarName = $"sliceOnValueDiscriminator";
            sliceDiscriminators
                .OpenBrace()
                .AppendLine($"/// Define discriminator'")
                .AppendLines("/// ", discriminator.ToFormatedJson().ToLines())
                .AppendCode($"var {tempVarName} = new SliceOnValueDiscriminator<{baseItemTypeName}, {leafType}>()")
                .OpenBrace()
                .AppendCode($"Path = \"{discriminator.Path}\",")
                .AppendCode($"ValueFilter = {valueFilterMethod}")
                .CloseBrace(";")
                ;

            ElementFixCode.Construct(sliceDiscriminators, fixedValue, $"{tempVarName}.Pattern", out String propertyType);

            sliceDiscriminators
                .AppendCode($"{varName} = {tempVarName};")
                .CloseBrace("")
                ;

            return true;
        }

        bool DefineDiscriminator(Int32 index,
            CodeBlockNested sliceDiscriminators,
            ElementNode sliceNode,
            String varName,
            ElementDefinition.DiscriminatorComponent discriminator)
        {
            const String fcn = nameof(DefineDiscriminator);

            switch (discriminator.Type)
            {
                case ElementDefinition.DiscriminatorType.Value:
                    if (DefineSliceOnValueDiscriminator(index, sliceDiscriminators, sliceNode, varName, discriminator, "valueFilterMethod", "leafType") == false)
                        return false;
                    return true;

                default:
                    this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: discriminator.Type {discriminator.Type} currently implemented. '{elementNode.FullPath()}'");
                    return false;
            }
        }

        void CreateSliceAccessor(ElementNode sliceNode, String sliceClassName, String sliceInterfaceName)
        {
            String sliceName = sliceNode.Element.SliceName.ToMachineName();
            String propertyPath = sliceNode.PropertyName;

            String sliceBaseClassName;
            switch (SliceAccessorType(sliceNode))
            {
                case SliceAccessorTypes.Error:
                    sliceBaseClassName = $"??";
                    break;

                case SliceAccessorTypes.Single:
                    sliceBaseClassName = $"ISliceAccessorSingle<{accessorType}>";
                    break;

                case SliceAccessorTypes.Multiple:
                    sliceBaseClassName = $"ISliceAccessorMultiple<{accessorType}>";
                    break;

                default:
                    throw new NotImplementedException("Unknown SliceAccessorTypes value");
            }

            this.methodsBlock
                .BlankLine()
                .SummaryOpen()
                .Summary($"Extension method to return slice {sliceName} on {elementNode.Name}")
                .SummaryClose()
                .Example(
                    $"{this.fhirBaseClassType.FriendlyName()} resource = new {this.fhirBaseClassType.FriendlyName()}();",
                    $"{this.className}.{sliceInterfaceName} sliceAccessor = resource.{propertyPath}.{sliceName}();"
                    )
                .AppendCode($"public static {sliceInterfaceName} {sliceName}(this {baseTypeName} item)")
                .OpenBrace()
                .AppendCode($"{sliceClassName} retVal = new {sliceClassName}(item);")
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        SliceAccessorTypes SliceAccessorType(ElementNode sliceNode)
        {
            const String fcn = nameof(SliceAccessorType);

            String baseType = sliceNode.FhirType.FriendlyName();

            if (sliceNode.IsListType)
            {
                switch (sliceNode.Element.Max.ToMax())
                {
                    case 0:
                        this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{sliceNode.FullPath()}' has max of 0. Not sure what I am supposed to do!");
                        return SliceAccessorTypes.Error;

                    case 1:
                        return SliceAccessorTypes.Single;

                    default:
                        return SliceAccessorTypes.Multiple;
                }
            }
            else
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{sliceNode.FullPath()}' unknown base type {baseType}");
                return SliceAccessorTypes.Error;
            }
        }

        void CreateConstructor(String className, String fieldName)
        {
            sliceClassMethods
                .BlankLine()
                .SummaryOpen()
                .Summary($"{className} constructor")
                .SummaryClose()
                .AppendCode($"public {className}({elementNode.FhirType.FriendlyName()} items)")
                .OpenBrace()
                .AppendCode($"this.Items = items;")
                .AppendCode($"this.Slicing = {fieldName};")
                .CloseBrace()
                ;
        }

        void CreateSliceAccessorClass(ElementNode sliceNode,
            out String sliceClassName,
            out String sliceInterfaceName)
        {
            const String fcn = nameof(CreateSliceAccessorClass);

            String sliceName = sliceNode.Element.SliceName.ToMachineName();
            sliceClassName = $"{sliceName}Impl";
            sliceInterfaceName = $"I{sliceName}";
            String sliceBaseClassName;
            String sliceBaseInterfaceName;
            String baseType = elementNode.FhirType.FriendlyName();

            // Debug.Assert(sliceClassName != "BreastradAbnormalityDensityImpl");

            switch (SliceAccessorType(sliceNode))
            {
                case SliceAccessorTypes.Error:
                    sliceBaseClassName = "??";
                    sliceBaseInterfaceName = "??";
                    break;

                case SliceAccessorTypes.Single:
                    sliceBaseClassName = $"SliceListAccessorSingle<{accessorType}>";
                    sliceBaseInterfaceName = $"ISliceAccessorSingle<{accessorType}>";
                    break;

                case SliceAccessorTypes.Multiple:
                    sliceBaseClassName = $"SliceListAccessorMultiple<{accessorType}>";
                    sliceBaseInterfaceName = $"ISliceAccessorMultiple<{accessorType}>";
                    break;

                default:
                    throw new NotImplementedException("Unknown SliceAccessorTypes value");
            }

            String elementJson = sliceNode.Element.ToFormatedJson();
            this.subClassBlock
                .BlankLine()
                .SummaryOpen()
                .Summary($"public interface that implements the functionality of slice {sliceClassName}")
                .SummaryClose()
                .AppendCode($"public interface {sliceInterfaceName} : {sliceBaseInterfaceName}")
                .OpenBrace()
                .CloseBrace()
                .BlankLine()
                .SummaryOpen()
                .Summary($"private class that implements the functionality of slice {sliceClassName}")
                .Summary("")
                .Summary(elementJson.ToLines())
                .SummaryClose()
                .AppendCode($"class {sliceClassName} : {sliceBaseClassName}, {sliceInterfaceName}")
                .OpenBrace()
                .DefineBlock(out this.sliceStaticFields)
                .DefineBlock(out CodeBlockNested staticConstructorHeader)
                .DefineBlock(out this.sliceClassFields)
                .DefineBlock(out this.sliceClassMethods)
                .CloseBrace()
                ;

            staticConstructorHeader
                .SummaryOpen()
                .Summary("Static constructor")
                .SummaryClose()
                .AppendLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Performance\", \"CA1810:Initialize reference type static fields inline\")]")
                .AppendCode($"static {sliceClassName}()")
                .OpenBrace()
                .DefineBlock(out this.sliceStaticConstructor)
                .CloseBrace()
                ;

            if (sliceName == null)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Slice node '{elementNode.FullPath()}' lacks slice name");
                retVal = false;
            }
            else
            {
                const String sliceFieldName = "slicing";

                CreateConstructor(sliceClassName, sliceFieldName);

                this.sliceStaticFields
                    .BlankLine()
                    .SummaryOpen()
                    .Summary($"slicing discriminator for {elementNode.FullPath()} slice {sliceName}")
                    .SummaryClose()
                    .AppendCode($"static Slicing<{baseItemTypeName}> {sliceFieldName};")
                    ;

                this.sliceStaticConstructor
                    .BlankLine()
                    ;

                this.sliceStaticConstructor
                    .AppendLine("// Instantiate slicing discriminator")
                    .OpenBrace()
                    .AppendCode($"ISliceDiscriminator<{baseItemTypeName}>[] discriminators = ")
                    .AppendCode($"    new ISliceDiscriminator<{baseItemTypeName}>[{discriminators.Length}];")
                    ;

                for (Int32 i = 0; i < discriminators.Length; i++)
                {
                    if (DefineDiscriminator(i, this.sliceStaticConstructor, sliceNode, $"discriminators[{i}]", discriminators[i]) == false)
                        retVal = false;
                }

                this.sliceStaticConstructor
                    .AppendCode($"{sliceFieldName} = new Slicing<{baseItemTypeName}>")
                    .OpenBrace()
                    .AppendCode($"Discriminators = discriminators")
                    .CloseBrace(";")
                    .CloseBrace()
                    ;

            }

            // Recursively create code to set values that are fixed in object.
            // If a child object needs to be fixed, make sure that parent objects are created
            // as well.
            // i.e. if a.b.c = fix(...)
            // than we need to create a and a.b as well as setting a.b.c.
            void SetFixedValues(ElementNode setNode,
                String propertyPath)
            {
                Int32 varNum = 0;
                foreach (ElementNode setNodeChild in setNode.ChildNodes)
                {
                    String childPropertyPath = $"{propertyPath}.{setNodeChild.PropertyName}";

                    String childItemTypeName = setNodeChild.FhirItemType.FriendlyName();
                    if (setNodeChild.IsFixed)
                    {
                        if (setNodeChild.IsListType)
                        {
                            String varName = $"var{varNum}";
                            varNum += 1;
                            ElementFixCode.Construct(sliceClassMethods, setNodeChild.Element.Fixed, $"{varName}", out String propertyType);
                            sliceClassMethods.AppendCode($"{childPropertyPath}.Add({varName});");
                        }
                        else
                        {
                            ElementFixCode.Construct(sliceClassMethods, setNodeChild.Element.Fixed, childPropertyPath, out String propertyType);
                        }
                    }
                    else if (setNodeChild.HasFixedChild)
                    {
                        String varName = $"var{varNum}";
                        varNum += 1;
                        sliceClassMethods.AppendCode($"{childItemTypeName} {varName} = new {childItemTypeName}();");
                        if (setNodeChild.IsListType)
                            sliceClassMethods.AppendCode($"{childPropertyPath}.Add({varName});");
                        else
                            sliceClassMethods.AppendCode($"{childPropertyPath} = {varName};");
                        SetFixedValues(setNodeChild, varName);
                    }
                    else if (setNodeChild.HasFixedSlice)
                    {
                        String varName = $"var{varNum}";
                        varNum += 1;
                        sliceClassMethods.AppendCode($"// {childItemTypeName} {varName} = xxyyz;");
                        //methods.AppendCode($"{childItemTypeName} {varName} = new {childItemTypeName}();");
                        //if (setNodeChild.IsListType)
                        //    methods.AppendCode($"{childPropertyPath}.Add({varName});");
                        //else
                        //    methods.AppendCode($"{childPropertyPath} = {varName};");
                        //SetFixedValues(setNodeChild, varName);
                    }
                }
            }
            sliceClassMethods
                .BlankLine()
                .SummaryOpen()
                .Summary($"Create and initialize a new item")
                .SummaryClose()
                .AppendCode($"protected override {accessorType} Create()")
                .OpenBrace()
                .AppendCode($"{accessorType} retVal = new {accessorType}();")
                ;
            SetFixedValues(sliceNode, "retVal");
            sliceClassMethods
                .AppendCode($"return retVal;")
                .CloseBrace()
                ;
        }

        /// <summary>
        /// Create slices on indicated node.
        /// </summary>
        /// <param name="elementNode">Element node containing discriminator</param>
        /// <returns></returns>
        public bool CreateSlice()
        {
            const String fcn = nameof(CreateSlice);

            baseTypeName = elementNode.FhirType.FriendlyName();
            baseItemTypeName = elementNode.FhirItemType.FriendlyName();

            ElementDefinition.SlicingComponent sliceComponent = elementNode.Element.Slicing;
            if (sliceComponent.Ordered == true)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Ordered == true not currently implemented. '{elementNode.FullPath()}'");
                return false;
            }

            if (sliceComponent.Rules != ElementDefinition.SlicingRules.Open)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"TODO: Slicing.Rules != Open not currently implemented. '{elementNode.FullPath()}'");
                return false;
            }

            discriminators = sliceComponent.Discriminator.ToArray();
            accessorType = elementNode.FhirItemType.FriendlyName();
            foreach (ElementNode sliceNode in elementNode.Slices)
            {
                CreateSliceAccessorClass(sliceNode, out String sliceClassName, out String sliceInterfaceName);
                CreateSliceAccessor(sliceNode, sliceClassName, sliceInterfaceName);
            }

            return retVal;
        }
    }
}
