using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Pages
{
    public class WidgetSelectMenuPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public WidgetSelectMenuPage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        //  IWebElement selectMenu => driver.FindElement(By.Id("selectMenuButton"));
        //IWebElement selectMenuDropdown =>  driver.FindElement(By.XPath("//div[@class=' css-1hwfws3']"));
        IWebElement selectMenuDropdown => driver.FindElement(By.XPath("//div[contains(@class, 'css-1hwfws3')]"));

        IWebElement selectValue => driver.FindElement(By.XPath("//*[text()='Group 2, option 2']"));
        IWebElement selectOneDropdown => driver.FindElement(By.Id("selectOne"));
        IWebElement selectValueOneDropdown => driver.FindElement(By.XPath("//*[text()='Mr.']"));
        IWebElement selectOldStyleMenu => driver.FindElement(By.Id("oldSelectMenu"));
        IWebElement newDropDown => driver.FindElement(By.XPath("//div[contains(@class, 'css-1hwfws3')]//div[contains(@class, 'placeholder') and text()='Select...']"));
        IWebElement standardMultiSelectValue => driver.FindElement(By.XPath("//option[text()='Saab']"));

        public void ClickOnSelectMenu()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
           // wait.Until(driver => driver.FindElement(By.XPath("//div[contains(@class, 'css-1hwfws3')]")).Displayed);

            elementMethods.ClickOnElement(selectMenuDropdown);
            elementMethods.ClickOnElement(selectValue);


            //  elementMethods.ClickOnElement(selectMenu);
            elementMethods.ClickOnElement(selectMenuDropdown);
            elementMethods.ClickOnElement(selectValue);
           
            elementMethods.ClickOnElement(selectOneDropdown);
            elementMethods.ClickOnElement(selectValueOneDropdown);
            
            elementMethods.ClickOnElement(selectOldStyleMenu);
            SelectElement selectValueOldStyleMenu = new SelectElement(selectOldStyleMenu);
            selectValueOldStyleMenu.SelectByText("Yellow");
            
            
        }

       

        public void ClickOnNewDropDown()
        {
            elementMethods.ClickOnElement(newDropDown);

            javaScriptHelper.ScrollPageVertically(1000);

            Actions action = new Actions(driver);
            action.SendKeys("Green" + Keys.Enter).Build().Perform();

        }

        public void ClickOnStandardMultiSelect()
        {
            IWebElement standardMultiSelect = driver.FindElement(By.Id("cars"));

            JavaScriptHelper jsHelper = new JavaScriptHelper(driver);
            jsHelper.ScrollIntoView(standardMultiSelect);

            SelectElement selectElement = new SelectElement(standardMultiSelect);
            selectElement.SelectByText("Saab");
        }

           



    }
}
