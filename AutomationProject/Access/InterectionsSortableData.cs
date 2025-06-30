using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class InterectionsSortableData
    {
        private XElement dataNode;
        public InterectionsSortableData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            SortableNumber = GetValue("sortableNumber");
        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\InterectionsSortableData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"InterectionsSortableDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Interections Sortable Data Set_ '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
