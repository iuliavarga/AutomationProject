using System.Runtime.Intrinsics.X86;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace AutomationProject
{
    public class TextBoxTest
    {
       
        IWebDriver driver;     
                
        public void DefinireParametriiTextBox(IWebElement elementsFirstName, IWebElement elementsEmail, IWebElement elementsAdresa, IWebElement elementsPermanentAdresa )
        {
            
            elementsFirstName.SendKeys("varga");
            elementsEmail.SendKeys("vjh@yahoo.com");
            elementsAdresa.SendKeys("str. Calea Dorobantilor 89");
            elementsPermanentAdresa.SendKeys("str. Calea Dorobantilor 1, CJ");

        }


        [Test]
        public void TextBox()
        {
           
            driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");


            IWebElement elementsButton = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            elementsButton.Click();

            IWebElement elementsTextBoxButton = driver.FindElement(By.XPath("//*[text()='Text Box']"));
            elementsTextBoxButton.Click();

            IWebElement elementsFirstName = driver.FindElement(By.Id("userName"));
            //elementsFirstName.SendKeys("varga julia");
            
            IWebElement elementsEmail = driver.FindElement(By.Id("userEmail"));
           // elementsEmail.SendKeys("vjh@yahoo.com");

            IWebElement elementsAdresa = driver.FindElement(By.Id("currentAddress"));
            //elementsAdresa.SendKeys("str. Calea Dorobantilor 89");

            IWebElement elementsPermanentAdresa = driver.FindElement(By.Id("permanentAddress"));
            //elementsPermanentAdresa.SendKeys("str. Calea Dorobantilor 1, CJ");

            DefinireParametriiTextBox(elementsFirstName, elementsEmail, elementsPermanentAdresa, elementsPermanentAdresa);
        

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement elementsSubmitButton = driver.FindElement(By.Id("submit"));
            //driver.FindElement(By.XPath("//button[text()='Submit']"));
            //elementsSubmitButton.Submit();

            jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);

        }


        public void DefinireParametriiWebTables(IWebElement popFirstName, IWebElement popLastName, IWebElement popUserEmail,IWebElement popAge, IWebElement popSalary, IWebElement popDepartment)
        {


            popFirstName.SendKeys("J");
            popLastName.SendKeys("V");
            popUserEmail.SendKeys("vjs@yahoo.com");
            popAge.SendKeys("44");
            popSalary.SendKeys("1000");
            popDepartment.SendKeys("it");

        }




        [Test]

        public void TestWebTables()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementsButton1 = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
            elementsButton1.Click();


            IWebElement WebTablesButton1 = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            WebTablesButton1.Click();

            IWebElement addButton = driver.FindElement(By.Id("addNewRecordButton"));
            addButton.Click();

            IWebElement popFirstName = driver.FindElement(By.Id("firstName"));
            IWebElement popLastName = driver.FindElement(By.Id("lastName"));
            IWebElement popUserEmail = driver.FindElement(By.Id("userEmail"));
            IWebElement popAge = driver.FindElement(By.Id("age"));
            IWebElement popSalary = driver.FindElement(By.Id("salary"));
            IWebElement popDepartment = driver.FindElement(By.Id("department"));


            //popFirstName.SendKeys(firstName);
            //popLastName.SendKeys(lastName);
            //popUserEmail.SendKeys(userEmail);
            //popAge.SendKeys(age);
            //popSalary.SendKeys(salary);
            //popDepartment.SendKeys(department);


            //popFirstName.SendKeys("Julia");
            //popLastName.SendKeys("Varga");
            //popUserEmail.SendKeys("vjs@yahoo.com");
            //popAge.SendKeys("44");
            //popSalary.SendKeys("1000");
            //popDepartment.SendKeys("it");

            DefinireParametriiWebTables(popFirstName, popLastName, popUserEmail, popAge, popSalary, popDepartment);


            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement elementsSubmitButton = driver.FindElement(By.Id("submit"));

            jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);






            // jse.ExecuteScript("arguments[0].click();", elementsSubmitButton);

            //elementsSubmitButton.Submit();

            //IWebElement newRowWebTable = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));
            //Console.WriteLine(newRowWebTable.Text);

            //IWebElement firstName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
            //IWebElement lastName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
            //IWebElement age = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
            //IWebElement email = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
            //IWebElement salary = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
            //IWebElement department = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

            //Assert.That(firstName.Text.Equals("Julia"));
            //Assert.That(lastName.Text.Equals("Varga"));
            //Assert.That(age.Text.Equals("44"));
            //Assert.That(email.Text.Equals("vjs@yahoo.com"));
            //Assert.That(salary.Text.Equals("1000"));
            //Assert.That(department.Text.Equals("it"));

            //Assert.True(newRowWebTable.Text.Contains("Julia"));
            //Assert.True(newRowWebTable.Text.Contains("Varga"));
            //Assert.True(newRowWebTable.Text.Contains("vjs@yahoo.com"));
            //Assert.True(newRowWebTable.Text.Contains("44"));
            //Assert.True(newRowWebTable.Text.Contains("1000"));
            //Assert.True(newRowWebTable.Text.Contains("it"));



            //


        }







        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}

    }
}