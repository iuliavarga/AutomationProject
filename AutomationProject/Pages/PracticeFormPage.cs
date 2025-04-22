using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class PracticeFormPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;

        public PracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
            this.elementMethods = new ElementMethods(driver);


        }

        IWebElement FirstNameElement => driver.FindElement(By.Id("firstName"));
        IWebElement LastNameElement => driver.FindElement(By.Id("lastName"));
        IWebElement EmailElement => driver.FindElement(By.Id("userEmail"));
        IWebElement MobilePhoneElement => driver.FindElement(By.Id("userNumber"));
        IWebElement CurrentAddressElement => driver.FindElement(By.Id("currentAddress"));

        IWebElement genderMaleButton => driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
        IWebElement genderFemaleButton => driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        IWebElement genderOtherButton => driver.FindElement(By.XPath("//label[@for='gender-radio-3']"));

        public void CompleteFirstRegion(string firstName, string lastName, string userEmail, string userNumber, string currentAddress)
        {
            elementMethods.FillElement(FirstNameElement, firstName);
            elementMethods.FillElement(LastNameElement, lastName);
            elementMethods.FillElement(EmailElement, userEmail);
            elementMethods.FillElement(MobilePhoneElement, userNumber);
            elementMethods.FillElement(CurrentAddressElement, currentAddress);
        }

        public void CompleteGender(string gender)
        {
            switch (gender)
            {
                case "Male":
                    genderMaleButton.Click();
                    elementMethods.ClickOnElement(genderMaleButton);
                    break;
                case "Female":
                    genderFemaleButton.Click();
                    elementMethods.ClickOnElement(genderFemaleButton);
                    break;
                case "Other":
                    genderOtherButton.Click();
                    elementMethods.ClickOnElement(genderOtherButton);
                    break;
            }
        }
    }
}
