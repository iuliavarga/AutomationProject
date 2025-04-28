using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProject.HelperMethods
{
       
    public class JavaScriptHelper
    {
        IWebDriver driver;
        public JavaScriptHelper(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ScrollPageHorizontally(int x)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollTo({x}, 0);");
        }

       public void ScrollPageVertically(int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollTo(0, {y});");
        }

        public void ScrollPageDynamic(int x, int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollTo({x}, {y});");
        }

        public void HideFixedBanner()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("var fixedBan = document.getElementById('fixedban'); if(fixedBan) { fixedBan.style.display = 'none'; }");
        }

        public void ScrollIntoView(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

    }
}
