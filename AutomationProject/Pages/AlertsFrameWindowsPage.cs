using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Pages
{
    public class AlertsFrameWindowsPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public AlertsFrameWindowsPage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        IWebElement alert1 => driver.FindElement(By.Id("alertButton"));
        IWebElement timerAlertButton => driver.FindElement(By.Id("timerAlertButton"));
        IWebElement confirmButton => driver.FindElement(By.Id("confirmButton"));
        IWebElement promptButton => driver.FindElement(By.Id("promtButton"));

        public void ClickOnAlertButton()
        {
            elementMethods.ClickOnElement(alert1);
            driver.SwitchTo().Alert().Accept();
        }

        public void ClickOnTimerAlertButton()
        {
            elementMethods.ClickOnElement(timerAlertButton);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Accept();
        }

        public void ClickOnConfirmButton()
        {
            elementMethods.ClickOnElement(confirmButton);
            driver.SwitchTo().Alert().Dismiss();
        }

        public void ClickOnPromptButton()
        {
            elementMethods.ClickOnElement(promptButton);
            driver.SwitchTo().Alert().SendKeys("Test");
            driver.SwitchTo().Alert().Accept();
        }

        public void ClickOnPromptButtonWithText(AlertData alertData)
        {
            elementMethods.ClickOnElement(promptButton);
            driver.SwitchTo().Alert().SendKeys(alertData.PromptText);
            driver.SwitchTo().Alert().Accept();
        }



        //public void ClickOnPromptButtonWithText(string text)
        //{
        //    elementMethods.ClickOnElement(promptButton);
        //    driver.SwitchTo().Alert().SendKeys(text);
        //    driver.SwitchTo().Alert().Accept();
        //}
    }
}
