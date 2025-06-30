using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;
using AutomationProject.BasePage;
using AutomationProject.Access;

namespace AutomationProject.Tests
{
    public class Frames : TestBasePage
    {

       // IWebDriver driver;
        ElementMethods elementMethods;
        HomePage homePage;
        CommonPage commonPage;
        FramePage framePage;
        JavaScriptHelper javaScriptHelper;


        [Test]
        [TestCase(1)]
        [TestCase(2)]

        public void Frametest(int dataSetNumber)
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            framePage = new FramePage(driver);
            javaScriptHelper = new JavaScriptHelper(driver);

            var framesData = new FramesData(dataSetNumber);
          

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            homePage.ClickOnFramesPage();
            commonPage.GoToDesireMenu("Frames");
            framePage.GetFrameText(framesData);

            //framePage.GetTextFromFrame1();
            //framePage.GetTextFromFrame2();

        }




        //[Test]
        //public void ExecFrames()
        //{
        //    driver = new ChromeDriver();

        //    driver.Navigate().GoToUrl("https://demoqa.com/");
        //    driver.Manage().Window.Maximize();

        //    elementMethods = new ElementMethods(driver);

        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("window.scrollTo(0,1000)");

        //    IWebElement alertFramesButtom = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][3]"));
        //    //alertFramesButtom.Click();
        //    elementMethods.ClickOnElement(alertFramesButtom);

        //    List<IWebElement> listFrames = driver.FindElements(By.XPath("//div[@class='element-list collapse show']//li[@class='btn btn-light ']")).ToList();
        //    //listFrames[2].Click();
        //    elementMethods.ClickOnElement(listFrames[2]);

        //    IWebElement frame1 = driver.FindElement(By.Id("frame1"));

        //    driver.SwitchTo().Frame(frame1);

        //    IWebElement frameText = driver.FindElement(By.Id("sampleHeading"));
        //    Console.WriteLine($"text is:  {frameText.Text}");

        //    driver.SwitchTo().DefaultContent();
        //    IWebElement frame2 = driver.FindElement(By.Id("frame2"));
        //    driver.SwitchTo().Frame(frame2);

        //    IWebElement frameText2 = driver.FindElement(By.Id("sampleHeading"));
        //    Console.WriteLine($"text is:  {frameText2.Text}");



        //}


    }
}
