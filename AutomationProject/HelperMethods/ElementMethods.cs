using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.HelperMethods
{
    public class ElementMethods
    {
        IWebDriver driver;
        public ElementMethods(IWebDriver driver) 
        {
            this.driver = driver;
        }

        //public void ClickOnElement(IWebElement element)
        //{
        //    //  element.Click();
        //    JavaScriptHelper jsHelper = new JavaScriptHelper(driver);
        //    jsHelper.ScrollIntoView(element);
        //    element.Click();

        //}


        public void ClickOnElement(IWebElement element)
        {
            JavaScriptHelper jsHelper = new JavaScriptHelper(driver);
            jsHelper.ScrollIntoView(element);

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // If normal click fails, do JavaScript click
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", element);
            }
        }

        public void FillElement(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void FillElementAlerts(IAlert element, string text)
        {
            element.SendKeys(text);
        }

        //public void ClickElementIList(IList<IWebElement> element, int gridNumbers)
        //{
        //    element[gridNumbers].Click();
        //}

        public void ClickElementIList(IList<IWebElement> elements, int index)
        {
            JavaScriptHelper jsHelper = new JavaScriptHelper(driver);
            jsHelper.ScrollIntoView(elements[index]);
            elements[index].Click();
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
