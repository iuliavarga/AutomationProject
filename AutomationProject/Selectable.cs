using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    public class InteractionsSelectable
    {

        IWebDriver driver;

        [Test]

        public void Selectable()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement interactionsButton = driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsButton.Click();

            IWebElement elementsSelectable = driver.FindElement(By.XPath("//*[text()='Selectable']"));
            elementsSelectable.Click();

            IWebElement elementsGrid = driver.FindElement(By.Id("demo-tab-grid"));
            elementsGrid.Click();

            IList<IWebElement> gridNumbers = driver.FindElements(By.XPath("//div[@id='gridContainer']//li[contains(@class, 'list-group-item')]"));

         
            for (int i = 0; i < gridNumbers.Count; i++)
            {
                if(i % 2 == 0)
                {
                    gridNumbers[i].Click();
                }
            }




        }


    }
}
