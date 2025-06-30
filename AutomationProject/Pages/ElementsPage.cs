using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class ElementsPage
    {

        public IWebDriver driver;
        public ElementMethods elementMethods;

        public ElementsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementMethods = new ElementMethods(driver);
        }


        IWebElement webTablesButtonElemenet => driver.FindElement(By.XPath("//span[text()='Web Tables']"));
        IWebElement addButtonElement => driver.FindElement(By.Id("addNewRecordButton"));
        IWebElement submitButtonElement => driver.FindElement(By.Id("submit"));
        IWebElement firstNameElement => driver.FindElement(By.Id("firstName"));
        IWebElement lastNameElement => driver.FindElement(By.Id("lastName"));
        IWebElement userEmailElement => driver.FindElement(By.Id("userEmail"));
        IWebElement ageElemenent => driver.FindElement(By.Id("age"));
        IWebElement salaryElemenent => driver.FindElement(By.Id("salary"));
        IWebElement departmentElemenent => driver.FindElement(By.Id("department"));


        public void ClickOnWebtables()
        {
            elementMethods.ClickOnElement(webTablesButtonElemenet);
        }

        public void ClickOnAddButton()
        {
            elementMethods.ClickOnElement(addButtonElement);
        }

        public void ClickOnSubmitButton()
        {
            elementMethods.ClickOnElement(submitButtonElement);
        }

        public void FillRegistrationForm(WebTableData webTableData)
        {
            elementMethods.FillElement(firstNameElement, webTableData.FirstName);
            elementMethods.FillElement(lastNameElement, webTableData.LastName);
            elementMethods.FillElement(userEmailElement, webTableData.UserEmail);
            elementMethods.FillElement(ageElemenent, webTableData.Age);
            elementMethods.FillElement(salaryElemenent, webTableData.Salary);
            elementMethods.FillElement(departmentElemenent, webTableData.Department);
        }


        //public void CompleteWebTables(string firstName, string lastName, string userEmail, string age, string salary, string department)
        //{                    

        //    elementMethods.FillElement(firstNameElement, firstName);
        //    elementMethods.FillElement(lastNameElement, lastName);
        //    elementMethods.FillElement(userEmailElement, userEmail);
        //    elementMethods.FillElement(ageElemenent, age);
        //    elementMethods.FillElement(salaryElemenent, salary);
        //    elementMethods.FillElement(departmentElemenent, department);

        //}


        public IReadOnlyCollection<IWebElement> GetTableRows()
        {
            return driver.FindElements(By.XPath("//div[@class='rt-tbody']/div[@class='rt-tr-group']"));
        }

        public bool RecordExists(WebTableData webTableData)
        {
            foreach (var row in GetTableRows())
            {
                var cells = row.FindElements(By.XPath(".//div[@class='rt-td']"));
                if (cells.Count >= 3)
                {
                    if (cells[0].Text.Trim() == webTableData.FirstName &&
                        cells[1].Text.Trim() == webTableData.LastName &&
                        cells[3].Text.Trim() == webTableData.UserEmail)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        IWebElement elementsFullName => driver.FindElement(By.Id("userName"));
        IWebElement elementsEmail => driver.FindElement(By.Id("userEmail"));
        IWebElement elementsAdresa => driver.FindElement(By.Id("currentAddress"));
        IWebElement elementsPermanentAdresa => driver.FindElement(By.Id("permanentAddress"));
        IWebElement submitButtonTextBox => driver.FindElement(By.Id("submit"));


        public void FillElementTextBox(TextBoxData textBoxData)
        {

            elementMethods.FillElement(elementsFullName, textBoxData.FullName);
            elementMethods.FillElement(elementsEmail, textBoxData.UserEmail);
            elementMethods.FillElement(elementsAdresa, textBoxData.CurrentAddress);
            elementMethods.FillElement(elementsPermanentAdresa, textBoxData.PermanentAddress);
        }

        public void ClickOnSubmitButtonTextBox()
        {
            elementMethods.ClickOnElement(submitButtonTextBox);
        }


    }
}
