using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    public class  WidgetsAutoComplet
    {
        IWebDriver driver;

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

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            IWebElement widgetsButton = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsButton.Click();

            IWebElement widgetsAutoCompletButton = driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
            widgetsAutoCompletButton.Click();

            IWebElement autoCompletMultiple = driver.FindElement(By.Id("autoCompleteMultipleInput"));
            autoCompletMultiple.SendKeys("Bl"); 
            autoCompletMultiple.SendKeys(Keys.ArrowDown);
            autoCompletMultiple.SendKeys(Keys.Enter);
         
            autoCompletMultiple.SendKeys("A");
            autoCompletMultiple.SendKeys(Keys.ArrowDown);
            autoCompletMultiple.SendKeys(Keys.ArrowDown);
            autoCompletMultiple.SendKeys(Keys.Enter);

            IWebElement autoCompletSingle = driver.FindElement(By.Id("autoCompleteSingleInput"));
            //  autoCompletSingle.SendKeys("R");
            SingleParameter(autoCompletSingle);
            autoCompletSingle.SendKeys(Keys.Enter);
            

        }

    }
}
