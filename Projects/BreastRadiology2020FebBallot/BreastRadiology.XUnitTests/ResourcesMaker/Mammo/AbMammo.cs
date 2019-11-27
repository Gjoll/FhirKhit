﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String AbMammo(String mammoBreastDensity,
            String mammoMass,
            String calc,
            String archDist,
            String assymetries,
            String intramammaryLymphNode,
            String skinLesions,
            String solitaryDilatedDuct)
        {
            SDefEditor e = this.CreateObservationEditor("BreastRadAbnormalityMammo",
                    "Breast Radiology Abnormality (Mammography)",
                    new string[] {"Mammo", "Abnormality"})
                .Description(new Markdown()
                            .Paragraph("Mammography Breast Abnormality Observation")
                            .BiradHeader()
                            .MarkedDown("A \"MASS\" is three dimensional and occupies space. It is seen on two different mammographic pro-")
                            .MarkedDown("jections. It has completely or partially convex-outward borders and (when radiodense) appears")
                            .MarkedDown("denser in the center than at the periphery. If a potential mass is seen only on a single projection, it")
                            .MarkedDown("should be called an \"ASYMMETRY\" until its 3-dimensionality is confirmed (See Section D on Asym-")
                            .MarkedDown("metries and also the Guidance chapter). (Insert links/page #s)")
                            .BiradFooter()
                            )
                .AddFragRef(this.abnormalityFragmentUrl)
                ;
            ////$ todo. Incorrect method!!!
            //e.Find("method")
            // .FixedCodeSlice("method", "http://snomed.info/sct", "115341008")
            // .Card(1, "*")
            // ;

            {
                ProfileTarget[] targets = new ProfileTarget[]
                {
                    new ProfileTarget(mammoBreastDensity, 1, "1"),
                    new ProfileTarget(mammoMass, 0, "*"),
                    new ProfileTarget(calc, 0, "*"),
                    new ProfileTarget(archDist, 0, "1"),
                    new ProfileTarget(assymetries, 0, "*"),
                    new ProfileTarget(intramammaryLymphNode, 1, "1"),
                    new ProfileTarget(skinLesions, 0, "*"),
                    new ProfileTarget(solitaryDilatedDuct, 1, "1")
                };
                e.Find("hasMember").SliceByUrl(targets);
                e.MapNode.AddProfileTargets(targets);
            }
            return e.SDef.Url;
        }
    }
}
