using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;
using AutomationProject.BasePage;

namespace AutomationProject.Tests
{
    public class Alerte : TestBasePage
    {
      //IWebDriver driver;
        ElementMethods elementMethods;
        JavaScriptHelper javaScriptHelper;
        HomePage homePage;
        CommonPage commonPage;
        AlertsFrameWindowsPage alertsFrameWindowsPage;



        [Test]
        public void AlerteTest()
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            alertsFrameWindowsPage = new AlertsFrameWindowsPage(driver);
            javaScriptHelper = new JavaScriptHelper(driver);

            javaScriptHelper.ScrollPageVertically(1000);

            homePage.ClickOnFramesPage();
            commonPage.GoToDesireMenu("Alerts");
            alertsFrameWindowsPage.ClickOnAlertButton();
            alertsFrameWindowsPage.ClickOnTimerAlertButton();
            alertsFrameWindowsPage.ClickOnConfirmButton();
            alertsFrameWindowsPage.ClickOnConfirmButton();
            alertsFrameWindowsPage.ClickOnPromptButtonWithText("zzzz");

        }





        //    [Test]
        //    public void Test1()
        //    {

        //        driver = new ChromeDriver();

        //        driver.Navigate().GoToUrl("https://demoqa.com/");
        //        driver.Manage().Window.Maximize();

        //        elementMethods = new ElementMethods(driver);

        //        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //        js.ExecuteScript("window.scrollTo(0,1000)");

        //        IWebElement alertButton = driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']"));
        //        //alertButton.Click();
        //        elementMethods.ClickOnElement(alertButton);

        //        IWebElement alertButton1 = driver.FindElement(By.XPath("//span[text()='Alerts']"));
        //        //alertButton1.Click();
        //        elementMethods.ClickOnElement(alertButton1);    

        //        IWebElement alert1 = driver.FindElement(By.Id("alertButton"));
        //        //alert1.Click();
        //        elementMethods.ClickOnElement (alert1); 

        //        IAlert alertOk = driver.SwitchTo().Alert();
        //        alertOk.Accept();

        //        IWebElement timerAlertButton = driver.FindElement(By.Id("timerAlertButton"));
        //        //timerAlertButton.Click();
        //        elementMethods.ClickOnElement(timerAlertButton);

        //        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //        wait.Until(ExpectedConditions.AlertIsPresent());

        //        IAlert alertWithDelay = driver.SwitchTo().Alert();
        //        alertWithDelay.Accept();

        //        IWebElement confirmButton = driver.FindElement(By.Id("confirmButton"));
        //        //confirmButton.Click();
        //        elementMethods.ClickOnElement(confirmButton);

        //        IAlert arteWithDismiss = driver.SwitchTo().Alert();
        //        arteWithDismiss.Dismiss();

        //        IWebElement promtButton = driver.FindElement(By.Id("promtButton"));
        //        //promtButton.Click();
        //        elementMethods.ClickOnElement(promtButton);


        //        IAlert arteWithPromt = driver.SwitchTo().Alert();
        //        //arteWithPromt.SendKeys("zzzx");
        //        elementMethods.FillElementAlerts(arteWithPromt, "zzz");
        //        arteWithPromt.Accept();

        //    }
        //}
    }
}