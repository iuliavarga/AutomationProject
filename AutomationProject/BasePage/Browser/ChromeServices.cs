using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.BasePage.Browser
{

    public class ChromeServices : IBrowserService
    {
        public IWebDriver Driver { get; private set; }
        public object BrowserOptions()
        {
            ChromeOptions chromeoptions = new ChromeOptions();
            chromeoptions.AddArgument("--window-size=1929,1080");
            chromeoptions.AddArgument("--disable-gpu");
            chromeoptions.AddArgument("--no-sandbox");
            return chromeoptions;

        }

        public void OpenBrowser()
        {
            ChromeOptions options = (ChromeOptions)BrowserOptions();
            Driver = new ChromeDriver(options);

        }
    }
}
