using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
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

   

        public DateTime FormatDate(string date)
        {
            var value = date.Split(',').Select(int.Parse).ToArray();
            var day = value[0];
            var month = value[1];
            var year = value[2];

            var currentDate = DateTime.Now;
            var formattedDate = currentDate.AddDays(day).AddMonths(month).AddYears(year);

            return formattedDate;

        }

        public void SelectElementByText(IWebElement element, string text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public void SelectElementByValue(IWebElement element, string value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }
    }
}
