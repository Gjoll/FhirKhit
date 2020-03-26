using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#if FHIR_R4
namespace FhirKhit.Tools.R4
#elif FHIR_R3
namespace FhirKhit.Tools.R3
#endif
{
    public class FhirValidator : ConverterProcess
    {
        public bool FailOnWarnings { get; set; } = true;
        public bool CheckIfResourceFlag { get; set; } = false;

        public String ValidatorArgs { get; set; }
        public String ValidationPath { get; set; }


        public FhirValidator(String validationPath = null)
        {
            if (validationPath == null)
            {
                String localDir = Assembly.GetEntryAssembly().Location;
                localDir = Path.GetDirectoryName(localDir);
                localDir = Path.GetFullPath(localDir);
                validationPath = Path.Combine(localDir, "validation.xml");
            }
            this.ValidationPath = validationPath;
        }

        public bool ValidateDir(String baseDir, String fileFilter, String version)
        {
            bool retVal = true;

            String[] files = Directory.GetFiles(baseDir, fileFilter);

            if (this.CheckIfResourceFlag == true)
            {
                List<String> temp = new List<string>();
                foreach (String file in files)
                {
                    try
                    {
                        JObject jObj = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(file));
                        if (jObj["resourceType"] != null)
                            temp.Add(file);
                    }
                    catch
                    {

                    }
                }
                files = temp.ToArray();
            }

            if (files.Length > 0)
                if (this.Validate(version, files) == false)
                    retVal = false;

            foreach (String subDir in Directory.GetDirectories(baseDir))
            {
                if (this.ValidateDir(subDir, fileFilter, version) == false)
                    retVal = false;
            }

            return retVal;
        }


        public bool Validate(String version, params String[] resourcePaths)
        {
            if (resourcePaths is null)
                throw new ArgumentNullException(nameof(resourcePaths));

            String executingDir = Assembly.GetExecutingAssembly().Location;
            executingDir = Path.GetDirectoryName(executingDir);
            executingDir = Path.GetFullPath(executingDir);
            String jarPath = Path.Combine(executingDir, "org.hl7.fhir.validator.jar");
            StringBuilder args = new StringBuilder();
            args.Append($"-jar  \"{jarPath}\" {this.ValidatorArgs}");
            foreach (String resourcePath in resourcePaths)
                args.Append($"\"{Path.GetFullPath(resourcePath)}\" ");
            args.Append($"-output \"{this.ValidationPath}\" -version {version}");
            base.Execute(executingDir, "java", args.ToString());
            return this.ProcessResults(resourcePaths, this.ValidationPath);
        }

        protected Boolean ProcessResults(String[] resourcePaths, String validationPath)
        {
            if (resourcePaths is null)
                throw new ArgumentNullException(nameof(resourcePaths));

            FhirXmlParser parser = new FhirXmlParser();
            bool retVal = true;
            if (resourcePaths.Length == 1)
            {
                OperationOutcome results = parser.Parse<OperationOutcome>(File.ReadAllText(validationPath));
                String resourceName = Path.GetFileName(resourcePaths[0]);
                this.ProcessOutcome(results, resourceName, this.FailOnWarnings, ref retVal);
            }
            else
            {
                Bundle resultsBundle = parser.Parse<Bundle>(File.ReadAllText(validationPath));
                foreach (Bundle.EntryComponent item in resultsBundle.Entry)
                {
                    OperationOutcome results = item.Resource as OperationOutcome;
                    Extension e = results.GetExtension("http://hl7.org/fhir/StructureDefinition/operationoutcome-file");
                    String resourceName = Path.GetFileName(((FhirString)e.Value).Value);
                    this.ProcessOutcome(results, resourceName, this.FailOnWarnings, ref retVal);
                }
            }
            return retVal;
        }

        void ProcessOutcome(OperationOutcome results,
            String resourceName,
            bool failOnWarnings,
            ref bool retVal)
        {
            const String fcn = nameof(ProcessOutcome);
            foreach (OperationOutcome.IssueComponent issue in results.Issue)
            {
                switch (issue.Severity)
                {
                    case OperationOutcome.IssueSeverity.Error:
                    case OperationOutcome.IssueSeverity.Fatal:
                        this.ConversionError(this.GetType().Name, fcn, $"{resourceName}: {issue.Details.Text}");
                        retVal = false;
                        break;

                    case OperationOutcome.IssueSeverity.Warning:
                        this.ConversionWarn(this.GetType().Name, fcn, $"{resourceName}: {issue.Details.Text}");
                        if (failOnWarnings)
                            retVal = false;
                        break;

                    case OperationOutcome.IssueSeverity.Information:
                        this.ConversionInfo(this.GetType().Name, fcn, $"{resourceName}: {issue.Details.Text}");
                        break;

                    default:
                        throw new NotImplementedException($"Unimplemented IssueSeverity {issue.Severity}");
                }
            }
        }
    }
}
