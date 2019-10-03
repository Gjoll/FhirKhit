using FhirKhit.Tools;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhirKhit.Maker.Common.Resource
{
    public partial class Resource_DomainResource
    {
        /*
        <StructureDefinition xmlns="http://hl7.org/fhir">
          <url value="http://example.org/fhir/StructureDefinition/participation-agreement"/>
          <name value="Example Extension Definition"/>
          <!-- snip other metadata -->
          <kind value="complex-type"/>
          <context>
            <type value="element"/>
            <expression value="Patient"/>
          </context>
          <type value="Extension"/>
          <baseDefinition value="http://hl7.org/fhir/StructureDefinition/Extension"/>
          <derivation value="constraint"/>

          <differential>
            <element>
              <path value="Extension"/>
              <short value="Agreed agreement/policy"/>
              <definition value="A URI that identifies a participation agreement/policy
                to which the patient has agreed"/>
              <comment value="URI is a literal reference to agreement text (html).
                Systems SHALL conform to the policies as indicated.
                For further information, see the partnership agreement..."/>
              <mustSupport value="true"/>
              <isModifier value="false"/>
            </element>
            <element>
              <path value="Extension.url"/>
              <fixedUri value="http://example.org/fhir/StructureDefinition/participation-agreement"/>
            </element>
            <element>
              <path value="Extension.valueUri"/>
              <short value="The URI value"/>
              <min value="1"/>
              <max value="*"/>
              <type>
                 <code value="uri"/>
              </type>
              <mustSupport value="true"/>
            </element>
          </differential>
        </StructureDefinition>
        */
        /*
        <StructureDefinition xmlns="http://hl7.org/fhir">
          <id value="patient-profile"/>
          <!-- snip other metadata, narrative -->
          <differential>

            <!-- first, the patient root element
              - can be copy/paste from the base patient profile -->
            <element>
              <path value="Patient"/>
              <!-- snip definition -->
            </element>

            <!-- now, the general definition for extensions
              - can be copied/pasted from the base patient profile,
              with changes for slicing  -->
            <element>
              <path value="Patient.extension"/>
              <!-- we're going to slice the extension element, and
                one of the extensions is one we have defined -->
              <slicing>
                <!-- extension is always sliced on url -->
                <discriminator>
                  <type value="value"/>
                  <path value="url"/>
                </discriminator>
                <!-- we don't care what the order of any extensions is -->
                <ordered value="false"/>
                <!-- Other extensions are allowed in addition to this one -->
                <rules value="open"/>
              </slicing>
              <!-- snip definition -->
            </element>

            <!-- now, the slice that contains our extension -->
            <element>
              <path value="Patient.extension"/>
              <sliceName value="agreement"/>
              <!-- clone information from the extension definition.
                duplicative, but this duplication makes it simpler overall -->
              <short value="Agreed agreement/policy"/>
              <definition value="A URI that identifies a participation agreement/policy
              to which the patient has agreed"/>
              <!--  min has to be 1, since the extension itself has min = 1 -->
              <min value="1"/>
              <max value="*"/>
              <type>
                <!-- obviously it has to be an extension -->
                <code value="Extension"/>
                <!-- and here is the link to the extension definition:
                  this extension has to conform to the rules laid down in its definition -->
                <profile value="http://example.org/phr/documents/fhir/StructureDefinition/participation-agreement"/>
              </type>
              <isModifier value="false"/>
            </element>

          <!-- snip the rest of the profile -->

          </differential>
        </StructureDefinition>
        */

        /// <summary>
        /// Configure the extension element to have the corret slicing discriminator. This does not
        /// add the slice, just the discriminator.
        /// </summary>
        void ConfigureExtensionSlice()
        {
            ElementDefinition extDef = this.Element_Extension.CreateConstraint();
            // I assume that if slicing exists, it was added by the code below.
            // If someone else adds slicing differently than below there will be a problem....
            if (extDef.Slicing == null)
            {
                extDef.Slicing = new ElementDefinition.SlicingComponent
                {
                    Ordered = false,
                    Rules = ElementDefinition.SlicingRules.Open
                };
                extDef.Slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
                {
                    Type = ElementDefinition.DiscriminatorType.Value,
                    Path = "url"
                });
            }
        }

        /// <summary>
        /// Add the indicated slice to the extension.
        /// </summary>
        void AddExtensionSlice(String sliceUrl,
            String sliceName,
            String shortText,
            Markdown definition,
            Int32 max)
        {
            ElementDefinition extSlice = this.Element_Extension.AppendElement();
            extSlice.ElementId += $":{sliceName}";
            extSlice.SliceName = sliceName;
            extSlice.Short = shortText;
            extSlice.Definition = definition;
            extSlice.Min = 1;
            extSlice.Max = (max == -1) ? "*" : max.ToString();
            extSlice.IsModifier = false;
            extSlice.Type.Add(new ElementDefinition.TypeRefComponent
            {
                Code = "Extension",
                Profile = new String[] {sliceUrl}
            });
        }

        public void SimpleExtension(String name,
            String shortText,
            String definition,
            Int32 max)
        {
            String sliceUrl = $"{this.Uri.BaseUriPart()}/{name}-extension";
            ConfigureExtensionSlice();
            AddExtensionSlice(sliceUrl, name, shortText, new Markdown(definition), max);
        }
    }
}
