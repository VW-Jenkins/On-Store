using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OnlineStore.TestDataAccess;

using OnlineStore.Extensions;

namespace OnlineStore.PageObjects
{
    public class LoginPage
    {
        //private IWebDriver driver;

        [FindsBy(How =How.Id, Using = "log")][CacheLookup]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")][CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")][CacheLookup]
        private IWebElement Submit { get; set; }

        /*
        public LoginPage(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }
        */
        public void LoginToApplication(string testName) {
            var userData = ExcelDataAccess.GetTestData(testName);

            /*UserName.SendKeys("selenium_test");
            Password.SendKeys("9Esu%YxUmZuP1lBA");
            */

            /*
            UserName.SendKeys(userData.Username);
            Password.SendKeys(userData.Password);
            Submit.Click();
            */
            UserName.EnterText(userData.Username,"Username");
            Password.EnterText(userData.Password, "Passowrd");
            Submit.ClickOnIt("Submit button");

        }

    }
}
