using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice2025.Pages
{
    internal class LoginPage

    {

        public void LoginSteps(IWebDriver driver)
        {
            

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
           

        }
        
    }
}
