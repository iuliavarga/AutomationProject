using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;

namespace AutomationProject.Tests
{
    public class Windows
    {

        IWebDriver driver;
        ElementMethods elementMethods;
        JavaScriptHelper javaScriptHelper;
        HomePage homePage;
        CommonPage commonPage;
        BrowserWindowsPage browserWindowsPage;

        [Test]

        public void BrowserWindowsTest()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            browserWindowsPage = new BrowserWindowsPage(driver);
            javaScriptHelper = new JavaScriptHelper(driver);

            javaScriptHelper.ScrollPageVertically(1000);

            homePage.ClickOnFramesPage();
            commonPage.GoToDesireMenu("Browser Windows");
            browserWindowsPage.ClickOnNewWindowButton();
            browserWindowsPage.ClickOnNewTabButton();

        }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}




        //    public void ExecWindows()
        //    {
        //        driver = new ChromeDriver();

        //        driver.Navigate().GoToUrl("https://demoqa.com/");
        //        driver.Manage().Window.Maximize();


        //        elementMethods = new ElementMethods(driver);

        //        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //        js.ExecuteScript("window.scrollTo(0,1000)");

        //        IWebElement alertFramesButtom = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][3]"));
        //        //alertFramesButtom.Click();
        //        elementMethods.ClickOnElement(alertFramesButtom);

        //        List<IWebElement> listFrames = driver.FindElements(By.XPath("//div[@class='element-list collapse show']//li[@class='btn btn-light ']")).ToList();
        //        // listFrames[0].Click();
        //        elementMethods.ClickElementIList(listFrames, 0);

        //        IWebElement newtabButton = driver.FindElement(By.Id("tabButton"));
        //       // newtabButton.Click();
        //        elementMethods.ClickOnElement(newtabButton);

        //        List<string> tabList = new List<string>(driver.WindowHandles);
        //        driver.SwitchTo().Window(tabList[1]);

        //        IWebElement textNewTab = driver.FindElement(By.Id("sampleHeading"));
        //        Console.WriteLine($"text is:  {textNewTab.Text}");

        //        driver.Close();
        //        driver.SwitchTo().Window(tabList[0]);

        //        IWebElement newWindowButton = driver.FindElement(By.Id("windowButton"));
        //        // newWindowButton.Click();
        //        elementMethods.ClickOnElement(newWindowButton);

        //        List<string> windowList = new List<string>(driver.WindowHandles);

        //        driver.SwitchTo().Window(windowList[1]);

        //        IWebElement textNewWindow = driver.FindElement(By.Id("sampleHeading"));
        //        Console.WriteLine($"text is:  {textNewWindow.Text}");




        //    }
        //}
    }

}