using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void CompleteWebTables(string firstName, string lastName, string userEmail, string age, string salary, string department)
        {                    

            elementMethods.FillElement(firstNameElement, firstName);
            elementMethods.FillElement(lastNameElement, lastName);
            elementMethods.FillElement(userEmailElement, userEmail);
            elementMethods.FillElement(ageElemenent, age);
            elementMethods.FillElement(salaryElemenent, salary);
            elementMethods.FillElement(departmentElemenent, department);
  
        }

       






    }
}
