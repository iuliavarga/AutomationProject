using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class WidgetsSelectMenuData
    {
        private XElement dataNode;
        public WidgetsSelectMenuData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            SelectValue = GetValue("selectValue");
            Title = GetValue("title");
            OldStyleColor = GetValue("oldStyleColor");
            DropDownValue = GetValue("dropDownValue");  
            MultiSelectValue = GetValue("multiSelectValue");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\WidgetsSelectMenuData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"WidgetsSelectMenuDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Widgets Select MenuData Set_ '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
