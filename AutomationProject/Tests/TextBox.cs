using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
using AutomationProject.BasePage;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;
using OpenQA.Selenium;

namespace AutomationProject.Tests
{
    public class TextBox : TestBasePage
    {
        ElementMethods elementMethods;
        HomePage homePage;
        CommonPage commonPage;
        ElementsPage elementsPage;

        [Test]
        public void TestTextBox()
        {
            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            elementsPage = new ElementsPage(driver);

            var textBoxData = new TextBoxData(1);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            homePage.ClickOnElemenetsPage();
            commonPage.GoToDesireMenu("Text Box");
            elementsPage.FillElementTextBox(textBoxData);
            elementsPage.ClickOnSubmitButton();


        }



        //    //public void DefinireParametriiTextBox(IWebElement elementsFirstName, IWebElement elementsEmail, IWebElement elementsAdresa, IWebElement elementsPermanentAdresa)
        //    //{

        //    //    //elementsFirstName.SendKeys("varga");
        //    //    //elementsEmail.SendKeys("vjh@yahoo.com");
        //    //    //elementsAdresa.SendKeys("str. Calea Dorobantilor 89");
        //    //    //elementsPermanentAdresa.SendKeys("str. Calea Dorobantilor 1, CJ");

        //    //    elementMethods.FillElement(elementsFirstName, "varga");
        //    //    elementMethods.FillElement(elementsEmail, "vjh@yahoo.com");
        //    //    elementMethods.FillElement(elementsAdresa, "str. Calea Dorobantilor 89");
        //    //    elementMethods.FillElement(elementsPermanentAdresa, "str. Calea Dorobantilor 1, CJ");
        //    //}


        //    //[Test]
        //    //public void TextBox()
        //    //{

        //    //    driver = new ChromeDriver();

        //    //    driver.Navigate().GoToUrl("https://demoqa.com/");
        //    //    driver.Manage().Window.Maximize();

        //    //    elementMethods = new ElementMethods(driver);

        //    //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //    js.ExecuteScript("window.scrollTo(0,1000)");


        //    //    IWebElement elementsButton = driver.FindElement(By.XPath("//h5[text()='Elements']"));
        //    //    //elementsButton.Click();
        //    //    elementMethods.ClickOnElement(elementsButton);

        //    //    IWebElement elementsTextBoxButton = driver.FindElement(By.XPath("//*[text()='Text Box']"));
        //    //    //elementsTextBoxButton.Click();
        //    //    elementMethods.ClickOnElement(elementsTextBoxButton);

        //    //    IWebElement elementsFirstName = driver.FindElement(By.Id("userName"));
        //    //    //elementsFirstName.SendKeys("varga julia");

        //    //    IWebElement elementsEmail = driver.FindElement(By.Id("userEmail"));
        //    //    // elementsEmail.SendKeys("vjh@yahoo.com");

        //    //    IWebElement elementsAdresa = driver.FindElement(By.Id("currentAddress"));
        //    //    //elementsAdresa.SendKeys("str. Calea Dorobantilor 89");

        //    //    IWebElement elementsPermanentAdresa = driver.FindElement(By.Id("permanentAddress"));
        //    //    //elementsPermanentAdresa.SendKeys("str. Calea Dorobantilor 1, CJ");

        //    //    DefinireParametriiTextBox(elementsFirstName, elementsEmail, elementsPermanentAdresa, elementsPermanentAdresa);


        //    //    IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        //    //    IWebElement elementsSubmitButton = driver.FindElement(By.Id("submit"));
        //    //    //driver.FindElement(By.XPath("//button[text()='Submit']"));
        //    //    //elementsSubmitButton.Submit();

        //    //    jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);

        //    //}

    }
}
