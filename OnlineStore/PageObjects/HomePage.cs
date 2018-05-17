using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace OnlineStore.PageObjects
{
    public class HomePage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "account")] [CacheLookup]
        private IWebElement MyAccount { get; set; }

        /*
        public HomePage(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }
        */
        public void ClickOnMyAccount() {
            MyAccount.Click();
        }
    }
}
