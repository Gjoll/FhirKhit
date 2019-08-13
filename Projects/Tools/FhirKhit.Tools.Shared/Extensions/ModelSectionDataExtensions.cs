using FhirKhit.Tools;
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
    public static class ModelDefinitionExtensions
    {
        static String className = "ModelDefinitionExtensions";

    public static ModelSectionData SetPublisher(this ModelSectionData model,
            ModelLabToModelDefConvertor converter,
            ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetPublisher";

            String publisher = converter.ProjectData.NameOfPublishingEntity;
            if (String.IsNullOrWhiteSpace(publisher))
            {
                converter.ConversionError(className, fcn, $"Model {converter.ProjectData.LongProjectName} is missing NameOfPublishingEntity field");
                return model;
            }

            model.StructureDefinition.Publisher = publisher;
            return model;
        }

        public static ModelSectionData SetStatus(this ModelSectionData model,
            ModelLabToModelDefConvertor converter,
            ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetStatus";
            String status = converter.OutputCache.ProjectData.PublicationStatus;

            if (String.IsNullOrWhiteSpace(status))
            {
                converter.ConversionError(className, fcn, $"Project {project.Title} is missing status field");
                return model;
            }

            try
            {
                model.StructureDefinition.Status = status.ToPublicationStatus();
            }
            catch
            {
                converter.ConversionError(className, fcn, $"Project {project.Title} has invalid status field '{status}'");
                model.StructureDefinition.Status = "Unknown".ToPublicationStatus();
            }

            return model;
        }

        public static ModelSectionData SetTitle(this ModelSectionData model, ModelLabToModelDefConvertor converter,
            ModelLabProject project)
        {
            const String fcn = "ModelDefinitionExtensions.SetTitle";

            String title = model.ConfigData.Title;
            if (title == null)
            {
                converter.ConversionWarn(className, fcn, $"Section {model.ConfigData.Id} is missing Title field");
                return model;
            }
#if FHIR_R3 || FHIR_R4
            model.StructureDefinition.Title = title;
#endif
            return model;
        }

        public static String ToUrl(this ModelSectionData model, ModelLabToModelDefConvertor converter, String baseUrl)
        {
            //const String fcn = "ModelDefinitionExtensions.ToUrl";
            if (baseUrl == null)
                throw new Exception("base url can not be null");
            return $"{baseUrl}/StructureDefinition/{model.ConfigData.Id.ToMachineName()}";
        }

        public static ModelSectionData SetUrl(this ModelSectionData model, ModelLabToModelDefConvertor converter, String baseUrl)
        {
            model.StructureDefinition.Url = model.ToUrl(converter, baseUrl);
            return model;
        }
    }
}
