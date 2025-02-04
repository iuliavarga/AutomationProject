using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationProject
{
    public class Windows
    {

        IWebDriver driver;

        [Test]
        public void ExecWindows()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement alertFramesButtom = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][3]"));
            alertFramesButtom.Click();

            List<IWebElement> listFrames = driver.FindElements(By.XPath("//div[@class='element-list collapse show']//li[@class='btn btn-light ']")).ToList();
            listFrames[0].Click();

            IWebElement newtabButton = driver.FindElement(By.Id("tabButton"));
            newtabButton.Click();

            List<string> tabList = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabList[1]);
            
            IWebElement textNewTab = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {textNewTab.Text}");

            driver.Close();
            driver.SwitchTo().Window(tabList[0]);

            IWebElement newWindowButton = driver.FindElement(By.Id("windowButton"));
            newWindowButton.Click();

            List<string> windowList = new List<string>(driver.WindowHandles);

            driver.SwitchTo().Window(windowList[1]);

            IWebElement textNewWindow = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {textNewWindow.Text}");




        }
    }
}
