using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomationProject.Access
{
    public partial class FramesData
    {
        private XElement dataNode;
        public FramesData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FrameID = GetValue("frameID");
                
        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\FramesData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"FrameDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Frame Data set '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}

