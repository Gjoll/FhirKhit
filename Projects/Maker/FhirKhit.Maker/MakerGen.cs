using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification.Source;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace FhirKhit.Maker
{
    public class MakerGen : ConverterBase, IDisposable
    {
        String GeneratedPath => Path.Combine(this.outputDir, "Generated");
        String outputDir;

        FhirStructureDefinitions sDefs;

        public MakerGen(String outputDir)
        {
            this.outputDir = outputDir;

            String specPath = Path.GetFullPath("specification.zip");
            String sDefsPath = Path.Combine(this.outputDir, "StructureDefinitions.json");
            sDefs = new FhirStructureDefinitions(sDefsPath, specPath);

            DirHelper.CreateDirPath(this.GeneratedPath);
                DirHelper.CleanDir(this.GeneratedPath);
        }


        public Int32 CreateBundle()
        {
            try
            {
                sDefs.StoreFhirElements();
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            return this.Errors.Any() ? -1 : 0;
        }

        void LoadFhirElements()
        {
            const String fcn = "LoadFhirElements";

            this.ConversionInfo(this.GetType().Name, fcn, "Loading Fhir structure definitions");
            foreach (StructureDefinition sDef in this.sDefs.FhirSDefs.GetResources())
            {
                //        SDefInfo sDefInfo = new SDefInfo
                //        {
                //            SDef = sDef
                //        };

                //        switch (sDef.Url)
                //        {
                //            case "http://hl7.org/fhir/StructureDefinition/Element":
                //                sDefInfo.TFlag = SDefInfo.TypeFlag.Group;
                //                break;

                //            case "http://hl7.org/fhir/StructureDefinition/Resource":
                //                sDefInfo.TFlag = SDefInfo.TypeFlag.Entry;
                //                break;
                //            default:
                //                sDefInfo.TFlag = SDefInfo.TypeFlag.Unknown;
                //                break;
                //        }

                //        this.items.Add(sDef.Url, sDefInfo);
            }
        }

        public Int32 GenerateBaseClasses(String outputDir)
        {
            const String fcn = "GenerateBaseClasses";

            try
            {
                this.ConversionInfo(this.GetType().Name, fcn, "Starting generation of Fhir MAKER classes");
                this.outputDir = outputDir;
                if (Directory.Exists(this.GeneratedPath) == false)
                    Directory.CreateDirectory(this.GeneratedPath);
                else
                    DirHelper.CleanDir(this.GeneratedPath);

                this.sDefs.StoreFhirElements();

                this.LoadFhirElements();
                //this.ProcessFhirElements();
            }
            catch (ConvertErrorException err)
            {
                this.ConversionError(err.FileName, err.MethodName, err.Message);
            }
            catch (Exception err)
            {
                this.ConversionError(this.GetType().Name, "Execute", err.Message);
            }

            this.ConversionInfo(this.GetType().Name, fcn, "Completed generation of CIMPL classes");
            return this.Errors.Any() ? -1 : 0;
        }

        public void Dispose()
        {
        }

    }
}
