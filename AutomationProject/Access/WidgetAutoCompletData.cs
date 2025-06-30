using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class WidgetAutoCompletData
    {
        private XElement dataNode;
        public WidgetAutoCompletData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            MultipleText1 = GetValue("multipleText1");
            MultipleText2 = GetValue("multipleText2");
            SingleText = GetValue("singleText");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\WidgetAutoCompletData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"WidgetAutoCompletDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Widget AutoComplet Data Set_ '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
