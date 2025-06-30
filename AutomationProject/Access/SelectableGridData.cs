using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class SelectableGridData
    {
        private XElement dataNode;
        public SelectableGridData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            Type = GetValue("type");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\SelectableGridData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"SelectableGridDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Selectable Grid Data Set_ '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}

