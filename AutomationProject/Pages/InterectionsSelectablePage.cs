using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.HelperMethods;
using OpenQA.Selenium;

namespace AutomationProject.Pages
{
    public class InterectionsSelectablePage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public InterectionsSelectablePage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        IWebElement elementsGrid => driver.FindElement(By.Id("demo-tab-grid"));
        // IWebElement selectableButton => driver.FindElement(By.XPath("//div[@class='element-list collapse show']//li[@id='item-0']"));
        IList<IWebElement> gridNumbers => driver.FindElements(By.XPath("//div[@id='gridContainer']//li[contains(@class, 'list-group-item')]"));
        public void ClickOnGrid()
        {
            elementMethods.ClickOnElement(elementsGrid);
        }

        //public void SelectEvenNumbers()
        //{

        //    for (int i = 0; i < gridNumbers.Count; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            elementMethods.ClickElementIList(gridNumbers, i);
        //        }
        //    }
        //}

        public void SelectEvenNumbersXML(string type)
        {

            for (int i = 0; i < gridNumbers.Count; i++)
            {
                bool selectable;
                if (type.Equals("Even"))
                {
                    selectable = i % 2 == 0;
                }
                else
                {
                    selectable = i % 2 != 0;
                   
                }
                
                if(selectable)
                {
                    elementMethods.ClickElementIList(gridNumbers, i);
                }

            }
        }




    }
}
