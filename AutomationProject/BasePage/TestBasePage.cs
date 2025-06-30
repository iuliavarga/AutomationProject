using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.BasePage.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.BasePage
{
    public class TestBasePage
    {
        public IWebDriver driver;

        [SetUp]
        public void InitializeBrowser()
        {
            //driver = new ChromeDriver();
            driver = new BrowserFactory().GetBrowserFactory();
                   
            driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();

        }




        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //    driver.Dispose();
        //}

    }
}
