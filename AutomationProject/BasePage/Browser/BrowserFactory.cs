using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.BasePage.Browser
{
    public class BrowserFactory
    {
        public IWebDriver GetBrowserFactory()
        {
            string browser = "chrome"; 

            switch(browser)
            {
                case BrowserType.BROWSER_CHROME:
                    ChromeServices chromeDriver = new ChromeServices();
                    chromeDriver.OpenBrowser();
                    return chromeDriver.Driver;
                case BrowserType.BROWSER_EDGE:
                    EdgeServices edgeDriver = new EdgeServices();
                    edgeDriver.OpenBrowser();
                    return edgeDriver.Driver;
                default:
                    throw new NotSupportedException($"Browser '{browser}' is not supported.");
            }
        }
    }
}
