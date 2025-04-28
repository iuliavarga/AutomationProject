using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace AutomationProject.Pages
{
    public class CommonPage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
        }

        List<IWebElement> elements => driver.FindElements(By.XPath("//span[@class='text']")).ToList();
        public void GoToDesireMenu(string menuName)
        {
            elementMethods.SelectElementForListByText(elements, menuName);
        }
    }
}
