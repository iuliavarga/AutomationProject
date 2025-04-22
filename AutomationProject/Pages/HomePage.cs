using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class HomePage
    {
        public IWebDriver driver;

        public ElementMethods elementMethods;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
        }

        IWebElement formsButton => driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));

        public void ClickOnFormsPage()
        {
            elementMethods.ClickOnElement(formsButton);
        }

        IWebElement elementsButton => driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));

        public void ClickOnElemenetsPage()
        {
            elementMethods.ClickOnElement(elementsButton);
        }


    }
}
