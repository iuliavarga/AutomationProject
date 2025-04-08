using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Tests
{
    public class WidgetsAutoComplet
    {
        IWebDriver driver;

        ElementMethods elementMethods;

        public void SingleParameter(IWebElement autoCompletSingle)
        {
            autoCompletSingle.SendKeys("R");

        }

        [Test]
        public void ExecAutoComplet()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            elementMethods = new ElementMethods(driver);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            IWebElement widgetsButton = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            //widgetsButton.Click();
            elementMethods.ClickOnElement(widgetsButton);

            IWebElement widgetsAutoCompletButton = driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
            // widgetsAutoCompletButton.Click();
            elementMethods.ClickOnElement(widgetsAutoCompletButton);

            IWebElement autoCompletMultiple = driver.FindElement(By.Id("autoCompleteMultipleInput"));
            //autoCompletMultiple.SendKeys("Bl");
            //autoCompletMultiple.SendKeys(Keys.ArrowDown);
            //autoCompletMultiple.SendKeys(Keys.Enter);

            //autoCompletMultiple.SendKeys("A");
            //autoCompletMultiple.SendKeys(Keys.ArrowDown);
            //autoCompletMultiple.SendKeys(Keys.ArrowDown);
            //autoCompletMultiple.SendKeys(Keys.Enter);

            elementMethods.FillElement(autoCompletMultiple, "Bl");
            elementMethods.FillElement(autoCompletMultiple, Keys.ArrowDown);
            elementMethods.FillElement(autoCompletMultiple, Keys.Enter);




            IWebElement autoCompletSingle = driver.FindElement(By.Id("autoCompleteSingleInput"));
            //  autoCompletSingle.SendKeys("R");
            SingleParameter(autoCompletSingle);
            // autoCompletSingle.SendKeys(Keys.Enter);
            elementMethods.FillElement(autoCompletSingle, Keys.Enter);

        }

    }
}
