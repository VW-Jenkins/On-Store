using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

using OnlineStore.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

using System.Configuration;

using OnlineStore.WrapperFactory;
// store name: selenium_test
// store email: TestingLA4v@outlook.com
// store pwd: 9Esu%YxUmZuP1lBA
namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        [Category("LogIn")]
        public void Test() {
            /*
            IWebDriver driver = new FirefoxDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];
            */
            BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            /*
            var homePage = new HomePage(BrowserFactory.Driver);
            homePage.ClickOnMyAccount();
            var loginPage = new LoginPage(BrowserFactory.Driver);
            loginPage.LoginToApplication("LogInTest");
            */
            Page.Home.ClickOnMyAccount();
            Page.Login.LoginToApplication("LogInTest");
            BrowserFactory.CloseAllDrivers();

            //driver.Quit();

            /*May17 - 11am
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("selenium_test");
            loginPage.Password.SendKeys("9Esu%YxUmZuP1lBA");
            loginPage.Submit.Click();

            */
            /* ------------May17 - 10am
            driver.FindElement(By.XPath("//div[@id='account']/a")).Click();

            driver.FindElement(By.Id("log")).SendKeys("selenium_test");
            driver.FindElement(By.Name("pwd")).SendKeys("az!(enxPaFJ!iayT");

            driver.FindElement(By.Id("login")).Click();
            */
            /*
            driver.FindElement(By.XPath("//aside[@id='meta']/ul/li[2]/a")).Click();
            driver.Quit();
            */
        }
    }
}
