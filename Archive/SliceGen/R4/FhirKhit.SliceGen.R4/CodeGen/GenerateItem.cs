﻿using FhirKhit.SliceGen.CodeGen;
using FhirKhit.SliceGen.CSApi;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using static FhirKhit.SliceGen.CodeGen.SliceGenerator;

namespace FhirKhit.SliceGen.R4
{
    /// <summary>
    /// Generates one output item. i.e. one profile, or one backbone element, etc.
    /// </summary>
    internal class GenerateItem
    {
        /// <summary>
        /// code output item
        /// </summary>
        public ICodeFormatter Code { get; private set; }
        String className;
        String nameSpace;
        String profileType;
        Type fhirType;
        ElementDefinitionNode profileElements;
        OutputLanguageType outputLanguage;
        SliceGenerator gen;

        public GenerateItem(SliceGenerator gen,
            String nameSpace,
            String className,
            String profileType,
            Type fhirType,
            OutputLanguageType outputLanguage,
            ElementDefinitionNode profileElements)
        {
            this.gen = gen;
            this.nameSpace = nameSpace;
            this.className = className;
            this.fhirType = fhirType;
            this.outputLanguage = outputLanguage;
            this.profileElements = profileElements;
            this.profileType = profileType;
        }

        public void Process()
        {
            String fcn = nameof(Process);

            //IEnumerable<string> y = Source.ListArtifactNames();
            //Resource x = Source.ResolveByUri("http://hl7.org/fhir/DataElement/Identifier");
            //x = Source.FindStructureDefinitionForCoreType("identifier");

            this.gen.ConversionInfo(this.GetType().Name, fcn, $"Converting {this.className} to {this.outputLanguage}");

            switch (this.outputLanguage)
            {
                case OutputLanguageType.CSharp:
                    this.Code = new CSCodeFormatter(this.gen);
                    break;

                default:
                    throw new Exception($"Output language {this.outputLanguage} not found");
            }

            switch (this.profileType)
            {
                case "Extension":
                    this.ProcessExtension();
                    break;

                default:
                    this.ProcessResourceConstraint();
                    break;
            }
        }

        /// <summary>
        /// Process an extension.
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessExtension() => false;

        /// <summary>
        /// Process elements, searching for elements that are sliced.
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessElementSlices(ElementDefinitionNode node)
        {
            //const String fcn = nameof(ProcessResourceConstraint);

            // Dont create slices on extensions. Those will be handled by another tool.
            if (node.FhirItemType == typeof(Extension))
                return false;

            bool retVal = true;
            if (node.Slices.Any())
            {
                if (CreateSlice(node) == false)
                    retVal = false;
            }

            foreach (var child in node.ChildNodes)
            {
                if (ProcessElementSlices(child) == false)
                    retVal = false;
            }

            foreach (var slice in node.Slices)
            {
                if (ProcessElementSlices(slice) == false)
                    retVal = false;
            }
            return retVal;
        }

        bool CreateSlice(ElementDefinitionNode elementNode)
        {
            const String fcn = nameof(ProcessResourceConstraint);

            this.gen.ConversionInfo(this.GetType().Name, fcn, $"Processing slice on node {elementNode.Element.Path}");

            List<ElementDefinition.DiscriminatorComponent> d = elementNode.Element.Slicing?.Discriminator;
            if ((d == null) || (d.Count == 0))
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Slice of element {elementNode.Element.Path} failed. Element lacks slice discriminator");
                return false;
            }

            return this.Code.CreateSlice(elementNode);
        }

        /// <summary>
        /// Process a constraint
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessResourceConstraint()
        {
            const String fcn = nameof(ProcessResourceConstraint);

            if (this.Code.StartNameSpace(this.nameSpace) == false)
                return false;
            if (this.Code.StartClass(this.className, fhirType) == false)
                return false;

            if (profileElements.ChildNodes.Count() != 1)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Profile head element has invalid number of children {profileElements.ChildNodes.Count()}");
                return false;
            }

            bool retVal = ProcessElementSlices(profileElements.ChildNodes.First());

            if (this.Code.EndClass() == false)
                retVal = false;
            if (this.Code.EndNameSpace() == false)
                retVal = false;
            return retVal;
        }

        public String GetCode()
        {
            return this.Code.GetCode();
        }
    }
}
