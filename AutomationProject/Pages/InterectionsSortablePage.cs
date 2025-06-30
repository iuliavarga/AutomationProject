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
    public class InterectionsSortablePage
    {
        public IWebDriver driver;
        public ElementMethods elementMethods;
        public JavaScriptHelper javaScriptHelper;

        public InterectionsSortablePage(IWebDriver driver)
        {
            this.driver = driver;
            elementMethods = new ElementMethods(driver);
            javaScriptHelper = new JavaScriptHelper(driver);
        }

        List<IWebElement> listInteractions =>
               driver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();

        List<IWebElement> listElements =>
            driver.FindElements(By.XPath(" //div[@class='vertical-list-container mt-4']/div[@class='list-group-item list-group-item-action']")).ToList();

        public void ClickOnSortable(InterectionsSortableData data)
        {
            if (int.TryParse(data.SortableNumber, out int index))
            {
                if (index >= 0 && index < listElements.Count)
                {
                    Console.WriteLine(listElements[index].Text);

                    for (int counter = 0; counter < listElements.Count; counter++)
                    {
                        Console.WriteLine($"[{counter}] {listElements[counter].Text}");
                    }

                    elementMethods.ClickOnElement(listElements[index]);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(data.SortableNumber), "Index is out of range for the sortable elements.");
                }
            }
            else
            {
                throw new FormatException("SortableNumber must be a valid integer.");
            }



            //public void ClickOnSortable(InterectionsSortableData interectionsSortableData)
            //{
            //    for (int counter = 0; counter < listElements.Count; counter++)
            //        Console.WriteLine(listElements[counter].Text);
            //}

        }
    }
}
