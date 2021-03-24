using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JuiceShopTests.PageObjects
{
    class YourBasketPageObject
    {
        private IWebDriver webdriver;

        private readonly By chekoutButton = By.XPath("//button[@id='checkoutButton']");

        public YourBasketPageObject(IWebDriver driver)
        {
            webdriver = driver;
        }

        public void Chekout()
        {
            Thread.Sleep(25000);
            //WaitUntil.WaitElement(webdriver, chekoutButton);
            webdriver.FindElement(chekoutButton).Click();
        }

    }
}
