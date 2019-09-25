using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FhirKhit.ElementDefinitionViewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        String filePath = openFileDialog.FileName;
                        String extension = Path.GetExtension(filePath);
                        StructureDefinition resource;
                        String fhirText = File.ReadAllText(filePath);
                        switch (extension.ToUpper())
                        {
                            case ".XML":
                                {
                                    FhirXmlParser parser = new FhirXmlParser();
                                    resource = parser.Parse<StructureDefinition>(fhirText);
                                }
                                break;

                            case ".JSON":
                                {
                                    FhirJsonParser parser = new FhirJsonParser();
                                    resource = parser.Parse<StructureDefinition>(fhirText);
                                }
                                break;

                            default:
                                throw new Exception($"Invalid extension {extension}");
                        }
                        LoadStructureDef(resource);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void LoadElementDefinition(TreeNode parent, ElementDefinition element)
        {
            TreeNodeElementNode ed = new TreeNodeElementNode(element);
            parent.Nodes.Add(ed);
        }

        void LoadElementDefinition(TreeNode parent, IEnumerable<ElementDefinition> elements)
        {
            foreach (ElementDefinition element in elements)
                LoadElementDefinition(parent, element);
        }

        void LoadStructureDef(StructureDefinition sDef)
        {
            TreeNode snapshotNode = this.tvElements.Nodes.Add("Snapshot view");
            LoadElementDefinition(snapshotNode, sDef.Snapshot.Element);
            TreeNode differentialNode = this.tvElements.Nodes.Add("Differential view");
            LoadElementDefinition(differentialNode, sDef.Differential.Element);
        }
    }
}
