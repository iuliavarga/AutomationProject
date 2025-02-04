using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationProject
{
    public class Frames
    {

        IWebDriver driver;

        [Test]
        public void ExecFrames()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement alertFramesButtom = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][3]"));
            alertFramesButtom.Click();

            List<IWebElement> listFrames = driver.FindElements(By.XPath("//div[@class='element-list collapse show']//li[@class='btn btn-light ']")).ToList();
            listFrames[2].Click();
            
            IWebElement frame1 = driver.FindElement(By.Id("frame1"));

            driver.SwitchTo().Frame(frame1);

            IWebElement frameText = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {frameText.Text}");

            driver.SwitchTo().DefaultContent();
            IWebElement frame2 = driver.FindElement(By.Id("frame2"));
            driver.SwitchTo().Frame(frame2);

            IWebElement frameText2 = driver.FindElement(By.Id("sampleHeading"));
            Console.WriteLine($"text is:  {frameText2.Text}");



        }


    }
}
