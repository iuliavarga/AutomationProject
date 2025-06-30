using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Access;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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

        IWebElement dateInput => driver.FindElement(By.Id("dateOfBirthInput"));
        IWebElement monthDropDown => driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
        IWebElement yearDropDown => driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
        //IWebElement dayElement => driver.FindElement(By.XPath("//div[contains(@class, 'react-datepicker__day--') and not(contains(@class, '--outside-month'))]"));
        IWebElement subjectsInput => driver.FindElement(By.Id("subjectsInput"));

        IWebElement hobbiesSportsCheckbox => driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
        IWebElement hobbiesReadingCheckbox => driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
        IWebElement hobbiesMusicCheckbox => driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));

        IWebElement uploadPicture => driver.FindElement(By.Id("uploadPicture"));

        IWebElement stateDropdown => driver.FindElement(By.Id("react-select-3-input"));
        IWebElement cityDropdown => driver.FindElement(By.Id("react-select-4-input"));

        IWebElement submitButton => driver.FindElement(By.Id("submit"));



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

        
        public void CompleteDateOfBirth(PracticeFormData practiceFormData)
        {
            var dateTime = elementMethods.FormatDate(practiceFormData.DateOfBirth);

            elementMethods.ClickOnElement(dateInput);
            elementMethods.SelectElementByText(monthDropDown, dateTime.ToString("MMMM"));
            elementMethods.SelectElementByText(yearDropDown, dateTime.Year.ToString());
            
            var correctDay = driver.FindElement(By.XPath($"//div[contains(@class, 'react-datepicker__day--0{dateTime.Day}') and not(contains(@class, '--outside-month'))]"));
            correctDay.Click();

        }

        //public void CompleteDateOfBirth(string day, string month, string year)
        //{
        //    elementMethods.ClickOnElement(dateInput);

        //    var monthDropDown = new SelectElement (driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']")));
        //    monthDropDown.SelectByValue(month);

        //    var yearDropDown = new SelectElement(driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")));
        //    yearDropDown.SelectByValue(year);

        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        //    // Retry strategy: format day and search AFTER the DOM refresh
        //    string dayFormatted = day.PadLeft(2, '0');
        //    string dayClass = $"react-datepicker__day--{dayFormatted}";

        //    wait.Until(d =>
        //    {
        //        var elements = d.FindElements(By.XPath($"//div[contains(@class, '{dayClass}') and not(contains(@class, '--outside-month'))]"));
        //        return elements.Any() && elements.First().Displayed;
        //    });

        //    var dayElement = driver.FindElement(By.XPath($"//div[contains(@class, '{dayClass}') and not(contains(@class, '--outside-month'))]"));
        //    elementMethods.ClickOnElement(dayElement);

        //}


        public void CompleteSubjects(string subjects)
        {
            elementMethods.FillElement(subjectsInput, subjects);
            subjectsInput.SendKeys(Keys.Enter);
        }

        public void CompleteHobbies(string hobbies)
        {
            switch (hobbies)
            {
                case "Sports":
                    elementMethods.ClickOnElement(hobbiesSportsCheckbox);
                    break;
                case "Reading":
                    elementMethods.ClickOnElement(hobbiesReadingCheckbox);
                    break;
                case "Music":
                    elementMethods.ClickOnElement(hobbiesMusicCheckbox);
                    break;
            }
        }

        public void UploadPicture(string filePath)
        {
            uploadPicture.SendKeys(filePath);
        }

        public void SelectState(string state)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", stateDropdown);
            stateDropdown.SendKeys(state);
            stateDropdown.SendKeys(Keys.Enter);
        }

        public void SelectCity(string city)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", cityDropdown);
            cityDropdown.SendKeys(city);
            cityDropdown.SendKeys(Keys.Enter);
        }

        public void SubmitForm()
        {
            elementMethods.ClickOnElement(submitButton);
        }
    }
}
