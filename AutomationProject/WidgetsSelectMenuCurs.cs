using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject
{
    public class WidgetsSelectMenuCurs
    {

        IWebDriver driver;

        [Test]
        public void ExecSelectMenu()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            //IWebElement widgetsButton = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            //widgetsButton.Click();

            IWebElement widgetsButton2 = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
            widgetsButton2.Click();

            IWebElement widgetsSelectMenuButton = driver.FindElement(By.XPath("//span[text()='Select Menu']"));
            widgetsSelectMenuButton.Click();

            IWebElement selectOldStyleMenu = driver.FindElement(By.Id("oldSelectMenu"));
            selectOldStyleMenu.Click();
            SelectElement selectValueOldStyleMenu = new SelectElement(selectOldStyleMenu);            
           // selectValueOldStyleMenu.SelectByValue("2");
            selectValueOldStyleMenu.SelectByText("Yellow");







        }


    }
}
