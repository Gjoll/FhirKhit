using FhirKhit.Tools;
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

namespace FhirKhit.Tools
{
    public interface ISection
    {
        ConfigData ConfigData { get; set; }
    }

    /// <summary>
    /// Convert model lab files to modeldef files.
    /// 
    /// Todo:
    /// </summary>
    public abstract partial class ModelLabVisitor<Section> : ConverterBase
        where Section : ISection
    {
        protected Dictionary<Guid, Section> sections = new Dictionary<Guid, Section>();
        protected List<Section> stage2SectionsList = new List<Section>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public ModelLabVisitor()
        {
        }

        public IEnumerable<Section> GetAllSections() => sections.Values;

        public void Visit(IEnumerable<Section> models)
        {
            foreach (Section model in models)
                Stage1(model);

            if (this.Errors.Any() == true)
                return;

            while (stage2SectionsList.Count > 0)
            {
                Section model = stage2SectionsList[0];
                stage2SectionsList.RemoveAt(0);
                Stage2(model);
            }
        }

        protected bool TryFindSection(Guid guid, out Section section)
        {
            return this.sections.TryGetValue(guid, out section);
        }

        protected void Stage1(Section model)
        {
            const String fcn = "Stage1";

            if (this.Visit_Stage1Start(model) == false)
                return;

            switch (model.ConfigData.Section_Purpose)
            {
                case ConfigData.PurposeEnums.ComposeTarget:
                    if (this.Visit_Stage1_ComposeTarget(model))
                    {
                        sections.Add(model.ConfigData.Guid, model);
                        stage2SectionsList.Add(model);
                    }
                    break;

                case ConfigData.PurposeEnums.Profile:
                    if (this.Visit_Stage1_Profile(model))
                    {
                        sections.Add(model.ConfigData.Guid, model);
                        stage2SectionsList.Add(model);
                    }
                    break;

                default:
                    Log.Info(fcn, $"Ignoring section {model.ConfigData.Id}");
                    break;
            }
            if (this.Visit_Stage1Complete(model) == false)
                return;
        }


        void Stage2(Section model)
        {
            const String fcn = "Stage2";

            switch (model.ConfigData.Type)
            {
                case ConfigData.Type_ModelSection:
                    this.Stage2ModelSection(model);
                    break;

                default:
                    throw new Exception($"{fcn}. Unexpected type {model.ConfigData.Type} found");
            }
        }

        void Stage2ModelSection(Section model)
        {
            const String fcn = "Stage2ModelSection";

            if (this.Visit_Stage2_ModelSection(model) == false)
                return;

            foreach (ConfigData child in model.ConfigData.Children)
            {
                switch (child.Type)
                {
                    case ConfigData.Type_BooleanElement:
                        this.Stage2BooleanElement(model, child);
                        break;

                    case ConfigData.Type_CompositionReference:
                        this.Stage2CompositionReference(model, child);
                        break;

                    case ConfigData.Type_DateTimeElement:
                        this.Stage2DateTimeElement(model, child);
                        break;

                    case ConfigData.Type_ModelPropertyElement: // new
                        break;

                    case ConfigData.Type_NumericElement:
                        this.Stage2NumericElement(model, child);
                        break;

                    case ConfigData.Type_SelectElement:
                        this.Stage2SelectElement(model, child);
                        break;

                    case ConfigData.Type_StringElement:
                        this.Stage2StringElement(model, child);
                        break;

                    case ConfigData.Type_StructureElement:  // delete
                        break;

                    default:
                        throw new Exception($"{fcn}. Unexpected type {child.Type} found");
                }
            }
        }

        void Stage2NumericElement(Section model,
            ConfigData item)
        {
            const String fcn = "Stage2NumericElement";
            if (Visit_Stage2_NumericProperty(model, item) == false)
                return;

            foreach (ConfigData child in item.Children)
            {
                switch (child.Type)
                {
                    case ConfigData.Type_NumericElement:
                        this.Stage2NumericElement(model, child);
                        break;

                    case ConfigData.Type_StringElement:
                        this.Stage2StringElement(model, child);
                        break;

                    case ConfigData.Type_DateTimeElement:
                        this.Stage2DateTimeElement(model, child);
                        break;

                    case ConfigData.Type_BooleanElement:
                        this.Stage2BooleanElement(model, child);
                        break;

                    default:
                        throw new Exception($"{fcn}. Unexpected type {child.Type} found");
                }
            }
        }

        void Stage2StringElement(Section model,
            ConfigData item)
        {
            const String fcn = "Stage2StringElement";
            if (Visit_Stage2_StringProperty(model, item) == false)
                return;
            foreach (ConfigData child in item.Children)
            {
                switch (child.Type)
                {
                    case ConfigData.Type_NumericElement:
                        this.Stage2NumericElement(model, child);
                        break;

                    case ConfigData.Type_StringElement:
                        this.Stage2StringElement(model, child);
                        break;

                    case ConfigData.Type_DateTimeElement:
                        this.Stage2DateTimeElement(model, child);
                        break;

                    case ConfigData.Type_BooleanElement:
                        this.Stage2BooleanElement(model, child);
                        break;

                    default:
                        throw new Exception($"{fcn}. Unexpected type {child.Type} found");
                }
            }
        }

        void Stage2CompositionReference(Section model,
            ConfigData item)
        {
            if (Visit_Stage2_CompositionReference(model, item) == false)
                return;
        }

        void Stage2BooleanElement(Section model,
            ConfigData item)
        {
            const String fcn = "Stage2BooleanElement";

            if (Visit_Stage2_BooleanProperty(model, item) == false)
                return;
            foreach (ConfigData child in item.Children)
            {
                switch (child.Type)
                {
                    case ConfigData.Type_NumericElement:
                        this.Stage2NumericElement(model, child);
                        break;

                    case ConfigData.Type_StringElement:
                        this.Stage2StringElement(model, child);
                        break;

                    case ConfigData.Type_DateTimeElement:
                        this.Stage2DateTimeElement(model, child);
                        break;

                    case ConfigData.Type_BooleanElement:
                        this.Stage2BooleanElement(model, child);
                        break;

                    default:
                        throw new Exception($"{fcn}. Unexpected type {child.Type} found");
                }
            }
        }

        void Stage2DateTimeElement(Section model,
            ConfigData item)
        {
            const String fcn = "Stage2DateTimeElement";
            if (Visit_Stage2_DateTimeProperty(model, item) == false)
                return;
            foreach (ConfigData child in item.Children)
            {
                switch (child.Type)
                {
                    case ConfigData.Type_NumericElement:
                        this.Stage2NumericElement(model, child);
                        break;

                    case ConfigData.Type_StringElement:
                        this.Stage2StringElement(model, child);
                        break;

                    case ConfigData.Type_DateTimeElement:
                        this.Stage2DateTimeElement(model, child);
                        break;

                    case ConfigData.Type_BooleanElement:
                        this.Stage2BooleanElement(model, child);
                        break;

                    default:
                        throw new Exception($"{fcn}. Unexpected type {child.Type} found");
                }
            }
        }

        void Stage2SelectElement(Section model,
            ConfigData item)
        {
            if (Visit_Stage2_SelectElement(model, item) == false)
                return;
        }
    }
}
