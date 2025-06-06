using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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

        IWebElement framesButton => driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][3]"));

        public void ClickOnFramesPage()
        {
            elementMethods.ClickOnElement(framesButton);
        }

        IWebElement widgetsButton => driver.FindElement(By.XPath("//h5[text()='Widgets']"));

        public void ClickOnWidgetPage()
        {
            elementMethods.ClickOnElement(widgetsButton);
        }

        IWebElement interactionsButton => driver.FindElement(By.XPath("//h5[text()='Interactions']"));
        public void ClickOnInteractionsPage()
        {
            elementMethods.ClickOnElement(interactionsButton);
        }
    }
}
