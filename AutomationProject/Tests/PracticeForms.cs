using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Tests
{

    public class PracticeForms
    {
        IWebDriver driver;

        ElementMethods elementMethods;

        [Test]
        public void Test1()
        {

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            elementMethods = new ElementMethods(driver);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
            //formsButton.Click();
            elementMethods.ClickOnElement(formsButton);


            IWebElement elementPracticeForm = driver.FindElement(By.XPath("//*[text()='Practice Form']"));
            //elementPracticeForm.Click();
            elementMethods.ClickOnElement(elementPracticeForm);

            IWebElement genderMale = driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement genderFemale = driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
            IWebElement genderOther = driver.FindElement(By.XPath("//label[@for='gender-radio-3']"));
            //labelGenderOther.Click();

            string gender = "Male";

            //if (gender.Equals("Male"))
            //{
            //    genderMale.Click();

            //}
            //else if (gender.Equals("Female"))
            //{
            //    genderFemale.Click();
            //}
            //else
            //{
            //    genderOther.Click();
            //}

            switch (gender)
            {
                case "Male":
                  //  genderMale.Click();
                    elementMethods.ClickOnElement(genderMale);
                    break;
                case "Female":
                   // genderFemale.Click();
                    elementMethods.ClickOnElement(genderFemale);
                    break;
                case "Other":
                    //genderOther.Click();
                    elementMethods.ClickOnElement(genderOther);
                    break;
            }

               IWebElement elementSubject = driver.FindElement(By.Id("subjectsInput"));
            //elementSubject.SendKeys("English");
            //elementSubject.SendKeys(Keys.Enter);
            //elementSubject.SendKeys("C");
            //elementSubject.SendKeys(Keys.ArrowDown);
            //elementSubject.SendKeys(Keys.ArrowDown);
            //elementSubject.SendKeys(Keys.ArrowDown);
            //elementSubject.SendKeys(Keys.Enter);

            elementMethods.FillElement(elementSubject, "English");
            elementMethods.FillElement(elementSubject, Keys.Enter);
            elementMethods.FillElement(elementSubject, "C");
            elementMethods.FillElement(elementSubject, Keys.ArrowDown);
            elementMethods.FillElement(elementSubject, Keys.Enter);

            IWebElement dateBirth = driver.FindElement(By.Id("dateOfBirthInput"));
            //dateBirth.Click();
           elementMethods.ClickOnElement(dateBirth);

            IWebElement datePickerMonth = driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
            SelectElement monthDropDown = new SelectElement(datePickerMonth);
            monthDropDown.SelectByValue("2");

            IWebElement datePickerYear = driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
            SelectElement yearDropDown = new SelectElement(datePickerYear);
            yearDropDown.SelectByValue("1990");

            IWebElement datePickerDate = driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--026' and not (contains(@class, '--outside-month'))]"));
           // datePickerDate.Click();
           elementMethods.ClickOnElement(datePickerDate);





        }


        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}



    }
}
