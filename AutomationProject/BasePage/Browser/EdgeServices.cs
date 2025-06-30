using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace AutomationProject.BasePage.Browser
{
    public class EdgeServices : IBrowserService
    {
        public IWebDriver Driver { get; private set; }
        public object BrowserOptions()
        {
            EdgeOptions edgeoptions = new EdgeOptions();
            edgeoptions.AddArgument("--window-size=1929,1080");
            edgeoptions.AddArgument("--disable-gpu");
            edgeoptions.AddArgument("--no-sandbox");
            return edgeoptions;
        }

        public void OpenBrowser()
        {
            EdgeOptions options = (EdgeOptions)BrowserOptions();
            Driver = new EdgeDriver(options);
        }
    }
}
