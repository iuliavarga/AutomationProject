using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    public class TextBoxTest
    {
       
        IWebDriver driver;


        [Test]
        public void Test1()
        {
           
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementsButton = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            elementsButton.Click();

            IWebElement elementsTextBoxButton = driver.FindElement(By.XPath("//*[text()='Text Box']"));
            elementsTextBoxButton.Click();

            IWebElement elementsFirstName = driver.FindElement(By.Id("userName"));
            elementsFirstName.SendKeys("varga julia");

            IWebElement elementsEmail = driver.FindElement(By.Id("userEmail"));
            elementsEmail.SendKeys("vjh@yahoo.com");

            IWebElement elementsAdresa = driver.FindElement(By.Id("currentAddress"));
            elementsAdresa.SendKeys("str. Calea Dorobantilor 89");

            IWebElement elementsPermanentAdresa = driver.FindElement(By.Id("permanentAddress"));
            elementsPermanentAdresa.SendKeys("str. Calea Dorobantilor 1, CJ");

            IWebElement elementsSubmitButton = driver.FindElement(By.XPath("//button[text()='Submit']"));
            elementsSubmitButton.Click();

        }

    //    [TearDown]
    //    public void TearDown()
    //    {
    //        driver.Quit();
    //        driver.Close();
    //    }

    }
}