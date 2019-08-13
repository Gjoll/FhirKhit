using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#elif FHIR_R2
namespace FhirKhit.Tools.R2
#endif
{
    public static class ValueSetExtensions
    {
        static String className = "ValueSetExtensions";

        public static ValueSetData SetPublisher(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ValueSetExtensions.SetPublisher";

            String publisher = converter.ProjectData.NameOfPublishingEntity;
            if (String.IsNullOrWhiteSpace(publisher))
            {
                converter.ConversionError(className, fcn, $"Model {converter.ProjectData.LongProjectName} is missing NameOfPublishingEntity field");
                return valueSetData;
            }
            valueSetData.ValueSet.Publisher = publisher;
            return valueSetData;
        }

        public static ValueSetData SetStatus(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetStatus";

            String status = converter.OutputCache.ProjectData.PublicationStatus;
            if (String.IsNullOrWhiteSpace(status))
            {
                converter.ConversionError(className, "ModelDefinitionExtensions.SetStatus", $"Project {project.Title} is missing status field");
                return valueSetData;
            }

            try
            {
                valueSetData.ValueSet.Status = status.ToPublicationStatus();
            }
            catch
            {
                converter.ConversionError(className, fcn, $"Project {project.Title} has invalid status field '{status}'");
                valueSetData.ValueSet.Status = "Unknown".ToPublicationStatus();
            }

            return valueSetData;
        }

        public static ValueSetData SetDescription(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ValueSetExtensions.SetDescription";

            String description = valueSetData.ConfigData.Description;
            if (String.IsNullOrWhiteSpace(description))
            {
                converter.ConversionWarn(className, fcn, $"SelectElement {project.Title}.{valueSetData.ConfigData.Id} is missing Description field");
                description = valueSetData.ConfigData.Title;
            }

            if (String.IsNullOrWhiteSpace(description))
                description = "??????";

#if FHIR_R4 || FHIR_R3
            valueSetData.ValueSet.Description = new Markdown(description);
#elif FHIR_R2
            valueSetData.ValueSet.Description = description;
#endif
            //valueSetData.ValueSet.Text = new Narrative
            //{
            //    Status = Narrative.NarrativeStatus.Generated,
            //    Div = ConverterBase.ToDiv(description)
            //};
            return valueSetData;
        }

        public static ValueSetData SetId(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetId";

            String id = valueSetData.ConfigData.Id.ToMachineName();
            if (String.IsNullOrWhiteSpace(id))
            {
                converter.ConversionError(className, fcn, $"SelectElement {project.Title}.{valueSetData.ConfigData.Title} is missing Id field");
                return valueSetData;
            }

            valueSetData.ValueSet.Id = id;
            valueSetData.ValueSet.Name = id;
            return valueSetData;
        }

        public static ValueSetData SetTitle(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetTitle";

            String title = valueSetData.ConfigData.Title;
            if (String.IsNullOrWhiteSpace(title))
            {
                converter.ConversionError(className, fcn, $"SelectElement {project.Title}.{valueSetData.ConfigData.Id} is missing Title field");
                return valueSetData;
            }

#if FHIR_R4 || FHIR_R3
            valueSetData.ValueSet.Title = title;
#elif FHIR_R2
#endif
            return valueSetData;
        }

        public static ValueSetData SetUrl(this ValueSetData valueSetData, ModelLabToModelDefConvertor converter, ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetUrl";

            String url = valueSetData.Url;
            if (url == null)
            {
                String baseUrl = project.BaseUrl;
                if (baseUrl == null)
                {
                    converter.ConversionError(className, fcn, $"Project {project.Title} is missing ModelProperty.BaseUrl field");
                    return valueSetData;
                }
                url = $"{baseUrl}/ValueSet/{valueSetData.ConfigData.Id.ToMachineName()}";
            }
            valueSetData.ValueSet.Url = url;
            return valueSetData;
        }

        public static ValueSet.ConceptReferenceComponent FindByCode(this IEnumerable<ValueSet.ConceptReferenceComponent> concepts, String codeStr)
        {
            foreach (ValueSet.ConceptReferenceComponent concept in concepts)
            {
                if (concept.Code == codeStr)
                    return concept;
            }
            return null;
        }
    }
}
