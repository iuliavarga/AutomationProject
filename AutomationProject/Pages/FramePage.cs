using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class FramePage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public FramePage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        IWebElement frame1 => driver.FindElement(By.Id("frame1"));
        IWebElement frame2 => driver.FindElement(By.Id("frame2"));
        IWebElement frameText => driver.FindElement(By.Id("sampleHeading"));

        public void GetTextFromFrame1()
        {
            driver.SwitchTo().Frame(frame1);          
           // Console.WriteLine(frameText.Text);
            driver.SwitchTo().DefaultContent();
            //javaScriptHelper.ScrollPageVertically(1000);
        }

        public void GetTextFromFrame2()
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0,1000)");

            javaScriptHelper.ScrollPageVertically(1000);
            driver.SwitchTo().Frame(frame2);
            javaScriptHelper.ScrollPageDynamic(1000, 1000);

            //Console.WriteLine(frameText.Text);
            //driver.SwitchTo().DefaultContent();
        }

        public void GetFrameText(FramesData framesData)
        {
            IWebElement frameElement = driver.FindElement(By.Id(framesData.FrameID));
            driver.SwitchTo().Frame(frameElement);

            try
            {
                IWebElement frameTextElement = driver.FindElement(By.Id("sampleHeading"));
                Console.WriteLine(frameTextElement.Text);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Frame text element not found.");
            }
            finally
            {
                driver.SwitchTo().DefaultContent();
            }
        }
    }
}
