using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.BasePage;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//namespace AutomationProject.Tests
//{
//    public class WidgetsSelectMenuCurs : TestBasePage
//    {

//        //IWebDriver driver;

//        ElementMethods elementMethods;

//        [Test]
//        public void ExecSelectMenu()
//        {
//            //driver = new ChromeDriver();
//            //driver.Navigate().GoToUrl("https://demoqa.com/");
//            //driver.Manage().Window.Maximize();

//            elementMethods = new ElementMethods(driver);

//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("window.scrollTo(0,1000)");


//            //IWebElement widgetsButton = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
//            //widgetsButton.Click();

//            IWebElement widgetsButton2 = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
//            //widgetsButton2.Click();
//            elementMethods.ClickOnElement(widgetsButton2);

//            IWebElement widgetsSelectMenuButton = driver.FindElement(By.XPath("//span[text()='Select Menu']"));
//            //widgetsSelectMenuButton.Click();
//            elementMethods.ClickOnElement(widgetsSelectMenuButton);

//            IWebElement selectOldStyleMenu = driver.FindElement(By.Id("oldSelectMenu"));
//            //selectOldStyleMenu.Click();
//            elementMethods.ClickOnElement(selectOldStyleMenu);

//            SelectElement selectValueOldStyleMenu = new SelectElement(selectOldStyleMenu);
//            // selectValueOldStyleMenu.SelectByValue("2");
//            selectValueOldStyleMenu.SelectByText("Yellow");







//        }


//    }
//}
