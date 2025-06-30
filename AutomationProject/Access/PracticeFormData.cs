using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using sun.util.locale.provider;

namespace AutomationProject.Access
{
    public partial class PracticeFormData
    {
        private XElement dataNode;
        public PracticeFormData(int dataSetNumber)
        {
            LoadData(dataSetNumber);
            FirstName = GetValue("firstName");
            LastName = GetValue("lastName");
            UserEmail = GetValue("userEmail");
            UserNumber = GetValue("userNumber");
            CurrentAddress = GetValue("currentAddress");
            Gender = GetValue("gender");
            DateOfBirth = GetValue("dateOfBirth");
            //Day = GetValue("day");
            //Month = GetValue("month");
            //Year = GetValue("year");
            Subjects = GetValue("subjects");
            Hobbies = GetValue("hobbies");
            Picture = GetValue("picturePath");
            State = GetValue("state");
            City = GetValue("city");

        }

        private void LoadData(int dataSetNumber)
        {
            string path = Path.Combine("C:\\Users\\ivarga\\source\\repos\\AutomationProject\\AutomationProject\\Resources\\PracticeFormData.xml");
            XDocument doc = XDocument.Load(path);

            string nodeName = $"PracticeFormDataSet_{dataSetNumber}";
            dataNode = doc.Root.Element(nodeName);

            if (dataNode == null)
            {
                throw new Exception($"Practice Form Data Set '{nodeName}' not found in the XML file.");
            }
        }

        private string GetValue(string nodeName)
        {
            return dataNode.Element(nodeName)?.Value ?? throw new Exception($"Node '{nodeName}' not found in the data set.");
        }
    }
}
