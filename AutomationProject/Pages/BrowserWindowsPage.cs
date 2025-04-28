using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class BrowserWindowsPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public BrowserWindowsPage(IWebDriver driver) 
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        IWebElement newTabButton => driver.FindElement(By.Id("tabButton"));
        IWebElement newWindowButton => driver.FindElement(By.Id("windowButton"));

        public void ClickOnNewTabButton()
        {
            elementMethods.ClickOnElement(newTabButton);
            List<string> tabList = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabList[1]);
            IWebElement textNewTab = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {textNewTab.Text}");
            driver.Close();
            driver.SwitchTo().Window(tabList[0]);
        }
         public void ClickOnNewWindowButton()
        {
            elementMethods.ClickOnElement(newWindowButton);
            List<string> windowList = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(windowList[1]);
            IWebElement textNewWindow = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {textNewWindow.Text}");
            driver.Close();
            driver.SwitchTo().Window(windowList[0]);
        }
     

    }
}
