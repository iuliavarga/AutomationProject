using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class TextBoxData
    {
        private XElement dataNode;
        public TextBoxData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FullName = GetValue("fullName");
            UserEmail = GetValue("userEmail");
            CurrentAddress = GetValue("currentAddress");
            PermanentAddress = GetValue("permanentAddress");
        }        

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\TextBoxData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"TextBoxDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Text Box Data Set_ set '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
