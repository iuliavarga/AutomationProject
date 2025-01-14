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
using SeleniumExtras.WaitHelpers;
using static System.Collections.Specialized.BitVector32;
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

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            Thread.Sleep(3000);



            js.ExecuteScript("window.scrollTo(0,500)");

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

            js.ExecuteScript("window.scrollTo(0,1000)");
            Actions action = new Actions(driver);

            //IWebElement multiSelectDropdown = driver.FindElement(By.ClassName("css-yk16xz-control"));

            IWebElement newDropDown = driver.FindElement(By.XPath("//div[contains(@class, 'css-1hwfws3')]//div[contains(@class, 'placeholder') and text()='Select...']"));
            newDropDown.Click();
            action.SendKeys("Green" + Keys.Enter)
                 .Build()
                 .Perform();


            //js.ExecuteScript("arguments[0].click();", multiSelectDropdown);
            //actions.SendKeys("Green" + Keys.Enter).Build().Perform();

            //IList<IWebElement> selectedOption = multiSelectDropdown.AllSelectedOptions;
            //foreach (IWebElement option in selectedOption)
            //{
            //    Console.WriteLine(option.Text);
            //}

            IWebElement standardMultiSelect = driver.FindElement(By.Id("cars"));
            //standardMultiSelect.Click();
            IWebElement standardMultiSelectValue = driver.FindElement(By.XPath("//option[text()='Saab']"));
            standardMultiSelectValue.Click();
            //IWebElement standardMultiSelectValue2 = driver.FindElement(By.XPath("//option[text()='Opel']"));
            //standardMultiSelectValue2.Click();





        }
    }
}
 