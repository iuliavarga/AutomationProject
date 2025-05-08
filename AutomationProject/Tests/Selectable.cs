using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.BasePage;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Tests
{
    public class InteractionsSelectable : TestBasePage
    {
        //IWebDriver driver;
        ElementMethods elementMethods;
        JavaScriptHelper javaScriptHelper;
        HomePage homePage;
        CommonPage commonPage;
        InterectionsSelectablePage interectionsSelectablePage;


        [Test]

        public void Selectable()
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
            interectionsSelectablePage = new InterectionsSelectablePage(driver);
            
            //javaScriptHelper.ScrollPageVertically(1000);
            javaScriptHelper.HideFixedBanner();


            homePage.ClickOnInteractionsPage();
            commonPage.GoToDesireMenu("Selectable");
            interectionsSelectablePage.ClickOnGrid();
            interectionsSelectablePage.SelectEvenNumbers();
        }




        //public void Selectable()
        //{
        //    driver = new ChromeDriver();

        //    driver.Navigate().GoToUrl("https://demoqa.com/");
        //    driver.Manage().Window.Maximize();

        //    elementMethods = new ElementMethods(driver);

        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("window.scrollTo(0,1000)");

        //    IWebElement interactionsButton = driver.FindElement(By.XPath("//h5[text()='Interactions']"));
        //    //interactionsButton.Click();
        //    elementMethods.ClickOnElement(interactionsButton);

        //    IWebElement elementsSelectable = driver.FindElement(By.XPath("//*[text()='Selectable']"));
        //    //elementsSelectable.Click();
        //    elementMethods.ClickOnElement(elementsSelectable);

        //    IWebElement elementsGrid = driver.FindElement(By.Id("demo-tab-grid"));
        //    //elementsGrid.Click();
        //    elementMethods.ClickOnElement(elementsGrid);

        //    IList<IWebElement> gridNumbers = driver.FindElements(By.XPath("//div[@id='gridContainer']//li[contains(@class, 'list-group-item')]"));


        //    for (int i = 0; i < gridNumbers.Count; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            //gridNumbers[i].Click();
        //            elementMethods.ClickElementIList(gridNumbers, i);
        //        }
        //    }




        //}


    }
}
