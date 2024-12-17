﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    
    public class PracticeForms
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

            IWebElement formsButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
            formsButton.Click();

            IWebElement elementPracticeForm = driver.FindElement(By.XPath("//*[text()='Practice Form']"));
            elementPracticeForm.Click();

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
                    genderMale.Click();
                    break;
                case "Female":
                    genderFemale.Click();
                    break;
                case "Other":
                    genderOther.Click();
                    break;
            }

            IWebElement elementSubject = driver.FindElement(By.Id("subjectsInput"));
            elementSubject.SendKeys("English");
            elementSubject.SendKeys(Keys.Enter);
            elementSubject.SendKeys("C");
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.ArrowDown);
            elementSubject.SendKeys(Keys.Enter);


        }


        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}



    }
}