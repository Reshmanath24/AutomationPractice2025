using AutomationPractice2025.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationPractice2025.Test
{
    internal class MainTestPage
    {
        static void Main(string[] args)
        {
            //open chrome browser

            IWebDriver driver = new ChromeDriver(); //created the instance of chrome

            //launch the portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            //login page object initialization

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //homepage object initialization

            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //tmpage object initiatlization

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);


            //edit tm
           // tmPageObj.EditTM(driver);
            //tmPageObj.DeleteTM(driver);

        }
    }
}
