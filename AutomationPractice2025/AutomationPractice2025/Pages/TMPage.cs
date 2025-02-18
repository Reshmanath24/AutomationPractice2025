using AutomationPractice2025.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice2025.Pages
{
    internal class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click create button

            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //click material dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            //select material from the dropdown
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            Thread.Sleep(2000);
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
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\'tmsGrid\']/div[4]/a[4]", 2);
            Thread.Sleep(2000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
            goToLastPage.Click();


            //validate the time and material created
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 2);
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
        public void EditTM(IWebDriver driver)
        {

        }
        public void DeleteTM(IWebDriver driver)
        {

        }
    }
}
