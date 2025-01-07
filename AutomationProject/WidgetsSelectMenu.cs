using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace AutomationProject
{
    public class WidgetsSelectMenu
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


            IWebElement widgetsButton = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsButton.Click();

            IWebElement widgetsSelectMenuButton = driver.FindElement(By.XPath("//*[text()='Select Menu']"));
            widgetsSelectMenuButton.Click();

            IWebElement selectMenuDropdown = driver.FindElement(By.XPath("//div[@class=' css-1hwfws3']"));
            selectMenuDropdown.Click();

            //SelectElement select = new SelectElement(selectMenuDropdown);
            //select.SelectByText("Group 2, option 2");

            IWebElement selectValue = driver.FindElement(By.XPath("//*[text()='Group 2, option 2']"));
            selectValue.Click();

            IWebElement selectOneDropdown = driver.FindElement(By.Id("selectOne"));
            selectOneDropdown.Click();
            IWebElement selectValueOneDropdown = driver.FindElement(By.XPath("//*[text()='Mr.']"));
            selectValueOneDropdown.Click();

            IWebElement selectOldStyleMenu = driver.FindElement(By.Id("oldSelectMenu"));
            selectOldStyleMenu.Click();
            SelectElement selectValueOldStyleMenu = new SelectElement(selectOldStyleMenu);
            selectValueOldStyleMenu.SelectByValue("2");
            selectOldStyleMenu.Click();


           
           IWebElement multiSelectDropdown = driver.FindElement(By.XPath("//div[@class=' css-1hwfws3']"));
           
            multiSelectDropdown.Click();
           // IWebElement option1 = driver.FindElement(By.XPath("//div[@class='css-12jo7m5']"));
           // option1.Click();
           // multiSelectDropdown.Click();
            IWebElement option2 = driver.FindElement(By.XPath("//*[text()='Black']"));
            option2.Click();
            multiSelectDropdown.Click();

            IWebElement standardMultiSelect = driver.FindElement(By.Id("cars"));
            //standardMultiSelect.Click();
            IWebElement standardMultiSelectValue = driver.FindElement(By.XPath("//option[text()='Saab']"));
            standardMultiSelectValue.Click();
            //IWebElement standardMultiSelectValue2 = driver.FindElement(By.XPath("//option[text()='Opel']"));
            //standardMultiSelectValue2.Click();





        }
    }
}
