using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProject.HelperMethods
{
    public class ElementMethods
    {
        IWebDriver Driver;
        public ElementMethods(IWebDriver driver) 
        {
            Driver = driver;
        }

        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }

        public void FillElement(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void FillElementAlerts(IAlert element, string text)
        {
            element.SendKeys(text);
        }

        public void ClickElementIList(IList<IWebElement> element, int gridNumbers)
        {
            element[gridNumbers].Click();
        }

        public void SelectElementForListByText(IList<IWebElement> elementsList, string text)
        {
            foreach (IWebElement element in elementsList)
            {
                if (element.Text == text)
                {
                    ClickOnElement(element);
                }
            }

        }
    }
}
