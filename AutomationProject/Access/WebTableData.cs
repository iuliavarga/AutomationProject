using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class WebTableData
    {
        private XElement dataNode;

        public WebTableData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FirstName = GetValue("firstName");
            LastName = GetValue("lastName");
            UserEmail = GetValue("userEmail");
            Age = GetValue("age");
            Salary = GetValue("salary");
            Department = GetValue("department");
        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\WebTableData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"DataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Data set '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
