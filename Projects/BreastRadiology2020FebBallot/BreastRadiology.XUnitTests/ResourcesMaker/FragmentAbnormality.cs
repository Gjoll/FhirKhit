using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace FhirKhit.BreastRadiology.XUnitTests
{
    public partial class ResourcesMaker : ConverterBase
    {
        String FragmentAbnormality()
        {
            SDefEditor e = this.CreateFragment("BreastRadAbnormalityMammo",
                "Breast Radiology Abnormality (Mammography)",
                "Observation")
                .Description(new Markdown().Paragraph("Mammography Breast Abnormality Observation"))
                //e.SliceByUrl("hasMember",
                //    new ObservationTarget[]
                //    {
                //        new ObservationTarget(mammoBreastDensity, 1, "1"),
                //        new ObservationTarget(mammoMass, 0, "*"),
                //        new ObservationTarget(calc, 0, "*"),
                //        new ObservationTarget(archDist, 0, "1"),
                //        new ObservationTarget(assymetries, 0, "*"),
                //        new ObservationTarget(intramammaryLymphNode, 1, "1"),
                //        new ObservationTarget(skinLesions, 0, "*"),
                //        new ObservationTarget(solitaryDilatedDuct, 1, "1")
                //    });
                ;

            e.Select("value[x]").Zero();
            e.Select("specimen").Zero();
            e.Select("referenceRange").Zero();
            e.Select("interpretation").Zero();
            e.Select("note").Zero();
            // todo: Add body site info.
            //e.Select("bodySite").Zero();

            e.Find("method")
             .FixedCodeSlice("method",
                             "http://snomed.info/sct",
                             "115341008")
             .Card(1, "*")
             ;

            return e.SDef.Url;
        }
    }
}
