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
    public class WidgetAutoCompletPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public WidgetAutoCompletPage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        IWebElement widgetsButton => driver.FindElement(By.XPath("//h5[text()='Widgets']"));
        IWebElement widgetsAutoCompletButton => driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
        IWebElement autoCompletSingle => driver.FindElement(By.Id("autoCompleteSingleInput"));
        IWebElement autoCompletMultiple => driver.FindElement(By.Id("autoCompleteMultipleInput"));

        public void FillAutoCompleteMultiple(WidgetAutoCompletData data)
        {
          //  elementMethods.ClickOnElement(widgetsButton);            
            elementMethods.ClickOnElement(widgetsAutoCompletButton);
            elementMethods.FillElement(autoCompletMultiple, data.MultipleText1);
            elementMethods.FillElement(autoCompletMultiple, Keys.ArrowDown);
            elementMethods.FillElement(autoCompletMultiple, Keys.Enter);
            elementMethods.FillElement(autoCompletMultiple, data.MultipleText2);
            elementMethods.FillElement(autoCompletMultiple, Keys.ArrowDown);
            elementMethods.FillElement(autoCompletMultiple, Keys.Enter);
        }

        public void FillAutoCompleteSingle(WidgetAutoCompletData data)
        {
           // elementMethods.ClickOnElement(widgetsButton);
            elementMethods.ClickOnElement(widgetsAutoCompletButton);
            elementMethods.FillElement(autoCompletSingle, data.SingleText);
            elementMethods.FillElement(autoCompletSingle, Keys.Enter);
        }

        
    }
}
