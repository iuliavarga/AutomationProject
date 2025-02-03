using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    public class StructuriRepetitive
    {
        IWebDriver driver;

        [Test]
        public void AutoComplet()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement interactionsButton = driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsButton.Click();

            //IWebElement elementsSortable = driver.FindElement(By.XPath("//*[text()='Sortable']"));
            //elementsSortable.Click();

            List<IWebElement> listInteractions =
                driver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();
            listInteractions[0].Click();

            List<IWebElement> listElements =
                driver.FindElements(By.XPath(" //div[@class='vertical-list-container mt-4']/div[@class='list-group-item list-group-item-action']")).ToList();
            //Console.WriteLine(listElements[0].Text);
            //Console.WriteLine(listElements[1].Text);

            //for(int counter = 0; counter < listElements.Count; counter++)
            //{
            //    Console.WriteLine(listElements[counter].Text);
            //}

            for (int counter = 0; counter < listElements.Count; counter++)
                Console.WriteLine(listElements[counter].Text);



        }

        [Test]

        public void Test2()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formsButton.Click();

            IWebElement elementPracticeForm = driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            elementPracticeForm.Click();

          //  IWebElement checkBoxSport = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            //checkBoxSport.Click();

           // IWebElement checkBoxReading = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
            //checkBoxReading.Click();

          //  IWebElement checkBoxMusic = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));
            //checkBoxMusic.Click();

            IWebElement sportElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            IWebElement readingElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
            IWebElement musicElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));


            List<IWebElement> hobbiesList = new List<IWebElement>();
            hobbiesList.Add(sportElement);
            hobbiesList.Add(readingElement);
            hobbiesList.Add(musicElement);

            string[] array = ["Sports", "Reading", "Music"];
            foreach (IWebElement hobby in hobbiesList)
            {
                foreach (string item in array)
                {
                    if (hobby.Text.Equals(item))
                    {
                        hobby.Click();
                    }

                }

            }


        }


        [Test]

        public void Test3()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formsButton.Click();

            IWebElement elementPracticeForm = driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            elementPracticeForm.Click();

            IWebElement elementSubject = driver.FindElement(By.Id("subjectsInput"));

            elementSubject.SendKeys("English");
            elementSubject.SendKeys(Keys.Enter);
            elementSubject.SendKeys("C");
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.Enter);

          //  List<IWebElement> removeSubjects = driver.FindElements(By.XPath("//div[@class='css-xb97g8 subjects-auto-complete__multi-value__remove']")).ToList();

            List<IWebElement> removeSubjects = driver.FindElements(By.XPath("//div[@class='css-xb97g8 subjects-auto-complete__multi-value__remove']")).ToList();
            bool subjectFlag = true;




            //  driver.FindElements(By.XPath("//div[@class='css-xb97g8 subjects-auto-complete__multi-value__remove']")).ToList();
          //  bool subjectFlag = true;
            while (subjectFlag)
            {
                foreach (IWebElement element in removeSubjects)
                {
                    element.Click();
                    //Thread.Sleep(1000);
                }
                subjectFlag = false;
            }



        }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}

    }




}
