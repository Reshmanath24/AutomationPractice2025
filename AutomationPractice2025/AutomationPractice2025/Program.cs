using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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

        }
    }
}
