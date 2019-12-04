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

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        String MammoSkinThickening
        {
            get
            {
                if (mammoSkinThickening == null)
                    CreateMammoSkinThickening();
                return mammoSkinThickening;
            }
        }
        String mammoSkinThickening = null;

        // Todo:
        // - Add choice for focal or diffuse (see definition)?
        // - Add body location?
        // - Add size measurement?
        // - cardinality 0..1 or 0..*?
        void CreateMammoSkinThickening()
        {
            SDefEditor e = this.CreateEditor("BreastRadMammoSkinThickening",
                "Breast Radiology Skin Thickening Observation",
                new string[] { "Skin", "Thickening" },
                ObservationUrl,
                out mammoSkinThickening)
                .Description(new Markdown()
                    .Paragraph("Skin Thickening Observation")
                    .BiradHeader()
                    .BlockQuote("Skin thickening may be focal or diffuse, and is defined as being greater than 2 mm in thickness. This ")
                    .BlockQuote("finding is of particular concern if it represents a change from previous mammography examinations. ").BlockQuote("However, unilateral skin thickening is an expected finding after radiation therapy.")
                    .BiradFooter()
                )
                .AddFragRef(this.BreastBodyLocationRequiredFragment)
                .AddFragRef(this.ObservationNoValueFragment)
                ;

            e.Select("value[x]").Zero();
        }
    }
}
