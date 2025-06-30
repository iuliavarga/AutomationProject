using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class BrowserWindowsData
    {
        private XElement dataNode;

        public BrowserWindowsData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            Type = GetValue("type");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\BrowserWindowsData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"BrowserWindowsDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Browser Windows Data Set '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }

}
    

