using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LeadSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        static string PrettyXml(string xml)
        {
            var stringBuilder = new StringBuilder(); 
            var element = XElement.Parse(xml); 
            var settings = new XmlWriterSettings();
  
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;  
            settings.NewLineOnAttributes = true; 

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();}

        private void tbImportPDF_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                tbImportPDF.Text = openFileDialog1.FileName;
            }
        } 
    }
}
