using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationPractice2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser

            IWebDriver driver = new ChromeDriver(); //created the instance of chrome

            //launch the portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            //Identify user name field and enter user name

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");


            //identify password field and enter password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //click login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            //check user login success/not

            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if(hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("login success/test passed");
            }
            else
            {
                Console.WriteLine("login failed/test failed");
            }

            //create time and material 

            //Go to time and material page

            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();
            //click time and material

            IWebElement tmoptionclick = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoptionclick.Click();

            //click create button

            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //click material dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            //select material from the dropdown
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]")); 
            Thread.Sleep(1000);
            materialOption.Click();

            //enter code
            IWebElement code = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            code.SendKeys("test");

            //enter description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("testdescription");

            //enter price range
            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("123");

            //click save button

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();


            //go to last page
            Thread.Sleep(2000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
            goToLastPage.Click();


            //validate the time and material created
            Thread.Sleep(2000);
           
          IWebElement typeCodeText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (typeCodeText.Text == "test")
            {
                Console.WriteLine("tm created / test passed");
            }
            else
            {
                Console.WriteLine("tm not created / test failed");
            }





        }
    }
}
