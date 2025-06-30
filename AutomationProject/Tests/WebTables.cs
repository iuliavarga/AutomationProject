using System.Runtime.Intrinsics.X86;
using AutomationProject.Access;
using AutomationProject.BasePage;
using AutomationProject.HelperMethods;
using AutomationProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace AutomationProject.Tests
{
 

    public class ElementsWebTables : TestBasePage
    {
        //IWebDriver driver;
        ElementMethods elementMethods;
        HomePage homePage;
        CommonPage commonPage;
        ElementsPage elementsPage;


        [Test]

        public void WebTables()
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();
          
            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            elementsPage = new ElementsPage(driver);

            var webTableData = new WebTableData(1);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            homePage.ClickOnElemenetsPage();
            commonPage.GoToDesireMenu("Web tables");
            elementsPage.ClickOnWebtables();
            elementsPage.ClickOnAddButton();
            elementsPage.FillRegistrationForm(webTableData);
            //elementsPage.CompleteWebTables("vvv", "jjj", "vvv@gmail.com", "11", "2200", "it");
            elementsPage.ClickOnSubmitButton();
            

        }

        [Test]

        public void WebTablesCheckRecordExists()
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/");
            //driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
            elementsPage = new ElementsPage(driver);

            var webTableData = new WebTableData(2);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            homePage.ClickOnElemenetsPage();
            commonPage.GoToDesireMenu("Web tables");
            elementsPage.ClickOnWebtables();
            elementsPage.ClickOnAddButton();

            bool recordFound = elementsPage.RecordExists(webTableData);

            if (recordFound)
            {
                Console.WriteLine($"Record found for: {webTableData.FirstName} {webTableData.LastName} - {webTableData.UserEmail}");
            }
            else
            {
                Console.WriteLine($"Record not found for: {webTableData.FirstName} {webTableData.LastName} - {webTableData.UserEmail}");
                elementsPage.FillRegistrationForm(webTableData);
                elementsPage.ClickOnSubmitButton();
            }


        }


    }


    }




   


    //    //public void DefinireParametriiWebTables(IWebElement popFirstName, IWebElement popLastName, IWebElement popUserEmail, IWebElement popAge, IWebElement popSalary, IWebElement popDepartment)
    //    //{


    //    //    //popFirstName.SendKeys("J");
    //    //    //popLastName.SendKeys("V");
    //    //    //popUserEmail.SendKeys("vjs@yahoo.com");
    //    //    //popAge.SendKeys("44");
    //    //    //popSalary.SendKeys("1000");
    //    //    //popDepartment.SendKeys("it");

    //    //    elementMethods.FillElement(popFirstName, "J");
    //    //    elementMethods.FillElement(popLastName, "V");
    //    //    elementMethods.FillElement(popUserEmail, "vjs@yahoo.com");
    //    //    elementMethods.FillElement(popAge, "44");
    //    //    elementMethods.FillElement(popSalary, "1000");
    //    //    elementMethods.FillElement(popDepartment, "it");

    //    //}




    //    //[Test]

    //    //public void TestWebTables()
    //    //{
    //    //    driver = new ChromeDriver();

    //    //    driver.Navigate().GoToUrl("https://demoqa.com/");
    //    //    driver.Manage().Window.Maximize();

    //    //    elementMethods = new ElementMethods(driver);

    //    //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
    //    //    js.ExecuteScript("window.scrollTo(0,1000)");

    //    //    IWebElement elementsButton1 = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
    //    //    //elementsButton1.Click();
    //    //    elementMethods.ClickOnElement(elementsButton1);

    //    //    IWebElement WebTablesButton1 = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
    //    //    //WebTablesButton1.Click();
    //    //    elementMethods.ClickOnElement(WebTablesButton1);

    //    //    IWebElement addButton = driver.FindElement(By.Id("addNewRecordButton"));
    //    //    //addButton.Click();
    //    //    elementMethods.ClickOnElement(addButton);

    //    //    IWebElement popFirstName = driver.FindElement(By.Id("firstName"));
    //    //    IWebElement popLastName = driver.FindElement(By.Id("lastName"));
    //    //    IWebElement popUserEmail = driver.FindElement(By.Id("userEmail"));
    //    //    IWebElement popAge = driver.FindElement(By.Id("age"));
    //    //    IWebElement popSalary = driver.FindElement(By.Id("salary"));
    //    //    IWebElement popDepartment = driver.FindElement(By.Id("department"));


    //    //    //popFirstName.SendKeys(firstName);
    //    //    //popLastName.SendKeys(lastName);
    //    //    //popUserEmail.SendKeys(userEmail);
    //    //    //popAge.SendKeys(age);
    //    //    //popSalary.SendKeys(salary);
    //    //    //popDepartment.SendKeys(department);


    //    //    //popFirstName.SendKeys("Julia");
    //    //    //popLastName.SendKeys("Varga");
    //    //    //popUserEmail.SendKeys("vjs@yahoo.com");
    //    //    //popAge.SendKeys("44");
    //    //    //popSalary.SendKeys("1000");
    //    //    //popDepartment.SendKeys("it");

    //    //    DefinireParametriiWebTables(popFirstName, popLastName, popUserEmail, popAge, popSalary, popDepartment);


    //    //    IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

    //    //    IWebElement elementsSubmitButton = driver.FindElement(By.Id("submit"));

    //    //    jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);






    //    //    // jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);

    //    //    //elementsSubmitButton.Submit();

    //    //    //IWebElement newRowWebTable = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));
    //    //    //Console.WriteLine(newRowWebTable.Text);

    //    //    //IWebElement firstName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
    //    //    //IWebElement lastName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
    //    //    //IWebElement age = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
    //    //    //IWebElement email = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
    //    //    //IWebElement salary = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
    //    //    //IWebElement department = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

    //    //    //Assert.That(firstName.Text.Equals("Julia"));
    //    //    //Assert.That(lastName.Text.Equals("Varga"));
    //    //    //Assert.That(age.Text.Equals("44"));
    //    //    //Assert.That(email.Text.Equals("vjs@yahoo.com"));
    //    //    //Assert.That(salary.Text.Equals("1000"));
    //    //    //Assert.That(department.Text.Equals("it"));

    //    //    //Assert.True(newRowWebTable.Text.Contains("Julia"));
    //    //    //Assert.True(newRowWebTable.Text.Contains("Varga"));
    //    //    //Assert.True(newRowWebTable.Text.Contains("vjs@yahoo.com"));
    //    //    //Assert.True(newRowWebTable.Text.Contains("44"));
    //    //    //Assert.True(newRowWebTable.Text.Contains("1000"));
    //    //    //Assert.True(newRowWebTable.Text.Contains("it"));



    //    //    //


    //    //}







    //    ////[TearDown]
    //    ////public void TearDown()
    //    ////{
    //    ////    driver.Quit();
    //    ////    driver.Close();
    //    ////}

    //}
  