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

namespace FhirKhit.Maker.Common
{
    public class MakerGen : ConverterBase, IDisposable
    {
        Bundle fhirSDefsBundle;
        ZipSource source;

        String GeneratedPath => Path.Combine(this.outputDir, "Generated");
        String outputDir;
        String FhirSDefsPath => Path.Combine(this.outputDir, "StructureDefinitions.json");

        Bundle FhirSDefsBundle
        {
            get
            {
                if (this.fhirSDefsBundle == null)
                {
                    if (File.Exists(this.FhirSDefsPath) == false)
                        return null;

                    FhirJsonParser parser = new FhirJsonParser();
                    this.fhirSDefsBundle = parser.Parse<Bundle>(File.ReadAllText(this.FhirSDefsPath));
                }
                return this.fhirSDefsBundle;
            }
        }

        public MakerGen(String outputDir)
        {
            String specPath = Path.GetFullPath("specification.zip");
            if (File.Exists(specPath) == false)
                throw new Exception($"Missing {specPath}");
            this.outputDir = outputDir;
            this.source = new ZipSource(specPath);
            DirHelper.CreateDirPath(this.GeneratedPath);
                DirHelper.CleanDir(this.GeneratedPath);
        }

        /// <summary>
        /// To save time, store all structure definitions in a fhir bundle file. This need only be run when we get a new 
        /// FHIR version.
        /// </summary>
        void StoreFhirElements()
        {
            // const String fcn = "StoreFhirElements";

            this.fhirSDefsBundle = new Bundle();
            foreach (string uri in this.source.ListResourceUris())
            {
                StructureDefinition sDef = this.source.ResolveByUri(uri) as StructureDefinition;
                if (sDef != null)
                {
                    // This is to get rid of the http://....//de-... entries.
                    if (sDef.Snapshot.Element[0].Path.Split('.').Length == 1)
                        this.fhirSDefsBundle.AddResourceEntry(sDef, sDef.Url);
                }
            }
            this.fhirSDefsBundle.SaveJson(this.FhirSDefsPath);
        }

        public Int32 CreateBundle()
        {
            try
            {
                this.StoreFhirElements();
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
            foreach (StructureDefinition sDef in this.FhirSDefsBundle.GetResources())
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

                if (File.Exists(this.FhirSDefsPath) == false)
                    this.StoreFhirElements();

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
