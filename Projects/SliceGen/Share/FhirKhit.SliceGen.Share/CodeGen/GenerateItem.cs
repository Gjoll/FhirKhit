using FhirKhit.SliceGen.CSApi;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static FhirKhit.SliceGen.Share.ProfileGenerator;

namespace FhirKhit.SliceGen.Share
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
        String name;
        String nameSpace;
        String profileType;
        Type fhirType;
        ElementNode profileElements;
        OutputLanguageType outputLanguage;
        ProfileGenerator gen;

        public GenerateItem(ProfileGenerator gen,
            String nameSpace,
            String name,
            String profileType,
            Type fhirType,
            OutputLanguageType outputLanguage,
            ElementNode profileElements)
        {
            this.gen = gen;
            this.nameSpace = nameSpace;
            this.name = name;
            this.fhirType = fhirType;
            this.outputLanguage = outputLanguage;
            this.profileElements = profileElements;
            this.profileType = profileType;
        }

        public void Process()
        {
            String fcn = "ProcessProfile";

            //IEnumerable<string> y = Source.ListArtifactNames();
            //Resource x = Source.ResolveByUri("http://hl7.org/fhir/DataElement/Identifier");
            //x = Source.FindStructureDefinitionForCoreType("identifier");

            this.gen.ConversionInfo(this.GetType().Name, fcn, $"Converting {this.name} to {this.outputLanguage}");

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
        /// Process a constraint
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        bool ProcessResourceConstraint()
        {
            const String fcn = "ProcessResourceConstraint";

            this.Code.StartNameSpace(this.nameSpace);
            this.Code.StartClass(this.name, fhirType);

            if (profileElements.Children.Count() != 1)
            {
                this.gen.ConversionError(this.GetType().Name, fcn, $"Profile head element has invalid number of children {profileElements.Children.Count()}");
                return false;
            }

            ElementNode head = profileElements.Children.First();
            foreach (ElementNode profileElement in head.Children)
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
            return true;
        }

        public String GetCode()
        {
            return this.Code.GetCode();
        }

        /// <summary>
        /// Process element that has been modified from parent element.
        /// </summary>
        /// <param name="elementPaths"></param>
        /// <param name="modifiedElement"></param>
        void CreateProperty(ElementNode profileElement)
        {
            const String fcn = "CreateProperty";
            if (profileElement.Path.EndsWith(".extension"))
            {
                this.gen.ConversionWarn(this.GetType().Name, fcn, $"TODO: handle extension {profileElement.Path}");
            }
            else
            {
                Code.CreateProperty(profileElement);
            }
        }
    }
}
